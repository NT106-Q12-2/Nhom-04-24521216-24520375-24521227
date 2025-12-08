using System;
using System.Windows.Forms;
using System.Net.Mail;
using MailKit.Net.Imap;

namespace Cau6
{
    public partial class MailClient : Form
    {
        SmtpClient smtpClient = new SmtpClient();
        ImapClient imapClient = new ImapClient();

        public MailClient()
        {
            InitializeComponent();
            btn_refresh.Enabled = false;
            btn_signout.Enabled = false;
            btn_sendmail.Enabled = false;
            tb_password.UseSystemPasswordChar = true;
            lv_showemail.Columns.Clear();
            if (lv_showemail.Items.Count == 0)
            {
                lv_showemail.Columns.Add("Email", 300);
                lv_showemail.Columns.Add("From", 250);
                lv_showemail.Columns.Add("Date", 200);
            }
        }


        private void btn_signin_Click(object sender, EventArgs e)
        {
            try
            {
                var basicCredential = new System.Net.NetworkCredential(tb_email.Text, tb_password.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Username or password is Incorrect" + ex);
            }
            if (tb_email.Text == "" || tb_password.Text == "")
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin");
                return;
            }
            lv_showemail.Items.Clear();
            try
            {
                ImapLogin();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Login failed: " + ex.Message);
                return;
            }
            LoadEmail();
            btn_refresh.Enabled = true;
            btn_signout.Enabled = true;
            btn_sendmail.Enabled = true;
            btn_signin.Enabled = false;
        }

        public void ImapReading()
        {
            var inbox = imapClient.Inbox;
            int listViewIndex = lv_showemail.SelectedIndices[0];
            int serverIndex = (inbox.Count - 1) - listViewIndex;
            inbox.Open(MailKit.FolderAccess.ReadOnly);
            var message = inbox.GetMessage(serverIndex);
            MessageBox.Show("Subject: " + message.Subject + "\nFrom: " + message.From + "\nDate: " + message.Date + "\n\n" + message.TextBody);
        }

        private void ImapLogin()
        {
            try
            {
                imapClient.Connect(tb_imaphost.Text, (int)numUD_imapport.Value, true);
                imapClient.Authenticate(tb_email.Text, tb_password.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Login failed: " + ex.Message);
            }
        }

        private void LoadEmail()
        {
            if (imapClient.IsAuthenticated == false)
            {
                return;
            }
            var inbox = imapClient.Inbox;
            inbox.Open(MailKit.FolderAccess.ReadOnly);
            int total = inbox.Count;
            int limit = 20;
            for (int i = total - 1; i >= 0 && i >= total - limit; i--)
            {
                var message = inbox.GetMessage(i);
                ListViewItem item = new ListViewItem(message.Subject);
                item.SubItems.Add(message.From.ToString());
                item.SubItems.Add(message.Date.ToString());
                lv_showemail.Items.Add(item);
            }
            MessageBox.Show("Fetched " + limit + " emails.");
        }

        private void lv_showemail_DoubleClick(object sender, EventArgs e)
        {
            ImapReading();
        }

        private void btn_signout_Click(object sender, EventArgs e)
        {
            imapClient.Disconnect(true);
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            try
            {
                lv_showemail.Items.Clear();
                lv_showemail.Columns.Clear();
                if (lv_showemail.Items.Count == 0)
                {
                    lv_showemail.Columns.Add("Email", 300);
                    lv_showemail.Columns.Add("From", 250);
                    lv_showemail.Columns.Add("Date", 200);
                }
                if (imapClient.IsAuthenticated == false)
                {
                    return;
                }
                LoadEmail();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Refresh failed: " + ex.Message);
            }
        }

        private void btn_sendmail_Click(object sender, EventArgs e)
        {
            SendMail sendmail = new SendMail(tb_email.Text.Trim(), tb_password.Text.Trim());
            this.Hide();
            sendmail.ShowDialog();
            this.Show();
        }
    }
}
