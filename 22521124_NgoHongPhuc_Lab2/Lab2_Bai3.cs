using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _22521124_NgoHongPhuc_Lab2
{
    public partial class Lab2_Bai3 : Form
    {
        public Lab2_Bai3()
        {
            InitializeComponent();
        }

        private void doc_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("input3.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            content.Text = sr.ReadToEnd();
            sr.Close();
        }

        private void ghi_Click(object sender, EventArgs e)
        {
            string[] lines = content.Lines;

            string outputFilePath = "output3.txt";
            using (StreamWriter sw = new StreamWriter(outputFilePath))
            {
                // Duyệt qua từng dòng trong RichTextBox
                foreach (string line in lines)
                {
                    string formattedLine = RemoveExtraSpaces(line);
                    if (IsValidExpression(formattedLine))
                    {
                        double result = Solve(formattedLine);
                        sw.WriteLine($"{formattedLine} = {result}");
                    }
                    else
                    {
                        sw.WriteLine("Syntax Error");
                    }
                }
            }
            MessageBox.Show("Đã xử lý xong và lưu vào file output3.txt");
        }

        private string RemoveExtraSpaces(string input)
        {
            return Regex.Replace(input, @"\s+", "");
        }

        private bool IsValidExpression(string input)
        {
            return Regex.IsMatch(input, @"^[0-9\.+\-*\/]+$") && !Regex.IsMatch(input, @"\.\.+");
        }

        private double Solve(string expression)
        {
            string[] elements = Regex.Split(expression, @"([+\-*\/])");
            double result = double.Parse(elements[0]);
            for (int i = 1; i < elements.Length; i += 2)
            {
                string operation = elements[i];
                double operand = double.Parse(elements[i + 1]);

                switch (operation)
                {
                    case "+":
                        result += operand;
                        break;
                    case "-":
                        result -= operand;
                        break;
                    case "*":
                        result *= operand;
                        break;
                    case "/":
                        if (operand == 0)
                        {
                            return double.NaN;
                        }
                        else
                        {
                            result /= operand;
                            break;
                        }
                }
            }
            return result;
        }
    }
}

