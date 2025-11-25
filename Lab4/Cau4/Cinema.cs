using System.IO;
using System.Net;
using System.Security.AccessControl;
using System.Security.Policy;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;
using System.Xml.Linq;
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
            getHTML(cbb_cinemaUrl.Text);
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
                if (tb_name != null && tb_phone != null)
                {
                    MessageBox.Show("Bạn đã đặt vé thành công của phim " + cbb_movieSelection.Text + " cho khách hàng tên " + tb_name.Text + " có số điện thoại là " + tb_phone.Text + ".", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }    
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
