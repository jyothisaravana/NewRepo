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
    public partial class updateSalary : Form
    {
        public updateSalary()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\EMSC#\Login_Form\Login_Form\Database1.mdf;Integrated Security=True");
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            con.Open();
           SqlCommand cmd = new SqlCommand("Select * from Employee_informations where Emp_id ='" + textBox1.Text + "'", con);
           SqlDataReader rdr = cmd.ExecuteReader();
            
                try
                {
                    while (rdr.Read())

                    {


                        first.Text = (string)rdr["first_name"];
                        sur.Text = (string)rdr["surname"];
                        textBox2.Text = (string)rdr["Dob"];
                        textBox3.Text = (string)rdr["Department"];
                        textBox4.Text = (string)rdr["Salary"];



                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:" + ex.Message);

                }
                finally
                {
                    if (rdr != null)
                    {
                        rdr.Close();
                    }
                }


                cmd.ExecuteNonQuery();
                con.Close();
           

            
        }

        private void Radioperce_CheckedChanged(object sender, EventArgs e)
        {
            if (Radioperce.Checked == true)
                textBox6.Enabled = false;
            else
                textBox6.Enabled = true;
        }

        private void Amount_CheckedChanged(object sender, EventArgs e)
        {
            if (Amount.Checked == true)
                textBox5.Enabled = false;
            else
                textBox5.Enabled = true;
        }

        private void Update_Click(object sender, EventArgs e)
        {


            int salary = Convert.ToInt32(textBox4.Text);
             if(Radioperce.Checked== true)
             {
                int getPercentage = Convert.ToInt32(textBox5.Text);
                int CalSalper = salary / 100 * getPercentage + salary;
                string sx = CalSalper.ToString();
                textBox4.Text = sx;

             }
             else if(Amount.Checked == true)
             {
                int getAmount = Convert.ToInt32(textBox6.Text);
                int CalSalper = getAmount+ salary;
                string sx = CalSalper.ToString();
                textBox4.Text = sx;
             }

            DialogResult drr = MessageBox.Show("Do You Want to update the record", "Update", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);


            if (drr == DialogResult.OK)
            {

                con.Open();
                string q = "Update Employee_informations set Salary ='" + textBox4.Text + "' where Emp_id = '" + textBox1.Text + "'";
                SqlCommand cmd = new SqlCommand(q, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Update successful");
                con.Close();
            }
        }
    }
}
