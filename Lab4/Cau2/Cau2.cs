using System.Net;

namespace Cau2
{
    public partial class Cau2 : Form
    {
        public Cau2()
        {
            InitializeComponent();
        }

        private void btn_download_Click(object sender, EventArgs e)
        {
            getHTML(tb_url.Text);
        }

        private string getHTML(string szURL)
        {
            try
            {
                WebClient webClient = new WebClient();
                WebRequest request = WebRequest.Create(szURL);
                WebResponse response = request.GetResponse();
                Stream dataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                string responseFromServer = reader.ReadToEnd();
                rtb_showhtml.Text = responseFromServer;
                saveFileDialog.Filter = "All files (*.*)|*.*";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;
                    tb_filepath.Text = filePath;
                    webClient.DownloadFile(szURL, filePath);
                }
                return responseFromServer;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return string.Empty;
            }
        }
    }
}
