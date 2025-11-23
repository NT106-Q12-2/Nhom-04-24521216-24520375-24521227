using System.Net;
using System.IO;
using System.Security.Policy;

namespace Cau3
{
    public partial class Cau3 : Form
    {
        WebClient webClient;
        WebRequest request;
        WebResponse response;
        Stream dataStream;
        StreamReader reader;
        SaveFileDialog saveFileDialog;
        string responseFromServer;
        public Cau3()
        {
            InitializeComponent();
            btn_reload.Enabled = false;
            btn_downfile.Enabled = false;
            btn_downresources.Enabled = false;
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            checkURL(tb_url.Text);
            webClient = new WebClient();
            request = WebRequest.Create(tb_url.Text);
            response = request.GetResponse();
            wbvw2_shweb.Source = new Uri(tb_url.Text);
            dataStream = response.GetResponseStream();
            reader = new StreamReader(dataStream);
            btn_reload.Enabled = true;
            btn_downfile.Enabled = true;
            btn_downresources.Enabled = true;
        }


        private string getHTML(string szURL)
        {
            try
            {
                saveFileDialog = new SaveFileDialog();
                responseFromServer = reader.ReadToEnd();
                saveFileDialog.Filter = "All files (*.*)|*.*";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    if (saveFileDialog.FileName == null)
                    {
                        MessageBox.Show("Invalid file path.");
                        return string.Empty;
                    }
                    else
                    {
                        string filePath = saveFileDialog.FileName;
                        webClient.DownloadFile(szURL, filePath);
                    }
                }
                return responseFromServer;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return string.Empty;
            }
        }

        private void btn_reload_Click(object sender, EventArgs e)
        {
            btn_load_Click(sender, e);
        }

        private void checkURL(string inurl)
        {
            string url = tb_url.Text.Trim();
            if (!url.StartsWith("http://") && !url.StartsWith("https://"))
            {
                url = "https://" + url;
            }
            tb_url.Text = url;
        }

        private void btn_downfile_Click(object sender, EventArgs e)
        {
            getHTML(tb_url.Text);
            new ShowHTML(responseFromServer).Show();
        }

        private void btn_downresources_Click(object sender, EventArgs e)
        {
            Uri baseUri = new Uri(tb_url.Text);
            int index = 0;
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.ShowDialog();
            string filepath = folderBrowserDialog.SelectedPath;
            responseFromServer = reader.ReadToEnd();
            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(responseFromServer);
            doc.DocumentNode.SelectNodes("//img[@src]").ToList();
            var imgNodes = doc.DocumentNode.SelectNodes("//img[@src]");
            if (imgNodes == null)
            {
                MessageBox.Show("No images found.");
                return;
            }   
            foreach (var img in imgNodes)
            {
                string imgUrl = img.GetAttributeValue("src", "");
                Uri imgUri = new Uri(baseUri, imgUrl);
                string localPath = imgUri.LocalPath;
                string filename = Path.GetFileName(imgUrl);
                filename = "image_" + (index++);
                string extension = Path.GetExtension(localPath);
                if (!string.IsNullOrEmpty(extension))
                {
                    filename += extension;
                }
                else
                {
                    filename += ".jpg";
                }
                string savepath = Path.Combine(filepath, filename);
                if (!string.IsNullOrEmpty(imgUrl))
                {
                    webClient.DownloadFile(imgUri, savepath);
                }
            }
        }
    }
}
