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
    public partial class Library_page : Form
    {
        public Library_page()
        {
            InitializeComponent();



        }


        private void Library_page_Load(object sender, EventArgs e)
        {




        }
       
        

        
        private void Done_bt_Click(object sender, EventArgs e)
        {


            if(Buy.Checked == true)
            {
               
                    Buy_book obj = new Buy_book();
                        obj.Show();
                
            }
            else if(Rent.Checked == true)
            {
                
                
                    Rent_book obj1 = new Rent_book();
                    obj1.Show();
                
            }

        }
    }
}
