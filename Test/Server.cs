using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Net.Sockets;
using System.Net;
using System.IO;

namespace NT106_Test
{
    public partial class Server : Form
    {
        Dictionary<char, List<string>> ListMonAn = new Dictionary<char, List<string>>();
        public Server()
        {
            InitializeComponent();
            string path = "Menu.txt";
            if (!File.Exists(path)){
                MessageBox.Show("Khong tim thay Menu");
            }
            else
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    while (sr.Peek() >= 0)
                    {
                        string line = sr.ReadLine();
                        //MessageBox.Show(line + "    length: " + line.Length);
                        string monan = "", price = "";
                        char id = ' ';
                        int idx = 0;
                        while (line[idx] != ';')
                        {
                            id += line[idx];
                            idx++;
                        }
                        idx++;
                        while (line[idx] != ';')
                        {
                            monan += line[idx];
                            idx++;
                        }
                        idx++;
                        while (idx<=line.Length-1)
                        {
                            price += line[idx];
                            idx++;
                        }
                        //MessageBox.Show("ID: " + id + ", Name : " + monan+"Price:"+price);
                        List<string> list = new List<string>();
                        list.Add(monan);
                        list.Add(price); 
                        ListMonAn.Add(id, list);
                    }
                }
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void Event(string request)
        {
            //if (this.listView1.InvokeRequired)
            //{
            //    this.listView1.BeginInvoke(new Action<string>(InfoMessage), message);
            //    return;
            //}
            //ListViewItem item = new ListViewItem(message);
            //listView1.Items.Add(item);
            //if (listView1.Items.Count > 0)
            //{
            //    listView1.EnsureVisible(listView1.Items.Count - 1);
            //}
            if(request.Contains("ORDER"))
            {
                char so_ban = request[6], id_mon = request[8], so_luong = request[10];
                string name = ListMonAn[id][0];
                int total = ListMonAn[id][1] * (so_luong - '0');
                listView1.Columns.Add(so_ban, name, so_luong, total);
            }
            else if(request.Contains("MENU"))
            {

            }
        }
        void StartUnsafeThread()
        {
            int bytesReceived = 0;
            byte[] recv = new byte[1024];
            Socket clientSocket;
            Socket listenerSocket;
            listenerSocket = new Socket(
                AddressFamily.InterNetwork,
                SocketType.Stream,
                ProtocolType.Tcp
            );
            IPEndPoint ipepServer = new IPEndPoint(IPAddress.Any, 8888);
            listenerSocket.Bind(ipepServer);
            listenerSocket.Listen(-1);
            clientSocket = listenerSocket.Accept();
            while (clientSocket.Connected)
            {
                string receivedText = "";
                int bytesRead;
                do
                {
                    bytesRead = clientSocket.Receive(recv);
                    receivedText += Encoding.UTF8.GetString(recv, 0, bytesRead);    // xử lí Tiếng Việt
                } while (bytesRead > 0 && !receivedText.EndsWith("\n"));
                if (bytesRead > 0)
                {
                    string request = receivedText.TrimEnd('\r', '\n');
                    Event(request);
                }
                else
                {
                    break;
                }
            }

            // 4. Đóng Socket Client
            clientSocket.Close();
            listenerSocket.Close();
        }

        private void btn_startserver_Click(object sender, EventArgs e)
        {
            Thread server_thread = new Thread(new ThreadStart(StartUnsafeThread));
            server_thread.IsBackground = true;
            server_thread.Start();
            label_status.Text = "Status Listening on port 8888";
            btn_startserver.Enabled = false;
        }

        private void label_status_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_charge_Click(object sender, EventArgs e)
        {

        }
    }
}
