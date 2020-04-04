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
    public partial class FAllSms : Form
    {
        public FAllSms()
        {
            InitializeComponent();
        }

        private void BClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FAllSms_Load(object sender, EventArgs e)
        {
            if (File.Exists("all_sms.txt"))
            {
                TBAllSms.Lines = File.ReadAllLines("all_sms.txt", Encoding.Default);
                TBAllSms.SelectionStart = TBAllSms.Text.Length;
                TBAllSms.ScrollToCaret();
                TBAllSms.Refresh();
             
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            File.Delete("all_sms.txt");
            TBAllSms.Clear();
        }
    }
}
