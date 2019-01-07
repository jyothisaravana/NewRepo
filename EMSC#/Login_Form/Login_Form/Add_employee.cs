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
    public partial class Add_employee : Form
    {
        public Add_employee()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\EMSC#\Login_Form\Login_Form\Database1.mdf;Integrated Security=True");
        string Gender;
        string value1;
        string value2;
        string value3;
        string value4;
        string result;
        string q;
        
        
        string filename;
        int count;
        int count1;
        private void Add_employee_Load(object sender, EventArgs e)
        {

            Autogenerate();
            
            
           



        }
        void Autogenerate()
        {
            string str = "Select count(Emp_id) from Employee_informations";
            SqlCommand cmd = new SqlCommand(str, con);
            con.Open();
            count = Convert.ToInt32(cmd.ExecuteScalar()) + 1;
            if (count >= 1 && count <= 9)
            {
                Empid_t1.Text = "E00" + count.ToString();
            }
            else if(count>=10 && count <=99)
            {
                Empid_t1.Text = "E0" + count.ToString();
            }
            else if (count >= 100 && count <= 999)
            {
                Empid_t1.Text = "E" + count.ToString();
            }

            Empid_t1.Enabled = false;
            con.Close();

        }
        void Autogenerate2()
        {
            con.Open();
            string str = "Select count(Id) from Users";
            SqlCommand cmd = new SqlCommand(str, con);
            count1 = Convert.ToInt32(cmd.ExecuteScalar()) + 1;
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

       
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            // image filters  
            openFileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            
           if (openFileDialog.ShowDialog(this) == DialogResult.OK)
           {
                    try
                    {

                       filename = openFileDialog.FileName;
                       pictureBox1.Image = Image.FromFile(filename);
                       pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                            
                            //MessageBox.Show(myStream.Length.ToString());
                        
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Error: Could not read file from disk. error: " + ex.Message);

                    }
           }


            
        }

        

        private void Addbt_Click(object sender, EventArgs e)
        {
            DialogResult drr = MessageBox.Show("Do You Want to add the record", "ADD", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            
           
                if (drr == DialogResult.OK)
                {
                    con.Open();

                   byte[] data = Convertimagetobinary(pictureBox1.Image);
                  
                  q = "insert into Employee_informations(Emp_id,first_name,surname,Dob,Email,Telephone,Address1,Address2,Postal_Code,Department,Image,Gender,Salary,Designation,Status,Date_hired,Job_title) values(@Emp_id,@first_name,@surname,@Dob,@Email,@Telephone,@Address1,@Address2,@Postal_Code,@Department,@Image,@Gender,@Salary,@Designation,@Status,@Date_hired,@Job_title);";
                
                   


                 SqlCommand cmd = new SqlCommand(q, con);
                 cmd.Parameters.AddWithValue("@Emp_id",Empid_t1.Text);
                 cmd.Parameters.AddWithValue("@first_name", first.Text);
                 cmd.Parameters.AddWithValue("@surname", sur.Text);
                 cmd.Parameters.AddWithValue("@Dob", textBox1.Text);
                 cmd.Parameters.AddWithValue("@Email",email_id.Text);
                 cmd.Parameters.AddWithValue("@Salary", sal.Text);
                 cmd.Parameters.AddWithValue("@Telephone", cont.Text);
                 cmd.Parameters.AddWithValue("@Address1", add1.Text);
                 cmd.Parameters.AddWithValue("@Address2", add2.Text);
                 cmd.Parameters.AddWithValue("@Postal_code",postcode.Text);
                 cmd.Parameters.AddWithValue("@Department", dept.Text);
                 cmd.Parameters.AddWithValue("@Designation", desig.Text);
                 cmd.Parameters.AddWithValue("@Status", status.Text);
                 cmd.Parameters.AddWithValue("@Gender", Gender);
                 cmd.Parameters.AddWithValue("@Image", data);
                 cmd.Parameters.AddWithValue("@Date_hired", date.Text);
                 cmd.Parameters.AddWithValue("@Job_title", job_t.Text);












                  cmd.ExecuteNonQuery();
                    MessageBox.Show("Data entered successfully");
                    con.Close();
                }
            
            

            
            con.Open();
            string query2 = "select Emp_id,first_name,Dob ,Designation from Employee_informations";
             
            SqlCommand cmd1 = new SqlCommand(query2, con);
            SqlDataReader dr = cmd1.ExecuteReader();
            try
            {
                while (dr.Read())
                {
                    value1 = (string)dr["first_name"];
                    value2 = (string)dr["Emp_id"];
                    value3 = (string)dr["Dob"];
                    result = value3.Replace("/","");
                    value4 = (string)dr["Designation"];
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);

            }
            finally
            {
                if (dr != null)

                    dr.Close();
            }
           
            cmd1.ExecuteNonQuery();

            con.Close();

            Autogenerate2();


            con.Open();
            string query3 = "insert into Users(Id,username,password,division,Emp_id) values('"+count1+"','" + value1 + "','" + result+ "','" + value4 + "','" + value2 + "')";
            SqlCommand cmd2 = new SqlCommand(query3, con);
            cmd2.ExecuteNonQuery();
            MessageBox.Show("Your data as been successfully entered,Username:" + value1 + "password:" + result);
            
             con.Close();


         







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
            Autogenerate();
            first.Clear();
            sur.Clear();
            sal.Clear();
            desig.Clear();
            dept.Clear();
            status.Clear();
            pictureBox1.Image = null;
            email_id.Clear();
            textBox1.Clear();
            add1.Clear();
            add2.Clear();
            date.Clear();
            postcode.Clear();
            cont.Clear();
            job_t.Clear();





        }
    }
}
