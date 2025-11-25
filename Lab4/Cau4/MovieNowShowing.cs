using Microsoft.Web.WebView2.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cau4
{
    public partial class MovieNowShowing : Form
    {
        ImageList imgList = new ImageList();
        List<Cinema.Movie> movies;
        public MovieNowShowing(List<Cinema.Movie> list)
        {
            InitializeComponent();
            this.movies = list;
            MovieShowing.Clear();
            ShowingMovie(movies);
            this.MovieShowing.MouseClick += MovieNowShowing_MouseClick;

        }

        public void ShowingMovie(List<Cinema.Movie> Movies)
        {
            imgList.Images.Clear();
            imgList.ImageSize = new Size(90, 120);
            imgList.ColorDepth = ColorDepth.Depth32Bit;

            MovieShowing.Items.Clear();
            MovieShowing.View = View.Details;
            MovieShowing.GridLines = true;
            MovieShowing.FullRowSelect = true;


            if (MovieShowing.Columns.Count == 0)
            {
                MovieShowing.Columns.Clear();
                MovieShowing.Columns.Add("Ảnh & Tên Phim", 400);
                MovieShowing.Columns.Add("Đường dẫn", Width);
            }

            int imgIndex = 0;
            WebClient webClient = new WebClient();
            foreach (var movie in Movies)
            {
                Image poster = null;
                try
                {
                    byte[] bytes = webClient.DownloadData(movie.PosterURL);
                    using (MemoryStream ms = new MemoryStream(bytes))
                    {
                        poster = Image.FromStream(ms);
                    }

                }
                catch
                {
                    poster = new Bitmap(100, 150);
                }
                imgList.Images.Add(poster);

                ListViewItem item = new ListViewItem();
                item.Text = movie.Title;
                item.ImageIndex = imgIndex;

                item.SubItems.Add(movie.DetailURL);

                item.Tag = movie;

                MovieShowing.Items.Add(item);
                imgIndex++;
            }
            MovieShowing.SmallImageList = imgList;
        }

        private void MovieNowShowing_MouseClick(object sender, MouseEventArgs e)
        {
            string url = MovieShowing.SelectedItems[0].SubItems[1].Text;
            new WebMovie(url).Show();
        }
    }
}
