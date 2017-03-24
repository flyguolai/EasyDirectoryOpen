using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FileNameReader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DirectoryPath.Text = @"D:\vtkproject\vtk7build\vtkdebug\lib";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "打开文件夹";
            if(dialog.ShowDialog() == DialogResult.OK){
                string foldPath = dialog.SelectedPath;
                DirectoryPath.Text = foldPath;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*
            var files = Directory.GetFiles(DirectoryPath.Text, "*.lib");

            string OutputText = "";
            foreach (var file in files)
            {
                OutputText += file + "\r\n";
            }
            OutputTextBox.Text = OutputText;
            */
            OutputTextBox.Clear();
            DirectoryInfo folder = new DirectoryInfo(DirectoryPath.Text);
            string OutputText = "";
            foreach (FileInfo file in folder.GetFiles("*.lib"))
            {
                OutputText += headtext.Text;
                OutputText += file.Name;
                OutputText += endtext.Text;
                OutputText += "\r\n";
            }
            OutputTextBox.Text = OutputText;


        }
    }
}
