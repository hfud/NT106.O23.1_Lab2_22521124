using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using System.Text.Json;
using System.IO;
using classStudent;
using System.Runtime.Serialization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Reflection.Emit;

namespace _22521124_NgoHongPhuc_Lab2
{
    public partial class Lab2_Bai4 : Form
    {
        public Lab2_Bai4()
        {
            InitializeComponent();
        }

        List<Student> students = new List<Student>();
        int dem = 0;
        string textrich = "";
        int i = 0;
        List<Student> lastStudent = new List<Student>();

        private void add_Click(object sender, EventArgs e)
        {
            if (inID.Text.Trim().Length != 8)
            {
                MessageBox.Show("Sai định dạng MSSV");
            }
            else
            {
                if (inPhone.Text.Trim().Length != 10 || inPhone.Text.Trim()[0] != '0')
                {
                    MessageBox.Show("Sai định dạng SĐT");
                }
                else
                {
                    if (float.Parse(inC1.Text.Trim()) < 0 || float.Parse(inC1.Text.Trim()) > 10 ||
                        float.Parse(inC2.Text.Trim()) < 0 || float.Parse(inC2.Text.Trim()) > 10 ||
                        float.Parse(inC3.Text.Trim()) < 0 || float.Parse(inC3.Text.Trim()) > 10)
                    {
                        MessageBox.Show("Sai định dạng điểm");
                    }
                    else
                    {
                        Student tmp = new Student(inName.Text.Trim(), Int32.Parse(inID.Text.Trim()), inPhone.Text.Trim(),
                                float.Parse(inC1.Text.Trim()), float.Parse(inC2.Text.Trim()), float.Parse(inC3.Text.Trim()));
                        students.Add(tmp);
                        textrich += students[dem].Name + '\n' + students[dem].ID + '\n' + students[dem].Phone + '\n' + students[dem].Course1
                 + '\n' + students[dem].Course2 + '\n' + students[dem].Course3 + '\n' + '\n';
                        screen.Text = textrich;
                        dem++;
                    }
                }
            }
        }

        static void SerializeToFileStream(String filePath, List<Student> students)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    foreach (Student student in students)
                    {
                        writer.WriteLine($"{student.Name},{student.ID},{student.Phone},{student.Course1},{student.Course2},{student.Course3}");
                    }
                }
                MessageBox.Show("Write success! (input4.txt)");
            }
            catch
            {
                MessageBox.Show("Error!");
            }
        }

        static List<Student> DeserializeFromFileStream(string filePath)
        {
            List<Student> students = new List<Student>();
            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        if (parts.Length == 6)
                        {
                            string name = parts[0];
                            int id = int.Parse(parts[1]);
                            string phone = parts[2];
                            float c1 = float.Parse(parts[3]);
                            float c2 = float.Parse(parts[4]);
                            float c3 = float.Parse(parts[5]);
                            if (name != null && phone != null)
                            {
                                students.Add(new Student(name, id, phone, c1, c2, c3));
                            }
                            else
                            {
                                MessageBox.Show("Name or phone is null.");
                            }
                        }
                    }
                }
                MessageBox.Show("Read success! input4.txt");
            }
            catch
            {
                MessageBox.Show("Error!");
            }
            return students;
        }

        private void write_Click(object sender, EventArgs e)
        {
            SerializeToFileStream("input4.txt", students);
        }

        private void read_Click(object sender, EventArgs e)
        {
            lastStudent = DeserializeFromFileStream("input4.txt");
            if (lastStudent.Count > 0)
            {
                DisplayStudent(0);
                i = 1;
                page.Text = i.ToString();
            }
            else
            {
                MessageBox.Show("Không có sinh viên nào trong danh sách.");
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            if (i > 1 && i <= lastStudent.Count)
            {
                i--;
                page.Text = i.ToString();
                DisplayStudent(i - 1);
            }
            else
            {
                MessageBox.Show("First student");
            }
        }

        private void Next_Click(object sender, EventArgs e)
        {
            if (i < lastStudent.Count)
            {
                i++;
                page.Text = i.ToString();
                DisplayStudent(i - 1);
            }
            else
            {
                MessageBox.Show("Last student");
            }
        }

        private void DisplayStudent(int index)
        {
            Student student = lastStudent[index];
            outName.Text = student.Name;
            outID.Text = student.ID.ToString();
            outPhone.Text = student.Phone;
            outC1.Text = student.Course1.ToString();
            outC2.Text = student.Course2.ToString();
            outC3.Text = student.Course3.ToString();
            student.Average = student.TBC();
            outAvg.Text = student.Average.ToString();
        }   
    }
}
