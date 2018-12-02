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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private string path = @"C:\Users\Student\Desktop\C# project\sample.txt";

        public Form1()
        {
            InitializeComponent();
        }

        private void Create_Click(object sender, EventArgs e)
        {
         
            File.CreateText(path);
            //FileStream f = new FileStream(path, FileMode.Open, FileAccess.Write, FileShare.ReadWrite);
            MessageBox.Show("File created");
        }

        private void Write_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(@"C:\Users\Student\Desktop\C# project\sample.txt");
            sw.WriteLine("Hello world");
            sw.Close();
            MessageBox.Show("Your message as been written");
        }

        private void Read_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(@"C:\Users\Student\Desktop\C# project\sample.txt");
            string line = sr.ReadLine();
            Textbox.Text = line;

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            File.Delete(path);
            MessageBox.Show("Your record is deleted successfully");
        }
    }
}
