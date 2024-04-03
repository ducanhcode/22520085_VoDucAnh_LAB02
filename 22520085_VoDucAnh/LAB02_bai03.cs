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
                string[] lines = File.ReadAllLines("input3.txt");// Đọc các dòng từ tệp tin "input3.txt"
                foreach (string line in lines)// Duyệt qua từng dòng trong mảng lines
                {
                    string[] tokens = line.Split(' ');// Tách các phần tử trong dòng thành mảng dựa trên dấu cách
                    double result = EvaluateExpression(tokens);
                    string output = string.Join(" ", tokens) + " = " + result.ToString() + "\n";
                    richTextBox1.AppendText(output);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi đọc file input3.txt !" + ex.Message); // Hiển thị thông báo lỗi nếu không thể đọc được file "input3.txt"
            }
        }

        private double EvaluateExpression(string[] tokens)
        {
            // Khởi tạo kết quả ban đầu bằng giá trị của phần tử đầu tiên trong mảng tokens
            double result = double.Parse(tokens[0]);
            char operation = '+';// Khởi tạo toán tử mặc định là '+'
            for (int i = 1; i < tokens.Length; i++)
            {
                if (tokens[i] == "+" || tokens[i] == "-" || tokens[i] == "*" || tokens[i] == "/") // Kiểm tra nếu phần tử là một trong các toán tử +, -, *, /
                {
                    operation = char.Parse(tokens[i]);
                }
                else
                {
                    // Nếu phần tử không phải là toán tử, chuyển đổi thành số và thực hiện phép toán tương ứng
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
                    writer.Write(richTextBox1.Text);// Ghi nội dung của RichTextBox vào tệp tin "output3.txt"
                }
                MessageBox.Show("Ghi kết quả vào file output3.txt thành công !");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi kết quả ! " + ex.Message); // Hiển thị thông báo lỗi nếu không thể ghi được kết quả vào file "output3.txt"
            }
        }
    }
}
