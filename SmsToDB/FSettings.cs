using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SmsToDB
{
    public partial class FSettings : Form
    {
        public FSettings()
        {
            InitializeComponent();
        }
        #region загрузка формы установок
        private void FSettings_Load(object sender, EventArgs e)
        {
            TBEmail.Text = Properties.Settings.Default.email;
            TBPass.Text = Properties.Settings.Default.pas;
            TBHost.Text = Properties.Settings.Default.host;
            TBPort.Text = Properties.Settings.Default.port;
            TBKey.Text = Properties.Settings.Default.key_api;
            TBModem1.Text = Properties.Settings.Default.FileSms1;
            TBModem2.Text = Properties.Settings.Default.FileSms2;
            TBModem3.Text = Properties.Settings.Default.FileSms3;
            TBModem4.Text = Properties.Settings.Default.FileSms4;
            TBModem5.Text = Properties.Settings.Default.FileSms5;
            TBModem6.Text = Properties.Settings.Default.FileSms6;
            CBSendMail.Checked = Properties.Settings.Default.CBSendMail;
            TBtoEmail.Text = Properties.Settings.Default.ToEmail;
            CBCheckTimeGoIP.Text = Properties.Settings.Default.TimeCheckGoIP.ToString() + " min";

            LoadIp();
        }
        #endregion

        #region загрузка ip в GridView
        private void LoadIp()
        {
            using (StreamReader sr = new StreamReader("GoIP.txt", Encoding.Default)) 
            {
                int i = 0;
                string[] S;

                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    S = line.Split(' ');
                    GridGOIP.Rows.Add(S[0]);
                    GridGOIP[1, i].Value = S[1];
                    i++;
                }
            }
        }
        #endregion

        #region сохраняем ip
        private void WriteIp()
        {
            using (StreamWriter sw = new StreamWriter("GoIP.txt", false,  Encoding.Default))
            {
                for (int i = 0; i < GridGOIP.RowCount - 1; i++)
                {
                    sw.WriteLine(GridGOIP[0, i].Value + " " + GridGOIP[1, i].Value); 
                }                
            }
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        #region button - сохранить настройки
        private void button2_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default["email"] = TBEmail.Text;
            Properties.Settings.Default["pas"] = TBPass.Text;
            Properties.Settings.Default["port"] = TBPort.Text;
            Properties.Settings.Default["key_api"] = TBKey.Text;
            Properties.Settings.Default["host"] = TBHost.Text;
            Properties.Settings.Default["CBSendMail"] = CBSendMail.Checked;
            Properties.Settings.Default["ToEmail"] = TBtoEmail.Text;
            Properties.Settings.Default["TimeCheckGoIP"] = Convert.ToInt32(CBCheckTimeGoIP.Text.Trim().Substring(0, 2)) ;
            Properties.Settings.Default.Save();

            FMain F = new FMain();
            F.TimerGoIP.Interval = Properties.Settings.Default.TimeCheckGoIP * 60000;

            WriteIp();

            Close();
        }
        #endregion

        #region отправить тестовое письмо
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                FMain.SendGMail(TBEmail.Text, TBtoEmail.Text, TBPass.Text, "TEST SmsToDb");
                MessageBox.Show("Сообщение отправлено");
            }
            catch
            {
                MessageBox.Show("Ошибка отправки... Проверьте корректность почты и пароля!");
            }
        }
        #endregion

        private void SetPatchModem(FolderBrowserDialog D, TextBox TB, string FileName)
        {
            if  (D.ShowDialog() == DialogResult.OK)
                {
                    TB.Text = D.SelectedPath + @"\" + "in-sms.log";
                    Properties.Settings.Default[FileName] = TB.Text;
                    Properties.Settings.Default.Save();
                }
        }

        #region button click - указать путь файла смс
        private void BModem1_Click(object sender, EventArgs e)
        {
            SetPatchModem(FBD, TBModem1, "FileSms1");            
        }

        private void BModem2_Click(object sender, EventArgs e)
        {
            SetPatchModem(FBD, TBModem2, "FileSms2");            
        }

        private void BModem3_Click(object sender, EventArgs e)
        {            
            SetPatchModem(FBD, TBModem3, "FileSms3");
        }

        private void BModem4_Click(object sender, EventArgs e)
        {
            SetPatchModem(FBD, TBModem4, "FileSms4");
        }

        private void BModem5_Click(object sender, EventArgs e)
        {
            SetPatchModem(FBD, TBModem5, "FileSms5");
        }

        private void BModem6_Click(object sender, EventArgs e)
        {
            SetPatchModem(FBD, TBModem6, "FileSms6");
        }
        #endregion
    }
}
