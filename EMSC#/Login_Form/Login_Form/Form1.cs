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

namespace Login_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\EMSC#\Login_Form\Login_Form\Database1.mdf;Integrated Security=True");
        string access;
        string usr;
        string pass;

        private void Login_Click(object sender, EventArgs e)
        {


            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Users where division='"+access+"'", con);
            SqlDataReader dr = cmd.ExecuteReader();
            try
            {
                while (dr.Read())
                {


                    usr = (string)dr["Username"];
                    pass = (string)dr["password"];


                   

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
            finally
            {
                if (dr != null)
                {
                    dr.Close();
                }
            }
            cmd.ExecuteNonQuery();
            con.Close();




            if (access == "Admin")
            {
                if (user.Text == usr && password.Text == pass)
                {
                    MessageBox.Show("Success");
                    Admin obj = new Admin();
                    obj.Show();

                }
                else
                    MessageBox.Show("Enter the correct details");

            }
            else if (access == "Staff")
            {
                if (user.Text == usr && password.Text == pass)
                {
                    MessageBox.Show("Success");
                    Main_Menu obj1 = new Main_Menu();
                    obj1.Show();

                }
                else
                    MessageBox.Show("Enter the correct details");

            }

        }



    

      private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
      {
            access = ComboBox1.SelectedItem.ToString();
      }  

        private void Login_page_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Users", con);
            SqlDataReader dr = cmd.ExecuteReader();
            try
            {
                while (dr.Read())
                {


                    

                    
                    this.ComboBox1.Items.Add((string)dr["division"].ToString());
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
            finally
            {
                if (dr != null)
                {
                    dr.Close();
                } 
            }
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
    }
}
