using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _22521124_NgoHongPhuc_Lab2
{
    public partial class Lab2 : Form
    {
        public Lab2()
        {
            InitializeComponent();
        }

        private void Bai1_Click(object sender, EventArgs e)
        {
            Lab2_Bai1 bai1 = new Lab2_Bai1();
            bai1.ShowDialog();
        }

        private void Bai2_Click(object sender, EventArgs e)
        {
            Lab2_Bai2 bai2 = new Lab2_Bai2();
            bai2.ShowDialog();
        }

        private void Bai3_Click(object sender, EventArgs e)
        {
            Lab2_Bai3 bai3 = new Lab2_Bai3();
            bai3.ShowDialog();
        }

        private void Bai4_Click(object sender, EventArgs e)
        {
            Lab2_Bai4 bai4 = new Lab2_Bai4();
            bai4.ShowDialog();
        }

        private void Bai5_Click(object sender, EventArgs e)
        {

        }

        private void Bai6_Click(object sender, EventArgs e)
        {

        }

        private void Bai7_Click(object sender, EventArgs e)
        {
            Lab2_Bai7 bai7 = new Lab2_Bai7();
            bai7.ShowDialog();
        }
    }
}
