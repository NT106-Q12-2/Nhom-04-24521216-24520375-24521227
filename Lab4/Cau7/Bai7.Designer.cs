namespace Cau7
{
    partial class Bai7
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
            this.btn_takefood = new System.Windows.Forms.Button();
            this.btn_addfood = new System.Windows.Forms.Button();
            this.textbox_status = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabControl_allfood = new System.Windows.Forms.TabControl();
            this.linkLabel_signup = new System.Windows.Forms.LinkLabel();
            this.linkLabel_login = new System.Windows.Forms.LinkLabel();
            this.tabControl_allfood.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(93, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "HÔM NAY ĂN GÌ?";
            // 
            // btn_takefood
            // 
            this.btn_takefood.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_takefood.ForeColor = System.Drawing.Color.Black;
            this.btn_takefood.Location = new System.Drawing.Point(1155, 88);
            this.btn_takefood.Name = "btn_takefood";
            this.btn_takefood.Size = new System.Drawing.Size(225, 82);
            this.btn_takefood.TabIndex = 1;
            this.btn_takefood.Text = "Ăn gì giờ?";
            this.btn_takefood.UseVisualStyleBackColor = true;
            this.btn_takefood.Click += new System.EventHandler(this.btn_takefood_Click);
            // 
            // btn_addfood
            // 
            this.btn_addfood.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addfood.ForeColor = System.Drawing.Color.Black;
            this.btn_addfood.Location = new System.Drawing.Point(1418, 88);
            this.btn_addfood.Name = "btn_addfood";
            this.btn_addfood.Size = new System.Drawing.Size(225, 82);
            this.btn_addfood.TabIndex = 2;
            this.btn_addfood.Text = "Thêm món ăn";
            this.btn_addfood.UseVisualStyleBackColor = true;
            this.btn_addfood.Click += new System.EventHandler(this.btn_addfood_Click);
            // 
            // textbox_status
            // 
            this.textbox_status.Location = new System.Drawing.Point(89, 997);
            this.textbox_status.Name = "textbox_status";
            this.textbox_status.Size = new System.Drawing.Size(235, 26);
            this.textbox_status.TabIndex = 5;
            this.textbox_status.TextChanged += new System.EventHandler(this.textbox_status_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1739, 791);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tôi đóng góp";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1739, 791);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "All";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tabControl_allfood
            // 
            this.tabControl_allfood.Controls.Add(this.tabPage1);
            this.tabControl_allfood.Controls.Add(this.tabPage2);
            this.tabControl_allfood.Location = new System.Drawing.Point(85, 167);
            this.tabControl_allfood.Name = "tabControl_allfood";
            this.tabControl_allfood.SelectedIndex = 0;
            this.tabControl_allfood.Size = new System.Drawing.Size(1747, 824);
            this.tabControl_allfood.TabIndex = 3;
            // 
            // linkLabel_signup
            // 
            this.linkLabel_signup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel_signup.Location = new System.Drawing.Point(342, 997);
            this.linkLabel_signup.Name = "linkLabel_signup";
            this.linkLabel_signup.Size = new System.Drawing.Size(100, 36);
            this.linkLabel_signup.TabIndex = 6;
            this.linkLabel_signup.TabStop = true;
            this.linkLabel_signup.Text = "Sign Up";
            this.linkLabel_signup.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_signin_LinkClicked);
            // 
            // linkLabel_login
            // 
            this.linkLabel_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel_login.Location = new System.Drawing.Point(459, 997);
            this.linkLabel_login.Name = "linkLabel_login";
            this.linkLabel_login.Size = new System.Drawing.Size(100, 36);
            this.linkLabel_login.TabIndex = 7;
            this.linkLabel_login.TabStop = true;
            this.linkLabel_login.Text = "Login";
            this.linkLabel_login.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_login_LinkClicked);
            // 
            // Bai7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1061);
            this.Controls.Add(this.linkLabel_login);
            this.Controls.Add(this.linkLabel_signup);
            this.Controls.Add(this.textbox_status);
            this.Controls.Add(this.tabControl_allfood);
            this.Controls.Add(this.btn_addfood);
            this.Controls.Add(this.btn_takefood);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.IndianRed;
            this.Name = "Bai7";
            this.Text = "Bai7";
            this.Load += new System.EventHandler(this.Bai7_Load);
            this.tabControl_allfood.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_takefood;
        private System.Windows.Forms.Button btn_addfood;
        private System.Windows.Forms.TextBox textbox_status;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl_allfood;
        private System.Windows.Forms.LinkLabel linkLabel_signup;
        private System.Windows.Forms.LinkLabel linkLabel_login;
    }
}