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

namespace _22521124_NgoHongPhuc_Lab2
{
    public partial class Lab2_Bai1 : Form
    {
        public Lab2_Bai1()
        {
            InitializeComponent();
        }

        private void doc_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("input1.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            content.Text = sr.ReadToEnd();
            sr.Close();
        }

        private void ghi_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("output1.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(content.Text.ToUpper());
            sw.Close();
        }
    }
}
