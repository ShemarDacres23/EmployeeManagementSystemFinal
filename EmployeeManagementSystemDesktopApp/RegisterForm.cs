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
    public partial class RegisterForm : Form
    {
        //DATABASE
        SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-IKLBTJP\SQLEXPRESS24;Initial Catalog=EmployeeManagementSystem;Integrated Security=True;TrustServerCertificate=True"); //DATABASE CONNECTION
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void signup_loginBtn_Click(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1();
            loginForm.Show();
            this.Hide();
        }

        private void signup_showPass_CheckedChanged(object sender, EventArgs e)
        {
            signup_password.PasswordChar = signup_showPass.Checked ? '\0' : '*';
        }

        //CONNECTS DATABASE LOGIN FOR THE REGISTRATION
        private void signup_btn_Click(object sender, EventArgs e)
        {
            if(signup_username.Text == "" || signup_password.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                if (connect.State != ConnectionState.Open)
                {
                    try
                    {
                        //DATABASE LOGIN
                        connect.Open();

                        //TO CHECK IF USER EXIST ALREADY
                        string selectUsername = "SELECT COUNT (EmployeeID) FROM Employees WHERE Username = @user";

                        using (SqlCommand checkUser = new SqlCommand(selectUsername, connect))
                        {
                            checkUser.Parameters.AddWithValue("@user", signup_username.Text.Trim());
                            int count = (int) checkUser.ExecuteScalar();

                            if (count >= 1) 
                            {
                                    MessageBox.Show(signup_username.Text.Trim() + " is already taken",
                                    "Error Message",  MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                DateTime today = DateTime.Today;

                                    string insertData = "INSERT INTO Employees " + "(Username, PasswordHash, DateRegistered)"
                                    + "VALUES(@username, @password, @dateReg)";

                                using (SqlCommand cmd = new SqlCommand(insertData, connect))
                                {
                                    cmd.Parameters.AddWithValue("@username", signup_username.Text.Trim());
                                    cmd.Parameters.AddWithValue("@password", signup_password.Text.Trim());
                                    cmd.Parameters.AddWithValue("@dateReg", today);

                                    cmd.ExecuteNonQuery();

                                    MessageBox.Show("Registerd successfully!", "Information Message",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    //Brings up Login page after successfully registering
                                    Form1 loginForm = new Form1();
                                    loginForm.Show();
                                    this.Hide();
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

        private void loginTo_account_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        
        private void label1_Click(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1();
            loginForm.Show();
            this.Hide();
        }
        

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 loginForm = new Form1();
            loginForm.Show();
            this.Hide();
        }
    }
}
