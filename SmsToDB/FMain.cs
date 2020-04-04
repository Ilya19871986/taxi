using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Collections.Specialized;
using System.Net.Mail;
using System.Net;
using System.IO;
using System.Threading;
using System.Security.Cryptography;

namespace SmsToDB
{
    public partial class FMain : Form
    {        
        public FMain()
        {
            InitializeComponent();
            
        }
                
        public List<GoIP> ListGoIP { get => listGoIP; set => listGoIP = value; } // содержит экземпляры GoIP для каждого шлюза
        private List<GoIP> listGoIP = new List<GoIP>();

        public List<string> ErrorList { get => errorList; set => errorList = value; } // содержит статус по подключению шлюза (если  = 1, то нет ошибки подключения)
        private List<string> errorList = new List<string>();

        public List<string> E { get => e; set => e = value; } // содержит ip для каждого шлюза
        private List<string> e = new List<string> ();
        
        private int NGoIP = 0; // количество шлюзов

        public void CreatListGOIP(bool OutInfo)
        {            
            GoIP t = new GoIP();

            E = t.LoadIpList(); // получаем список IP адресов

            if (OutInfo) LV.Items.Add(CurrentTime() + "Загрузка IP адресов: ").BackColor = Color.Linen;

            foreach (string s in E) // формируем list GoIP 
            {
                GoIP X = new GoIP();

                ListGoIP.Add(X);
                ErrorList.Add("1");

                if (OutInfo) LV.Items.Add(s);

                NGoIP++;
            }

            if (OutInfo)
            {
                LV.Items.Add(CurrentTime() + "Количество GoIP:  " + Convert.ToString(NGoIP)).BackColor = Color.Linen;
                LV.Items.Add(new string('-', 128));
            }

            LV.Items[LV.Items.Count - 1].EnsureVisible();
        }


        private void BSettings_Click(object sender, EventArgs e)
        {
            FSettings F2 = new FSettings();
            F2.ShowDialog();
        }
        #region send mail
        public static void SendGMail(string fromAddress, string ToAdress, string mailPassword, string messageBody)
        {
            string SHost;

            if (fromAddress.Contains("mail.ru"))
            {
                SHost = "smtp.mail.ru";
            }

            if (fromAddress.Contains("gmail.com"))
            {
                SHost = "smtp.gmail.com";
            }
            else
            {
                SHost = "unknown";
            }

            try
            {
                SmtpClient client = new SmtpClient
                {
                    Port = 587,
                    Host = SHost,
                    EnableSsl = true,
                    //Timeout = 10000,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(fromAddress, mailPassword)
                };

                var send_mail = new MailMessage
                {
                    IsBodyHtml = true,
                    From = new MailAddress(fromAddress)
                };

                send_mail.To.Add(new MailAddress(ToAdress));
                send_mail.Subject = "SmsToDB";

                send_mail.Body = messageBody;
                client.Send(send_mail);
            }
            catch
            {
                
            }
        }
        #endregion

        private void BInvalidSms_Click(object sender, EventArgs e)
        {
            FInvalidSms F3 = new FInvalidSms();
            F3.Show();
        }
        #region logic
        private void Run(string SFileName)
        {
            string tmp;
            if (File.Exists(SFileName))
            {
                try
                {
                    Sms sms = new Sms();
                    ApiDb api = new ApiDb();
                    // --------------------------------------------------------------------------------
                    sms.GetSms(SFileName);

                    sms.OutSms(LV, sms);

                    if (sms.CountAllSms > 0)
                       LV.Items.Add(new string('-', 128));   
                                        

                    SetPriority(sms.Priority, api); // <--------------------------------------------------- установка приоритетов --------------------------------------------------
                    // sms.GetSms(SFileName);
                    // все смс сохраняем в all_sms.txt
                    // ArId[] - массив телефонов или ид
                    // ArSum[] - соответствует индексам ArId[], массив сумм
                    // CountAllSms - количетсво элементов массивов ArId и ArSum
                    // некорректные sms заносим в InvalidSms(список)
                    // Priority - список приоритетных водителей 
                    // --------------------------------------------------------------------------------
                    for (int i = 0; i <= sms.CountAllSms; i++)
                    {
                        #region  СБЕРБАНК
                        if (sms.ArId[i].Length < 7)
                        {
                            LV.Items.Add(CurrentTime() + " (Сбербанк) Поиск водителя  " + sms.ArId[i] + " ... " + api.Check_driver(sms.ArId[i]).ToString());
                            
                            if (api.Check_driver(sms.ArId[i])) // ЕСЛИ НЕ УВОЛЕН
                            {
                                LV.Items.Add(CurrentTime() + "Операция для водитетя " + sms.ArId[i] + " на сумму " + sms.ArSum[i]);

                                LV.Items.Add(CurrentTime() + api.POST(sms.ArId[i], sms.ArSum[i]));

                                LV.Items.Add(new string('-', 128));
                            }
                            else // ЕСЛИ УВОЛЕН
                            {
                                LV.Items.Add(CurrentTime() + "Водитель " + sms.ArId[i] + " уволен или не найден ").BackColor = Color.Red;

                                if (Properties.Settings.Default.CBSendMail)
                                {
                                    SendGMail(Properties.Settings.Default.email,  Properties.Settings.Default.ToEmail, Properties.Settings.Default.pas,
                                                 sms.ArId[i] + " перевел " + sms.ArSum[i] + " / ВОДИТЕЛЬ УВОЛЕН ИЛИ НЕ НАЙДЕН");

                                    LV.Items.Add(CurrentTime() + "Отправлено на почту");
                                }
                                LV.Items.Add(new string('-', 128));
                            }
                        }
                        #endregion
                        #region QIWI
                        else 
                        {
                            
                            tmp = api.Analyze_phone(sms.ArId[i]);
                            if (tmp != "NOT_FOUND") // ЕСЛИ НАЙДЕН
                            {
                                if (api.Check_driver(tmp)) // ЕСЛИ НЕ УВОЛЕН 
                                {
                                    LV.Items.Add(CurrentTime() + "Операция для водитетя " + tmp + " (" + sms.ArId[i] + ") " + " на сумму " + sms.ArSum[i]);
                                    LV.Items.Add(CurrentTime() + api.POST(tmp, sms.ArSum[i]));
                                }
                                else // УВОЛЕН
                                {
                                    LV.Items.Add(CurrentTime() + "Водитель " + sms.ArId[i] + " уволен ").BackColor = Color.Red;

                                    if (Properties.Settings.Default.CBSendMail)
                                    {
                                        SendGMail(Properties.Settings.Default.email, Properties.Settings.Default.ToEmail, Properties.Settings.Default.pas,
                                                 sms.ArId[i] + " перевел " + sms.ArSum[i] + " / ВОДИТЕЛЬ УВОЛЕН");

                                        LV.Items.Add(CurrentTime() + "Отправлено на почту");
                                    }
                                    LV.Items.Add(new string('-', 128));
                                }
                            }
                            else // НЕ НАЙДЕН
                            {
                                LV.Items.Add(CurrentTime() + "Водитель " + sms.ArId[i] + " не найден ").BackColor = Color.Red;

                                if (Properties.Settings.Default.CBSendMail)
                                {
                                    SendGMail(Properties.Settings.Default.email, Properties.Settings.Default.ToEmail, Properties.Settings.Default.pas,
                                             sms.ArId[i] + " перевел " + sms.ArSum[i] + " / ВОДИТЕЛЬ НЕ НАЙДЕН");

                                    LV.Items.Add(CurrentTime() + "Отправлено на почту");
                                }
                                LV.Items.Add(new string('-', 128));
                            }
                        }
                        #endregion
                    }

                    LV.Items[LV.Items.Count - 1].EnsureVisible();
                    sms.Write_Invalid_Sms(sms.InvalidSms);
                    sms.DelSmsFile(SFileName);
                }
                catch
                {
                    SendGMail(Properties.Settings.Default.email, Properties.Settings.Default.ToEmail, Properties.Settings.Default.pas, 
                              " Критическая ошибка SmsToDb, возможна остановка или некорректная работа. ");
                }
            }
        }
        #endregion

        public static string CurrentTime()
        {
            return DateTime.Now.ToString("(dd.MM.yyyy | HH:mm:ss) ");
        }

        #region Timer
        private void TimerMain_Tick(object sender, EventArgs e)
        {
            Run(Properties.Settings.Default.FileSms1);
            Run(Properties.Settings.Default.FileSms2);
            Run(Properties.Settings.Default.FileSms3);
            Run(Properties.Settings.Default.FileSms4);
            Run(Properties.Settings.Default.FileSms5);
            Run(Properties.Settings.Default.FileSms6);
            Run(Environment.CurrentDirectory + @"\" + "TempGoIP.txt");
        }
        #endregion
        private void button1_Click_1(object sender, EventArgs e)
        {
            TimerMain.Interval = 30 * 1000;
            TimerMain.Enabled = true;
            BRun.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TimerMain.Enabled = false;
            BRun.Enabled = true; 
        }

       
        #region Connect GoIP
        private async Task ConnectGoIP(bool OutInfo, List<GoIP> list)
        {        

            IP.Clear();

            if (OutInfo == false)
            {
                for (int i = 0; i < NGoIP; i++)
                {
                    if (E[i] != "")
                    {
                        await list[i].Disconnect(LV, E[i]);   
                    }
                }
            }

            for (int i = 0; i < NGoIP; i++)
            {
                if (E[i] != "")
                {
                    string s =
                    await list[i].Connect(E[i], LV, IP, OutInfo, ErrorList[i]);   // для каждого GoIP выполняем connect() и bind()     
                    if (!s.Contains("{")) ErrorList[i] = s;
                }           
                Thread.Sleep(500);
                LV.Items[LV.Items.Count - 1].EnsureVisible();
            }
        }
        #endregion
              

        #region FormLoad
        private async void FMain_Load(object sender, EventArgs e)
        {            
            ApiDb R = new ApiDb();
            
            LV.Items.Add(new string('-', 128)); 

            LV.Items.Add(CurrentTime() + "Ping...").BackColor = Color.Linen;
            LV.Items.Add(CurrentTime() + R.Ping()).BackColor = Color.Lime; // ping

            LV.Items.Add(new string('-', 128));

            LV.Items.Add("ФАЙЛЫ СООБЩЕНИЙ: ").BackColor = Color.Linen;
            LV.Items.Add(Properties.Settings.Default.FileSms1);
            LV.Items.Add(Properties.Settings.Default.FileSms2);
            LV.Items.Add(Properties.Settings.Default.FileSms3);
            LV.Items.Add(Properties.Settings.Default.FileSms4);
            LV.Items.Add(Properties.Settings.Default.FileSms5);
            LV.Items.Add(Properties.Settings.Default.FileSms6);

            LV.Items.Add(new string('-', 128));

            LV.Scrollable = true;
            LV.View = View.Details;

            TimerGoIP.Interval = Properties.Settings.Default.TimeCheckGoIP * 60000;
            Status.Text = "Время опроса GoIP: " + Properties.Settings.Default.TimeCheckGoIP;
            TimerGoIP.Enabled = true;

            CreatListGOIP(true);

            await ConnectGoIP(true, ListGoIP);

            button1_Click_1(this, new EventArgs());
        }
        #endregion
        private void BAllSms_Click(object sender, EventArgs e)
        {
            FAllSms F4 = new FAllSms();
            F4.Show();
        }

        private void BPriority_Click(object sender, EventArgs e)
        {            
            FPriority F5 = new FPriority();
            F5.ShowDialog();
        }
        #region Priorit
        private string[] GetPhonePriority() // получаем массив номеров "бригадиров"
        {     
            if (File.Exists("phone.dat"))
            {
                string[]  tmp = File.ReadAllLines("phone.dat");
                
                return tmp;
            }
            else
            {
                return null;
            }         
        }
        
        private bool CheckPhonePriority(string[] Ar, string phone) // проверяем номер на принадлежность к "бригадирам"
        {
            bool flag = false;

            for (int i = 0; i <= Ar.Length - 1; i++)
            {
                if (Ar[i] == phone)
                {
                    flag = true;
                    break;
                }
            }
            return flag;
        }

        private void SetPriority(List<string> A, ApiDb Q)
        {
            string[] Ar;

            if (A.Count > 0) // ----------------------------------------------------------------------  если есть команды приоритета
            {
                foreach (string s in A)
                {
                    
                    string[] temp = s.Split(',', ' ', '.', ';');
                    Ar = GetPhonePriority();
                    
                    if (CheckPhonePriority(Ar, temp[temp.Length - 2]))
                    {
                        LV.Items.Add(CurrentTime() + "Назначен приоритет "+ "("+ temp[temp.Length - 2] + ")" + ": " + temp[0]).BackColor = Color.LightBlue; // тип приоритета temp[0]
                        LV.Items.Add(CurrentTime() + "Для: ").BackColor = Color.LightBlue;

                        for (int i = 1; i < temp.Length - 2; i++)
                        {
                            if ((temp[i] != " ") && (temp[i] != ",") && (temp[i] != ""))
                            {
                                LV.Items.Add(CurrentTime() + "     id: " + temp[i]).BackColor = Color.LightBlue;
                                LV.Items.Add(CurrentTime() + Q.Create_dyn_priority(temp[0], temp[i])).BackColor = Color.LightBlue;
                            }
                        }
                    }
                    else
                    {
                        LV.Items.Add(CurrentTime() + "Смс с приоритетом от неизвестного номера: " + temp[temp.Length - 2]).BackColor = Color.Red;                        
                    }
                }
            } // ----------------------------------------------------------------------------------------------------------------------
        }
        #endregion

        private async void TimerGoIP_Tick(object sender, EventArgs e)
        {
            await ConnectGoIP(false, ListGoIP);
            TimerGoIP.Interval = Properties.Settings.Default.TimeCheckGoIP * 60000;
            Status.Text = "Время опроса GoIP: " + Properties.Settings.Default.TimeCheckGoIP;
        }
        // проверка GoIP
        private async void toolStripMenuItem1_ClickAsync(object sender, EventArgs e)
        {
            await ConnectGoIP(false, ListGoIP);
        }       
    }
}
