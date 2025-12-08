using MimeKit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailKit.Net.Smtp;
using MailKit.Security;


namespace Cau6
{
    public partial class SendMail : Form
    {
        private string _attachmentFilePath;
        private string senderEmail;
        private string senderPassword;

        public SendMail(string senderEmail, string senderPassword)
        {
            InitializeComponent();
            this.senderPassword = senderPassword;
            this.senderEmail = senderEmail;
        }

        private void btn_browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Chọn tệp đính kèm";
            openFileDialog.Filter = "Tất cả tệp (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                _attachmentFilePath = openFileDialog.FileName;
                tb_attachment.Text = System.IO.Path.GetFileName(_attachmentFilePath);
            }
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            {

                if (string.IsNullOrWhiteSpace(tb_to.Text))
                {
                    MessageBox.Show("Vui lòng nhập địa chỉ email người nhận!");
                    return;
                }

                if (string.IsNullOrWhiteSpace(tb_subject.Text))
                {
                    MessageBox.Show("Vui lòng nhập tiêu đề email!");
                    return;
                }
                try
                {
                    var message = new MimeMessage();
                    string senderName = tb_name.Text;
                    if (string.IsNullOrWhiteSpace(senderName))
                    {
                        message.From.Add(MailboxAddress.Parse(senderEmail));
                    }
                    else
                    {
                        message.From.Add(new MailboxAddress(senderName, senderEmail));
                    }
                    message.To.Add(MailboxAddress.Parse(tb_to.Text.Trim()));
                    message.Subject = tb_subject.Text.Trim();

                    var builder = new BodyBuilder();
                    if (cb_html.Checked)
                    {
                        builder.HtmlBody = tb_body.Text;
                    }
                    else
                    {
                        builder.TextBody = tb_body.Text;
                    }
                    if (!string.IsNullOrEmpty(_attachmentFilePath) && System.IO.File.Exists(_attachmentFilePath))
                    {
                        builder.Attachments.Add(_attachmentFilePath);
                    }

                    message.Body = builder.ToMessageBody();

                    using (var smtpClient = new MailKit.Net.Smtp.SmtpClient())
                    {
                        smtpClient.Connect("smtp.gmail.com", 465, SecureSocketOptions.SslOnConnect);
                        smtpClient.Authenticate(senderEmail, senderPassword);

                        smtpClient.Send(message);
                        smtpClient.Disconnect(true);
                    }

                    MessageBox.Show("Gửi email thành công!");


                    tb_to.Clear();
                    tb_subject.Clear();
                    tb_body.Clear();
                    tb_attachment.Clear();
                    _attachmentFilePath = "";
                }
                catch (MailKit.Security.AuthenticationException authEx)
                {
                    MessageBox.Show("Lỗi xác thực: Vui lòng kiểm tra lại Mật khẩu Ứng dụng (App Password) hoặc email.", "Lỗi Gửi Mail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi gửi email: " + ex.Message, "Lỗi Gửi Mail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}