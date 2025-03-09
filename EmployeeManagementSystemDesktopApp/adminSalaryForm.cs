using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace EmployeeManagementSystemDesktopApp
{
    public partial class adminSalaryForm : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-IKLBTJP\SQLEXPRESS24;Initial Catalog=EmployeeManagementSystem;Integrated Security=True;TrustServerCertificate=True");

        
        public adminSalaryForm()
        {
            InitializeComponent();
            DisplayEmployeeSalaryData();
            DisableFields();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void DisplayEmployeeSalaryData()
        {
            SalaryData ed = new SalaryData();
            DataTable dt = ed.GetEmployeeSalaryData();

            if (dt.Rows.Count > 0)
            {
                dataGridView1.DataSource = null; // Reset DataGridView
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh(); // Ensure it refreshes
            }
            else
            {
                MessageBox.Show("No data found to display.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void salaryUpdateBtn_Click(object sender, EventArgs e)
        {
            if (salaryEmployeeID.Text == ""
                || salaryEmployeeName.Text == ""
                || salaryEmployeeePosition.Text == ""
                || salaryEmpoyee.Text == "")
            {
                MessageBox.Show("please fill in all the fields", "Error Message", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                DialogResult check = MessageBox.Show("Are you sure you want to UPDATE  Employee ID:" + salaryEmployeeID.Text.Trim() +
              "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (check == DialogResult.Yes)
                {

                    if (connect.State == ConnectionState.Closed)
                    {
                        try
                        {
                            connect.Open();
                            DateTime today = DateTime.Today;

                            // Get the salary from the input
                            decimal salary = Convert.ToDecimal(salaryEmpoyee.Text.Trim());

                            // Calculate deductions
                            decimal educationTax = salary * 0.025m; // 2.5% of salary
                            decimal nht = salary * 0.03m; // 3% of salary
                            decimal nis = salary * 0.05m; // 5% of salary

                            // Calculate net salary after deductions
                            decimal netSalary = salary - educationTax - nht - nis;

                            // Create and print Pay Slip
                            PaySlipPrinter paySlip = new PaySlipPrinter(
                                salaryEmployeeID.Text,
                                salaryEmployeeName.Text,
                                salaryEmployeeePosition.Text,
                                salary,
                                educationTax,
                                nht,
                                nis,
                                netSalary
                            );

                            paySlip.PrintPaySlip();

                            // Update the database with the new salary
                            string updateData = "UPDATE EmployeesInfo SET salary = @salary, net_salary = @netSalary, education_tax = @educationTax, nht = @nht, nis = @nis, update_date = @updateDate WHERE emp_id = @EmployeeID ";

                            using (SqlCommand cmd = new SqlCommand(updateData, connect))
                            {
                                cmd.Parameters.AddWithValue("@salary", salary);
                                cmd.Parameters.AddWithValue("@netSalary", netSalary);
                                cmd.Parameters.AddWithValue("@educationTax", educationTax);
                                cmd.Parameters.AddWithValue("@nht", nht);
                                cmd.Parameters.AddWithValue("@nis", nis);
                                cmd.Parameters.AddWithValue("@updateDate", today);
                                cmd.Parameters.AddWithValue("@EmployeeID", salaryEmployeeID.Text.Trim());

                                cmd.ExecuteNonQuery();

                                DisplayEmployeeSalaryData();

                                MessageBox.Show("Updated Successfully!", "Information Message", MessageBoxButtons.OK, 
                                    MessageBoxIcon.Information);

                                clearFields();
                            }

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK,
                                  MessageBoxIcon.Error);

                        }
                        finally
                        {
                            connect.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Cancelled", "Information Message", MessageBoxButtons.OK,
                             MessageBoxIcon.Warning);

                    }
                }
            }
        }
           
        private void salaryDataGridView_Paint(object sender, PaintEventArgs e)
        {

        }

        public void RefreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)RefreshData);
                return;
            }
            DisplayEmployeeSalaryData();
            DisableFields();
        }

        public void DisableFields()
        {
            salaryEmployeeID.Enabled = false;
            salaryEmployeeName.Enabled = false;
            salaryEmployeeePosition.Enabled = false;
            //salaryEmpoyee.Enabled = false;
        }

        public void clearFields()
        {
            salaryEmployeeID.Text = "";
            salaryEmployeeName.Text = "";
            salaryEmpoyee.Text = "";
            salaryEmployeeePosition.Text = "";
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Make sure to use correct field names in adminSalaryForm
                if (row.Cells.Count >= 4)
                {
                    salaryEmployeeID.Text = row.Cells["emp_id"].Value?.ToString() ?? "";  
                    salaryEmployeeName.Text = row.Cells["full_name"].Value?.ToString() ?? "";
                    salaryEmployeeePosition.Text = row.Cells["position"].Value?.ToString() ?? "";
                    salaryEmpoyee.Text = row.Cells["salary"].Value?.ToString() ?? "";
                    //cmbDepartment.SelectedItem = row.Cells[4].Value?.ToString() ?? "";
                    // cmbStatus.SelectedItem = row.Cells[5].Value?.ToString() ?? "";
                    // cmbRole.SelectedItem = row.Cells[6].Value?.ToString() ?? "";
                }
                else
                {
                    MessageBox.Show("Invalid row data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }


        }

        private void salaryEmployeeID_TextChanged(object sender, EventArgs e)
        {

        }

        private void generatePaySlipBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(salaryEmployeeID.Text) || string.IsNullOrEmpty(salaryEmployeeName.Text) ||
                string.IsNullOrEmpty(salaryEmployeeePosition.Text) || string.IsNullOrEmpty(salaryEmpoyee.Text))
            {
                MessageBox.Show("Please select an employee first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal salary = Convert.ToDecimal(salaryEmpoyee.Text.Trim());
            decimal educationTax = salary * 0.025m;
            decimal nht = salary * 0.03m;
            decimal nis = salary * 0.05m;
            decimal netSalary = salary - (educationTax + nht + nis);

            PaySlipPrinter paySlip = new PaySlipPrinter(
                salaryEmployeeID.Text, salaryEmployeeName.Text, salaryEmployeeePosition.Text,
                salary, educationTax, nht, nis, netSalary
            );

            paySlip.PrintPaySlip();
        }
    }
}

//name of of salary datagridview before change
//flowLayoutPanel1


//After change
//salaryDataGridView