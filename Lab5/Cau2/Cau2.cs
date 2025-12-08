using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Security.Authentication;
using System.Text;
using MailKit.Net.Imap;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cau2
{
    public partial class Cau2 : Form
    {
        public Cau2()
        {
            InitializeComponent();
        }

        private void Cau2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string email = textBox1.Text; 
            string password = textBox2.Text; 
            string server = "imap.gmail.com"; 
            int port = 993; 
            try { 
                using (var client = new ImapClient()) 
                { 
                    client.Connect(server, port, true); 
                    client.Authenticate(email, password);
                    var inbox = client.Inbox; inbox.Open(MailKit.FolderAccess.ReadOnly); 
                    label_totalvalue.Text = $"Total: {inbox.Count}"; 
                    label_recentvalue.Text = $"Recent: {inbox.Recent}"; 
                    int limit = Math.Min(inbox.Count, 10); 
                    for (int i = 0; i < limit; i++) 
                    { 
                        var message = inbox.GetMessage(inbox.Count - 1 - i); 
                        var item = new ListViewItem(message.Subject); 
                        item.SubItems.Add(message.From.ToString()); 
                        item.SubItems.Add(message.Date.ToString("dd/MM/yyyy HH:mm:ss")); 
                        listView1.Items.Add(item); } client.Disconnect(true); 
                } 
            } 
            catch (AuthenticationException) 
            { 
                MessageBox.Show("Đăng nhập thất bại"); 
            } 
            catch (Exception ex) 
            { 
                MessageBox.Show("Email hoặc Password sai."); 
            }
        }
    }
}
