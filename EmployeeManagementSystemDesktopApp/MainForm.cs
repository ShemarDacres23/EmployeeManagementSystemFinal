using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagementSystemDesktopApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure you want to exit?", "Confirmation Message", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Form1 loginForm = new Form1();
                loginForm.Show();
                this.Hide();
                Application.Exit();
            }


        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            adminDashBoard1.Visible = true;
            adminAddEmployee1.Visible = false;
            adminSalaryForm1.Visible = false;
            */
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void logout_Btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Confirmation Message", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Form1 loginForm = new Form1();
                loginForm.Show();

                this.Hide();
                
            }
        }

        private void salaryBtn_Click(object sender, EventArgs e)
        {
            
            adminDashBoard1.Visible = false;
            adminAddEmployee1.Visible = false;
            adminSalaryForm1.Visible = true;
            
        }

        private void addEmployeeBtn_Click_1(object sender, EventArgs e)
        {
            
            adminDashBoard1.Visible = false;
            adminAddEmployee1.Visible = true;
            adminSalaryForm1.Visible = false;
            
        }

        private void salaryBtn_Click_1(object sender, EventArgs e)
        {
            adminDashBoard1.Visible = false;
            adminAddEmployee1.Visible = false;
            adminSalaryForm1.Visible = true;
        }
    }
}
