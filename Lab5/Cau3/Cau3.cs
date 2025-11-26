using System.Net.Mail;
using System;
using MailKit.Net.Imap;
using MailKit;
using Org.BouncyCastle.Utilities.IO;

namespace Bai1
{
    public partial class Cau3 : Form
    {
        ImapClient client = new ImapClient();
        string server = "imap.gmail.com";
        public Cau3()
        {
            InitializeComponent();
            lv_showemail.View = View.Details;
            lv_showemail.FullRowSelect = true;
            lv_showemail.GridLines = true;
            
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                client.Connect(server, 993, true);
                client.Authenticate(tb_email.Text, tb_password.Text);
                MessageBox.Show("Login successful!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Login failed: " + ex.Message);
            }

            lv_showemail.Items.Clear();
            if (lv_showemail.Items.Count == 0)
            {
                lv_showemail.Columns.Add("Email", 300);
                lv_showemail.Columns.Add("From", 250);
                lv_showemail.Columns.Add("Date", 200);
            }
            if (client.IsAuthenticated == false)
            {
                return;
            }
            var inbox = client.Inbox;
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
            client.Disconnect(true);
            MessageBox.Show("Fetched " + limit + " emails.");
        }

        private void lv_showemail_DoubleClick(object sender, EventArgs e)
        {
            if (client.IsAuthenticated == false)
            {
                try
                {
                    client.Connect(server, 993, true);
                    client.Authenticate(tb_email.Text, tb_password.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    return;
                }
            }
            else
            {
                var inbox = client.Inbox;
                int listViewIndex = lv_showemail.SelectedIndices[0];
                int serverIndex = (inbox.Count - 1) - listViewIndex;
                inbox.Open(MailKit.FolderAccess.ReadOnly);
                var message = inbox.GetMessage(serverIndex);
                MessageBox.Show("Subject: " + message.Subject + "\nFrom: " + message.From + "\nDate: " + message.Date + "\n\n" + message.TextBody);
            }    
        }
    }
}
