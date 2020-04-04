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
    public partial class FInvalidSms : Form
    {
        public FInvalidSms()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            Close();
        }

        private void FInvalidSms_Load(object sender, EventArgs e)
        {
            if (File.Exists("InvalidSms.txt"))
            {
                lbInvalidSms.Items.AddRange(File.ReadAllLines("InvalidSms.txt", Encoding.Default));
                lbInvalidSms.SelectedIndex = lbInvalidSms.Items.Count - 1;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            File.Delete("InvalidSms.txt");
            lbInvalidSms.Items.Clear();
        }               
    }
}
