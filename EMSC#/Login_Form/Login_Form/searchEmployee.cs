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
using System.IO;
using System.Drawing.Imaging;

namespace Login_Form
{
    public partial class searchEmployee : Form
    {
        public searchEmployee()
        {
            InitializeComponent();
        }
        
        DataSet ds;

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\EMSC#\Login_Form\Login_Form\Database1.mdf;Integrated Security=True");
        string Gender;
        
        
        private void Employee_id_TextChanged(object sender, EventArgs e)
        {

            con.Open();

            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter drd = new SqlDataAdapter("Select Emp_id,first_name,surname,Dob,Email,Telephone,Address1,Address2,Postal_Code,Department,Gender,Salary,Designation,Status,Image,Date_hired,Job_title from Employee_informations where Emp_id ='" + Employee_id.Text + "'", con);
            ds = new DataSet();
            drd.Fill(ds);

            if (ds.Tables[0].Rows.Count > 0)
            { 

                
            
                
                Empid_t1.Text = ds.Tables[0].Rows[0]["Emp_id"].ToString();
                first.Text = ds.Tables[0].Rows[0]["first_name"].ToString();
                sur.Text = ds.Tables[0].Rows[0]["surname"].ToString();
                textBox2.Text = ds.Tables[0].Rows[0]["Dob"].ToString();
                email_id.Text = ds.Tables[0].Rows[0]["Email"].ToString();
                cont.Text = ds.Tables[0].Rows[0]["Telephone"].ToString();
                add1.Text = ds.Tables[0].Rows[0]["Address1"].ToString();
                add2.Text = ds.Tables[0].Rows[0]["Address2"].ToString();
                postcode.Text = ds.Tables[0].Rows[0]["Postal_Code"].ToString();
                dept.Text = ds.Tables[0].Rows[0]["Department"].ToString();
                MemoryStream ms = new MemoryStream((byte[])ds.Tables[0].Rows[0]["Image"]);
                pictureBox1.Image = Image.FromStream(ms);

                pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                String gen = ds.Tables[0].Rows[0]["Gender"].ToString();
                if (gen == "Male")
                {
                    Male_radio.Checked = true;
                }
                else
                    Female_radio.Checked = true;
                sal.Text = ds.Tables[0].Rows[0]["Salary"].ToString();
                desig.Text = ds.Tables[0].Rows[0]["Designation"].ToString();
                status.Text = ds.Tables[0].Rows[0]["Status"].ToString();
                date.Text = ds.Tables[0].Rows[0]["Date_hired"].ToString();
                job_t.Text = ds.Tables[0].Rows[0]["Job_title"].ToString();
            }





            con.Close();

        }
        byte[] Convertimagetobinary(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }



        private void Addbt_Click(object sender, EventArgs e)
        {
            DialogResult drr = MessageBox.Show("Do You Want to add the record", "ADD", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);


            if (drr == DialogResult.OK)
            {
                con.Open();

                byte[] data = Convertimagetobinary(pictureBox1.Image);
                
                string query = "Update Employee_informations set Emp_id = @Emp_id,first_name = @first_name,surname=@surname,Dob=@Dob,Email=@Email,Telephone=@Telephone,Address1=@Address1,Address2=@Address2,Postal_Code=@Postal_Code,Department=@Department,Image=@Image,Gender=@Gender,Salary=@Salary,Designation=@Designation,Status=@Status,Date_hired=@Date_hired,Job_title=@Job_title Where Emp_id=@Emp_id";


                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Emp_id", Empid_t1.Text);
                cmd.Parameters.AddWithValue("@first_name", first.Text);
                cmd.Parameters.AddWithValue("@surname", sur.Text);
                cmd.Parameters.AddWithValue("@Dob", textBox2.Text);
                cmd.Parameters.AddWithValue("@Email", email_id.Text);
                cmd.Parameters.AddWithValue("@Salary", sal.Text);
                cmd.Parameters.AddWithValue("@Telephone", cont.Text);
                cmd.Parameters.AddWithValue("@Address1", add1.Text);
                cmd.Parameters.AddWithValue("@Address2", add2.Text);
                cmd.Parameters.AddWithValue("@Postal_code", postcode.Text);
                cmd.Parameters.AddWithValue("@Department", dept.Text);
                cmd.Parameters.AddWithValue("@Designation", desig.Text);
                cmd.Parameters.AddWithValue("@Status", status.Text);
                cmd.Parameters.AddWithValue("@Gender", Gender);
                cmd.Parameters.AddWithValue("@Image", data);
                cmd.Parameters.AddWithValue("@Date_hired", date.Text);
                cmd.Parameters.AddWithValue("@Job_title", job_t.Text);
                MessageBox.Show("You update is successfull");


                cmd.ExecuteNonQuery();
                con.Close();
            }
           
        }

        private void Male_radio_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Male";
        }

        private void Female_radio_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Female";
        }

        private void Clear_Click(object sender, EventArgs e)
        {

            Empid_t1.Clear();
           
            first.Clear();
            sur.Clear();
            sal.Clear();
            desig.Clear();
            dept.Clear();
            status.Clear();
            pictureBox1.Image = null;
            email_id.Clear();
            textBox2.Clear();
            add1.Clear();
            add2.Clear();
            date.Clear();
            postcode.Clear();
            cont.Clear();
            job_t.Clear();

        }
    }
            
            
}



            
           
       
    

