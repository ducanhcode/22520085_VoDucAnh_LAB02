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
    public partial class LAB02_bai02 : Form
    {
        public LAB02_bai02()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Mở hộp thoại chọn file
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
         
                string name = openFileDialog.SafeFileName.ToString();
                long fileSize = new FileInfo(name).Length;
                string fileUrl = openFileDialog.FileName.ToString();
                string fileContent = File.ReadAllText(name);
            ///
                filename.Text = name;
                size.Text = fileSize.ToString() + " bytes";
                url.Text = fileUrl;
            ///    
                int lineCount = fileContent.Split('\n').Length;
                int wordCount = fileContent.Split('\n',' ').Length;
                int characterCount = fileContent.Length;
           
                linecount.Text = lineCount.ToString();
                wordscount.Text = wordCount.ToString();
                charactercount.Text = characterCount.ToString();
                richTextBox1.Text = fileContent;
            
        }

        
    }
}
