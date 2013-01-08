namespace ShotLife
{
    partial class Config
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxAutoRun = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbPixelFormat = new System.Windows.Forms.ComboBox();
            this.nudFrequency = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.tbxPicWidth = new System.Windows.Forms.TextBox();
            this.tbxPicHeight = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbxBaseHeight = new System.Windows.Forms.CheckBox();
            this.cbxBaseWidth = new System.Windows.Forms.CheckBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.tbxSmtpServer = new System.Windows.Forms.TextBox();
            this.tbxMailUserName = new System.Windows.Forms.TextBox();
            this.tbxMailPassword = new System.Windows.Forms.TextBox();
            this.tbxSavePath = new System.Windows.Forms.TextBox();
            this.cbxAutoSendMail = new System.Windows.Forms.CheckBox();
            this.tbxMailTo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudFrequency)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "图片品质";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(225, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "保存路径";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "用户名";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "Smtp";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 3;
            this.label5.Text = "密码";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 4;
            this.label6.Text = "截图频率";
            // 
            // cbxAutoRun
            // 
            this.cbxAutoRun.AutoSize = true;
            this.cbxAutoRun.Location = new System.Drawing.Point(12, 270);
            this.cbxAutoRun.Name = "cbxAutoRun";
            this.cbxAutoRun.Size = new System.Drawing.Size(96, 16);
            this.cbxAutoRun.TabIndex = 5;
            this.cbxAutoRun.Text = "开机自动运行";
            this.cbxAutoRun.UseVisualStyleBackColor = true;
            this.cbxAutoRun.CheckedChanged += new System.EventHandler(this.cbxAutoRun_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(225, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 2;
            this.label7.Text = "发送机制";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(68, 236);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 12);
            this.label9.TabIndex = 8;
            this.label9.Text = "分钟";
            // 
            // cmbPixelFormat
            // 
            this.cmbPixelFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPixelFormat.FormattingEnabled = true;
            this.cmbPixelFormat.Location = new System.Drawing.Point(71, 1);
            this.cmbPixelFormat.Name = "cmbPixelFormat";
            this.cmbPixelFormat.Size = new System.Drawing.Size(121, 20);
            this.cmbPixelFormat.TabIndex = 7;
            this.cmbPixelFormat.SelectedIndexChanged += new System.EventHandler(this.cmbImageFormat_SelectedIndexChanged);
            // 
            // nudFrequency
            // 
            this.nudFrequency.Location = new System.Drawing.Point(14, 232);
            this.nudFrequency.Name = "nudFrequency";
            this.nudFrequency.Size = new System.Drawing.Size(49, 21);
            this.nudFrequency.TabIndex = 9;
            this.nudFrequency.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.nudFrequency.Validated += new System.EventHandler(this.nudFrequency_Validated);
            this.nudFrequency.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nudFrequency_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(225, 71);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 12);
            this.label10.TabIndex = 2;
            this.label10.Text = "长";
            // 
            // tbxPicWidth
            // 
            this.tbxPicWidth.Location = new System.Drawing.Point(248, 71);
            this.tbxPicWidth.Name = "tbxPicWidth";
            this.tbxPicWidth.Size = new System.Drawing.Size(49, 21);
            this.tbxPicWidth.TabIndex = 10;
            // 
            // tbxPicHeight
            // 
            this.tbxPicHeight.Location = new System.Drawing.Point(248, 93);
            this.tbxPicHeight.Name = "tbxPicHeight";
            this.tbxPicHeight.Size = new System.Drawing.Size(49, 21);
            this.tbxPicHeight.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(225, 99);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 12);
            this.label11.TabIndex = 12;
            this.label11.Text = "宽";
            // 
            // cbxBaseHeight
            // 
            this.cbxBaseHeight.AutoSize = true;
            this.cbxBaseHeight.Location = new System.Drawing.Point(313, 98);
            this.cbxBaseHeight.Name = "cbxBaseHeight";
            this.cbxBaseHeight.Size = new System.Drawing.Size(144, 16);
            this.cbxBaseHeight.TabIndex = 15;
            this.cbxBaseHeight.Text = "以长度为基准等比缩放";
            this.cbxBaseHeight.UseVisualStyleBackColor = true;
            // 
            // cbxBaseWidth
            // 
            this.cbxBaseWidth.AutoSize = true;
            this.cbxBaseWidth.Location = new System.Drawing.Point(313, 70);
            this.cbxBaseWidth.Name = "cbxBaseWidth";
            this.cbxBaseWidth.Size = new System.Drawing.Size(144, 16);
            this.cbxBaseWidth.TabIndex = 15;
            this.cbxBaseWidth.Text = "以长度为基准等比缩放";
            this.cbxBaseWidth.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Location = new System.Drawing.Point(227, 31);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(107, 16);
            this.radioButton2.TabIndex = 16;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "当前分辨率大小";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // tbxSmtpServer
            // 
            this.tbxSmtpServer.Location = new System.Drawing.Point(61, 97);
            this.tbxSmtpServer.Name = "tbxSmtpServer";
            this.tbxSmtpServer.Size = new System.Drawing.Size(158, 21);
            this.tbxSmtpServer.TabIndex = 17;
            // 
            // tbxMailUserName
            // 
            this.tbxMailUserName.Location = new System.Drawing.Point(61, 154);
            this.tbxMailUserName.Name = "tbxMailUserName";
            this.tbxMailUserName.Size = new System.Drawing.Size(158, 21);
            this.tbxMailUserName.TabIndex = 18;
            // 
            // tbxMailPassword
            // 
            this.tbxMailPassword.Location = new System.Drawing.Point(61, 183);
            this.tbxMailPassword.Name = "tbxMailPassword";
            this.tbxMailPassword.PasswordChar = '*';
            this.tbxMailPassword.Size = new System.Drawing.Size(158, 21);
            this.tbxMailPassword.TabIndex = 19;
            this.tbxMailPassword.UseSystemPasswordChar = true;
            // 
            // tbxSavePath
            // 
            this.tbxSavePath.Location = new System.Drawing.Point(227, 148);
            this.tbxSavePath.Name = "tbxSavePath";
            this.tbxSavePath.Size = new System.Drawing.Size(265, 21);
            this.tbxSavePath.TabIndex = 19;
            // 
            // cbxAutoSendMail
            // 
            this.cbxAutoSendMail.AutoSize = true;
            this.cbxAutoSendMail.Location = new System.Drawing.Point(14, 60);
            this.cbxAutoSendMail.Name = "cbxAutoSendMail";
            this.cbxAutoSendMail.Size = new System.Drawing.Size(120, 16);
            this.cbxAutoSendMail.TabIndex = 15;
            this.cbxAutoSendMail.Text = "将截图发送到邮箱";
            this.cbxAutoSendMail.UseVisualStyleBackColor = true;
            // 
            // tbxMailTo
            // 
            this.tbxMailTo.Location = new System.Drawing.Point(61, 123);
            this.tbxMailTo.Name = "tbxMailTo";
            this.tbxMailTo.Size = new System.Drawing.Size(158, 21);
            this.tbxMailTo.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 1;
            this.label8.Text = "MailTo";
            // 
            // Config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 333);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbxBaseHeight);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbxSavePath);
            this.Controls.Add(this.tbxPicWidth);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.nudFrequency);
            this.Controls.Add(this.tbxPicHeight);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbxBaseWidth);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbxMailPassword);
            this.Controls.Add(this.tbxMailTo);
            this.Controls.Add(this.cmbPixelFormat);
            this.Controls.Add(this.tbxMailUserName);
            this.Controls.Add(this.tbxSmtpServer);
            this.Controls.Add(this.cbxAutoSendMail);
            this.Controls.Add(this.cbxAutoRun);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Config";
            this.Text = "Config";
            ((System.ComponentModel.ISupportInitialize)(this.nudFrequency)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox cbxAutoRun;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbPixelFormat;
        private System.Windows.Forms.NumericUpDown nudFrequency;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbxPicWidth;
        private System.Windows.Forms.TextBox tbxPicHeight;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox cbxBaseHeight;
        private System.Windows.Forms.CheckBox cbxBaseWidth;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.TextBox tbxSmtpServer;
        private System.Windows.Forms.TextBox tbxMailUserName;
        private System.Windows.Forms.TextBox tbxMailPassword;
        private System.Windows.Forms.TextBox tbxSavePath;
        private System.Windows.Forms.CheckBox cbxAutoSendMail;
        private System.Windows.Forms.TextBox tbxMailTo;
        private System.Windows.Forms.Label label8;
    }
}