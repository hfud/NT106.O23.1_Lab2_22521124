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
    public partial class Lab2_Bai2 : Form
    {
        public Lab2_Bai2()
        {
            InitializeComponent();
        }

        private void doc_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.ShowDialog();
            FileStream fs = new FileStream(openFile.FileName, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string txt = sr.ReadToEnd();

            content.Text = txt;

            name.Text = openFile.SafeFileName;

            size.Text = fs.Length.ToString() + " bytes";

            url.Text = openFile.FileName;

            line.Text = txt.Split('\n').Length.ToString();
            
            int wordCount = txt.Split(new char[] { ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries).Length;
            word.Text = wordCount.ToString();

            character.Text = txt.Length.ToString();

            sr.Close();
        }
    }
}
