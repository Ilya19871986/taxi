namespace SmsToDB
{
    partial class FMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMain));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LV = new System.Windows.Forms.ListView();
            this.LOG = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TimerMain = new System.Windows.Forms.Timer(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BPriority = new System.Windows.Forms.Button();
            this.BRun = new System.Windows.Forms.Button();
            this.BAllSms = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.BInvalidSms = new System.Windows.Forms.Button();
            this.BSettings = new System.Windows.Forms.Button();
            this.TimerGoIP = new System.Windows.Forms.Timer(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.IP = new System.Windows.Forms.ListView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.Status = new System.Windows.Forms.ToolStripStatusLabel();
            this.CheckGoIP = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LV);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(6, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(669, 416);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // LV
            // 
            this.LV.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.LV.BackgroundImageTiled = true;
            this.LV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.LOG});
            this.LV.FullRowSelect = true;
            this.LV.Location = new System.Drawing.Point(6, 12);
            this.LV.Name = "LV";
            this.LV.Size = new System.Drawing.Size(657, 396);
            this.LV.TabIndex = 0;
            this.LV.UseCompatibleStateImageBehavior = false;
            this.LV.View = System.Windows.Forms.View.List;
            // 
            // LOG
            // 
            this.LOG.Text = global::SmsToDB.Properties.Settings.Default.ToEmail;
            this.LOG.Width = 670;
            // 
            // TimerMain
            // 
            this.TimerMain.Interval = 20000;
            this.TimerMain.Tick += new System.EventHandler(this.TimerMain_Tick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BPriority);
            this.groupBox2.Controls.Add(this.BRun);
            this.groupBox2.Controls.Add(this.BAllSms);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.BInvalidSms);
            this.groupBox2.Controls.Add(this.BSettings);
            this.groupBox2.Location = new System.Drawing.Point(6, 422);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(669, 55);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            // 
            // BPriority
            // 
            this.BPriority.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BPriority.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BPriority.Image = global::SmsToDB.Properties.Resources.pri;
            this.BPriority.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BPriority.Location = new System.Drawing.Point(529, 10);
            this.BPriority.Name = "BPriority";
            this.BPriority.Size = new System.Drawing.Size(134, 40);
            this.BPriority.TabIndex = 8;
            this.BPriority.Text = "Приоритеты";
            this.BPriority.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BPriority.UseVisualStyleBackColor = true;
            this.BPriority.Click += new System.EventHandler(this.BPriority_Click);
            // 
            // BRun
            // 
            this.BRun.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BRun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BRun.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BRun.Image = global::SmsToDB.Properties.Resources.fjSQk;
            this.BRun.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.BRun.Location = new System.Drawing.Point(7, 10);
            this.BRun.Name = "BRun";
            this.BRun.Size = new System.Drawing.Size(88, 40);
            this.BRun.TabIndex = 5;
            this.BRun.Text = "Старт";
            this.BRun.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BRun.UseVisualStyleBackColor = true;
            this.BRun.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // BAllSms
            // 
            this.BAllSms.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BAllSms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BAllSms.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BAllSms.Image = global::SmsToDB.Properties.Resources.file;
            this.BAllSms.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.BAllSms.Location = new System.Drawing.Point(432, 10);
            this.BAllSms.Name = "BAllSms";
            this.BAllSms.Size = new System.Drawing.Size(97, 40);
            this.BAllSms.TabIndex = 7;
            this.BAllSms.Text = "Все смс";
            this.BAllSms.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BAllSms.UseVisualStyleBackColor = true;
            this.BAllSms.Click += new System.EventHandler(this.BAllSms_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Image = global::SmsToDB.Properties.Resources.Shiny_stop_hand_svg;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button1.Location = new System.Drawing.Point(95, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 40);
            this.button1.TabIndex = 6;
            this.button1.Text = "Стоп";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BInvalidSms
            // 
            this.BInvalidSms.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BInvalidSms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BInvalidSms.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BInvalidSms.Location = new System.Drawing.Point(296, 10);
            this.BInvalidSms.Name = "BInvalidSms";
            this.BInvalidSms.Size = new System.Drawing.Size(136, 40);
            this.BInvalidSms.TabIndex = 3;
            this.BInvalidSms.Text = "Неизвестные смс";
            this.BInvalidSms.UseVisualStyleBackColor = true;
            this.BInvalidSms.Click += new System.EventHandler(this.BInvalidSms_Click);
            // 
            // BSettings
            // 
            this.BSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BSettings.BackgroundImage = global::SmsToDB.Properties.Resources.df22629de9c5;
            this.BSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BSettings.Location = new System.Drawing.Point(182, 10);
            this.BSettings.Name = "BSettings";
            this.BSettings.Size = new System.Drawing.Size(114, 40);
            this.BSettings.TabIndex = 1;
            this.BSettings.Text = "Настройки";
            this.BSettings.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BSettings.UseVisualStyleBackColor = true;
            this.BSettings.Click += new System.EventHandler(this.BSettings_Click);
            // 
            // TimerGoIP
            // 
            this.TimerGoIP.Interval = 60000;
            this.TimerGoIP.Tick += new System.EventHandler(this.TimerGoIP_Tick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.IP);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(681, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(106, 477);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            // 
            // IP
            // 
            this.IP.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.IP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IP.Location = new System.Drawing.Point(6, 12);
            this.IP.Name = "IP";
            this.IP.Size = new System.Drawing.Size(93, 459);
            this.IP.TabIndex = 0;
            this.IP.UseCompatibleStateImageBehavior = false;
            this.IP.View = System.Windows.Forms.View.List;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Status,
            this.CheckGoIP});
            this.statusStrip1.Location = new System.Drawing.Point(0, 482);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(791, 22);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Status
            // 
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(108, 17);
            this.Status.Text = "Время опроса GoIP: ";
            // 
            // CheckGoIP
            // 
            this.CheckGoIP.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CheckGoIP.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.CheckGoIP.Image = ((System.Drawing.Image)(resources.GetObject("CheckGoIP.Image")));
            this.CheckGoIP.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CheckGoIP.Name = "CheckGoIP";
            this.CheckGoIP.Size = new System.Drawing.Size(32, 20);
            this.CheckGoIP.Text = "toolStripSplitButton1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem1.Text = "Проверка GoIP";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_ClickAsync);
            // 
            // FMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 504);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SmsToDB - v3.5";
            this.Load += new System.EventHandler(this.FMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BSettings;
        private System.Windows.Forms.Button BInvalidSms;
        private System.Windows.Forms.Timer TimerMain;
        private System.Windows.Forms.Button BRun;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BAllSms;
        private System.Windows.Forms.ColumnHeader LOG;
        private System.Windows.Forms.Button BPriority;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.ListView LV;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ListView IP;
        public System.Windows.Forms.Timer TimerGoIP;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel Status;
        private System.Windows.Forms.ToolStripSplitButton CheckGoIP;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}

