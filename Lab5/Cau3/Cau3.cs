using System.Net.Mail;
using System;
using MailKit.Net.Imap;
using MailKit;
using Org.BouncyCastle.Utilities.IO;
using MailKit.Net.Pop3;

namespace Bai1
{
    public partial class Cau3 : Form
    {
        ImapClient imapClient = new ImapClient();
        Pop3Client pop3Client = new Pop3Client();
        string server = "imap.gmail.com";
        public Cau3()
        {
            InitializeComponent();
            lv_showemail.View = View.Details;
            lv_showemail.FullRowSelect = true;
            lv_showemail.GridLines = true;
            cbb_selectprotocol.SelectedItem = 1;

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            lv_showemail.Items.Clear();
            lv_showemail.Columns.Clear();
            if (lv_showemail.Items.Count == 0)
            {
                lv_showemail.Columns.Add("Email", 300);
                lv_showemail.Columns.Add("From", 250);
                lv_showemail.Columns.Add("Date", 200);
            }

            if (cbb_selectprotocol.SelectedItem.ToString() == "IMAP")
            {
                ImapLogin();
            }
            else if (cbb_selectprotocol.SelectedItem.ToString() == "POP3")
            {
                POPLogin();
            }


        }

        private void lv_showemail_DoubleClick(object sender, EventArgs e)
        {
            if (cbb_selectprotocol.SelectedItem.ToString() == "IMAP")
            {
                ImapReading();
            }
            else if (cbb_selectprotocol.SelectedItem.ToString() == "POP3")
            {
                POPReading();
            }
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

        public void POPReading()
        {
            int listViewIndex = lv_showemail.SelectedIndices[0];
            int serverIndex = (pop3Client.Count - 1) - listViewIndex;
            var message = pop3Client.GetMessage(serverIndex);
            MessageBox.Show("Subject: " + message.Subject + "\nFrom: " + message.From + "\nDate: " + message.Date + "\n\n" + message.TextBody);
        }

        private void ImapLogin()
        {
            try
            {
                imapClient.Connect(server, 993, true);
                imapClient.Authenticate(tb_email.Text, tb_password.Text);
                MessageBox.Show("Login successful!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Login failed: " + ex.Message);
            }

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

        private void POPLogin()
        {
            try
            {
                pop3Client.Connect("pop.gmail.com", 995, true);
                pop3Client.Authenticate(tb_email.Text, tb_password.Text);
                MessageBox.Show("Login successful!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Login failed: " + ex.Message);
            }
            if (pop3Client.IsAuthenticated == false)
            {
                return;
            }
            int total = pop3Client.Count;
            int limit = 20;
            for (int i = total - 1; i >= 0 && i >= total - limit; i--)
            {
                var message = pop3Client.GetMessage(i);
                ListViewItem item = new ListViewItem(message.Subject);
                item.SubItems.Add(message.From.ToString());
                item.SubItems.Add(message.Date.ToString());
                lv_showemail.Items.Add(item);
            }
            MessageBox.Show("Fetched " + limit + " emails.");
        }
    }
}
