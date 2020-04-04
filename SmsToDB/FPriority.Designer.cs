namespace SmsToDB
{
    partial class FPriority
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TBPhone = new System.Windows.Forms.TextBox();
            this.BMinus = new System.Windows.Forms.Button();
            this.BPlus = new System.Windows.Forms.Button();
            this.LBPhone = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.D2 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.D1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.C2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.C1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.BSave = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TBPhone);
            this.groupBox1.Controls.Add(this.BMinus);
            this.groupBox1.Controls.Add(this.BPlus);
            this.groupBox1.Controls.Add(this.LBPhone);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 288);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Телефоны";
            // 
            // TBPhone
            // 
            this.TBPhone.Location = new System.Drawing.Point(9, 243);
            this.TBPhone.Name = "TBPhone";
            this.TBPhone.Size = new System.Drawing.Size(181, 21);
            this.TBPhone.TabIndex = 4;
            this.TBPhone.Text = "79";
            // 
            // BMinus
            // 
            this.BMinus.Image = global::SmsToDB.Properties.Resources.Delete;
            this.BMinus.Location = new System.Drawing.Point(196, 56);
            this.BMinus.Name = "BMinus";
            this.BMinus.Size = new System.Drawing.Size(41, 38);
            this.BMinus.TabIndex = 2;
            this.BMinus.UseVisualStyleBackColor = true;
            this.BMinus.Click += new System.EventHandler(this.BMinus_Click);
            // 
            // BPlus
            // 
            this.BPlus.Image = global::SmsToDB.Properties.Resources.plus;
            this.BPlus.Location = new System.Drawing.Point(196, 19);
            this.BPlus.Name = "BPlus";
            this.BPlus.Size = new System.Drawing.Size(41, 38);
            this.BPlus.TabIndex = 1;
            this.BPlus.UseVisualStyleBackColor = true;
            this.BPlus.Click += new System.EventHandler(this.BPlus_Click);
            // 
            // LBPhone
            // 
            this.LBPhone.FormattingEnabled = true;
            this.LBPhone.ItemHeight = 15;
            this.LBPhone.Location = new System.Drawing.Point(9, 18);
            this.LBPhone.Name = "LBPhone";
            this.LBPhone.Size = new System.Drawing.Size(181, 214);
            this.LBPhone.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(252, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(243, 242);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Параметры команд";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.D2);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.D1);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Location = new System.Drawing.Point(10, 166);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(228, 67);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Время сегодня/завтра";
            // 
            // D2
            // 
            this.D2.FormattingEnabled = true;
            this.D2.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.D2.Location = new System.Drawing.Point(115, 20);
            this.D2.Name = "D2";
            this.D2.Size = new System.Drawing.Size(48, 23);
            this.D2.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(97, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(12, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "-";
            // 
            // D1
            // 
            this.D1.FormattingEnabled = true;
            this.D1.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.D1.Location = new System.Drawing.Point(41, 20);
            this.D1.Name = "D1";
            this.D1.Size = new System.Drawing.Size(48, 23);
            this.D1.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "D:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.C2);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.C1);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(9, 93);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(228, 67);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Время в пределах одних суток";
            // 
            // C2
            // 
            this.C2.FormattingEnabled = true;
            this.C2.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.C2.Location = new System.Drawing.Point(115, 20);
            this.C2.Name = "C2";
            this.C2.Size = new System.Drawing.Size(48, 23);
            this.C2.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(97, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(12, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "-";
            // 
            // C1
            // 
            this.C1.FormattingEnabled = true;
            this.C1.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.C1.Location = new System.Drawing.Point(41, 20);
            this.C1.Name = "C1";
            this.C1.Size = new System.Drawing.Size(48, 23);
            this.C1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "C:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "B: 20:00 - 6:00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "A: 8:00 - 8:00";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Image = global::SmsToDB.Properties.Resources.close;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(376, 250);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 38);
            this.button1.TabIndex = 5;
            this.button1.Text = "    Закрыть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BSave
            // 
            this.BSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BSave.Image = global::SmsToDB.Properties.Resources.save_as;
            this.BSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BSave.Location = new System.Drawing.Point(252, 250);
            this.BSave.Name = "BSave";
            this.BSave.Size = new System.Drawing.Size(118, 38);
            this.BSave.TabIndex = 4;
            this.BSave.Text = "Сохранить";
            this.BSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BSave.UseVisualStyleBackColor = true;
            this.BSave.Click += new System.EventHandler(this.BSave_Click);
            // 
            // FPriority
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 300);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BSave);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FPriority";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Установки приоритетов";
            this.Load += new System.EventHandler(this.FPriority_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox LBPhone;
        private System.Windows.Forms.Button BMinus;
        private System.Windows.Forms.Button BPlus;
        private System.Windows.Forms.TextBox TBPhone;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox C2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox C1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BSave;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox D2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox D1;
        private System.Windows.Forms.Label label6;
    }
}