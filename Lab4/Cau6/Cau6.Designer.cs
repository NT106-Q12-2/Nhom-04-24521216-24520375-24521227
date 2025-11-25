namespace Cau6
{
    partial class Cau6
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
            tb_username = new TextBox();
            tb_password = new TextBox();
            label3 = new Label();
            label2 = new Label();
            rtb_result = new RichTextBox();
            tb_URL = new TextBox();
            btn_login = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // tb_username
            // 
            tb_username.Location = new Point(230, 119);
            tb_username.Name = "tb_username";
            tb_username.Size = new Size(299, 27);
            tb_username.TabIndex = 15;
            // 
            // tb_password
            // 
            tb_password.Location = new Point(230, 190);
            tb_password.Name = "tb_password";
            tb_password.Size = new Size(299, 27);
            tb_password.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(129, 193);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 13;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(129, 122);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 12;
            label2.Text = "Username";
            // 
            // rtb_result
            // 
            rtb_result.Location = new Point(150, 238);
            rtb_result.Name = "rtb_result";
            rtb_result.ReadOnly = true;
            rtb_result.Size = new Size(522, 164);
            rtb_result.TabIndex = 11;
            rtb_result.Text = "";
            // 
            // tb_URL
            // 
            tb_URL.Location = new Point(230, 49);
            tb_URL.Name = "tb_URL";
            tb_URL.Size = new Size(442, 27);
            tb_URL.TabIndex = 10;
            // 
            // btn_login
            // 
            btn_login.Location = new Point(552, 119);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(120, 98);
            btn_login.TabIndex = 9;
            btn_login.Text = "LOGIN";
            btn_login.UseVisualStyleBackColor = true;
            btn_login.Click += btn_login_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(129, 52);
            label1.Name = "label1";
            label1.Size = new Size(35, 20);
            label1.TabIndex = 8;
            label1.Text = "URL";
            // 
            // Cau6
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tb_username);
            Controls.Add(tb_password);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(rtb_result);
            Controls.Add(tb_URL);
            Controls.Add(btn_login);
            Controls.Add(label1);
            Name = "Cau6";
            Text = "Câu 6";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tb_username;
        private TextBox tb_password;
        private Label label3;
        private Label label2;
        private RichTextBox rtb_result;
        private TextBox tb_URL;
        private Button btn_login;
        private Label label1;
    }
}
