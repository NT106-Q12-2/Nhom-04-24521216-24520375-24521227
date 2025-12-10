using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
namespace Cau6
{
    public partial class Cau6 : Form
    {
        public Cau6()
        {
            InitializeComponent();
        }

        private async void btn_login_Click(object sender, EventArgs e)
        {
            var Url = "https://nt106.uitiot.vn/auth/token";
            var username = tb_username.Text;
            var password = tb_password.Text;
            string tokenType = string.Empty;
            string accessToken = string.Empty;

            // Khởi tạo HttpClient và xử lý đăng nhập
            using (var client = new HttpClient())
            {
                try
                {
                    var content = new MultipartFormDataContent// Tạo nội dung yêu cầu dưới dạng 'multipartformdata'.
            {
                { new StringContent(username), "username" },
                { new StringContent(password), "password" }
            };

                    var response = await client.PostAsync(Url, content);
                    var responseString = await response.Content.ReadAsStringAsync();//gửi yêu cầu POST bất đồng bộ tới API token và chờ phản hồi
                    var responseObject = JObject.Parse(responseString);//phân tích chuỗi JSON

                    if (response.IsSuccessStatusCode)
                    {

                        tokenType = responseObject["token_type"].ToString();
                        accessToken = responseObject["access_token"].ToString();

                        rtb_result.Text = $"{tokenType} {accessToken}\r\nĐăng nhập thành công\r\n\r\n";

                        client.DefaultRequestHeaders.Authorization = new
                            System.Net.Http.Headers.AuthenticationHeaderValue(tokenType, accessToken);

                        var getUserUrl = "https://nt106.uitiot.vn/api/v1/user/me";
                        var getUserResponse = await client.GetAsync(getUserUrl);
                        var getUserResponseString = await getUserResponse.Content.ReadAsStringAsync();

                        if (getUserResponse.IsSuccessStatusCode)
                        {
                            var userObject = JObject.Parse(getUserResponseString);

                            
                            var userId = userObject["id"]?.ToString();
                            var userEmail = userObject["email"]?.ToString();
                            var isActive = userObject["is_active"]?.ToString();

                            rtb_result.AppendText("--- Thông tin người dùng ---\r\n");
                            rtb_result.AppendText($"ID: {userId}\r\n");
                            rtb_result.AppendText($"Email: {userEmail}\r\n");
                            rtb_result.AppendText($"Active: {isActive}\r\n");
                            rtb_result.AppendText($"JSON chi tiết: {getUserResponseString}");
                        }
                        else
                        {
                            rtb_result.AppendText($"\r\nLỗi lấy thông tin user: {getUserResponse.StatusCode}\r\n");
                            rtb_result.AppendText($"Detail: {getUserResponseString}");
                        }
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
