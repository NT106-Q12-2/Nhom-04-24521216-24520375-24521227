using System;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace Cau1
{
    public partial class Cau1 : Form
    {
        public Cau1()
        {
            InitializeComponent();
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            using (SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587))
            {
                string mailfrom = tb_from.Text;
                string mailto = tb_to.Text;
                var basicCredential = new NetworkCredential(mailfrom, tb_password.Text);
                using (MailMessage message = new MailMessage())
                {
                    MailAddress fromAddress = new MailAddress(mailfrom);
                    smtpClient.EnableSsl = true; 
                    smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtpClient.UseDefaultCredentials = false;
                    smtpClient.Credentials = basicCredential;

                    message.From = fromAddress;
                    message.Subject = tb_subject.Text;
                    message.IsBodyHtml = false;
                    message.Body = rtb_result.Text;
                    message.To.Add(mailto);
                    try
                    {
                        smtpClient.Send(message);
                        MessageBox.Show("Successfully sent!");
                    }
                   
                    catch (Exception ex)
                    {
                        MessageBox.Show("Username or password is Incorrect");
                    }
                }
            }

        }
    }
}
