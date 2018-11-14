using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Library_management
{
    public partial class Buy_book : Form
    {
        
        public Buy_book()
        {


            InitializeComponent();
          

            
        }


        private void Buy_book_Load(object sender, EventArgs e)
        {





        }

        private void Done_Click(object sender, EventArgs e)
        {
            this.Close();

           
            

        }
       
          
        private void Scombobox_SelectedIndexChanged(object sender, EventArgs e)
        {

            MessageBox.Show(Scombobox.Text);


        }

        private void HcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            MessageBox.Show(HcomboBox.Text);
        }

        private void LcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(LcomboBox.Text);
        }
    }
}
