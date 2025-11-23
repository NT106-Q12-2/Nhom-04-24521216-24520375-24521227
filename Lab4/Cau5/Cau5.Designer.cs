namespace Cau5
{
    partial class Cau5
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
            btn_login = new Button();
            tb_URL = new TextBox();
            rtb_result = new RichTextBox();
            label2 = new Label();
            label3 = new Label();
            tb_password = new TextBox();
            tb_username = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(99, 88);
            label1.Name = "label1";
            label1.Size = new Size(35, 20);
            label1.TabIndex = 0;
            label1.Text = "URL";
            // 
            // btn_login
            // 
            btn_login.Location = new Point(522, 155);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(120, 98);
            btn_login.TabIndex = 1;
            btn_login.Text = "LOGIN";
            btn_login.UseVisualStyleBackColor = true;
            btn_login.Click += btn_login_Click;
            // 
            // tb_URL
            // 
            tb_URL.Location = new Point(200, 85);
            tb_URL.Name = "tb_URL";
            tb_URL.Size = new Size(442, 27);
            tb_URL.TabIndex = 2;
            // 
            // rtb_result
            // 
            rtb_result.Location = new Point(120, 274);
            rtb_result.Name = "rtb_result";
            rtb_result.ReadOnly = true;
            rtb_result.Size = new Size(522, 164);
            rtb_result.TabIndex = 3;
            rtb_result.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(99, 158);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 4;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(99, 229);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 5;
            label3.Text = "Password";
            // 
            // tb_password
            // 
            tb_password.Location = new Point(200, 226);
            tb_password.Name = "tb_password";
            tb_password.Size = new Size(299, 27);
            tb_password.TabIndex = 6;
            // 
            // tb_username
            // 
            tb_username.Location = new Point(200, 155);
            tb_username.Name = "tb_username";
            tb_username.Size = new Size(299, 27);
            tb_username.TabIndex = 7;
            // 
            // Cau5
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
            Name = "Cau5";
            Text = "Câu 5";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btn_login;
        private TextBox tb_URL;
        private RichTextBox rtb_result;
        private Label label2;
        private Label label3;
        private TextBox tb_password;
        private TextBox tb_username;
    }
}
