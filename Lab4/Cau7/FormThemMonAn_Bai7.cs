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
    public partial class FormThemMonAn_Bai7 : Form
    {
        public FormThemMonAn_Bai7()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_picturefood_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog.Title = "Chọn ảnh món ăn";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBox_urlpic.Text = openFileDialog.FileName;
            }
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            string name = textBox_tenmonan.Text.Trim();
            string price = textBox_price.Text.Trim();
            string address = textBox_address.Text.Trim();
            string url = textBox_urlpic.Text.Trim(); // Tên file ảnh đã copy
            string mota = richTextBox_mota.Text.Trim();
            try
            {
                SessionManager_Bai7.AddDish(
                    name,
                    mota,
                    price,
                    url,
                    address
                );

                // Hoàn thành và đóng Form
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm món ăn");
            }
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_tenmonan.Text = "";
            textBox_price.Text = "";
            textBox_address.Text = "";
            textBox_urlpic.Text = "";
            richTextBox_mota.Text = "";
        }
    }
}
