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

        //RETURN TO LATER

        public void DisplayEmployeeData()
        {

            EmployeeData ed = new EmployeeData();
            List<EmployeeData> listDatas = ed.EmployeeListData();

            if (listDatas.Count > 0)
            {
                //dataGridView1.DataSource = listDatas;
                dataGridView1.DataSource = null; // Reset DataGridView
                dataGridView1.DataSource = listDatas;
                dataGridView1.Refresh(); // Ensure it refreshes
            }
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

        }
        private void addEmployeeBtn_Click(object sender, EventArgs e)
        {
            if (addEmployee_ID.Text == ""
                || EmployeeName.Text == ""
                || addEmployee_Gender.Text == ""
                || addEmployeePhoneNumber.Text == ""
                || EmployeeRole.Text == ""
                || EmployeeStatus.Text == "")
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
                                    ", position, salary, status, insert_date)" +
                                    "VALUES(@fullname, @gender, @contactNum" +
                                    ", @position,@salary, @status, @insertDate)";



                                using (SqlCommand insertCmd = new SqlCommand(insertData, connect))
                                {

                                    //insertCmd.Parameters.AddWithValue("@employeeID", addEmployee_ID.Text.Trim());
                                    insertCmd.Parameters.AddWithValue("@fullname", EmployeeName.Text.Trim());
                                    insertCmd.Parameters.AddWithValue("@gender", addEmployee_Gender.SelectedItem?.ToString() ?? "");
                                    insertCmd.Parameters.AddWithValue("@contactNum", addEmployeePhoneNumber.Text.Trim());
                                    insertCmd.Parameters.AddWithValue("@position", EmployeeRole.SelectedItem?.ToString() ?? "");
                                    insertCmd.Parameters.AddWithValue("@status", EmployeeStatus.SelectedItem?.ToString() ?? "");
                                    insertCmd.Parameters.AddWithValue("@salary", 0);
                                    insertCmd.Parameters.AddWithValue("@insertDate", today); // Set insert date automatically

                                    insertCmd.ExecuteNonQuery();


                                    MessageBox.Show("Added successfully!",
                                    " Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    clearFields();
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
               || EmployeeStatus.SelectedItem == null)
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
                            "contact_number = @contactNum, position = @position, " +
                            "update_date = @updatedate, status = @status WHERE emp_id = @empID";

                        using (SqlCommand cmd = new SqlCommand(updateData, connect))
                        {
                            cmd.Parameters.AddWithValue("@fullname", EmployeeName.Text.Trim());
                            cmd.Parameters.AddWithValue("@gender", addEmployee_Gender.SelectedItem?.ToString() ?? "");
                            cmd.Parameters.AddWithValue("@contactNum", addEmployeePhoneNumber.Text.Trim());
                            cmd.Parameters.AddWithValue("@position", EmployeeRole.SelectedItem?.ToString() ?? "");
                            cmd.Parameters.AddWithValue("@updatedate", today);
                            cmd.Parameters.AddWithValue("@status", EmployeeStatus.SelectedItem?.ToString() ?? "");
                            cmd.Parameters.AddWithValue("@empID", addEmployee_ID.Text.Trim());

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Updated successfully!",
                                    "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            clearFields();
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
               || EmployeeStatus.SelectedItem == null)
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
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                addEmployee_ID.Text = row.Cells[1].Value.ToString();
                EmployeeName.Text = row.Cells[2].Value.ToString();
                addEmployee_Gender.Text = row.Cells[3].Value.ToString();
                addEmployeePhoneNumber.Text = row.Cells[4].Value.ToString();
                EmployeeRole.Text = row.Cells[7].Value.ToString();
                adEmployee_Department.Text = row.Cells[5].Value.ToString();
                EmployeeStatus.Text = row.Cells[6].Value.ToString();

            }
        }
    }
}
