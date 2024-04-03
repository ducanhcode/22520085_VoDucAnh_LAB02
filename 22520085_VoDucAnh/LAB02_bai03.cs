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
using static System.Windows.Forms.LinkLabel;

namespace _22520085_VoDucAnh
{
    public partial class LAB02_bai03 : Form
    {
        public LAB02_bai03()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string[] lines = File.ReadAllLines("input3.txt");
                foreach (string line in lines)
                {
                    string[] tokens = line.Split(' ');
                    double result = EvaluateExpression(tokens);
                    string output = string.Join(" ", tokens) + " = " + result.ToString() + "\n";
                    richTextBox1.AppendText(output);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi đọc file input3.txt !" + ex.Message);
            }
        }

        private double EvaluateExpression(string[] tokens)
        {
            double result = double.Parse(tokens[0]);
            char operation = '+';
            for (int i = 1; i < tokens.Length; i++)
            {
                if (tokens[i] == "+" || tokens[i] == "-" || tokens[i] == "*" || tokens[i] == "/")
                {
                    operation = char.Parse(tokens[i]);
                }
                else
                {
                    double operand = double.Parse(tokens[i]);
                    switch (operation)
                    {
                        case '+':
                            result += operand;
                            break;
                        case '-':
                            result -= operand;
                            break;
                        case '*':
                            result *= operand;
                            break;
                        case '/':
                            result /= operand;
                            break;
                    }
                }
            }
            return result;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter("output3.txt"))
                {
                    writer.Write(richTextBox1.Text);
                }
                MessageBox.Show("Ghi kết quả vào file output3.txt thành công !");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi kết quả ! " + ex.Message);
            }
        }
    }
}
