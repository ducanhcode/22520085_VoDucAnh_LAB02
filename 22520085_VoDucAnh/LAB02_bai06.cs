using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SQLite;

namespace _22520085_VoDucAnh
{
    public partial class LAB02_bai06 : Form
    {
        private string selectedFilePath;
        public LAB02_bai06()
        {
            InitializeComponent();
            CreateTables();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox2.Clear();
            pictureBox1.Image = null;
            listView1.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files|*.txt";
            openFileDialog.Title = "Chọn tệp dữ liệu";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                selectedFilePath = openFileDialog.FileName;
                ReadAndInsertData(selectedFilePath);
            }
            else
            {
                MessageBox.Show("Bạn đã hủy chọn file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ShowDataOnListView();
        }
        private void ReadAndInsertData(string filePath)
        {
            using (SQLiteConnection connection = new SQLiteConnection("Data Source=food_database.db;Version=3;"))
            {
                connection.Open();

                using (StreamReader sr = new StreamReader(filePath))
                {
                    string line;
                    bool isMonAnSection = false;
                    bool isNguoiDungSection = false;

                    while ((line = sr.ReadLine()) != null)
                    {
                        if (line.StartsWith("# MonAn"))
                        {
                            isMonAnSection = true;
                            isNguoiDungSection = false;
                            continue;
                        }
                        else if (line.StartsWith("# NguoiDung"))
                        {
                            isMonAnSection = false;
                            isNguoiDungSection = true;
                            continue;
                        }
                        else if (line.Trim() != "")
                        {
                            string[] fields = line.Split(',');

                            if (isMonAnSection && fields.Length == 4)
                            {
                                using (SQLiteCommand cmd = new SQLiteCommand("INSERT INTO MonAn (IDMA, TenMonAn, HinhAnh, IDNCC) VALUES (@id, @name, @image, @contributorId)", connection))
                                {
                                    cmd.Parameters.AddWithValue("@id", Convert.ToInt32(fields[0]));
                                    cmd.Parameters.AddWithValue("@name", fields[1]);
                                    cmd.Parameters.AddWithValue("@image", fields[2]);
                                    cmd.Parameters.AddWithValue("@contributorId", Convert.ToInt32(fields[3]));
                                    cmd.ExecuteNonQuery();
                                }
                            }
                            else if (isNguoiDungSection && fields.Length == 3)
                            {
                                using (SQLiteCommand cmd = new SQLiteCommand("INSERT INTO NguoiDung (IDNCC, HoVaTen, QuyenHan) VALUES (@id, @name, @role)", connection))
                                {
                                    cmd.Parameters.AddWithValue("@id", Convert.ToInt32(fields[0]));
                                    cmd.Parameters.AddWithValue("@name", fields[1]);
                                    cmd.Parameters.AddWithValue("@role", fields[2]);
                                    cmd.ExecuteNonQuery();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Nội dung của tệp không tương thích với cấu trúc của bảng MonAn và NguoiDung.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                listView1 = null;
                                return;
                            }
                        }
                    }
                }
                connection.Close();
            }
        }
        private void ShowDataOnListView()
        {
            using (SQLiteConnection connection = new SQLiteConnection("Data Source=food_database.db;Version=3;"))
            {
                connection.Open();
                using (SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM MonAn", connection))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ListViewItem item = new ListViewItem(reader["TenMonAn"].ToString());
                            item.SubItems.Add(reader["HinhAnh"].ToString());
                            item.SubItems.Add(reader["IDNCC"].ToString());
                            listView1.Items.Add(item);
                        }
                    }
                }
                connection.Close();
            }
        }
        private void ShowRandomFoodInfo()
        {
            using (SQLiteConnection connection = new SQLiteConnection("Data Source=food_database.db;Version=3;"))
            {
                connection.Open();
                using (SQLiteCommand cmd = new SQLiteCommand("SELECT MonAn.TenMonAn, MonAn.HinhAnh, NguoiDung.HoVaTen " +
                                                              "FROM MonAn " +
                                                              "INNER JOIN NguoiDung ON MonAn.IDNCC = NguoiDung.IDNCC " +
                                                              "ORDER BY RANDOM() LIMIT 1", connection))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string foodName = reader["TenMonAn"].ToString();
                            string imageName = reader["HinhAnh"].ToString();
                            string contributorName = reader["HoVaTen"].ToString();

                            richTextBox1.Text = foodName;
                            richTextBox2.Text = contributorName;
                            if (Properties.Resources.ResourceManager.GetObject(imageName) != null)
                            {
                                pictureBox1.Image = (Image)Properties.Resources.ResourceManager.GetObject(imageName);
                            }
                            else
                            {
                                MessageBox.Show("Hình ảnh không tồn tại trong resource.");
                            }
                        }
                        else
                        {
                            richTextBox1.Text = "Không tìm thấy món ăn ngẫu nhiên";
                        }
                    }
                }
                connection.Close();
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            ShowRandomFoodInfo();
        }
        private void CreateTables()
        {
            using (SQLiteConnection connection = new SQLiteConnection("Data Source=food_database.db;Version=3;"))
            {
                connection.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(connection))
                {
                    //Tạo bảng món ăn
                    cmd.CommandText = @"
                    CREATE TABLE IF NOT EXISTS MonAn (
                        IDMA INTEGER PRIMARY KEY,
                        TenMonAn TEXT,
                        HinhAnh TEXT,
                        IDNCC INTEGER
                    );";
                    cmd.ExecuteNonQuery();
                    //Tạo bảng người dùng
                    cmd.CommandText = @"
                    CREATE TABLE IF NOT EXISTS NguoiDung (
                        IDNCC INTEGER PRIMARY KEY,
                        HoVaTen TEXT,
                        QuyenHan TEXT
                    );";
                    cmd.ExecuteNonQuery();
                }
                connection.Close();
            }
        }
        private void DeleteTables()
        {
            using (SQLiteConnection connection = new SQLiteConnection("Data Source=food_database.db;Version=3;"))
            {
                connection.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(connection))
                {
                    // Xóa bảng MonAn
                    cmd.CommandText = "DROP TABLE IF EXISTS MonAn;";
                    cmd.ExecuteNonQuery();

                    // Xóa bảng NguoiDung
                    cmd.CommandText = "DROP TABLE IF EXISTS NguoiDung;";
                    cmd.ExecuteNonQuery();
                }
                connection.Close();
            }
        }
        private void Bai6_FormClosing(object sender, FormClosingEventArgs e)
        {
            DeleteTables();
        }

        private void LAB02_bai06_Load(object sender, EventArgs e)
        {

        }
    }
}