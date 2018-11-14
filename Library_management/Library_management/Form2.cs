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
    public partial class Form2 : Form
    {

        SqlConnection s1 = new SqlConnection(@" Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jyothi\source\repos\Library_management\Library_management\Login_details.mdf;Integrated Security = True");
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Done_Click(object sender, EventArgs e)
        {

            s1.Open();
            SqlCommand cmd = new SqlCommand("Login_details_proc", s1);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("Uname", uname.Text);
            cmd.Parameters.AddWithValue("Pword", pword.Text);
            cmd.Parameters.AddWithValue("Email", email.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("You are signed up");
            uname.Focus();
            pword.Focus();
            email.Focus();
            s1.Close();
            this.Close();
            




        }
    }
}
