using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Net.Mail;
using System.Threading;
using System.Drawing;

namespace SmsToDB
{
    class Sms
    {
        public string[] AllSms { get; set; }
        public int CountAllSms { get; set; }

        private string[] _ArSum = new string[1000];
        public string[] ArSum
        {
            get { return _ArSum; }
            set { _ArSum = value; }
        }

        private string[] _ArId = new string[1000];
        public string[] ArId
        {
            get { return _ArId; }
            set { _ArId = value; }
        }
        public List<string> InvalidSms { get => invalidSms; set => invalidSms = value; }
        private List<string> invalidSms = new List<string>();

        public List<string> Priority { get => priority; set => priority = value; }
        private List<string> priority = new List<string>();

        public void Write_Invalid_Sms(List<string> S)
        {
            if (File.Exists("InvalidSms.txt"))
            {
                FileStream F = new FileStream("InvalidSms.txt", FileMode.Append);
                StreamWriter w = new StreamWriter(F, Encoding.GetEncoding(1251));
                foreach (string Q in S)
                {
                    w.WriteLine(FMain.CurrentTime() + Q);

                    if (Properties.Settings.Default.CBSendMail)
                    {
                        if (Q.Contains("900") | Q.Contains("QIWIWallet"))
                        //if ((!Q.Contains("Spisanie")) & (!Q.Contains("Этот")) & (!Q.Contains("абонент")) & (!Q.Contains("снова")))
                        {
                            FMain.SendGMail(Properties.Settings.Default.email, Properties.Settings.Default.ToEmail, Properties.Settings.Default.pas, "НЕВЕРНЫЙ ФОРМАТ СООБЩЕНИЯ: " + Q);
                            w.WriteLine("Отправлено на почту");
                        }
                    }
                }
                w.Close();
            }
            else
            {
                FileStream F = new FileStream("InvalidSms.txt", FileMode.Create);
                StreamWriter w = new StreamWriter(F, Encoding.GetEncoding(1251));
                foreach (string Q in S)
                {
                    w.WriteLine(FMain.CurrentTime() + Q);

                    if (Properties.Settings.Default.CBSendMail)
                    {
                        if (Q.Contains("900") | Q.Contains("QIWIWallet"))
                        //if ((!Q.Contains("Spisanie")) & (!Q.Contains("Этот")) & (!Q.Contains("снова")) & (!Q.Contains("GoIP"))) 
                        {
                            FMain.SendGMail(Properties.Settings.Default.email, Properties.Settings.Default.ToEmail, Properties.Settings.Default.pas, "НЕВЕРНЫЙ ФОРМАТ СООБЩЕНИЯ: " + Q);
                            w.WriteLine("Отправлено на почту");
                        }
                    }
                }
                w.Close();                                
            }            
        }

        private void WriteAllSms(string[] S)
        {
            if (File.Exists("all_sms.txt"))
            {
                FileStream F = new FileStream("all_sms.txt", FileMode.Append);
                StreamWriter w = new StreamWriter(F, Encoding.GetEncoding(1251));

               foreach (string Q in S)
                {
                    w.WriteLine(FMain.CurrentTime() + Q);
                }
                w.Close();
            }
            else
            {
                FileStream F = new FileStream("all_sms.txt", FileMode.Create);
                StreamWriter w = new StreamWriter(F, Encoding.GetEncoding(1251));
                foreach (string Q in S)
                {
                    w.WriteLine(FMain.CurrentTime() + Q);
                }
                w.Close();
            }
        }

        private bool CheckPriority(string[] s)
        {
            bool f = false;

            if (
                (s[0] == "A") | (s[0] == "А") |
                (s[0] == "a") | (s[0] == "а") |
                (s[0] == "B") | (s[0] == "В") |
                (s[0] == "b") | (s[0] == "в") |
                (s[0] == "C") | (s[0] == "С") |
                (s[0] == "c") | (s[0] == "с") |
                (s[0] == "D") | (s[0] == "d")
                          
                )
            {
                f = true;                
            }
            return f;
        }

        public void GetSms(string SFileName)
        {
            string X;
            int i, j;

            if (File.Exists(SFileName))
            {
                j = 0; 
                AllSms = File.ReadAllLines(SFileName, Encoding.GetEncoding(1251));

                WriteAllSms(AllSms);

                for (i = 0; i <= AllSms.Length - 1; i++)
                {
                    X = AllSms[i];
                    string[] tmp = X.Split(' ');
                    
                    try
                    {
                        tmp[0] = tmp[0].Trim(',');
                        tmp[0] = tmp[0].Trim(' ');
                        tmp[0] = tmp[0].Trim('.');
                        tmp[0] = tmp[0].Trim(';');
                        

                        if (CheckPriority(tmp))
                            Priority.Add(X);

                        bool flag = false;

                        if (tmp[0] == "Перевод")
                        {
                            try
                            {
                                if (tmp[tmp.Length - 1] == "900")
                                {
                                    ArSum[j] = tmp[1];
                                    ArId[j] = tmp[tmp.Length - 2];
                                    flag = true;
                                }
                            }
                            catch
                            {
                                InvalidSms.Add(X);
                            }
                        }


                        if ((tmp[0] == "Перевод") & (tmp.Length >= 8) & !flag)
                        {
                            tmp[1] = tmp[1].Trim('р');
                            tmp[8] = tmp[8].Trim('"');

                            bool testId = Int32.TryParse(tmp[8], out int t);

                            if ((tmp[8] != "900") & (testId))
                            {
                                ArSum[j] = tmp[1];
                                ArId[j] = tmp[8];
                                j++;
                            }
                            else
                            {
                                InvalidSms.Add(X);
                            }
                        }  else

                        if (tmp[0] == "Перевод" & !flag)
                        {
                            tmp[1] = tmp[1].Trim('р');
                            tmp[6] = tmp[6].Trim('"');

                            bool testId = Int32.TryParse(tmp[6], out int t);

                            if ((tmp[6] != "900") & (testId))
                            {
                                ArSum[j] = tmp[1];
                                ArId[j] = tmp[6];
                                j++;
                            }
                            else
                            {
                                InvalidSms.Add(X);
                            }                            
                        } 

                        if ((tmp[0] == "VISA9958") & (tmp[2] == "перевод"))
                        {
                            tmp[3] = tmp[3].Trim('р');
                            tmp[9] = tmp[9].Trim('"');
                            if (tmp[9] != "900")
                            {
                                ArSum[j] = tmp[3];
                                ArId[j] = tmp[9];
                                j++;
                            }
                            else
                            {
                                InvalidSms.Add(X);
                            }
                        }
                        
                        if (tmp[0] == "Сбербанк")
                        {
                            
                            tmp[10] = tmp[10].Trim('"');
                            //if (tmp[10] == "") { tmp[10] = "???";  }
                            bool testId = Int32.TryParse(tmp[10], out int t);
                            if (testId)
                            {
                                ArId[j] = tmp[10];
                                ArSum[j] = tmp[7];
                                j++;                                
                            }
                            else
                            {
                                InvalidSms.Add(X);
                            }
                         }
                        
                        if (tmp[8] == "qiwi.com")
                        {
                            ArId[j] = tmp[0];
                            ArId[j] = "8" + ArId[j].Substring(2);
                            ArSum[j] = tmp[3];
                            j++;
                        }                        
                    }
                    catch
                    {
                        InvalidSms.Add(X);
                    }
                    CountAllSms = j - 1;
                }
            }
        }

        public void OutSms(ListView LB, Sms s)
        {
            int i;
            for ( i = 0; i <= s.CountAllSms; i++)
            {
                LB.Items.Add(FMain.CurrentTime() + "Водитель: " + s.ArId[i] + " перевел " + s.ArSum[i]).BackColor = Color.Gray;
            }
        }

        public void DelSmsFile(string SFileName)
        {
            if (File.Exists(SFileName))
            {
                try
                {
                    File.Delete(SFileName);
                }
                catch
                {                   
                    Thread.Sleep(3000);
                    File.Delete(SFileName);
                }
            }
        }
    }
}