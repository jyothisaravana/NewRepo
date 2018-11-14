using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_management
{
    public partial class Rent_book : Form
    {
        public Rent_book()
        {
            InitializeComponent();
        }

        private void Scombobox_SelectedIndexChanged(object sender, EventArgs e)
        {

            MessageBox.Show("You should return your books from 30 days today"+Scombobox.Text);

        }

        private void HcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("You should return your books from 30 days today"+HcomboBox.Text);
        }

        
        private void Rent_book_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("You should return your books from 30 days today"+comboBox1.Text);
        }

        private void Done_Click(object sender, EventArgs e)
        {

            


        }
    }
}
