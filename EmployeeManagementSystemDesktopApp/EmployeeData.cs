using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace EmployeeManagementSystemDesktopApp
{
    
    class EmployeeData
    {
        public int ID { set; get; } //1
        public string EmployeeID { set; get; } //1
        public string Name { set; get; } //2
        public string Gender { set; get; } //3
        public string ContactNumber { set; get; } //4
        public string Position { set; get; } //5
        public int Salary { set; get; } //6
        public string Status { set; get; } //7

        SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-IKLBTJP\SQLEXPRESS24;Initial Catalog=EmployeeManagementSystem;Integrated Security=True;TrustServerCertificate=True");


        public List<EmployeeData> EmployeeListData()
        {
            List<EmployeeData> listDatas = new List<EmployeeData>();

            if(connect.State != System.Data.ConnectionState.Open)
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT * FROM EmployeesInfo WHERE delete_date IS NULL";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            EmployeeData ed = new EmployeeData()
                            {
                                ID = (int)reader["ID"],
                                EmployeeID = reader["emp_id"].ToString(),
                                Name = reader["full_name"].ToString(),
                                Gender = reader["gender"].ToString(),
                                ContactNumber = reader["contact_number"].ToString(),
                                Position = reader["position"].ToString(),
                                Salary = (int)reader["salary"],
                                Status = reader["status"].ToString()
                            };
                       

                            listDatas.Add(ed);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex);
                }
                finally
                {
                    connect.Close();
                }
            }
            return listDatas;
        }

    }
}
