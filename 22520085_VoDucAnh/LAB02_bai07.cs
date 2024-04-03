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
            InitTree();
        }
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

        private void treeView1_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            TreeNode node = e.Node;
            node.Nodes.Clear();
            string[] items = Directory.GetFileSystemEntries(node.FullPath);

            foreach (string item in items)
            {
                if (File.Exists(item))
                {
                    string extension = Path.GetExtension(item).ToLower();
                    if (extension == ".png" || extension == ".jpg" || extension == ".jpeg")
                    {
                        TreeNode n = node.Nodes.Add(Path.GetFileName(item));
                    }
                    else if (extension == ".txt")
                    {
                        TreeNode n = node.Nodes.Add(Path.GetFileName(item));
                    }
                }
                else if (Directory.Exists(item))
                {
                    TreeNode n = node.Nodes.Add(Path.GetFileName(item));
                    n.Nodes.Add("Tam");
                }
            }
        }
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode selectedNode = e.Node;
            string filePath = selectedNode.FullPath;

            if (File.Exists(filePath))
            {
                string extension = Path.GetExtension(filePath).ToLower();

                if (extension == ".txt")
                {
                    string textContent = File.ReadAllText(filePath);
                    textBox1.Text = textContent;
                }
                else if (extension == ".png" || extension == ".jpg" || extension == ".jpeg")
                {
                    try
                    {
                        pictureBox1.Image = Image.FromFile(filePath);
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Không thể mở tệp ảnh: " + ex.Message);
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
