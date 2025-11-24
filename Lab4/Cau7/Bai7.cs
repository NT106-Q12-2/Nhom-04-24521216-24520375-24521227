using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cau7;
namespace Cau7
{
    public partial class Bai7 : Form
    {
        public Bai7()
        {
            InitializeComponent();
            btn_addfood.Enabled = false;
            textbox_status.Text = "Unauthencated";
        }

        private void Bai7_Load(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void textbox_status_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel_signin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormSignUp_Bai7 formsignup = new FormSignUp_Bai7();
            formsignup.Show();
        }
        private void UpdateEvents()
        {
            if(SessionManager_Bai7.IsLoggedIn)      // nếu đang đăng nhập 
            {
                textbox_status.Text = "Logging in as " + SessionManager_Bai7.CurrentUsername;
                linkLabel_login.Text = "Logout";
                linkLabel_signup.Visible = false;
                btn_addfood.Enabled = true;
            }
            else
            {
                linkLabel_signup.Visible = true;
                btn_addfood.Enabled = false;
                textbox_status.Text = "Unauthencated";
                linkLabel_login.Text = "Login";
            }
        }
        private void linkLabel_login_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)        // login va logout
        {
            if (SessionManager_Bai7.IsLoggedIn)
            {
                SessionManager_Bai7.Logout();
                MessageBox.Show("Đã đăng xuất thành công.");
                tabPage2.Controls.Clear();
                UpdateEvents();
            }
            else
            {
                using(FormLogin_Bai7 formlogin = new FormLogin_Bai7())
                {
                    if (formlogin.ShowDialog() == DialogResult.OK)
                    {
                        UpdateEvents();
                        LoadDishes();
                    }
                }
            }
        }
        private void LoadDishes()   // hàm load dishes dùng để load các món ăn khi log in 1 phiên
        {
            IEnumerable<Dish> allDishes = SessionManager_Bai7.list_monan;
            int currentUserId = SessionManager_Bai7.CurrentUserId;
            List<Dish> listAll = allDishes.ToList();
            List<Dish> listMyContribution = allDishes
                .Where(d => d.ContributorId == currentUserId && currentUserId > 0)
                .ToList();
            DisplayDishesOnTab(tabPage1, listAll);
            DisplayDishesOnTab(tabPage2, listMyContribution);
        }
        private void DisplayDishesOnTab(TabPage targetTabPage, List<Dish> dishesToDisplay)
        {
            targetTabPage.Controls.Clear();
            int yPos = 5; 
            int spacing = 10;

            foreach (var dish in dishesToDisplay)
            {
                MonAn itemControl = new MonAn();
                itemControl.SetDishData(dish, GetUsernameById(dish.ContributorId, dishesToDisplay));

                itemControl.Location = new Point(0, yPos);
                itemControl.Width = targetTabPage.Width - 20;

                targetTabPage.Controls.Add(itemControl);
                yPos += itemControl.Height + spacing; 
            }
            targetTabPage.AutoScroll = true;
        }
        private string GetUsernameById(int id, List<Dish> dishesToDisplay)
        {
            if (id == SessionManager_Bai7.CurrentUserId)
            {
                return SessionManager_Bai7.CurrentUsername;
            }

            // Giả sử User class có thuộc tính Id và Username
            var user = dishesToDisplay.FirstOrDefault(u => u.ContributorId == id);

            if (user != null)
            {
                return user.ContributorName;
            }
            return "Unknown Contributor";
        }
        private void btn_addfood_Click(object sender, EventArgs e)
        {
            // Không check đã log in hay không vì không log in thì btn_addfood.Enabled = false
            using (FormThemMonAn_Bai7 formthemmonan = new FormThemMonAn_Bai7())
            {
                if (formthemmonan.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("Món ăn đã được thêm thành công!");
                    LoadDishes();
                }
            }
        }

        private void btn_takefood_Click(object sender, EventArgs e) // chon random food
        {
            List<Dish> monanAll = SessionManager_Bai7.list_monan;
            List<Dish> dishesToRandomize = new List<Dish>();
            if (this.tabControl_allfood.SelectedTab == tabPage2)      // tab "Tôi đóng góp"
            {
                int currentid = SessionManager_Bai7.CurrentUserId;
                if (currentid > 0)
                {
                    dishesToRandomize = monanAll.Where(d => d.ContributorId == currentid).ToList();
                }
            }
            else
            {
                dishesToRandomize = monanAll; // tabPage1
            }
            if (dishesToRandomize.Count == 0)
            {
                string tabName = this.tabControl_allfood.SelectedTab.Text;
                MessageBox.Show("Hiện không có món ăn nào trong tab '{tabName}'.");
                return;
            }
            int list_len = dishesToRandomize.Count;
            Random random_num = new Random();
            int idx = random_num.Next(list_len);
            Dish finaldish = dishesToRandomize[idx];
            string contributorName = GetUsernameById(finaldish.ContributorId, dishesToRandomize);
            MonAn monan = new MonAn();
            monan.SetDishData(finaldish, contributorName);
            // set option show mon an
            int controlWidth = 480;
            int controlHeight = 150;
            monan.Width = controlWidth;
            monan.Height = controlHeight;
            Form randomDishForm = new Form();
            randomDishForm.Text = $"Món Ăn Ngẫu Nhiên của {finaldish.ContributorName}: " + finaldish.Name;
            randomDishForm.ClientSize = new Size(controlWidth + 20, controlHeight + 20);
            randomDishForm.FormBorderStyle = FormBorderStyle.FixedSingle;
            randomDishForm.Controls.Add(monan);
            monan.Location = new Point(10, 10); // Đặt vị trí để tạo lề
            // Show form
            randomDishForm.ShowDialog();

        }
    }
}
