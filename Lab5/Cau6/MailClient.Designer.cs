namespace Cau6
{
    partial class MailClient
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            btn_sendmail = new Button();
            btn_refresh = new Button();
            btn_signout = new Button();
            btn_signin = new Button();
            label2 = new Label();
            label1 = new Label();
            tb_password = new TextBox();
            tb_email = new TextBox();
            groupBox2 = new GroupBox();
            tb_smtphost = new TextBox();
            tb_imaphost = new TextBox();
            numUD_smtpport = new NumericUpDown();
            numUD_imapport = new NumericUpDown();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            lv_showemail = new ListView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numUD_smtpport).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numUD_imapport).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_sendmail);
            groupBox1.Controls.Add(btn_refresh);
            groupBox1.Controls.Add(btn_signout);
            groupBox1.Controls.Add(btn_signin);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(tb_password);
            groupBox1.Controls.Add(tb_email);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(480, 181);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Đăng Nhập";
            // 
            // btn_sendmail
            // 
            btn_sendmail.Location = new Point(6, 147);
            btn_sendmail.Name = "btn_sendmail";
            btn_sendmail.Size = new Size(134, 34);
            btn_sendmail.TabIndex = 3;
            btn_sendmail.Text = "Send mail";
            btn_sendmail.UseVisualStyleBackColor = true;
            // 
            // btn_refresh
            // 
            btn_refresh.Location = new Point(169, 147);
            btn_refresh.Name = "btn_refresh";
            btn_refresh.Size = new Size(143, 34);
            btn_refresh.TabIndex = 3;
            btn_refresh.Text = "Refresh";
            btn_refresh.UseVisualStyleBackColor = true;
            btn_refresh.Click += btn_refresh_Click;
            // 
            // btn_signout
            // 
            btn_signout.Location = new Point(334, 147);
            btn_signout.Name = "btn_signout";
            btn_signout.Size = new Size(140, 34);
            btn_signout.TabIndex = 3;
            btn_signout.Text = "Sign out";
            btn_signout.UseVisualStyleBackColor = true;
            btn_signout.Click += btn_signout_Click;
            // 
            // btn_signin
            // 
            btn_signin.Location = new Point(286, 104);
            btn_signin.Name = "btn_signin";
            btn_signin.Size = new Size(188, 34);
            btn_signin.TabIndex = 2;
            btn_signin.Text = "Sign in";
            btn_signin.UseVisualStyleBackColor = true;
            btn_signin.Click += btn_signin_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 73);
            label2.Name = "label2";
            label2.Size = new Size(90, 25);
            label2.TabIndex = 4;
            label2.Text = "Mật khẩu:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 36);
            label1.Name = "label1";
            label1.Size = new Size(90, 25);
            label1.TabIndex = 2;
            label1.Text = "Tài khoản:";
            // 
            // tb_password
            // 
            tb_password.Location = new Point(116, 67);
            tb_password.Name = "tb_password";
            tb_password.Size = new Size(358, 31);
            tb_password.TabIndex = 3;
            // 
            // tb_email
            // 
            tb_email.Location = new Point(116, 30);
            tb_email.Name = "tb_email";
            tb_email.Size = new Size(358, 31);
            tb_email.TabIndex = 2;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tb_smtphost);
            groupBox2.Controls.Add(tb_imaphost);
            groupBox2.Controls.Add(numUD_smtpport);
            groupBox2.Controls.Add(numUD_imapport);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(498, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(609, 181);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Cài Đặt Cấu Hình";
            // 
            // tb_smtphost
            // 
            tb_smtphost.Location = new Point(391, 30);
            tb_smtphost.Name = "tb_smtphost";
            tb_smtphost.ReadOnly = true;
            tb_smtphost.Size = new Size(202, 31);
            tb_smtphost.TabIndex = 7;
            tb_smtphost.Text = "smtp.gmail.com";
            // 
            // tb_imaphost
            // 
            tb_imaphost.Location = new Point(85, 30);
            tb_imaphost.Name = "tb_imaphost";
            tb_imaphost.ReadOnly = true;
            tb_imaphost.Size = new Size(203, 31);
            tb_imaphost.TabIndex = 6;
            tb_imaphost.Text = "imap.gmail.com";
            // 
            // numUD_smtpport
            // 
            numUD_smtpport.Location = new Point(391, 71);
            numUD_smtpport.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numUD_smtpport.Name = "numUD_smtpport";
            numUD_smtpport.ReadOnly = true;
            numUD_smtpport.Size = new Size(202, 31);
            numUD_smtpport.TabIndex = 5;
            numUD_smtpport.Value = new decimal(new int[] { 587, 0, 0, 0 });
            // 
            // numUD_imapport
            // 
            numUD_imapport.Location = new Point(85, 71);
            numUD_imapport.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numUD_imapport.Name = "numUD_imapport";
            numUD_imapport.ReadOnly = true;
            numUD_imapport.Size = new Size(203, 31);
            numUD_imapport.TabIndex = 4;
            numUD_imapport.Value = new decimal(new int[] { 993, 0, 0, 0 });
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(318, 77);
            label6.Name = "label6";
            label6.Size = new Size(44, 25);
            label6.TabIndex = 3;
            label6.Text = "Port";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(318, 40);
            label5.Name = "label5";
            label5.Size = new Size(57, 25);
            label5.TabIndex = 2;
            label5.Text = "SMTP";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 73);
            label4.Name = "label4";
            label4.Size = new Size(44, 25);
            label4.TabIndex = 1;
            label4.Text = "Port";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 36);
            label3.Name = "label3";
            label3.Size = new Size(55, 25);
            label3.TabIndex = 0;
            label3.Text = "IMAP";
            // 
            // lv_showemail
            // 
            lv_showemail.Location = new Point(18, 199);
            lv_showemail.Name = "lv_showemail";
            lv_showemail.Size = new Size(1089, 483);
            lv_showemail.TabIndex = 2;
            lv_showemail.UseCompatibleStateImageBehavior = false;
            lv_showemail.DoubleClick += lv_showemail_DoubleClick;
            // 
            // MailClient
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1119, 694);
            Controls.Add(lv_showemail);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "MailClient";
            Text = "Mail Client";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numUD_smtpport).EndInit();
            ((System.ComponentModel.ISupportInitialize)numUD_imapport).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox tb_password;
        private TextBox tb_email;
        private GroupBox groupBox2;
        private Button btn_sendmail;
        private Button btn_refresh;
        private Button btn_signout;
        private Button btn_signin;
        private Label label2;
        private Label label1;
        private TextBox tb_smtphost;
        private TextBox tb_imaphost;
        private NumericUpDown numUD_smtpport;
        private NumericUpDown numUD_imapport;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private ListView lv_showemail;
    }
}
