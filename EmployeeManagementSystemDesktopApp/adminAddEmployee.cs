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
using System.Threading;


namespace EmployeeManagementSystemDesktopApp
{
    public partial class adminAddEmployee : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-IKLBTJP\SQLEXPRESS24;Initial Catalog=EmployeeManagementSystem;Integrated Security=True;TrustServerCertificate=True");
        public adminAddEmployee()
        {
            InitializeComponent();

            //Display Employee Info on DatGRid
            DisplayEmployeeData();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }



        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void RefreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)RefreshData);
                return;
            }
            DisplayEmployeeData();
        }

        public void DisplayEmployeeData()
        {

            EmployeeData ed = new EmployeeData();
            DataTable dt = ed.GetEmployeeData();

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


        public void clearFields()
        {
            addEmployee_ID.Text = "";
            EmployeeName.Text = "";
            addEmployee_Gender.SelectedIndex = -1;
            addEmployeePhoneNumber.Text = "";
            EmployeeRole.SelectedIndex = -1;
            EmployeeStatus.SelectedIndex = -1;
            adEmployee_Department.SelectedItem = -1;

        }
        private void addEmployeeBtn_Click(object sender, EventArgs e)
        {
            if (addEmployee_ID.Text == ""
                || EmployeeName.Text == ""
                || addEmployee_Gender.Text == ""
                || addEmployeePhoneNumber.Text == ""
                || EmployeeRole.Text == ""
                || EmployeeStatus.Text == ""
                || adEmployee_Department.SelectedItem == null)
            {

                MessageBox.Show("Please fill all blank fields",
                    "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State == ConnectionState.Closed)
                {
                    try
                    {
                        connect.Open();
                        string checkEmpID = "SELECT COUNT(*) FROM EmployeesInfo WHERE emp_id = @empID";


                        using (SqlCommand checkEm = new SqlCommand(checkEmpID, connect))
                        {

                            checkEm.Parameters.AddWithValue("@empID", addEmployee_ID.Text.Trim());


                            int count = (int)checkEm.ExecuteScalar();

                            if (count >= 1)
                            {
                                MessageBox.Show(addEmployee_ID.Text.Trim() + " is already taken",
                                 "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                DateTime today = DateTime.Today;
                                string insertData = "INSERT INTO EmployeesInfo" +
                                    "(full_name, gender, contact_number" +
                                    ", position, department, salary, status, insert_date)" +
                                    "VALUES(@fullname, @gender, @contactNum" +
                                    ", @position, @department, @salary, @status, @insertDate)";



                                using (SqlCommand insertCmd = new SqlCommand(insertData, connect))
                                {

                                    //insertCmd.Parameters.AddWithValue("@employeeID", addEmployee_ID.Text.Trim());
                                    insertCmd.Parameters.AddWithValue("@fullname", EmployeeName.Text.Trim());
                                    insertCmd.Parameters.AddWithValue("@gender", addEmployee_Gender.SelectedItem?.ToString() ?? "");
                                    insertCmd.Parameters.AddWithValue("@contactNum", addEmployeePhoneNumber.Text.Trim());
                                    insertCmd.Parameters.AddWithValue("@position", EmployeeRole.SelectedItem?.ToString() ?? "");
                                    insertCmd.Parameters.AddWithValue("@department", adEmployee_Department.ToString() ?? "");
                                    insertCmd.Parameters.AddWithValue("@status", EmployeeStatus.SelectedItem?.ToString() ?? "");
                                    insertCmd.Parameters.AddWithValue("@salary", 0);
                                    insertCmd.Parameters.AddWithValue("@insertDate", today); // Set insert date automatically

                                    insertCmd.ExecuteNonQuery();


                                    MessageBox.Show("Added successfully!",
                                    " Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    clearFields();

                                    // Refresh the DataGridView with inserted data
                                    DisplayEmployeeData();

                                }

                            }
                        }
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex,
                    "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }


        private void DataGridView_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void updateemployeeBtn_Click(object sender, EventArgs e)
        {
            if (addEmployee_ID.Text == ""
               || EmployeeName.Text == ""
               || addEmployee_Gender.SelectedItem == null
               || addEmployeePhoneNumber.Text == ""
               || EmployeeRole.SelectedItem == null
               || EmployeeStatus.SelectedItem == null
               || adEmployee_Department.SelectedItem == null)
            {

                MessageBox.Show("Please fill all blank fields",
                    "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult check = MessageBox.Show("Are you sure you want to UPDATE " +
                    "Employee ID: " + addEmployee_ID.Text.Trim() + "?", "Confirmation Message", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Information);

                if (check == DialogResult.Yes)
                {
                    try
                    {
                        connect.Open();
                        DateTime today = DateTime.Today;

                        string updateData = "UPDATE EmployeesInfo SET full_name = @fullname, gender = @gender, " +
                            "contact_number = @contactNum, position = @position, department = @department " +
                            ", update_date = @updatedate, status = @status WHERE emp_id = @empID";

                        using (SqlCommand cmd = new SqlCommand(updateData, connect))
                        {
                            cmd.Parameters.AddWithValue("@fullname", EmployeeName.Text.Trim());
                            cmd.Parameters.AddWithValue("@gender", addEmployee_Gender.SelectedItem?.ToString() ?? "");
                            cmd.Parameters.AddWithValue("@contactNum", addEmployeePhoneNumber.Text.Trim());
                            cmd.Parameters.AddWithValue("@position", EmployeeRole.SelectedItem?.ToString() ?? "");
                            cmd.Parameters.AddWithValue("@department", adEmployee_Department.Text.Trim() ?? "");
                            cmd.Parameters.AddWithValue("@updatedate", today);
                            cmd.Parameters.AddWithValue("@status", EmployeeStatus.SelectedItem?.ToString() ?? "");
                            cmd.Parameters.AddWithValue("@empID", addEmployee_ID.Text.Trim());

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Updated successfully!",
                                    "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            clearFields();

                            // Refresh the DataGridView with updated data
                            DisplayEmployeeData();
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex,
                       "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
                else
                {
                    MessageBox.Show("cacelled!",
                      "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void deleteemployeeBtn_Click(object sender, EventArgs e)
        {
            if (addEmployee_ID.Text == ""
               || EmployeeName.Text == ""
               || addEmployee_Gender.SelectedItem == null
               || addEmployeePhoneNumber.Text == ""
               || EmployeeRole.SelectedItem == null
               || EmployeeStatus.SelectedItem == null
               || adEmployee_Department.SelectedItem == null)
            {

                MessageBox.Show("Please fill all blank fields",
                    "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult check = MessageBox.Show("Are you sure you want to DELETE " +
                    "Employee ID: " + addEmployee_ID.Text.Trim() + "?", "Confirmation Message", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Information);

                if (check == DialogResult.Yes)
                {
                    try
                    {
                        connect.Open();
                        DateTime today = DateTime.Today;

                        string updateData = "UPDATE EmployeesInfo SET delete_date = @deleteDate " + "WHERE emp_id = @empID";

                        using (SqlCommand cmd = new SqlCommand(updateData, connect))
                        {

                            cmd.Parameters.AddWithValue("@deleteDate", today);
                            cmd.Parameters.AddWithValue("@empID", addEmployee_ID.Text.Trim());

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Deleted successfully!",
                                    "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            clearFields();

                            // Refresh the DataGridView with deleted data
                            DisplayEmployeeData();
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex,
                       "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
                else
                {
                    MessageBox.Show("cacelled!",
                      "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

    
        
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure the click is on a valid row and not the header row
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Ensure the row has enough cells to prevent index out of range errors
                if (row.Cells.Count >= 8) // Adjust this number based on the number of columns
                {
                    addEmployee_ID.Text = row.Cells[0].Value?.ToString() ?? "";
                    EmployeeName.Text = row.Cells[1].Value?.ToString() ?? "";
                    addEmployee_Gender.SelectedItem = row.Cells[2].Value?.ToString() ?? "";
                    addEmployeePhoneNumber.Text = row.Cells[3].Value?.ToString() ?? "";
                    adEmployee_Department.SelectedItem = row.Cells[4].Value?.ToString() ?? "";       
                    EmployeeStatus.SelectedItem = row.Cells[5].Value?.ToString() ?? "";
                    EmployeeRole.SelectedItem = row.Cells[6].Value?.ToString() ?? "";
                }
                else
                {
                    MessageBox.Show("Invalid row data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void EmployeeStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addEmployee_ID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
