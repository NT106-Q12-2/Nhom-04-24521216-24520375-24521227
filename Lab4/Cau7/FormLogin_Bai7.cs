using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cau7
{
    public partial class FormLogin_Bai7 : Form
    {
        public FormLogin_Bai7()
        {
            InitializeComponent();
        }

        private void textBox_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel_signupinLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormSignUp_Bai7 formsignup = new FormSignUp_Bai7();
            formsignup.Show();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            string username = textBox_username.Text, password = textBox_password.Text;
            if (string.IsNullOrEmpty(username) ||
                string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin đăng nhập.");
                return;
            }
            int id = Cau7.DatabaseFunction.ValidateUser(username, password);
            if(id>0)
            {
                SessionManager_Bai7.Login(id, username);    //log in phiên user
                MessageBox.Show($"Đăng nhập {username} thành công.");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

//        private void InitializeComponent()
//        {
//            this.SuspendLayout();
            // 
            // FormLogin_Bai7
            // 
//            this.ClientSize = new System.Drawing.Size(284, 261);
 //           this.Name = "FormLogin_Bai7";
//            this.Load += new System.EventHandler(this.FormLogin_Bai7_Load);
//            this.ResumeLayout(false);

//        }

        private void FormLogin_Bai7_Load(object sender, EventArgs e)
        {

        }
    }
}
