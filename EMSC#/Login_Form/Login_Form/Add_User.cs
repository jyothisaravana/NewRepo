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
    public partial class Add_User : Form
    {
        public Add_User()
        {
            InitializeComponent();
            
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\EMSC#\Login_Form\Login_Form\Database1.mdf;Integrated Security=True");

        private void Add_User_Load(object sender, EventArgs e)
        {
            con.Open();
            

            SqlCommand cmd = new SqlCommand("select * from Users", con);
            SqlDataReader dr = cmd.ExecuteReader();
            try
            {
                while (dr.Read())
                {

                    
               
                        this.comboBox1.Items.Add((string)dr["Emp_id"].ToString());
                    
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

            /*DataColumn column = new DataColumn();
            column.DataType = System.Type.GetType("System.Int32");
            column.ColumnName = "Id";
            column.AutoIncrement = true;
            column.AutoIncrementSeed = 0;
            column.AutoIncrementStep = -1;
            Database.Columns.Add(column);*/


        }
        private void Adduser_Click(object sender, EventArgs e)
        {



            DialogResult dr = MessageBox.Show("Do You Want to add the record","ADD", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            try
            {
                if (dr == DialogResult.OK)
                {
                    con.Open();
                    string query = "insert into Users(username,password,division,Emp_id)values('" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text +"','"+textBox1.Text+ "')";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Done");
                    con.Close();

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error Occured:" + ex.Message);
            }
            



            

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
            
            
                SqlCommand cmd = new SqlCommand("Select * from Users where Emp_id = '" + comboBox1.Text + "'", con);
                SqlDataReader dr = cmd.ExecuteReader();
                try
                {
                    while (dr.Read())
                    {
                        textBox2.Text = (string)dr["username"];
                        textBox1.Text = (string)dr["Emp_id"].ToString();
                        textBox3.Text = (string)dr["password"];
                        textBox4.Text = (string)dr["division"];

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

        private void Delete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do You Want to delete the record", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if(dr==DialogResult.OK)
            {
                con.Open();
                string query = "delete from Users where Emp_id = '"+textBox1.Text+"'";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Done");
                con.Close();

                



            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do You Want to Update the record", "Update", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (dr == DialogResult.OK)
            {
                try
                {
                    con.Open();
                    String query = "update Users set Emp_id = '"+textBox1.Text+"',username='" + textBox2.Text + "', password='" + textBox3.Text + "',division='" + textBox4.Text + "' where Emp_id='"+textBox1.Text+"' ";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error:" + ex.Message);
                }
            }

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
