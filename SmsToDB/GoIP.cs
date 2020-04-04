using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inetlab.SMPP;
using Inetlab.SMPP.Common;
using Inetlab.SMPP.Logging;
using Inetlab.SMPP.PDU;
using System.IO;
using System.Windows.Forms;
using System.Drawing;
using System.Threading;
using Inetlab.SMPP.Builders;
using System.Diagnostics;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;


namespace SmsToDB
{
    public class GoIP
    {
        private readonly SmppClient _client;
        private readonly MessageComposer _messageComposer;           

        public List<string> LogConnection { get => _LogConnection; set => _LogConnection = value; }
        private List<string> _LogConnection = new List<string>();

        public List<string> IpList { get => _Ip; set => _Ip = value; }
        private List<string> _Ip = new List<string>();        

        public GoIP()
        {
            _client = new SmppClient();
            _client.ResponseTimeout = TimeSpan.FromSeconds(60);
            _client.EnquireLinkInterval = TimeSpan.FromSeconds(20);

            _messageComposer = new MessageComposer();
            _client.evDeliverSm += new DeliverSmEventHandler(Inbox_sms);
        }
        
        public List<string> LoadIpList()
        {
            List<string> S = new List<string>();
            string[] temp;

            try
            {
                using (StreamReader sr = new StreamReader("GoIP.txt", Encoding.Default))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        temp = line.Split(' ');
                        S.Add(temp[0]);  
                    }
                }
            }
            catch
            {
                MessageBox.Show("Ошибка загрузки ip адресов из GoIP.txt");
            }
            return S;
        }        

        public async Task<string> Connect(string ip, ListView D, ListView D2, bool OutInfo, string Error)
        {
            string S;
            //if (_client.Status == ConnectionStatus.Closed) 
            //{
                _client.ConnectionRecoveryDelay = TimeSpan.FromSeconds(3);
                _client.ConnectionRecovery = true;

                bool bSuccess = await _client.Connect(ip, 7777);

                if (bSuccess)  
                {
                    if (OutInfo)
                        D.Items.Add(FMain.CurrentTime() + "Connect GoIP: " + ip).BackColor = Color.Linen;

                    await Bind(D, D2, OutInfo, ip);

                    if ((Error != "1") & (Error != ""))
                    {
                        ApiDb X1 = new ApiDb();
                        D.Items.Add(FMain.CurrentTime() + X1.Chahge_order(Error, "62")).BackColor = Color.Linen; // "удаляем" загаз, если при предтдущей проверке этого ip была ошибка
                    }

                    D2.Items.Add(ip).BackColor = Color.Lime;
                    D2.Items.Add(new string('-', 17));
                    return "1";
                }
                else
                {
                    D.Items.Add(FMain.CurrentTime() + "Connection error GoIP: " + ip).BackColor = Color.Red;
                    D2.Items.Add(ip).BackColor = Color.Red;
                    D2.Items.Add(new string('-', 17));

                    ApiDb X2 = new ApiDb();
                    S = X2.Create_order(ip);                    
                    D.Items.Add(FMain.CurrentTime() + S).BackColor = Color.Red;

                    string[] tmp = S.Split(':');
                    S = tmp[tmp.Length - 1];
                    S = S.Substring(0, S.Length - 2);
                     

                    D.Items.Add(new string('-', 128));
                    return S;
                }
            //}           
        }

        public async Task Bind(ListView D, ListView D2, bool OutInfo, string ip)
        {
            ConnectionMode mode = ConnectionMode.Transceiver;

            BindResp resp = await _client.Bind("admin", "admin", mode); 

            switch (resp.Header.Status)
            {
                case CommandStatus.ESME_ROK:
                    if (OutInfo)
                    {
                        D.Items.Add(FMain.CurrentTime() + "Bind succeeded. Status: " + resp.Header.Status).BackColor = Color.Linen;
                        D.Items.Add(new string('-', 128));
                    }
                    resp.Client.WorkerThreads = 1;
                    break;
                default:
                    //D.Items.Add(FMain.CurrentTime() + "Bind failed. Status: " + resp.Header.Status + "("+ ip + ")").BackColor = Color.Red;
                    D.Items.Add(new string('-', 128));
                    await Disconnect(D, ip);
                    break;
            }
        }

        public async Task Disconnect(ListView D, string ip)
        {
            //D.Items.Add(FMain.CurrentTime() + "Disconnect from SMPP server " + ip).BackColor = Color.Red;
            //D.Items.Add(new string('-', 128));

            if (_client.Status == ConnectionStatus.Bound)
            {
                await UnBind(D);                
            }

            if (_client.Status == ConnectionStatus.Open)
            {
                await _client.Disconnect();               
            }
        }

        public async Task UnBind(ListView D)
        {
            
            UnBindResp resp = await _client.UnBind();

            switch (resp.Header.Status)
            {
                case CommandStatus.ESME_ROK:
                    //D.Items.Add(FMain.CurrentTime() + "UnBind succeeded. Status: " + resp.Header.Status).BackColor = Color.Red;
                    
                    break;
                default:
                    
                    //D.Items.Add(FMain.CurrentTime() + "UnBind failed.Status: " + resp.Header.Status).BackColor = Color.Red;
                    await _client.Disconnect();
                    break;
            }
        }

        private void WriteSmsGoIP(string name, DeliverSm data)

        {
            bool flag;
            string s;

            bool z = File.Exists(name) ? flag = true : flag = false;

            using (StreamWriter sw = new StreamWriter(name, flag, Encoding.Default))
            {
                s = data.SourceAddress.ToString();
                s = s.Remove(0, 1); // удалить "+" из номера
                sw.WriteLine(data.MessageText + " " + s + " GoIP");
                sw.Close();
            }
        }

        public void Inbox_sms(object sender, DeliverSm data)
        {
            if (data.Concatenation != null)
            {
                _messageComposer.AddMessage(data);
            }
            else
            {
                WriteSmsGoIP("SmsGoIP.txt", data); 

                (Application.OpenForms[0] as FMain).LV.Invoke((MethodInvoker)(delegate ()
                {
                                                                                    (Application.OpenForms[0] as FMain).LV.Items.Add(DateTime.Now.ToString("(dd.MM.yyyy | HH:mm:ss) ") + "Входящее сообщение GoIP " + data.Client).BackColor = Color.Gray;
                }));

                (Application.OpenForms[0] as FMain).LV.Invoke((MethodInvoker)(delegate () 
                {
                                                                                    (Application.OpenForms[0] as FMain).LV.Items.Add(DateTime.Now.ToString("(dd.MM.yyyy | HH:mm:ss) ") +  data.MessageText + " " + 
                                                                                                                                    data.SourceAddress).BackColor = Color.Gray;
                 }));

                (Application.OpenForms[0] as FMain).LV.Invoke((MethodInvoker)(delegate ()
                {
                                                                                     (Application.OpenForms[0] as FMain).LV.Items.Add(new string('-', 128));
                }));

               
                try
                {
                    WriteSmsGoIP("TempGoIP.txt", data);
                }
                catch
                {
                    (Application.OpenForms[0] as FMain).LV.Invoke((MethodInvoker)(delegate ()
                    {
                                                                                    (Application.OpenForms[0] as FMain).LV.Items.Add(DateTime.Now.ToString("(dd.MM.yyyy | HH:mm:ss) ") + "ОШИБКА ЗАПИСИ GoIP ").BackColor = Color.Red;
                    }));
                }   

            }
        }
    }
}
