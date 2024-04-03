using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _22520085_VoDucAnh
{
    public partial class LAB02 : Form
    {
        public LAB02()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LAB02_bai01 frombai01 = new LAB02_bai01();
            frombai01.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LAB02_bai02 frombai02 = new LAB02_bai02();
            frombai02.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LAB02_bai03 frombai03 = new LAB02_bai03();
            frombai03.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LAB02_bai04 frombai04 = new LAB02_bai04();
            frombai04.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LAB02_bai05 frombai05 = new LAB02_bai05();
            frombai05.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            LAB02_bai06 frombai06 = new LAB02_bai06();
            frombai06.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            LAB02_bai07 frombai07 = new LAB02_bai07();
            frombai07.Show();
        }
    }
}
