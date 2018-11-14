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
    public partial class Form1 : Form
    {
        SqlConnection s1 = new SqlConnection(@" Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jyothi\source\repos\Library_management\Library_management\Login_details.mdf;Integrated Security = True");
        public Form1()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, EventArgs e)
        {

            s1.Open();
            SqlCommand sqlCommand = new SqlCommand("Login_details_proc1", s1);
            SqlCommand cmd = sqlCommand;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("Uname", uname.Text);
            cmd.Parameters.AddWithValue("Pword", pword.Text);
            
          
            
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.HasRows)
            {
                rd.Read();
                MessageBox.Show("Your login is successful");
                Library_page obj2 = new Library_page();
                obj2.Show();


            }
            else
            {
                MessageBox.Show("Invalid Username and Password");
            }
            s1.Close();
            

            


        }

        private void Sign_up_Click(object sender, EventArgs e)
        {
            Form2 obj = new Form2();
            obj.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
