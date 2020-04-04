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
    public partial class FPriority : Form
    {
        public FPriority()
        {
            InitializeComponent();
        }

        private void BMinus_Click(object sender, EventArgs e)
        {
            try
            {
                LBPhone.Items.RemoveAt(LBPhone.SelectedIndex);
            }
            catch 
            {
                MessageBox.Show("Выберите номер телефона!");
            }
        }

        private void BSave_Click(object sender, EventArgs e)
        {
            FileStream F = new FileStream("phone.dat", FileMode.Create);
            StreamWriter w = new StreamWriter(F, Encoding.GetEncoding(1251));
            foreach (string Q in LBPhone.Items)
            {
                 w.WriteLine(Q); 
            }
            w.Close();

            Properties.Settings.Default.C1 = C1.Text;
            Properties.Settings.Default.C2 = C2.Text;
            Properties.Settings.Default.D1 = D1.Text;
            Properties.Settings.Default.D2 = D2.Text;
            Properties.Settings.Default.Save();
            
            MessageBox.Show("Изменения сохранены");

            Close();
        }

        private void FPriority_Load(object sender, EventArgs e)
        {
            if (File.Exists("phone.dat"))
            {
                LBPhone.Items.AddRange(File.ReadAllLines("phone.dat", Encoding.Default));
                LBPhone.SelectedIndex = LBPhone.Items.Count - 1;
            }
            C1.Text = Properties.Settings.Default.C1;
            C2.Text = Properties.Settings.Default.C2;

            D1.Text = Properties.Settings.Default.D1;
            D2.Text = Properties.Settings.Default.D2;
        }

        private void BPlus_Click(object sender, EventArgs e)
        {
            if (TBPhone.Text.Length == 11)
            {
                LBPhone.Items.Add(TBPhone.Text);
                TBPhone.Text = "79";
            }
            else
            {
                MessageBox.Show("Не верный формат телефона!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
