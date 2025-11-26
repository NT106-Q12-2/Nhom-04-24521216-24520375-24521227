namespace Bai1
{
    partial class Cau3
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
            label1 = new Label();
            label2 = new Label();
            tb_email = new TextBox();
            tb_password = new TextBox();
            btn_login = new Button();
            lv_showemail = new ListView();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 29);
            label1.Name = "label1";
            label1.Size = new Size(58, 25);
            label1.TabIndex = 0;
            label1.Text = "Email:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 78);
            label2.Name = "label2";
            label2.Size = new Size(91, 25);
            label2.TabIndex = 1;
            label2.Text = "Password:";
            // 
            // tb_email
            // 
            tb_email.Location = new Point(154, 23);
            tb_email.Name = "tb_email";
            tb_email.Size = new Size(620, 31);
            tb_email.TabIndex = 2;
            // 
            // tb_password
            // 
            tb_password.Location = new Point(154, 72);
            tb_password.Name = "tb_password";
            tb_password.Size = new Size(620, 31);
            tb_password.TabIndex = 3;
            // 
            // btn_login
            // 
            btn_login.Location = new Point(866, 20);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(112, 34);
            btn_login.TabIndex = 4;
            btn_login.Text = "Login";
            btn_login.UseVisualStyleBackColor = true;
            btn_login.Click += btn_login_Click;
            // 
            // lv_showemail
            // 
            lv_showemail.Location = new Point(48, 190);
            lv_showemail.Name = "lv_showemail";
            lv_showemail.Size = new Size(952, 457);
            lv_showemail.TabIndex = 5;
            lv_showemail.UseCompatibleStateImageBehavior = false;
            lv_showemail.DoubleClick += lv_showemail_DoubleClick;
            // 
            // Cau3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1056, 659);
            Controls.Add(lv_showemail);
            Controls.Add(btn_login);
            Controls.Add(tb_password);
            Controls.Add(tb_email);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Cau3";
            Text = "Câu 3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tb_email;
        private TextBox tb_password;
        private Button btn_login;
        private ListView lv_showemail;
    }
}
