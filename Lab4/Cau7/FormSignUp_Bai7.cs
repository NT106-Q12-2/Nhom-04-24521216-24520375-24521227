using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Cau7
{
    public partial class FormSignUp_Bai7 : Form
    {
        public FormSignUp_Bai7()
        {
            InitializeComponent();
            List<string> languages = new List<string>{
                // can add more language in here
                "vi",
                "en"
            };
            foreach (var port in languages)
            {
                comboBox_language.Items.Add(port);
            }
            comboBox_language.SelectedIndex = 0;
        }

        private void hgroupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button_submit_Click(object sender, EventArgs e)
        {
            string username = textBox_username.Text.Trim();
            string password = textBox_password.Text;
            string email = textBox_email.Text.Trim();
            string firstName = textBox_firstname.Text.Trim();
            string lastName = textBox_lastname.Text.Trim();
            string phone = textBox_phone.Text.Trim();
            string birthday = dateTimePicker_birthday.Value.ToString("yyyy-MM-dd");
            string language = comboBox_language.Text;
            string sex = radioButton_male.Checked ? "Male" : "Female";  // nếu không là Male thì là Female
            if (string.IsNullOrWhiteSpace(username) || 
                string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(firstName) ||
                string.IsNullOrWhiteSpace(lastName) ||
                string.IsNullOrWhiteSpace(phone))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }
            bool success = DatabaseFunction.addUser(        // add user vào database (sqlite) trong phần sign up
                username, password, email, firstName, lastName, phone,
                birthday, language, sex
            );
            if (success)
            {
                MessageBox.Show("Đăng ký tài khoản thành công!");
                this.Close();
            }
        }

        private void textBox_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker_birthday_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_language_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedLanguage = comboBox_language.SelectedItem.ToString();
        }

        private void radioButton_male_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // FormSignUp_Bai7
            // 
            this.ClientSize = new System.Drawing.Size(407, 470);
            this.Name = "FormSignUp_Bai7";
            this.ResumeLayout(false);

        }
    }
}
