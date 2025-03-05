namespace EmployeeManagementSystemDesktopApp
{
    partial class adminAddEmployee
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DataGridView = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.addEmployeePhoneNumber = new System.Windows.Forms.TextBox();
            this.employeephoneNumber = new System.Windows.Forms.Label();
            this.addEmployee_Gender = new System.Windows.Forms.ComboBox();
            this.employeegender = new System.Windows.Forms.Label();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.deleteemployeeBtn = new System.Windows.Forms.Button();
            this.addEmployeeBtn = new System.Windows.Forms.Button();
            this.updateemployeeBtn = new System.Windows.Forms.Button();
            this.EmployeeStatus = new System.Windows.Forms.ComboBox();
            this.epmStatus = new System.Windows.Forms.Label();
            this.adEmployee_Department = new System.Windows.Forms.ComboBox();
            this.EmployeeRole = new System.Windows.Forms.ComboBox();
            this.employeeDepartment = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.EmployeeName = new System.Windows.Forms.TextBox();
            this.employeeFullName = new System.Windows.Forms.Label();
            this.addEmployee_ID = new System.Windows.Forms.TextBox();
            this.empID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.employeeManagementSystemDataSet = new EmployeeManagementSystemDesktopApp.EmployeeManagementSystemDataSet();
            this.employeeManagementSystemDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeesInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeesInfoTableAdapter = new EmployeeManagementSystemDesktopApp.EmployeeManagementSystemDataSetTableAdapters.EmployeesInfoTableAdapter();
            this.empidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.insertdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updatedateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deletedateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridView.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeManagementSystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeManagementSystemDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesInfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridView
            // 
            this.DataGridView.BackColor = System.Drawing.Color.White;
            this.DataGridView.Controls.Add(this.panel1);
            this.DataGridView.Controls.Add(this.comboBox3);
            this.DataGridView.Controls.Add(this.label5);
            this.DataGridView.Location = new System.Drawing.Point(18, 51);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.Size = new System.Drawing.Size(841, 197);
            this.DataGridView.TabIndex = 0;
            this.DataGridView.Paint += new System.Windows.Forms.PaintEventHandler(this.DataGridView_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(837, 196);
            this.panel1.TabIndex = 12;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Blue;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.empidDataGridViewTextBoxColumn,
            this.fullnameDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.contactnumberDataGridViewTextBoxColumn,
            this.positionDataGridViewTextBoxColumn,
            this.salaryDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.insertdateDataGridViewTextBoxColumn,
            this.updatedateDataGridViewTextBoxColumn,
            this.deletedateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.employeesInfoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(831, 191);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // comboBox3
            // 
            this.comboBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.comboBox3.Location = new System.Drawing.Point(19, 272);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(176, 28);
            this.comboBox3.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Status";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.addEmployeePhoneNumber);
            this.panel2.Controls.Add(this.employeephoneNumber);
            this.panel2.Controls.Add(this.addEmployee_Gender);
            this.panel2.Controls.Add(this.employeegender);
            this.panel2.Controls.Add(this.ClearBtn);
            this.panel2.Controls.Add(this.deleteemployeeBtn);
            this.panel2.Controls.Add(this.addEmployeeBtn);
            this.panel2.Controls.Add(this.updateemployeeBtn);
            this.panel2.Controls.Add(this.EmployeeStatus);
            this.panel2.Controls.Add(this.epmStatus);
            this.panel2.Controls.Add(this.adEmployee_Department);
            this.panel2.Controls.Add(this.EmployeeRole);
            this.panel2.Controls.Add(this.employeeDepartment);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.EmployeeName);
            this.panel2.Controls.Add(this.employeeFullName);
            this.panel2.Controls.Add(this.addEmployee_ID);
            this.panel2.Controls.Add(this.empID);
            this.panel2.Location = new System.Drawing.Point(18, 254);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(841, 296);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // addEmployeePhoneNumber
            // 
            this.addEmployeePhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmployeePhoneNumber.Location = new System.Drawing.Point(91, 154);
            this.addEmployeePhoneNumber.Name = "addEmployeePhoneNumber";
            this.addEmployeePhoneNumber.Size = new System.Drawing.Size(176, 26);
            this.addEmployeePhoneNumber.TabIndex = 30;
            // 
            // employeephoneNumber
            // 
            this.employeephoneNumber.AutoSize = true;
            this.employeephoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeephoneNumber.Location = new System.Drawing.Point(88, 136);
            this.employeephoneNumber.Name = "employeephoneNumber";
            this.employeephoneNumber.Size = new System.Drawing.Size(103, 15);
            this.employeephoneNumber.TabIndex = 29;
            this.employeephoneNumber.Text = "Phone Number";
            // 
            // addEmployee_Gender
            // 
            this.addEmployee_Gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmployee_Gender.FormattingEnabled = true;
            this.addEmployee_Gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.addEmployee_Gender.Location = new System.Drawing.Point(322, 98);
            this.addEmployee_Gender.Name = "addEmployee_Gender";
            this.addEmployee_Gender.Size = new System.Drawing.Size(176, 28);
            this.addEmployee_Gender.TabIndex = 28;
            // 
            // employeegender
            // 
            this.employeegender.AutoSize = true;
            this.employeegender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeegender.Location = new System.Drawing.Point(320, 79);
            this.employeegender.Name = "employeegender";
            this.employeegender.Size = new System.Drawing.Size(54, 15);
            this.employeegender.TabIndex = 27;
            this.employeegender.Text = "Gender";
            // 
            // ClearBtn
            // 
            this.ClearBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(179)))));
            this.ClearBtn.FlatAppearance.BorderSize = 0;
            this.ClearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearBtn.ForeColor = System.Drawing.Color.White;
            this.ClearBtn.Location = new System.Drawing.Point(599, 224);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(175, 34);
            this.ClearBtn.TabIndex = 14;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = false;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // deleteemployeeBtn
            // 
            this.deleteemployeeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(179)))));
            this.deleteemployeeBtn.FlatAppearance.BorderSize = 0;
            this.deleteemployeeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteemployeeBtn.ForeColor = System.Drawing.Color.White;
            this.deleteemployeeBtn.Location = new System.Drawing.Point(418, 224);
            this.deleteemployeeBtn.Name = "deleteemployeeBtn";
            this.deleteemployeeBtn.Size = new System.Drawing.Size(175, 34);
            this.deleteemployeeBtn.TabIndex = 13;
            this.deleteemployeeBtn.Text = "Delete";
            this.deleteemployeeBtn.UseVisualStyleBackColor = false;
            this.deleteemployeeBtn.Click += new System.EventHandler(this.deleteemployeeBtn_Click);
            // 
            // addEmployeeBtn
            // 
            this.addEmployeeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(179)))));
            this.addEmployeeBtn.FlatAppearance.BorderSize = 0;
            this.addEmployeeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmployeeBtn.ForeColor = System.Drawing.Color.White;
            this.addEmployeeBtn.Location = new System.Drawing.Point(56, 224);
            this.addEmployeeBtn.Name = "addEmployeeBtn";
            this.addEmployeeBtn.Size = new System.Drawing.Size(175, 34);
            this.addEmployeeBtn.TabIndex = 12;
            this.addEmployeeBtn.Text = "Add";
            this.addEmployeeBtn.UseVisualStyleBackColor = false;
            this.addEmployeeBtn.Click += new System.EventHandler(this.addEmployeeBtn_Click);
            // 
            // updateemployeeBtn
            // 
            this.updateemployeeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(179)))));
            this.updateemployeeBtn.FlatAppearance.BorderSize = 0;
            this.updateemployeeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateemployeeBtn.ForeColor = System.Drawing.Color.White;
            this.updateemployeeBtn.Location = new System.Drawing.Point(237, 224);
            this.updateemployeeBtn.Name = "updateemployeeBtn";
            this.updateemployeeBtn.Size = new System.Drawing.Size(175, 34);
            this.updateemployeeBtn.TabIndex = 13;
            this.updateemployeeBtn.Text = "Update";
            this.updateemployeeBtn.UseVisualStyleBackColor = false;
            this.updateemployeeBtn.Click += new System.EventHandler(this.updateemployeeBtn_Click);
            // 
            // EmployeeStatus
            // 
            this.EmployeeStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeStatus.FormattingEnabled = true;
            this.EmployeeStatus.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.EmployeeStatus.Location = new System.Drawing.Point(322, 43);
            this.EmployeeStatus.Name = "EmployeeStatus";
            this.EmployeeStatus.Size = new System.Drawing.Size(176, 28);
            this.EmployeeStatus.TabIndex = 24;
            // 
            // epmStatus
            // 
            this.epmStatus.AutoSize = true;
            this.epmStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.epmStatus.Location = new System.Drawing.Point(320, 24);
            this.epmStatus.Name = "epmStatus";
            this.epmStatus.Size = new System.Drawing.Size(47, 15);
            this.epmStatus.TabIndex = 23;
            this.epmStatus.Text = "Status";
            // 
            // adEmployee_Department
            // 
            this.adEmployee_Department.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adEmployee_Department.FormattingEnabled = true;
            this.adEmployee_Department.Items.AddRange(new object[] {
            "Administration",
            "Academics",
            "Ancillary"});
            this.adEmployee_Department.Location = new System.Drawing.Point(531, 43);
            this.adEmployee_Department.Name = "adEmployee_Department";
            this.adEmployee_Department.Size = new System.Drawing.Size(176, 28);
            this.adEmployee_Department.TabIndex = 22;
            this.adEmployee_Department.SelectedIndexChanged += new System.EventHandler(this.comboBox5_SelectedIndexChanged);
            // 
            // EmployeeRole
            // 
            this.EmployeeRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeRole.FormattingEnabled = true;
            this.EmployeeRole.Items.AddRange(new object[] {
            "Director/Principal",
            "System Administrator",
            "Vice Principal (Academics)",
            "Vice Principal (Administration)",
            "Librarian",
            "Assistant Librarian",
            "Plant Manager",
            "Lecturer",
            "Lab Technicians",
            "Registrar",
            "HR Director",
            "Assistant HR Director",
            "HR Secretary",
            "Secretary",
            "Ancillary"});
            this.EmployeeRole.Location = new System.Drawing.Point(531, 98);
            this.EmployeeRole.Name = "EmployeeRole";
            this.EmployeeRole.Size = new System.Drawing.Size(176, 28);
            this.EmployeeRole.TabIndex = 21;
            // 
            // employeeDepartment
            // 
            this.employeeDepartment.AutoSize = true;
            this.employeeDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeDepartment.Location = new System.Drawing.Point(529, 24);
            this.employeeDepartment.Name = "employeeDepartment";
            this.employeeDepartment.Size = new System.Drawing.Size(82, 15);
            this.employeeDepartment.TabIndex = 20;
            this.employeeDepartment.Text = "Department";
            this.employeeDepartment.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(528, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 15);
            this.label8.TabIndex = 19;
            this.label8.Text = "Role";
            // 
            // EmployeeName
            // 
            this.EmployeeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeName.Location = new System.Drawing.Point(91, 98);
            this.EmployeeName.Name = "EmployeeName";
            this.EmployeeName.Size = new System.Drawing.Size(176, 26);
            this.EmployeeName.TabIndex = 18;
            // 
            // employeeFullName
            // 
            this.employeeFullName.AutoSize = true;
            this.employeeFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeFullName.Location = new System.Drawing.Point(88, 80);
            this.employeeFullName.Name = "employeeFullName";
            this.employeeFullName.Size = new System.Drawing.Size(73, 15);
            this.employeeFullName.TabIndex = 17;
            this.employeeFullName.Text = "Full Name";
            // 
            // addEmployee_ID
            // 
            this.addEmployee_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmployee_ID.Location = new System.Drawing.Point(91, 40);
            this.addEmployee_ID.Name = "addEmployee_ID";
            this.addEmployee_ID.Size = new System.Drawing.Size(176, 26);
            this.addEmployee_ID.TabIndex = 16;
            // 
            // empID
            // 
            this.empID.AutoSize = true;
            this.empID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empID.Location = new System.Drawing.Point(88, 22);
            this.empID.Name = "empID";
            this.empID.Size = new System.Drawing.Size(88, 15);
            this.empID.TabIndex = 15;
            this.empID.Text = "Employee ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Employee\'s Data";
            // 
            // employeeManagementSystemDataSet
            // 
            this.employeeManagementSystemDataSet.DataSetName = "EmployeeManagementSystemDataSet";
            this.employeeManagementSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeManagementSystemDataSetBindingSource
            // 
            this.employeeManagementSystemDataSetBindingSource.DataSource = this.employeeManagementSystemDataSet;
            this.employeeManagementSystemDataSetBindingSource.Position = 0;
            // 
            // employeesInfoBindingSource
            // 
            this.employeesInfoBindingSource.DataMember = "EmployeesInfo";
            this.employeesInfoBindingSource.DataSource = this.employeeManagementSystemDataSetBindingSource;
            // 
            // employeesInfoTableAdapter
            // 
            this.employeesInfoTableAdapter.ClearBeforeFill = true;
            // 
            // empidDataGridViewTextBoxColumn
            // 
            this.empidDataGridViewTextBoxColumn.DataPropertyName = "emp_id";
            this.empidDataGridViewTextBoxColumn.HeaderText = "emp_id";
            this.empidDataGridViewTextBoxColumn.Name = "empidDataGridViewTextBoxColumn";
            this.empidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fullnameDataGridViewTextBoxColumn
            // 
            this.fullnameDataGridViewTextBoxColumn.DataPropertyName = "full_name";
            this.fullnameDataGridViewTextBoxColumn.HeaderText = "full_name";
            this.fullnameDataGridViewTextBoxColumn.Name = "fullnameDataGridViewTextBoxColumn";
            this.fullnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contactnumberDataGridViewTextBoxColumn
            // 
            this.contactnumberDataGridViewTextBoxColumn.DataPropertyName = "contact_number";
            this.contactnumberDataGridViewTextBoxColumn.HeaderText = "contact_number";
            this.contactnumberDataGridViewTextBoxColumn.Name = "contactnumberDataGridViewTextBoxColumn";
            this.contactnumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // positionDataGridViewTextBoxColumn
            // 
            this.positionDataGridViewTextBoxColumn.DataPropertyName = "position";
            this.positionDataGridViewTextBoxColumn.HeaderText = "position";
            this.positionDataGridViewTextBoxColumn.Name = "positionDataGridViewTextBoxColumn";
            this.positionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // salaryDataGridViewTextBoxColumn
            // 
            this.salaryDataGridViewTextBoxColumn.DataPropertyName = "salary";
            this.salaryDataGridViewTextBoxColumn.HeaderText = "salary";
            this.salaryDataGridViewTextBoxColumn.Name = "salaryDataGridViewTextBoxColumn";
            this.salaryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // insertdateDataGridViewTextBoxColumn
            // 
            this.insertdateDataGridViewTextBoxColumn.DataPropertyName = "insert_date";
            this.insertdateDataGridViewTextBoxColumn.HeaderText = "insert_date";
            this.insertdateDataGridViewTextBoxColumn.Name = "insertdateDataGridViewTextBoxColumn";
            this.insertdateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // updatedateDataGridViewTextBoxColumn
            // 
            this.updatedateDataGridViewTextBoxColumn.DataPropertyName = "update_date";
            this.updatedateDataGridViewTextBoxColumn.HeaderText = "update_date";
            this.updatedateDataGridViewTextBoxColumn.Name = "updatedateDataGridViewTextBoxColumn";
            this.updatedateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // deletedateDataGridViewTextBoxColumn
            // 
            this.deletedateDataGridViewTextBoxColumn.DataPropertyName = "delete_date";
            this.deletedateDataGridViewTextBoxColumn.HeaderText = "delete_date";
            this.deletedateDataGridViewTextBoxColumn.Name = "deletedateDataGridViewTextBoxColumn";
            this.deletedateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adminAddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.DataGridView);
            this.Name = "adminAddEmployee";
            this.Size = new System.Drawing.Size(875, 553);
            this.DataGridView.ResumeLayout(false);
            this.DataGridView.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeManagementSystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeManagementSystemDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesInfoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel DataGridView;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button addEmployeeBtn;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button deleteemployeeBtn;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Button updateemployeeBtn;
        private System.Windows.Forms.ComboBox EmployeeStatus;
        private System.Windows.Forms.Label epmStatus;
        private System.Windows.Forms.ComboBox adEmployee_Department;
        private System.Windows.Forms.ComboBox EmployeeRole;
        private System.Windows.Forms.Label employeeDepartment;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox EmployeeName;
        private System.Windows.Forms.Label employeeFullName;
        private System.Windows.Forms.TextBox addEmployee_ID;
        private System.Windows.Forms.Label empID;
        private System.Windows.Forms.ComboBox addEmployee_Gender;
        private System.Windows.Forms.Label employeegender;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox addEmployeePhoneNumber;
        private System.Windows.Forms.Label employeephoneNumber;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource employeeManagementSystemDataSetBindingSource;
        private EmployeeManagementSystemDataSet employeeManagementSystemDataSet;
        private System.Windows.Forms.BindingSource employeesInfoBindingSource;
        private EmployeeManagementSystemDataSetTableAdapters.EmployeesInfoTableAdapter employeesInfoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn empidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn insertdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn updatedateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deletedateDataGridViewTextBoxColumn;
    }
}
