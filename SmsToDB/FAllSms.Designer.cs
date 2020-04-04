namespace SmsToDB
{
    partial class FAllSms
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
            this.TBAllSms = new System.Windows.Forms.TextBox();
            this.BClose = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TBAllSms);
            this.groupBox1.Location = new System.Drawing.Point(6, -2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(782, 413);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // TBAllSms
            // 
            this.TBAllSms.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBAllSms.Location = new System.Drawing.Point(6, 14);
            this.TBAllSms.Multiline = true;
            this.TBAllSms.Name = "TBAllSms";
            this.TBAllSms.ReadOnly = true;
            this.TBAllSms.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TBAllSms.Size = new System.Drawing.Size(770, 393);
            this.TBAllSms.TabIndex = 0;
            // 
            // BClose
            // 
            this.BClose.BackgroundImage = global::SmsToDB.Properties.Resources.Delete;
            this.BClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BClose.Location = new System.Drawing.Point(286, 417);
            this.BClose.Name = "BClose";
            this.BClose.Size = new System.Drawing.Size(117, 36);
            this.BClose.TabIndex = 1;
            this.BClose.Text = "   Закрыть";
            this.BClose.UseVisualStyleBackColor = true;
            this.BClose.Click += new System.EventHandler(this.BClose_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::SmsToDB.Properties.Resources.clear1;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(409, 417);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 36);
            this.button1.TabIndex = 2;
            this.button1.Text = "    Очистить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FAllSms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 462);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BClose);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FAllSms";
            this.Text = "Все смс";
            this.Load += new System.EventHandler(this.FAllSms_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TBAllSms;
        private System.Windows.Forms.Button BClose;
        private System.Windows.Forms.Button button1;
    }
}