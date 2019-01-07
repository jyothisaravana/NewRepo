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
    public partial class allowance : Form
    {
        public allowance()
        {
            InitializeComponent();
        }
        int count1;
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
            catch(Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);

            }
            finally
            {
                if(rdr!=null)
                {
                    rdr.Close();
                }
            }

            cmd.ExecuteNonQuery();
            con.Close();

        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            int salary = Convert.ToInt32(textBox4.Text);
            int overtime = Convert.ToInt32(textBox5.Text);

            double eight = 8;
            double days = 25;
            double dbop = 0;
            double overtimeRate = 1.5;

            double total_overtime = overtime * overtimeRate;
            textBox9.Text = total_overtime.ToString();


            dbop = salary / days / eight;
            textBox10.Text = dbop.ToString();

            int med = Convert.ToInt32(textBox6.Text);
            int bonus = Convert.ToInt32(textBox7.Text);
            int other = Convert.ToInt32(textBox8.Text);
            int f = med + bonus + other;
            double calc = total_overtime * dbop + f;
            textBox11.Text = calc.ToString();
            





        }
        void Dataview()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Allowance",con);
            SqlDataAdapter d = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            d.Fill(dt);
            dataGridView1.DataSource = dt;
            cmd.ExecuteNonQuery();
            con.Close();


        }
        void Autogenerate2()
        {
            con.Open();
            string str = "Select count(Id) from Allowance";
            SqlCommand cmd = new SqlCommand(str, con);
            count1 = Convert.ToInt32(cmd.ExecuteScalar()) + 1;
            con.Close();

        }

        private void Save_Click(object sender, EventArgs e)
        {
            Dataview();
            DialogResult drr = MessageBox.Show("Do You Want to add the record", "ADD", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            Autogenerate2();
            try
            {
                if (drr == DialogResult.OK)
                {
                    con.Open();
                    string q = "insert into Allowance(id,Emp_id,firstname,surname,Dob,Department,overtime,medical,bonus,other,created_by,rate,total_allowance,salary) values(@id,@Emp_id,@firstname,@surname,@Dob,@Department,@overtime,@medical,@bonus,@other,@created_by,@rate,@total_allowance,@salary);";
                    
                    SqlCommand cmd = new SqlCommand(q, con);
                    cmd.Parameters.AddWithValue("@id", count1);
                    cmd.Parameters.AddWithValue("@Emp_id", textBox1.Text);
                    cmd.Parameters.AddWithValue("@firstname", first.Text);
                    cmd.Parameters.AddWithValue("@surname", sur.Text);
                    cmd.Parameters.AddWithValue("@Dob", textBox2.Text);
                    cmd.Parameters.AddWithValue("@Department", textBox3.Text);
                    cmd.Parameters.AddWithValue("@overtime",textBox5.Text);
                    cmd.Parameters.AddWithValue("@medical", textBox6.Text);
                    cmd.Parameters.AddWithValue("@bonus", textBox7.Text);
                    cmd.Parameters.AddWithValue("@other", textBox8.Text);
                    cmd.Parameters.AddWithValue("@created_by", textBox1.Text);
                    cmd.Parameters.AddWithValue("@rate", textBox10.Text);
                    cmd.Parameters.AddWithValue("@total_allowance", textBox11.Text);
                    cmd.Parameters.AddWithValue("@Salary", textBox4.Text);
                    


                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data entered successfully");
                    con.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void allowance_Load(object sender, EventArgs e)
        {
            Dataview();
            textBox5.Text = "0";
            textBox6.Text = "0";
            textBox7.Text = "0";
            textBox8.Text = "0";
            textBox9.Text = "0";
            textBox10.Text = "0";
            textBox11.Text = "0";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            first.Text= "";
            sur.Text = "";
            textBox5.Text = "0";
            textBox6.Text = "0";
            textBox7.Text = "0";
            textBox8.Text = "0";
            textBox9.Text = "0";
            textBox10.Text = "0";
            textBox11.Text = "0";

        }
    }
}
