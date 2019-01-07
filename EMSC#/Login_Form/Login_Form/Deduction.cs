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
    public partial class Deduction : Form
    {
        public Deduction()
        {
            InitializeComponent();
        }
        int count1;
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\EMSC#\Login_Form\Login_Form\Database1.mdf;Integrated Security=True");

        private void status_TextChanged(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void Employee_txt_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from Employee_informations where Emp_id ='" + Employee_txt.Text + "'", con);
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
                    job_t.Text = (string)rdr["Job_title"];
                    status.Text = (string)rdr["Status"];
                    date.Text = (string)rdr["Date_hired"];

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

        private void Calculate_Click(object sender, EventArgs e)
        {
            if (textBox4.Text!="")
            {
                int sal = Convert.ToInt32(textBox4.Text);

                if (radioButton4.Checked == true)
                {

                    int percen = Convert.ToInt32(textBox11.Text);
                    int total_percentage_deduction = sal / 100 * percen;
                    String X = total_percentage_deduction.ToString();
                    int salary = sal - total_percentage_deduction;
                    textBox13.Text = X;
                    textBox12.Text = salary.ToString();

                }
                else if (radioButton3.Checked == true)
                {

                    int deduction = Convert.ToInt32(textBox10.Text);
                    //calculate the total hours of overtime
                    int total_amount_deduction = sal - deduction;
                    String s = total_amount_deduction.ToString();
                    textBox13.Text = deduction.ToString();
                    textBox12.Text = s ;

                }
            }
            else
            {
                MessageBox.Show("Enter the Employee id");
            }
        }

        private void Deduction_Load(object sender, EventArgs e)
        {


            textBox10.Text = "0";
            textBox11.Text = "0";
            textBox12.Text = "0";
            textBox13.Text = "0";

        }
        void Autogenerate2()
        {
            con.Open();
            string str = "Select count(Id) from Deduction";
            SqlCommand cmd = new SqlCommand(str, con);
            count1 = Convert.ToInt32(cmd.ExecuteScalar()) + 1;
            con.Close();

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
                textBox10.Enabled = false;
            else
                textBox10.Enabled = true;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
                textBox11.Enabled = false;
            else
                textBox11.Enabled = true;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            DialogResult drr = MessageBox.Show("Do You Want to add the record", "ADD", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            Autogenerate2();
            try
            {
                if (drr == DialogResult.OK)
                {
                    con.Open();
                    string q = "insert into Deduction(Id,Emp_id,firstname,surname,Deduction_amount,Reason,Made_by,salary) values('" + count1 + "','" + Employee_txt.Text + "','" + first.Text + "','" + sur.Text + "','" + textBox13.Text + "','" + textBox1.Text + "','" + Employee_txt.Text + "','" +textBox12.Text + "');";
                    SqlCommand cmd = new SqlCommand(q, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data entered successfully");
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }



            

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Employee_txt.Text = "";
            first.Text = "";
            sur.Text = "";
            textBox1.Text = "";
            textBox10.Text = "0";
            textBox11.Text = "0";
            textBox12.Text = "0";
            textBox13.Text = "0";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";




            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Delete_Click(object sender, EventArgs e)
        {

            DialogResult drr = MessageBox.Show("Do You Want to delete the record", "ADD", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (drr == DialogResult.OK)
            {
                con.Open();
                string query = "Delete from Deduction where Emp_id= '" + Employee_txt.Text + "'";
                SqlCommand sql = new SqlCommand(query, con);
                sql.ExecuteNonQuery();
                MessageBox.Show("Your data is deleted successfully");
                con.Close();
            }
        }
    }
}
