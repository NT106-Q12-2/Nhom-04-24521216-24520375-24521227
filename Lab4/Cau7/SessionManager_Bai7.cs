using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cau7
{
    public class Dish
    {
        public int DishId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
        public string Url { get; set; }
        public string Address { get; set; }
        public int ContributorId { get; set; }
        public string ContributorName { get; set; }
    }
    public partial class SessionManager_Bai7 : Form
    {
        public static List<Dish> list_monan = new List<Dish>();
        private static int nextDishId = 1;
        public static int CurrentUserId { get; private set; } = 0;
        public static string CurrentUsername { get; private set; } = string.Empty;
        public static bool IsLoggedIn => CurrentUserId > 0;     
        public static void Login(int id, string username)
        {
            CurrentUserId = id;
            CurrentUsername = username;
        }
        public static void Logout()
        {
            CurrentUserId = 0;
            CurrentUsername = string.Empty;
        }
        public static void AddDish(string name, string mota, string price, string url, string address)
        {
            int newId = nextDishId++;
            var newDish = new Dish
            {
                DishId = newId,
                Name = name,
                Description = mota,
                Price = price,
                Url = url,
                Address = address,
                ContributorId = CurrentUserId, 
            };

            list_monan.Add(newDish);
        }

        private void SessionManager_Bai7_Load(object sender, EventArgs e)
        {

        }
    }
}
