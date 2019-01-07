using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Data.SqlClient;

namespace Login_Form
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }


        string filename;
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\EMSC#\Login_Form\Login_Form\Database1.mdf;Integrated Security=True");



        private void Employee_bt_Click(object sender, EventArgs e)
        {
            Add_employee obj = new Add_employee();
            obj.Show();
        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_User obj = new Add_User();
            obj.Show();
        }

        private void AuditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void Allowance_Click(object sender, EventArgs e)
        {
            allowance all = new allowance();
            all.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            searchEmployee se = new searchEmployee();
            se.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            updateSalary up = new updateSalary();
            up.Show();
        }

        private void Deduction_Click(object sender, EventArgs e)
        {
            Deduction dec = new Deduction();
            dec.Show();
        }

        private void Pay_slip_Click(object sender, EventArgs e)
        {
            PaySlip py = new PaySlip();
            py.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("HH:MM:SS");
            label2.Text = DateTime.Now.ToShortDateString();
        }

        private void allowanceReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sav = new SaveFileDialog();
            sav.Filter = "pdf files (*.pdf)|*.pdf|All files (*.*)|*.*";
            if (sav.ShowDialog(this) == DialogResult.OK)
            {
                filename = sav.FileName;

            }
            string query = "select *  from Allowance";

            con.Open();

            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader rdr = cmd.ExecuteReader();
            Document myDocument = new Document();
            PdfPTable table = new PdfPTable(14);
            PdfWriter wri = PdfWriter.GetInstance(myDocument, new FileStream(sav.FileName, FileMode.Create));
            myDocument.Open();
            float[] widths = new float[] { 31, 48, 47, 35, 35, 39, 38, 36, 36, 36, 36, 26, 36,36 };
            table.SetWidths(widths);

            myDocument.Add(new Paragraph("Allowance List", FontFactory.GetFont(FontFactory.TIMES_BOLD, 20)));
            myDocument.Add(new Paragraph(DateTime.Now.ToString()));

            myDocument.Add(new Paragraph("-------------------------------------------------------------------------------------------"));
            table.AddCell(new PdfPCell(new Paragraph("Id", FontFactory.GetFont(FontFactory.TIMES_ROMAN, 9))));
            table.AddCell(new PdfPCell(new Paragraph("Emp_id", FontFactory.GetFont(FontFactory.TIMES_ROMAN, 9))));
            table.AddCell(new PdfPCell(new Paragraph("firstname", FontFactory.GetFont(FontFactory.TIMES_ROMAN, 9))));
            table.AddCell(new PdfPCell(new Paragraph("Surname", FontFactory.GetFont(FontFactory.TIMES_ROMAN, 9))));
            table.AddCell(new PdfPCell(new Paragraph("Department", FontFactory.GetFont(FontFactory.TIMES_ROMAN, 9))));
            table.AddCell(new PdfPCell(new Paragraph("Dob", FontFactory.GetFont(FontFactory.TIMES_ROMAN, 9))));
            table.AddCell(new PdfPCell(new Paragraph("overtime", FontFactory.GetFont(FontFactory.TIMES_ROMAN, 9))));
            table.AddCell(new PdfPCell(new Paragraph("medical", FontFactory.GetFont(FontFactory.TIMES_ROMAN, 9))));

            table.AddCell(new PdfPCell(new Paragraph("Bonus", FontFactory.GetFont(FontFactory.TIMES_ROMAN, 9))));
            table.AddCell(new PdfPCell(new Paragraph("other", FontFactory.GetFont(FontFactory.TIMES_ROMAN, 9))));
            table.AddCell(new PdfPCell(new Paragraph("created_by", FontFactory.GetFont(FontFactory.TIMES_ROMAN, 9))));
            table.AddCell(new PdfPCell(new Paragraph("rate", FontFactory.GetFont(FontFactory.TIMES_ROMAN, 9))));
            table.AddCell(new PdfPCell(new Paragraph("total_allowance", FontFactory.GetFont(FontFactory.TIMES_ROMAN, 9))));
            table.AddCell(new PdfPCell(new Paragraph("salary", FontFactory.GetFont(FontFactory.TIMES_ROMAN, 9))));

            try
            {
                while (rdr.Read())
                {


                    int id = (int)rdr["Id"];

                    table.AddCell(new PdfPCell(new Paragraph(Convert.ToString(id), FontFactory.GetFont(FontFactory.TIMES_ROMAN, 9))));
                    table.AddCell(new PdfPCell(new Paragraph((string)rdr["Emp_id"], FontFactory.GetFont(FontFactory.TIMES_ROMAN, 9))));
                    table.AddCell(new PdfPCell(new Paragraph((string)rdr["firstname"], FontFactory.GetFont(FontFactory.TIMES_ROMAN, 9))));
                    table.AddCell(new PdfPCell(new Paragraph((string)rdr["Surname"], FontFactory.GetFont(FontFactory.TIMES_ROMAN, 9))));
                    table.AddCell(new PdfPCell(new Paragraph((string)rdr["Department"], FontFactory.GetFont(FontFactory.TIMES_ROMAN, 9))));
                    table.AddCell(new PdfPCell(new Paragraph((string)rdr["Dob"], FontFactory.GetFont(FontFactory.TIMES_ROMAN, 9))));
                    table.AddCell(new PdfPCell(new Paragraph((string)rdr["overtime"], FontFactory.GetFont(FontFactory.TIMES_ROMAN, 9))));
                    table.AddCell(new PdfPCell(new Paragraph((string)rdr["medical"], FontFactory.GetFont(FontFactory.TIMES_ROMAN, 9))));
                    table.AddCell(new PdfPCell(new Paragraph((string)rdr["Bonus"], FontFactory.GetFont(FontFactory.TIMES_ROMAN, 9))));
                    table.AddCell(new PdfPCell(new Paragraph((string)rdr["other"], FontFactory.GetFont(FontFactory.TIMES_ROMAN, 9))));
                    table.AddCell(new PdfPCell(new Paragraph((string)rdr["created_by"], FontFactory.GetFont(FontFactory.TIMES_ROMAN, 9))));
                    table.AddCell(new PdfPCell(new Paragraph((string)rdr["rate"], FontFactory.GetFont(FontFactory.TIMES_ROMAN, 9))));
                    table.AddCell(new PdfPCell(new Paragraph((string)rdr["total_allowance"], FontFactory.GetFont(FontFactory.TIMES_ROMAN, 9))));
                    table.AddCell(new PdfPCell(new Paragraph((string)rdr["salary"], FontFactory.GetFont(FontFactory.TIMES_ROMAN, 9))));
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


            myDocument.Add(table);
            myDocument.Add(new Paragraph("--------------------------------------------------------------------------------------------"));
            MessageBox.Show("Pdf is saved successfully");
            myDocument.Close();




        }

        private void employeeReportToolStripMenuItem_Click(object sender, EventArgs e)
        {




            SaveFileDialog sav = new SaveFileDialog();
            sav.Filter = "pdf files (*.pdf)|*.pdf|All files (*.*)|*.*";
            if (sav.ShowDialog(this) == DialogResult.OK)
            {
                filename = sav.FileName;

            }
            string query = "select *  from Employee_informations";

            con.Open();

            SqlCommand cmd = new SqlCommand(query,con);
            SqlDataReader rdr = cmd.ExecuteReader();
            Document myDocument = new Document();
            PdfPTable table = new PdfPTable(13);
            PdfWriter wri = PdfWriter.GetInstance(myDocument, new FileStream(sav.FileName, FileMode.Create));
            myDocument.Open();
            float[] widths = new float[] { 31, 48, 47, 65, 65, 69, 68, 69, 36, 36, 36, 68, 68 };
            table.SetWidths(widths);

            myDocument.Add(new Paragraph("Employees List", FontFactory.GetFont(FontFactory.TIMES_BOLD, 20)));
            myDocument.Add(new Paragraph(DateTime.Now.ToString()));
            
            myDocument.Add(new Paragraph("-------------------------------------------------------------------------------------------"));
            try
            {
                while (rdr.Read())
                {

                   
                    table.AddCell(new PdfPCell(new Paragraph((string)rdr["Emp_id"], FontFactory.GetFont(FontFactory.TIMES_ROMAN, 9))));
                    table.AddCell(new PdfPCell(new Paragraph((string)rdr["first_name"], FontFactory.GetFont(FontFactory.TIMES_ROMAN, 9))));
                    table.AddCell(new PdfPCell(new Paragraph((string)rdr["Surname"], FontFactory.GetFont(FontFactory.TIMES_ROMAN, 9))));
                    table.AddCell(new PdfPCell(new Paragraph((string)rdr["Dob"], FontFactory.GetFont(FontFactory.TIMES_ROMAN, 9))));
                    table.AddCell(new PdfPCell(new Paragraph((string)rdr["Email"], FontFactory.GetFont(FontFactory.TIMES_ROMAN, 9))));
                    table.AddCell(new PdfPCell(new Paragraph((string)rdr["Telephone"], FontFactory.GetFont(FontFactory.TIMES_ROMAN, 9))));
                    table.AddCell(new PdfPCell(new Paragraph((string)rdr["Address1"], FontFactory.GetFont(FontFactory.TIMES_ROMAN, 9))));
                    table.AddCell(new PdfPCell(new Paragraph((string)rdr["Department"], FontFactory.GetFont(FontFactory.TIMES_ROMAN, 9))));
                    table.AddCell(new PdfPCell(new Paragraph((string)rdr["Gender"], FontFactory.GetFont(FontFactory.TIMES_ROMAN, 9))));
                    table.AddCell(new PdfPCell(new Paragraph((string)rdr["Salary"], FontFactory.GetFont(FontFactory.TIMES_ROMAN, 9))));
                    table.AddCell(new PdfPCell(new Paragraph((string)rdr["Status"], FontFactory.GetFont(FontFactory.TIMES_ROMAN, 9))));
                    table.AddCell(new PdfPCell(new Paragraph((string)rdr["Date_hired"], FontFactory.GetFont(FontFactory.TIMES_ROMAN, 9))));
                    table.AddCell(new PdfPCell(new Paragraph((string)rdr["Job_title"], FontFactory.GetFont(FontFactory.TIMES_ROMAN, 9))));
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


            myDocument.Add(table);
            myDocument.Add(new Paragraph("--------------------------------------------------------------------------------------------"));
            MessageBox.Show("Pdf is saved successfully");
            myDocument.Close();



        }

        private void deductionReportToolStripMenuItem_Click(object sender, EventArgs e)
        {




            SaveFileDialog sav = new SaveFileDialog();
            sav.Filter = "pdf files (*.pdf)|*.pdf|All files (*.*)|*.*";
            if (sav.ShowDialog(this) == DialogResult.OK)
            {
                filename = sav.FileName;

            }
            string qquery = "select *  from Deduction";

            con.Open();

            SqlCommand cmd = new SqlCommand(qquery, con);
            SqlDataReader rdr = cmd.ExecuteReader();
            Document myDocument = new Document();
            PdfPTable table = new PdfPTable(8);
            PdfWriter wri = PdfWriter.GetInstance(myDocument, new FileStream(sav.FileName, FileMode.Create));
            myDocument.Open();
            float[] widths = new float[] { 31, 48, 47, 35, 35, 39, 38, 39 };
            table.SetWidths(widths);

            myDocument.Add(new Paragraph("Deduction List", FontFactory.GetFont(FontFactory.TIMES_BOLD, 20)));
            myDocument.Add(new Paragraph(DateTime.Now.ToString()));
            myDocument.Add(new Paragraph("-------------------------------------------------------------------------------------------"));
            table.AddCell(new PdfPCell(new Paragraph("Id", FontFactory.GetFont(FontFactory.TIMES_ROMAN, 9))));
            table.AddCell(new PdfPCell(new Paragraph("Emp_id", FontFactory.GetFont(FontFactory.TIMES_ROMAN, 9))));
            table.AddCell(new PdfPCell(new Paragraph("firstname", FontFactory.GetFont(FontFactory.TIMES_ROMAN, 9))));
            table.AddCell(new PdfPCell(new Paragraph("Surname", FontFactory.GetFont(FontFactory.TIMES_ROMAN, 9))));
            table.AddCell(new PdfPCell(new Paragraph("Deduction_amount", FontFactory.GetFont(FontFactory.TIMES_ROMAN, 9))));
            table.AddCell(new PdfPCell(new Paragraph("Reason", FontFactory.GetFont(FontFactory.TIMES_ROMAN, 9))));
            table.AddCell(new PdfPCell(new Paragraph("Made_by", FontFactory.GetFont(FontFactory.TIMES_ROMAN, 9))));
            table.AddCell(new PdfPCell(new Paragraph("salary", FontFactory.GetFont(FontFactory.TIMES_ROMAN, 9))));




            try
            {
                while (rdr.Read())
                {



                    int id = (int)rdr["Id"];

                    table.AddCell(new PdfPCell(new Paragraph(Convert.ToString(id), FontFactory.GetFont(FontFactory.TIMES_ROMAN, 9))));
                    table.AddCell(new PdfPCell(new Paragraph((string)rdr["Emp_id"], FontFactory.GetFont(FontFactory.TIMES_ROMAN, 9))));
                    table.AddCell(new PdfPCell(new Paragraph((string)rdr["firstname"], FontFactory.GetFont(FontFactory.TIMES_ROMAN, 9))));
                    table.AddCell(new PdfPCell(new Paragraph((string)rdr["Surname"], FontFactory.GetFont(FontFactory.TIMES_ROMAN, 9))));
                    table.AddCell(new PdfPCell(new Paragraph((string)rdr["Deduction_amount"], FontFactory.GetFont(FontFactory.TIMES_ROMAN, 9))));
                    table.AddCell(new PdfPCell(new Paragraph((string)rdr["Reason"], FontFactory.GetFont(FontFactory.TIMES_ROMAN, 9))));
                    table.AddCell(new PdfPCell(new Paragraph((string)rdr["Made_by"], FontFactory.GetFont(FontFactory.TIMES_ROMAN, 9))));
                    table.AddCell(new PdfPCell(new Paragraph((string)rdr["salary"], FontFactory.GetFont(FontFactory.TIMES_ROMAN, 9))));
                    
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


            myDocument.Add(table);
            myDocument.Add(new Paragraph("--------------------------------------------------------------------------------------------"));
            MessageBox.Show("Pdf is saved successfully");
            myDocument.Close();


        }
    }
}
