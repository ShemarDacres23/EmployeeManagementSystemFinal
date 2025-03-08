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
    public partial class adminDashBoard : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-IKLBTJP\SQLEXPRESS24;Initial Catalog=EmployeeManagementSystem;Integrated Security=True;TrustServerCertificate=True");
        public adminDashBoard()
        {
            InitializeComponent();

            DisplayTotalEmployees();

            DisplayActiveEmployees();

            DisplayInactiveEmployees();
        }

        public void RefreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)RefreshData);
                return;

            }
            DisplayTotalEmployees();

            DisplayActiveEmployees();

            DisplayInactiveEmployees();
        }


        public void DisplayTotalEmployees()
        {
            if(connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT COUNT (emp_id) FROM EmployeesInfo WHERE delete_date IS NULL";

                    using(SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        if(reader.Read())
                        {
                            int count = Convert.ToInt32(reader[0]);
                            dashboard_TotalEmp.Text = count.ToString();
                        }
                        reader.Close();
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
        }

        public void DisplayActiveEmployees()
        {
            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT COUNT (emp_id) FROM EmployeesInfo WHERE status = @status AND delete_date IS NULL";


                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        cmd.Parameters.AddWithValue("@status", "Active");
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            int count = Convert.ToInt32(reader[0]);
                            dashboard_ActiveEmp.Text = count.ToString();
                        }
                        reader.Close();
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
        }

        public void DisplayInactiveEmployees()
        {
            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT COUNT (emp_id) FROM EmployeesInfo WHERE status = @status AND delete_date IS NULL";


                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        cmd.Parameters.AddWithValue("@status", "Inactive");
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            int count = Convert.ToInt32(reader[0]);
                            dashboard_InactiveEmp.Text = count.ToString();
                        }
                        reader.Close();
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
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dashboard_TotalEmp_Click(object sender, EventArgs e)
        {

        }
    }
}
