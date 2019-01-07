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
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace Login_Form
{
    public partial class PaySlip : Form
    {
        public PaySlip()
        {
            InitializeComponent();
        }

        
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\EMSC#\Login_Form\Login_Form\Database1.mdf;Integrated Security=True");
        string filename;
        string value2;
        int value;
        int sval;
        double val;
        int v;
        double total;
        int ovr;
        int medi;
        int bonus;
        int others;

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

        private void Pay_Click(object sender, EventArgs e)
        {
            
            
            try
            {
                con.Open();
                string q = "Select * from Deduction where Emp_id='" + Employee_txt.Text + "'";
                SqlCommand cmd = new SqlCommand(q, con);
                SqlDataReader rd = cmd.ExecuteReader();
                try
                {


                    while (rd.Read())
                    {
                         value = Convert.ToInt32((string)rd["Deduction_amount"]);
                         value2 = (string)rd["Reason"];
                    }



                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:" + ex.Message);
                }
                finally
                {
                    MessageBox.Show("DOne");
                    if (rd != null)
                    {
                        rd.Close();

                    }
                }
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }



            try
            {


                con.Open();
                string q = "Select * from Allowance where Emp_id='" + Employee_txt.Text + "'";
                SqlCommand cmd = new SqlCommand(q, con);
                SqlDataReader rdr = cmd.ExecuteReader();


                try
                {

                    while (rdr.Read())
                    {

                        ovr = Convert.ToInt32((string)rdr["overtime"]);
                        medi = Convert.ToInt32((string)rdr["medical"]);
                        bonus = Convert.ToInt32((string)rdr["bonus"]);
                        others = Convert.ToInt32((string)rdr["other"]);
                        sval = Convert.ToInt32(textBox4.Text);
                        string val2 = (string)rdr["total_allowance"];
                        val = Convert.ToDouble(val2);
                        v = value;
                        total = sval + val - v;



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
            catch (Exception ex)
            {

                MessageBox.Show("Error:" + ex.Message);
            }

          
            SaveFileDialog sav = new SaveFileDialog();
            sav.Filter = "pdf files (*.pdf)|*.pdf|All files (*.*)|*.*";
            if ( sav.ShowDialog(this) == DialogResult.OK)
           {
                filename = sav.FileName;

           }
            Document doc = new Document();
            
            PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream(sav.FileName, FileMode.Create));
            doc.Open();

               doc.Add(new Paragraph("PaySlip", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16f)));
              doc.Add(new Paragraph(DateTime.Now.ToString()));

            doc.Add(new Paragraph("PaySlip", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16f)));
                doc.Add(new Paragraph("-------------------------------------------------------------------------------------------"));
            doc.Add(new Paragraph("EMPLOYEE DETAILS", FontFactory.GetFont(FontFactory.TIMES_ROMAN, 15f)));
            doc.Add(new Paragraph("Name of Employee: " + first.Text + " " + sur.Text, FontFactory.GetFont(FontFactory.TIMES_ROMAN, 10f)));
           
            doc.Add(new Paragraph("Department: " + textBox3.Text, FontFactory.GetFont(FontFactory.TIMES_ROMAN, 10f)));
            doc.Add(new Paragraph("-------------------------------------------------------------------------------------------"));
            doc.Add(new Paragraph("SALARY", FontFactory.GetFont(FontFactory.TIMES_ROMAN, 15)));
            doc.Add(new Paragraph("Basic Salary: $" +textBox4.Text , FontFactory.GetFont(FontFactory.TIMES_ROMAN, 10)));
            doc.Add(new Paragraph("Overtime: " + ovr + " Hours", FontFactory.GetFont(FontFactory.TIMES_ROMAN, 10)));
            doc.Add(new Paragraph("Medical: $" + medi, FontFactory.GetFont(FontFactory.TIMES_ROMAN, 10)));
            doc.Add(new Paragraph("Bonus: $" + bonus, FontFactory.GetFont(FontFactory.TIMES_ROMAN, 10)));
            doc.Add(new Paragraph("Other: $" + others, FontFactory.GetFont(FontFactory.TIMES_ROMAN, 10)));
            doc.Add(new Paragraph("-------------------------------------------------------------------------------------------"));
            doc.Add(new Paragraph("DEDUCTION", FontFactory.GetFont(FontFactory.TIMES_BOLD, 15)));
            doc.Add(new Paragraph("Deduction Details: " +value2 , FontFactory.GetFont(FontFactory.TIMES_ROMAN, 10)));
            doc.Add(new Paragraph("Total Deductions : $" + value, FontFactory.GetFont(FontFactory.TIMES_ROMAN, 10)));
            doc.Add(new Paragraph("-------------------------------------------------------------------------------------------"));
            doc.Add(new Paragraph("TOTAL PAYMENT", FontFactory.GetFont(FontFactory.TIMES_BOLD, 15)));
            doc.Add(new Paragraph("Total Earnings: " + val, FontFactory.GetFont(FontFactory.TIMES_ROMAN, 10)));
            doc.Add(new Paragraph("Net Pay : " + total, FontFactory.GetFont(FontFactory.TIMES_ROMAN, 10)));
            doc.Add(new Paragraph("-------------------------------------------------------------------------------------------"));
            doc.NewPage();
            doc.Close();

           





        }
    }
}
