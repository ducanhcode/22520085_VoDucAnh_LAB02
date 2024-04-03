using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _22520085_VoDucAnh
{
    public partial class LAB02_bai01 : Form
    {
        public LAB02_bai01()
        {
            InitializeComponent();
        }

        private void DocFile_Click(object sender, EventArgs e)
        {
            try
            {
                // Mở file "input1.txt" để đọc
                using (StreamReader sr = new StreamReader("input1.txt"))
                {
                    // Đọc toàn bộ nội dung file
                    string text = sr.ReadToEnd();

                    // Hiển thị nội dung lên RichTextBox
                    richTextBox1.Text = text;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đọc file: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GhiFile_Click(object sender, EventArgs e)
        {
            try
            {
                // Mở file "output1.txt" để ghi
                using (StreamWriter sw = new StreamWriter("output1.txt"))
                {
                    // Chuyển toàn bộ nội dung sang chữ hoa
                    string uppertext = richTextBox1.Text.ToUpper();

                    // Ghi nội dung xuống file
                    sw.Write(uppertext);
                }

                MessageBox.Show("Ghi file thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi ghi file: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
