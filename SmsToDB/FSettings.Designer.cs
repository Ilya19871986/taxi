namespace SmsToDB
{
    partial class FSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FSettings));
            this.BSave = new System.Windows.Forms.Button();
            this.ODFileSms = new System.Windows.Forms.OpenFileDialog();
            this.FBD = new System.Windows.Forms.FolderBrowserDialog();
            this.BClose = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TBtoEmail = new System.Windows.Forms.TextBox();
            this.CBSendMail = new System.Windows.Forms.CheckBox();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TBEmail = new System.Windows.Forms.TextBox();
            this.TBPass = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TBKey = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TBPort = new System.Windows.Forms.TextBox();
            this.TBHost = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BModem6 = new System.Windows.Forms.Button();
            this.BModem5 = new System.Windows.Forms.Button();
            this.BModem4 = new System.Windows.Forms.Button();
            this.BModem3 = new System.Windows.Forms.Button();
            this.BModem2 = new System.Windows.Forms.Button();
            this.BModem1 = new System.Windows.Forms.Button();
            this.TBModem6 = new System.Windows.Forms.TextBox();
            this.TBModem5 = new System.Windows.Forms.TextBox();
            this.TBModem4 = new System.Windows.Forms.TextBox();
            this.TBModem3 = new System.Windows.Forms.TextBox();
            this.TBModem2 = new System.Windows.Forms.TextBox();
            this.TBModem1 = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.GridGOIP = new System.Windows.Forms.DataGridView();
            this.IP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.CBCheckTimeGoIP = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridGOIP)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // BSave
            // 
            this.BSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BSave.Image = global::SmsToDB.Properties.Resources.save_as;
            this.BSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BSave.Location = new System.Drawing.Point(296, 289);
            this.BSave.Name = "BSave";
            this.BSave.Size = new System.Drawing.Size(120, 36);
            this.BSave.TabIndex = 2;
            this.BSave.Text = "Сохранить";
            this.BSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BSave.UseVisualStyleBackColor = true;
            this.BSave.Click += new System.EventHandler(this.button2_Click);
            // 
            // BClose
            // 
            this.BClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BClose.Image = global::SmsToDB.Properties.Resources.Delete;
            this.BClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BClose.Location = new System.Drawing.Point(175, 289);
            this.BClose.Name = "BClose";
            this.BClose.Size = new System.Drawing.Size(117, 36);
            this.BClose.TabIndex = 1;
            this.BClose.Text = "     Закрыть";
            this.BClose.UseVisualStyleBackColor = true;
            this.BClose.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.HotTrack = true;
            this.tabControl1.Location = new System.Drawing.Point(5, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(581, 282);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(573, 254);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Соединение";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.CBSendMail);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 205);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Почта";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.TBtoEmail);
            this.groupBox5.Location = new System.Drawing.Point(9, 94);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(338, 47);
            this.groupBox5.TabIndex = 11;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Прием";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Почта";
            // 
            // TBtoEmail
            // 
            this.TBtoEmail.Location = new System.Drawing.Point(73, 16);
            this.TBtoEmail.Name = "TBtoEmail";
            this.TBtoEmail.Size = new System.Drawing.Size(259, 22);
            this.TBtoEmail.TabIndex = 3;
            // 
            // CBSendMail
            // 
            this.CBSendMail.AutoSize = true;
            this.CBSendMail.Checked = true;
            this.CBSendMail.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CBSendMail.Location = new System.Drawing.Point(9, 143);
            this.CBSendMail.Name = "CBSendMail";
            this.CBSendMail.Size = new System.Drawing.Size(261, 20);
            this.CBSendMail.TabIndex = 6;
            this.CBSendMail.Text = "Оправлять сообщения на почту";
            this.CBSendMail.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(56, 169);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(256, 26);
            this.button3.TabIndex = 4;
            this.button3.Text = "Отправить тестовое письмо";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.TBEmail);
            this.groupBox4.Controls.Add(this.TBPass);
            this.groupBox4.Location = new System.Drawing.Point(9, 17);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(338, 76);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Отпрака";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Пароль";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Почта";
            // 
            // TBEmail
            // 
            this.TBEmail.Location = new System.Drawing.Point(73, 21);
            this.TBEmail.Name = "TBEmail";
            this.TBEmail.Size = new System.Drawing.Size(259, 22);
            this.TBEmail.TabIndex = 0;
            // 
            // TBPass
            // 
            this.TBPass.Location = new System.Drawing.Point(72, 49);
            this.TBPass.Name = "TBPass";
            this.TBPass.Size = new System.Drawing.Size(260, 22);
            this.TBPass.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.TBKey);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.TBPort);
            this.groupBox2.Controls.Add(this.TBHost);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(365, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(202, 205);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Соединение";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Ключ";
            // 
            // TBKey
            // 
            this.TBKey.Location = new System.Drawing.Point(16, 164);
            this.TBKey.Name = "TBKey";
            this.TBKey.Size = new System.Drawing.Size(174, 22);
            this.TBKey.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Порт";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Хост";
            // 
            // TBPort
            // 
            this.TBPort.Location = new System.Drawing.Point(16, 106);
            this.TBPort.Name = "TBPort";
            this.TBPort.Size = new System.Drawing.Size(174, 22);
            this.TBPort.TabIndex = 1;
            // 
            // TBHost
            // 
            this.TBHost.Location = new System.Drawing.Point(16, 52);
            this.TBHost.Name = "TBHost";
            this.TBHost.Size = new System.Drawing.Size(174, 22);
            this.TBHost.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(573, 254);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "GSM модемы";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.groupBox3.Controls.Add(this.BModem6);
            this.groupBox3.Controls.Add(this.BModem5);
            this.groupBox3.Controls.Add(this.BModem4);
            this.groupBox3.Controls.Add(this.BModem3);
            this.groupBox3.Controls.Add(this.BModem2);
            this.groupBox3.Controls.Add(this.BModem1);
            this.groupBox3.Controls.Add(this.TBModem6);
            this.groupBox3.Controls.Add(this.TBModem5);
            this.groupBox3.Controls.Add(this.TBModem4);
            this.groupBox3.Controls.Add(this.TBModem3);
            this.groupBox3.Controls.Add(this.TBModem2);
            this.groupBox3.Controls.Add(this.TBModem1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(5, 8);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(561, 235);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Файлы сообщений";
            // 
            // BModem6
            // 
            this.BModem6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BModem6.BackgroundImage")));
            this.BModem6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BModem6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BModem6.Location = new System.Drawing.Point(518, 195);
            this.BModem6.Name = "BModem6";
            this.BModem6.Size = new System.Drawing.Size(37, 37);
            this.BModem6.TabIndex = 11;
            this.BModem6.UseVisualStyleBackColor = true;
            this.BModem6.Click += new System.EventHandler(this.BModem6_Click);
            // 
            // BModem5
            // 
            this.BModem5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BModem5.BackgroundImage")));
            this.BModem5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BModem5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BModem5.Location = new System.Drawing.Point(518, 158);
            this.BModem5.Name = "BModem5";
            this.BModem5.Size = new System.Drawing.Size(37, 37);
            this.BModem5.TabIndex = 10;
            this.BModem5.UseVisualStyleBackColor = true;
            this.BModem5.Click += new System.EventHandler(this.BModem5_Click);
            // 
            // BModem4
            // 
            this.BModem4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BModem4.BackgroundImage")));
            this.BModem4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BModem4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BModem4.Location = new System.Drawing.Point(518, 121);
            this.BModem4.Name = "BModem4";
            this.BModem4.Size = new System.Drawing.Size(37, 37);
            this.BModem4.TabIndex = 9;
            this.BModem4.UseVisualStyleBackColor = true;
            this.BModem4.Click += new System.EventHandler(this.BModem4_Click);
            // 
            // BModem3
            // 
            this.BModem3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BModem3.BackgroundImage")));
            this.BModem3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BModem3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BModem3.Location = new System.Drawing.Point(518, 84);
            this.BModem3.Name = "BModem3";
            this.BModem3.Size = new System.Drawing.Size(37, 37);
            this.BModem3.TabIndex = 8;
            this.BModem3.UseVisualStyleBackColor = true;
            this.BModem3.Click += new System.EventHandler(this.BModem3_Click);
            // 
            // BModem2
            // 
            this.BModem2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BModem2.BackgroundImage")));
            this.BModem2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BModem2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BModem2.Location = new System.Drawing.Point(518, 47);
            this.BModem2.Name = "BModem2";
            this.BModem2.Size = new System.Drawing.Size(37, 37);
            this.BModem2.TabIndex = 7;
            this.BModem2.UseVisualStyleBackColor = true;
            this.BModem2.Click += new System.EventHandler(this.BModem2_Click);
            // 
            // BModem1
            // 
            this.BModem1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BModem1.BackgroundImage")));
            this.BModem1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BModem1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BModem1.Location = new System.Drawing.Point(518, 10);
            this.BModem1.Name = "BModem1";
            this.BModem1.Size = new System.Drawing.Size(37, 37);
            this.BModem1.TabIndex = 6;
            this.BModem1.UseVisualStyleBackColor = true;
            this.BModem1.Click += new System.EventHandler(this.BModem1_Click);
            // 
            // TBModem6
            // 
            this.TBModem6.Location = new System.Drawing.Point(12, 204);
            this.TBModem6.Name = "TBModem6";
            this.TBModem6.Size = new System.Drawing.Size(500, 22);
            this.TBModem6.TabIndex = 5;
            // 
            // TBModem5
            // 
            this.TBModem5.Location = new System.Drawing.Point(12, 169);
            this.TBModem5.Name = "TBModem5";
            this.TBModem5.Size = new System.Drawing.Size(500, 22);
            this.TBModem5.TabIndex = 4;
            // 
            // TBModem4
            // 
            this.TBModem4.Location = new System.Drawing.Point(12, 130);
            this.TBModem4.Name = "TBModem4";
            this.TBModem4.Size = new System.Drawing.Size(500, 22);
            this.TBModem4.TabIndex = 3;
            // 
            // TBModem3
            // 
            this.TBModem3.Location = new System.Drawing.Point(12, 95);
            this.TBModem3.Name = "TBModem3";
            this.TBModem3.Size = new System.Drawing.Size(500, 22);
            this.TBModem3.TabIndex = 2;
            // 
            // TBModem2
            // 
            this.TBModem2.Location = new System.Drawing.Point(12, 58);
            this.TBModem2.Name = "TBModem2";
            this.TBModem2.Size = new System.Drawing.Size(500, 22);
            this.TBModem2.TabIndex = 1;
            // 
            // TBModem1
            // 
            this.TBModem1.Location = new System.Drawing.Point(12, 21);
            this.TBModem1.Name = "TBModem1";
            this.TBModem1.Size = new System.Drawing.Size(500, 22);
            this.TBModem1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox6);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(573, 254);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "GoIP";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.GridGOIP);
            this.groupBox6.Location = new System.Drawing.Point(5, 1);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(562, 247);
            this.groupBox6.TabIndex = 0;
            this.groupBox6.TabStop = false;
            // 
            // GridGOIP
            // 
            this.GridGOIP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridGOIP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IP,
            this.Coment});
            this.GridGOIP.Location = new System.Drawing.Point(6, 11);
            this.GridGOIP.Name = "GridGOIP";
            this.GridGOIP.Size = new System.Drawing.Size(550, 230);
            this.GridGOIP.TabIndex = 2;
            // 
            // IP
            // 
            this.IP.HeaderText = "ip";
            this.IP.Name = "IP";
            this.IP.Width = 150;
            // 
            // Coment
            // 
            this.Coment.HeaderText = "Коментарий";
            this.Coment.Name = "Coment";
            this.Coment.Width = 355;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.groupBox7);
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(573, 254);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Дополнительно";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.CBCheckTimeGoIP);
            this.groupBox7.Location = new System.Drawing.Point(6, 2);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(141, 74);
            this.groupBox7.TabIndex = 1;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Интервал опроса GoIP";
            // 
            // CBCheckTimeGoIP
            // 
            this.CBCheckTimeGoIP.FormattingEnabled = true;
            this.CBCheckTimeGoIP.Items.AddRange(new object[] {
            "1 min",
            "5 min",
            "10 min",
            "15 min",
            "20 min",
            "30 min"});
            this.CBCheckTimeGoIP.Location = new System.Drawing.Point(6, 37);
            this.CBCheckTimeGoIP.Name = "CBCheckTimeGoIP";
            this.CBCheckTimeGoIP.Size = new System.Drawing.Size(121, 23);
            this.CBCheckTimeGoIP.TabIndex = 1;
            // 
            // FSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 329);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.BSave);
            this.Controls.Add(this.BClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FSettings";
            this.Text = "Настройки";
            this.Load += new System.EventHandler(this.FSettings_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridGOIP)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BClose;
        private System.Windows.Forms.Button BSave;
        private System.Windows.Forms.OpenFileDialog ODFileSms;
        private System.Windows.Forms.FolderBrowserDialog FBD;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TBtoEmail;
        private System.Windows.Forms.CheckBox CBSendMail;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBEmail;
        private System.Windows.Forms.TextBox TBPass;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TBKey;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TBPort;
        private System.Windows.Forms.TextBox TBHost;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button BModem6;
        private System.Windows.Forms.Button BModem5;
        private System.Windows.Forms.Button BModem4;
        private System.Windows.Forms.Button BModem3;
        private System.Windows.Forms.Button BModem2;
        private System.Windows.Forms.Button BModem1;
        private System.Windows.Forms.TextBox TBModem6;
        private System.Windows.Forms.TextBox TBModem5;
        private System.Windows.Forms.TextBox TBModem4;
        private System.Windows.Forms.TextBox TBModem3;
        private System.Windows.Forms.TextBox TBModem2;
        private System.Windows.Forms.TextBox TBModem1;
        private System.Windows.Forms.DataGridView GridGOIP;
        private System.Windows.Forms.DataGridViewTextBoxColumn IP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coment;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.ComboBox CBCheckTimeGoIP;
    }
}