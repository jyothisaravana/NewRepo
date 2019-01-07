using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Form
{
    public partial class Main_Menu : Form
    {
        public Main_Menu()
        {
            InitializeComponent();
        }

        private void Employee_bt_Click(object sender, EventArgs e)
        {
            Add_employee obj = new Add_employee();
            obj.Show();
        }

        private void Allowance_Click(object sender, EventArgs e)
        {
            allowance all = new allowance();
            all.Show();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            searchEmployee se = new searchEmployee();
            se.Show();
        }

        private void Update_Click(object sender, EventArgs e)
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

        private void Main_Menu_Load(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("HH:MM:SS");
            label2.Text = DateTime.Now.ToShortDateString();
        }
    }
}
