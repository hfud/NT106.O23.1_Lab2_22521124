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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _22521124_NgoHongPhuc_Lab2
{
    public partial class Lab2_Bai7 : Form
    {
        public Lab2_Bai7()
        {
            InitializeComponent();
            treeView.AfterSelect += treeView_AfterSelect;
        }
        private void Lab2_Bai7_Load(object sender, EventArgs e)
        {
            treeView.Nodes.Clear();
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (DriveInfo drive in drives)
            {
                if (drive.Name != @"C:\")
                {
                    TreeNode rootNode = new TreeNode(drive.Name);
                    rootNode.Tag = drive.RootDirectory;
                    treeView.Nodes.Add(rootNode);
                    AddSubDirectories(rootNode, drive.RootDirectory);
                }
            }
        }
        private void AddSubDirectories(TreeNode node, DirectoryInfo dir)
        {
            DirectoryInfo[] subDirs = dir.GetDirectories();
            foreach (DirectoryInfo subDir in subDirs)
            {
                try
                {
                    TreeNode subNode = new TreeNode(subDir.Name);
                    subNode.Tag = subDir.FullName;
                    AddSubDirectories(subNode, subDir);
                    node.Nodes.Add(subNode);
                    AddFiles(subNode, subDir);
                }
                catch (UnauthorizedAccessException ex) { }
            }
        }
        private void AddFiles(TreeNode node, DirectoryInfo dir)
        {
            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files)
            {
                try
                {
                    TreeNode fileNode = new TreeNode(file.Name);
                    fileNode.Tag = file.FullName;
                    node.Nodes.Add(fileNode);
                }
                catch (UnauthorizedAccessException ex) { }
            }
        }
        private void Display(string filePath)
        {
            string extension = Path.GetExtension(filePath).ToLowerInvariant();
            if (extension == ".png" || extension == ".jpg" || extension == ".jpeg" || extension == ".bmp" || extension == ".gif")
            {
                try
                {
                    Image image = Image.FromFile(filePath);
                    pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox.Image = image;
                }
                catch (OutOfMemoryException)
                {
                    MessageBox.Show("Not supported!");
                }
            }
            else if (extension == ".txt")
            {
                string fileContent = File.ReadAllText(filePath);
                richTextBox.Text = fileContent;
            }
            else
            {
                MessageBox.Show("Not supported!");
            }
        }

        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Tag != null && File.Exists(e.Node.Tag.ToString()))
            {
                Display(e.Node.Tag.ToString());
            }
        }
    }
}
