using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;
using System.Reflection.Metadata;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace Cau5
{
    public partial class Cau5 : Form
    {
        public Cau5()
        {
            InitializeComponent();
        }

        private async void btn_login_Click(object sender, EventArgs e)
        {
            var url = "https://nt106.uitiot.vn/auth/token";
            var username = tb_username.Text; 
            var password = tb_password.Text; 

            using (var client = new HttpClient())
            {
                try
                {

                    var content = new MultipartFormDataContent
            {
                { new StringContent(username), "username" },
                { new StringContent(password), "password" }
            };

                    var response = await client.PostAsync(url, content);

                    var responseString = await response.Content.ReadAsStringAsync();

                    var responseObject = JObject.Parse(responseString);

                    if (response.IsSuccessStatusCode)
                    {

                        var tokenType = responseObject["token_type"].ToString();
                        var accessToken = responseObject["access_token"].ToString();

                        rtb_result.Text = $"{tokenType} {accessToken}\r\nĐăng nhập thành công"; 
                    }
                    else
                    {

                        var detail = responseObject["detail"].ToString();
                        rtb_result.Text = $"Đăng nhập không thành công.\r\nDetail: {detail}";
                    }
                }
                catch (Exception ex)
                {
                    rtb_result.Text = $"Lỗi: {ex.Message}";
                }
            }
        }
    }
}
