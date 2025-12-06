using System.IO;
using System.Net;
using System.Security.AccessControl;
using System.Security.Policy;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Net.Mail;
using static Cau4.Cinema;

namespace Cau4
{
    public partial class Cinema : Form
    {
        WebClient webClient;
        WebRequest request;
        WebResponse response;
        Stream dataStream;
        StreamReader reader;
        SaveFileDialog saveFileDialog;
        string responseFromServer;
        int steps;
        int totalsteps = 1;
        List<Movie> currentlist = new List<Movie>();

        string mail = "5k1b1d12kar6@gmail.com";
        string AppPass = "scss kjto bxig pczp";

        private readonly Dictionary<int, string> url = new()
        {
            { 1, "https://www.cgv.vn/default/movies/now-showing.html" },
            { 2, "https://betacinemas.vn/phim.htm" }
        };
        public Cinema()
        {
            InitializeComponent();
            progressBarDD.Visible = false;
            progressBarDD.Value = 0;
            cbb_cinemaUrl.Items.AddRange(url.Values.ToArray());
            cbb_cinemaUrl.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbb_cinemaUrl.AutoCompleteSource = AutoCompleteSource.ListItems;
        }
        private List<Movie> movies = new List<Movie>();

        public class Movie()
        {
            public string Cinema { get; set; }
            public string Title { get; set; }
            public string genre { get; set; }
            public int? Duration { get; set; }
            public string Description { get; set; }
            public string DetailURL { get; set; }
            public string PosterURL { get; set; }
        }

        private string getHTML(string szURL)
        {
            try
            {
                webClient = new WebClient();
                webClient.Encoding = Encoding.UTF8;
                return webClient.DownloadString(szURL);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return string.Empty;
            }
        }

        List<Movie> parseCGV(string html)
        {
            progressBarDD.Value = 0;
            steps = 0;
            var list = new List<Movie>();
            var doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(html);
            var movieNodes = doc.DocumentNode.SelectNodes("//ul[contains(@class, 'products-grid')]//li[contains(@class, 'item')]");
            if (movieNodes == null)
            {
                return list;
            }
            totalsteps = movieNodes.Count;
            foreach (var movieNode in movieNodes)
            {
                var titleNode = movieNode.SelectSingleNode(".//h2[contains(@class, 'product-name')]/a");
                var titleLinkNode = movieNode.SelectSingleNode(".//h2[contains(@class, 'product-name')]/a");
                var posterNode = movieNode.SelectSingleNode(".//div[contains(@class, 'product-images')]//img");

                string title = titleNode?.InnerText?.Trim() ?? "";
                string titleLinkUrl = titleLinkNode?.GetAttributeValue("href", "") ?? "";
                string posterUrl = posterNode?.GetAttributeValue("src", "") ?? "";

                var movie = new Movie
                {
                    Cinema = "CGV",
                    Title = title,
                    DetailURL = titleLinkUrl,
                    PosterURL = posterUrl
                };

                list.Add(movie);
                steps++;
                progressBarDD.Value = (steps * 100) / totalsteps;
            }
            currentlist = list;
            return list;
        }

        List<Movie> parseBeta(string html)
        {
            progressBarDD.Value = 0;
            steps = 0;
            var list = new List<Movie>();
            var doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(html);
            var movieNodes = doc.DocumentNode.SelectNodes("//div[contains(@class, 'padding-bottom-30')]/div[@class='row']");
            if (movieNodes == null)
            {
                return list;
            }
            totalsteps = movieNodes.Count;
            foreach (var movieNode in movieNodes)
            {
                var titleNode = movieNode.SelectSingleNode(".//div[contains(@class, 'film-info')]//h3/a");
                var posterNode = movieNode.SelectSingleNode(".//div[contains(@class, 'product-item')]//img");

                string title = titleNode != null
             ? HtmlAgilityPack.HtmlEntity.DeEntitize(titleNode.InnerText).Trim()
             : "";
                string rawUrl = titleNode?.GetAttributeValue("href", "") ?? "";
                string posterUrl = posterNode?.GetAttributeValue("src", "") ?? "";

                string fullUrl = rawUrl;
                if (!string.IsNullOrEmpty(rawUrl) && rawUrl.StartsWith("/"))
                {
                    fullUrl = "https://www.betacinemas.vn" + rawUrl;
                }

                var movie = new Movie
                {
                    Cinema = "Beta",
                    Title = title,
                    DetailURL = fullUrl,
                    PosterURL = posterUrl
                };
                list.Add(movie);
                steps++;
                progressBarDD.Value = (steps * 100) / totalsteps;

            }
            currentlist = list;
            return list;
        }

        void SaveMovieToJson(List<Movie> movies, string filepath)
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
                Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping
            };
            string json = JsonSerializer.Serialize(movies, options);
            File.WriteAllText(filepath, json, Encoding.UTF8);
        }

        private void btn_downdata_Click(object sender, EventArgs e)
        {
            progressBarDD.Value = 0;
            progressBarDD.Visible = true;
            if (string.IsNullOrEmpty(cbb_cinemaUrl.Text))
            {
                MessageBox.Show("Vui lòng chọn URL rạp chiếu phim", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                progressBarDD.Visible = false;
                return;
            }
            try
            {
                getHTML(cbb_cinemaUrl.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi truy cập URL: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                progressBarDD.Visible = false;
                return;
            }
            var allMovies = new List<Movie>();

            // Site 1: CGV
            if (url.TryGetValue(1, out string cgvUrl))
            {
                string cgvHtml = getHTML(cgvUrl);
                allMovies.AddRange(parseCGV(cgvHtml));
            }

            // Site 2: Beta
            if (url.TryGetValue(2, out string betaUrl))
            {
                string betaHtml = getHTML(betaUrl);
                allMovies.AddRange(parseBeta(betaHtml));
            }
            string jsonPath = Path.Combine(Application.StartupPath, "movies.json");
            SaveMovieToJson(allMovies, jsonPath);

            MessageBox.Show($"Đã lưu {allMovies.Count} phim vào {jsonPath}");
            progressBarDD.Visible = false;
            GetJSONFile();
        }

        private void btn_mvnowshwing_Click(object sender, EventArgs e)
        {
            if (currentlist.Count > 0)
            {
                new MovieNowShowing(currentlist).Show();
            }
            else
            {
                MessageBox.Show("Không thể truy xuất dữ liệu phòng vé", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void GetJSONFile()
        {
            string jsonPath = Path.Combine(Application.StartupPath, "movies.json");

            if (!File.Exists(jsonPath))
            {
                MessageBox.Show("Không tìm thấy file movies.json", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                movies = new List<Movie>();
                return;
            }

            try
            {
                string json = File.ReadAllText(jsonPath);

                movies = JsonSerializer.Deserialize<List<Movie>>(json) ?? new List<Movie>();

                cbb_movieSelection.DataSource = null;
                cbb_movieSelection.DataSource = movies;
                cbb_movieSelection.DisplayMember = "Title";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi đọc JSON: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                movies = new List<Movie>();
            }
        }

        private void btn_bookticket_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> selectedSeats = new List<string>();
                foreach (Control control in this.Controls)
                {
                    if (control is CheckBox cb && cb.Checked && cb.Name.StartsWith("cb_"))
                    {
                        IsValidSeat(cb.Name.Substring(3));
                        selectedSeats.Add(cb.Name.Substring(3));
                    }
                }

                if (!string.IsNullOrWhiteSpace(tb_name.Text) && !string.IsNullOrWhiteSpace(tb_phone.Text) && tb_email != null && selectedSeats.Count != 0)
                {
                    MailSender(selectedSeats);
                    MessageBox.Show("Đặt vé thành công! Vui lòng kiểm tra email để xác nhận.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private bool IsValidSeat(string seat)
        {
            string[] validSeats = { "A1", "A2", "A3", "A4", "A5", "B1", "B2", "B3", "B4", "B5", "C1", "C2", "C3", "C4", "C5" };
            return validSeats.Contains(seat);
        }

        private string GetPosterUrl(string movieTitle)
        {
            if (movies == null || string.IsNullOrEmpty(movieTitle)) return "";

            var movie = movies.FirstOrDefault(m => m.Title.Equals(movieTitle, StringComparison.OrdinalIgnoreCase));

            return movie != null ? movie.PosterURL : "https://via.placeholder.com/200x300?text=No+Image";
        }

        private void MailSender(List<string> seats)
        {
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
            string MailFrom = mail;
            string AppPassword = AppPass;
            string MailTo = tb_email.Text;

            var basicCredential = new NetworkCredential(MailFrom, AppPassword);

            MailMessage message = new MailMessage();
            MailAddress fromAddress = new MailAddress(MailFrom, "Cinema Booking Sytsem");
            smtpClient.EnableSsl = true;
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Credentials = basicCredential;
            message.From = fromAddress;
            message.To.Add(MailTo);
            message.Subject = "Xác Nhận Đặt Vé -- Cinema Web Service";
            message.IsBodyHtml = true;

            string movieName = cbb_movieSelection.Text;
            string posterLink = GetPosterUrl(movieName);
            string seatString = string.Join(", ", seats);

            string htmlContent = $@"
                <html>
                <body style='font-family: Arial, sans-serif;'>
                    <div style='border: 1px solid #ddd; padding: 20px; max-width: 600px; border-radius: 10px;'>
                        <h2 style='color: #E50914;'>Đặt Vé Thành Công!</h2>
                        <p>Xin chào <b>{tb_name.Text}</b>,</p>
                        <p>Bạn đã đặt vé cho bộ phim: <b style='font-size: 16px;'>{movieName}</b></p>
                        
                        <table style='width: 100%; margin-top: 15px;'>
                            <tr>
                                <td style='width: 150px; vertical-align: top;'>
                                    <img src='{posterLink}' alt='Poster' width='140' style='border-radius: 5px; box-shadow: 2px 2px 5px #ccc;' />
                                </td>
                                <td style='vertical-align: top; padding-left: 15px;'>
                                    <p><b>Số điện thoại:</b> {tb_phone.Text}</p>
                                    <p><b>Ghế đã chọn:</b> <span style='background-color: #f1f1f1; padding: 3px 8px; border-radius: 4px;'>{seatString}</span></p>
                                    <p><b>Tổng số ghế:</b> {seats.Count}</p>
                                    <p style='color: green; font-weight: bold;'>Trạng thái: Đã xác nhận</p>
                                </td>
                            </tr>
                        </table>

                        <hr style='border: 0; border-top: 1px solid #eee; margin: 20px 0;'>
                        <p style='font-size: 12px; color: #777;'>Cảm ơn bạn đã sử dụng dịch vụ của chúng tôi.</p>
                    </div>
                </body>
                </html>";

            message.Body = htmlContent;

            smtpClient.Send(message);
        }
    }
}
