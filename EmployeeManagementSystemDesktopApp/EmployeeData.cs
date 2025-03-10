﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EmployeeManagementSystemDesktopApp
{
    public class EmployeeData
    {
        private readonly string connectionString = @"Data Source=DESKTOP-IKLBTJP\SQLEXPRESS24;Initial Catalog=EmployeeManagementSystem;Integrated Security=True;TrustServerCertificate=True";

        public DataTable GetEmployeeData()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connect = new SqlConnection(connectionString))
                {
                    string query = "SELECT emp_id, full_name, gender, contact_number, department, status, position, insert_date FROM EmployeesInfo WHERE delete_date IS NULL";
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connect))
                    {
                        connect.Open();
                        adapter.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dt;
        }

    }
}
