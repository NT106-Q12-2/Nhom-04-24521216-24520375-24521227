using System;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;
using System.Data; // Giữ lại các using cần thiết
using Cau7;
namespace Cau7
{
    public partial class DatabaseFunction 
    {
        private static string dbpath = "Data Source=Usersbai7.db;Version=3;";
        public static bool addUser(string username, string password, string email, string firstName, string lastName, string phone, string birthday, string language, string sex)
        {
            using (var connection = new SQLiteConnection(dbpath))
            {
                try
                {
                    connection.Open();
                    string insertSql = @"
                    INSERT INTO Users (Username, Password, Email, FirstName, LastName, Phone, Birthday, Language, Sex)
                    VALUES (@username, @password, @email, @firstName, @lastName, @phone, @birthday, @language, @sex);";
                    using (var command = new SQLiteCommand(insertSql, connection))
                    {
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@password", password);
                        command.Parameters.AddWithValue("@email", email);
                        command.Parameters.AddWithValue("@firstName", firstName);
                        command.Parameters.AddWithValue("@lastName", lastName);
                        command.Parameters.AddWithValue("@phone", phone);
                        command.Parameters.AddWithValue("@birthday", birthday);
                        command.Parameters.AddWithValue("@language", language);
                        command.Parameters.AddWithValue("@sex", sex);
                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
                catch (SQLiteException ex)
                {
                    if (ex.Message.Contains("UNIQUE constraint failed"))
                    {
                        MessageBox.Show("Lỗi Đăng ký");
                    }
                    else
                    {
                        MessageBox.Show($"Lỗi Database không xác định: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    return false;
                }
            }
        }
        public static void InitializeDatabase()
        {
            if (!File.Exists("Usersbai7.db"))
            {
                SQLiteConnection.CreateFile("Usersbai7.db");
            }
            using (var connection = new SQLiteConnection(dbpath))
            {
                try
                {
                    connection.Open();
                    string createTableSql = @"
                        CREATE TABLE IF NOT EXISTS Users (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        Username TEXT NOT NULL UNIQUE,
                        Password TEXT NOT NULL,
                        Email TEXT NOT NULL UNIQUE,
                        FirstName TEXT NOT NULL,
                        LastName TEXT NOT NULL,
                        Phone TEXT UNIQUE, 
                        Birthday TEXT NOT NULL,
                        Language TEXT NOT NULL,
                        Sex TEXT
                    );";
                    using (var command = new SQLiteCommand(createTableSql, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi khởi tạo Database: " + ex.Message);
                }
            }
        }
        // Đặt hàm này trong lớp DatabaseFunction (hoặc DbHelper)

        public static int ValidateUser(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                return 0;
            }
            string dbpath = "Data Source=Usersbai7.db;Version=3;";
            using (var connection = new SQLiteConnection(dbpath))
            {
                try
                {
                    connection.Open();
                    string selectSql = "SELECT Id FROM Users WHERE Username = @username AND Password = @password;";

                    using (var command = new SQLiteCommand(selectSql, connection))
                    {
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@password", password);
                        object result = command.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                        {
                            return Convert.ToInt32(result);
                        }
                        return 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi Database khi đăng nhập");
                    return 0;
                }
            }
        }

        private void DatabaseFunction_Load(object sender, EventArgs e)
        {

        }

//        private void InitializeComponent()
//        {
//            this.SuspendLayout();
            // 
            // DatabaseFunction
            // 
//            this.ClientSize = new System.Drawing.Size(284, 261);
//            this.Name = "DatabaseFunction";
 //           this.Load += new System.EventHandler(this.DatabaseFunction_Load_1);
//            this.ResumeLayout(false);

//        }

        private void DatabaseFunction_Load_1(object sender, EventArgs e)
        {

        }
    }
}