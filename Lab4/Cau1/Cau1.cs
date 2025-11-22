using System.Net;

namespace Lab4
{
    public partial class Cau1 : Form
    {
        public Cau1()
        {
            InitializeComponent();
        }

        private void btn_get_Click(object sender, EventArgs e)
        {
            getHTML(tb_webURL.Text);
        }

        private string getHTML(string szURL)
        {
            try
            {
                WebRequest request = WebRequest.Create(szURL);
                WebResponse response = request.GetResponse();
                Stream dataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);
                string responseFromServer = reader.ReadToEnd();
                rtb_showHTML.Text = responseFromServer;
                response.Close();
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
