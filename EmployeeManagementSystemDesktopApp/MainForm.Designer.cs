namespace EmployeeManagementSystemDesktopApp
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.close_click = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.logout_Btn = new System.Windows.Forms.Button();
            this.salaryBtn = new System.Windows.Forms.Button();
            this.addEmployeeBtn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dashboardBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.adminSalaryForm1 = new EmployeeManagementSystemDesktopApp.adminSalaryForm();
            this.adminAddEmployee1 = new EmployeeManagementSystemDesktopApp.adminAddEmployee();
            this.adminDashBoard1 = new EmployeeManagementSystemDesktopApp.adminDashBoard();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(179)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.close_click);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1100, 47);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(12, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Employee Management System";
            // 
            // close_click
            // 
            this.close_click.AutoSize = true;
            this.close_click.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close_click.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close_click.Location = new System.Drawing.Point(1066, 9);
            this.close_click.Name = "close_click";
            this.close_click.Size = new System.Drawing.Size(22, 23);
            this.close_click.TabIndex = 0;
            this.close_click.Text = "X";
            this.close_click.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(179)))));
            this.panel2.Controls.Add(this.logout_Btn);
            this.panel2.Controls.Add(this.salaryBtn);
            this.panel2.Controls.Add(this.addEmployeeBtn);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.dashboardBtn);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(0, 47);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(225, 553);
            this.panel2.TabIndex = 1;
            // 
            // logout_Btn
            // 
            this.logout_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(179)))));
            this.logout_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumBlue;
            this.logout_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumBlue;
            this.logout_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout_Btn.ForeColor = System.Drawing.Color.White;
            this.logout_Btn.Location = new System.Drawing.Point(28, 500);
            this.logout_Btn.Name = "logout_Btn";
            this.logout_Btn.Size = new System.Drawing.Size(165, 41);
            this.logout_Btn.TabIndex = 3;
            this.logout_Btn.Text = "LOGOUT";
            this.logout_Btn.UseVisualStyleBackColor = false;
            this.logout_Btn.Click += new System.EventHandler(this.logout_Btn_Click);
            // 
            // salaryBtn
            // 
            this.salaryBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(179)))));
            this.salaryBtn.FlatAppearance.BorderSize = 0;
            this.salaryBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumBlue;
            this.salaryBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumBlue;
            this.salaryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salaryBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salaryBtn.ForeColor = System.Drawing.Color.White;
            this.salaryBtn.Location = new System.Drawing.Point(28, 281);
            this.salaryBtn.Name = "salaryBtn";
            this.salaryBtn.Size = new System.Drawing.Size(165, 41);
            this.salaryBtn.TabIndex = 31;
            this.salaryBtn.Text = "SALARY";
            this.salaryBtn.UseVisualStyleBackColor = false;
            this.salaryBtn.Click += new System.EventHandler(this.salaryBtn_Click_1);
            // 
            // addEmployeeBtn
            // 
            this.addEmployeeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(179)))));
            this.addEmployeeBtn.FlatAppearance.BorderSize = 0;
            this.addEmployeeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumBlue;
            this.addEmployeeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumBlue;
            this.addEmployeeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addEmployeeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmployeeBtn.ForeColor = System.Drawing.Color.White;
            this.addEmployeeBtn.Location = new System.Drawing.Point(28, 221);
            this.addEmployeeBtn.Name = "addEmployeeBtn";
            this.addEmployeeBtn.Size = new System.Drawing.Size(165, 41);
            this.addEmployeeBtn.TabIndex = 3;
            this.addEmployeeBtn.Text = "ADD";
            this.addEmployeeBtn.UseVisualStyleBackColor = false;
            this.addEmployeeBtn.Click += new System.EventHandler(this.addEmployeeBtn_Click_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(54, 18);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(122, 86);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 29;
            this.pictureBox2.TabStop = false;
            // 
            // dashboardBtn
            // 
            this.dashboardBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(179)))));
            this.dashboardBtn.FlatAppearance.BorderSize = 0;
            this.dashboardBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumBlue;
            this.dashboardBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumBlue;
            this.dashboardBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboardBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardBtn.ForeColor = System.Drawing.Color.White;
            this.dashboardBtn.Location = new System.Drawing.Point(28, 157);
            this.dashboardBtn.Name = "dashboardBtn";
            this.dashboardBtn.Size = new System.Drawing.Size(165, 41);
            this.dashboardBtn.TabIndex = 2;
            this.dashboardBtn.Text = "DASHBOARD";
            this.dashboardBtn.UseVisualStyleBackColor = false;
            this.dashboardBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(51, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Welcome, User";
            // 
            // adminSalaryForm1
            // 
            this.adminSalaryForm1.Location = new System.Drawing.Point(222, 47);
            this.adminSalaryForm1.Name = "adminSalaryForm1";
            this.adminSalaryForm1.Size = new System.Drawing.Size(875, 553);
            this.adminSalaryForm1.TabIndex = 2;
            // 
            // adminAddEmployee1
            // 
            this.adminAddEmployee1.Location = new System.Drawing.Point(222, 47);
            this.adminAddEmployee1.Name = "adminAddEmployee1";
            this.adminAddEmployee1.Size = new System.Drawing.Size(875, 553);
            this.adminAddEmployee1.TabIndex = 3;
            // 
            // adminDashBoard1
            // 
            this.adminDashBoard1.Location = new System.Drawing.Point(222, 47);
            this.adminDashBoard1.Name = "adminDashBoard1";
            this.adminDashBoard1.Size = new System.Drawing.Size(875, 553);
            this.adminDashBoard1.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 600);
            this.Controls.Add(this.adminDashBoard1);
            this.Controls.Add(this.adminAddEmployee1);
            this.Controls.Add(this.adminSalaryForm1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "ad";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label close_click;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button dashboardBtn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button salaryBtn;
        private System.Windows.Forms.Button addEmployeeBtn;
        private System.Windows.Forms.Button logout_Btn;
        private adminSalaryForm adminSalaryForm1;
        private adminAddEmployee adminAddEmployee1;
        private adminDashBoard adminDashBoard1;
    }
}