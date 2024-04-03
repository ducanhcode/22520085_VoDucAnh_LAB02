using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _22520085_VoDucAnh
{
    public partial class LAB02_bai07 : Form
    {
        public LAB02_bai07()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            InitTree();// Gọi phương thức InitTree để khởi tạo cây thư mục
        }

        // Phương thức khởi tạo cây thư mục
        private void InitTree()
        {
            string[] drives = Directory.GetLogicalDrives();
            TreeNode node = null;
            foreach (string drive in drives)
            {
                node = new TreeNode(drive);
                treeView1.Nodes.Add(node);
                node.Nodes.Add("Tam");
            }
        }

        // Phương thức được gọi trước khi một node trong treeView1 được mở ra
        private void treeView1_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            TreeNode node = e.Node;  // Lấy node được mở ra
            node.Nodes.Clear();  // Xóa các node con của node hiện tại
            string[] items = Directory.GetFileSystemEntries(node.FullPath); // Lấy danh sách các thư mục và tệp tin trong đường dẫn của node hiện tại


            foreach (string item in items) // Kiểm tra nếu đối tượng là một tệp tin
            {
                if (File.Exists(item))
                {
                    string extension = Path.GetExtension(item).ToLower(); // Lấy phần mở rộng của tệp tin

                    // Kiểm tra nếu phần mở rộng là .png, .jpg hoặc .jpeg, thêm node cho tệp tin vào cây
                    if (extension == ".png" || extension == ".jpg" || extension == ".jpeg")
                    {
                        TreeNode n = node.Nodes.Add(Path.GetFileName(item));
                    }

                    // Kiểm tra nếu phần mở rộng là .txt, thêm node cho tệp tin vào cây
                    else if (extension == ".txt")
                    {
                        TreeNode n = node.Nodes.Add(Path.GetFileName(item));
                    }
                }
                else if (Directory.Exists(item)) // Kiểm tra nếu đối tượng là một thư mục
                {
                    TreeNode n = node.Nodes.Add(Path.GetFileName(item)); // Thêm node cho thư mục vào cây
                    n.Nodes.Add("Tam"); // Thêm một node tạm vào node thư mục vừa thêm
                }
            }
        }
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode selectedNode = e.Node; // Lấy node được chọn
            string filePath = selectedNode.FullPath; // Lấy đường dẫn của node được chọn

            if (File.Exists(filePath)) // Kiểm tra nếu đường dẫn là một tệp tin
            {
                string extension = Path.GetExtension(filePath).ToLower(); // Lấy phần mở rộng của tệp tin

                if (extension == ".txt") // Nếu phần mở rộng là .txt, hiển thị nội dung của tệp tin vào textBox1
                {
                    string textContent = File.ReadAllText(filePath);
                    textBox1.Text = textContent;
                }
                else if (extension == ".png" || extension == ".jpg" || extension == ".jpeg") // Nếu phần mở rộng là .png, .jpg hoặc .jpeg, hiển thị hình ảnh trong pictureBox1
                {
                    try
                    {
                        pictureBox1.Image = Image.FromFile(filePath); // Hiển thị hình ảnh từ tệp tin vào pictureBox1
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage; // Thiết lập chế độ hiển thị hình ảnh trong pictureBox1
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Không thể mở tệp ảnh: " + ex.Message); // Hiển thị thông báo lỗi nếu không thể mở tệp ảnh
                    }
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
