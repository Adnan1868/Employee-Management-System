namespace EmployeeManagementSystemProject
{
    partial class ManageEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageEmployee));
            this.pnlAdd = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.dtpJoiningdate = new System.Windows.Forms.DateTimePicker();
            this.lblJoiningDate = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblManageEmployee = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblInstraction = new System.Windows.Forms.Label();
            this.txtSearchByID = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtContactNumber = new System.Windows.Forms.TextBox();
            this.lblContactNumber = new System.Windows.Forms.Label();
            this.cmbDesignation = new System.Windows.Forms.ComboBox();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.lblDOB = new System.Windows.Forms.Label();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.lblSalary = new System.Windows.Forms.Label();
            this.lblDesignation = new System.Windows.Forms.Label();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblemployeeID = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblHeading = new System.Windows.Forms.Label();
            this.dgvEmployeeData = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Designation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DOB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContactNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JoiningDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeData)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlAdd
            // 
            this.pnlAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.pnlAdd.Controls.Add(this.btnBack);
            this.pnlAdd.Controls.Add(this.dtpJoiningdate);
            this.pnlAdd.Controls.Add(this.lblJoiningDate);
            this.pnlAdd.Controls.Add(this.pictureBox1);
            this.pnlAdd.Controls.Add(this.lblManageEmployee);
            this.pnlAdd.Controls.Add(this.btnExit);
            this.pnlAdd.Controls.Add(this.lblInstraction);
            this.pnlAdd.Controls.Add(this.txtSearchByID);
            this.pnlAdd.Controls.Add(this.btnSearch);
            this.pnlAdd.Controls.Add(this.btnClear);
            this.pnlAdd.Controls.Add(this.btnDelete);
            this.pnlAdd.Controls.Add(this.btnSave);
            this.pnlAdd.Controls.Add(this.txtContactNumber);
            this.pnlAdd.Controls.Add(this.lblContactNumber);
            this.pnlAdd.Controls.Add(this.cmbDesignation);
            this.pnlAdd.Controls.Add(this.dtpDOB);
            this.pnlAdd.Controls.Add(this.lblDOB);
            this.pnlAdd.Controls.Add(this.txtSalary);
            this.pnlAdd.Controls.Add(this.lblSalary);
            this.pnlAdd.Controls.Add(this.lblDesignation);
            this.pnlAdd.Controls.Add(this.txtEmployeeName);
            this.pnlAdd.Controls.Add(this.lblEmployeeName);
            this.pnlAdd.Controls.Add(this.txtID);
            this.pnlAdd.Controls.Add(this.lblemployeeID);
            this.pnlAdd.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlAdd.Location = new System.Drawing.Point(0, 0);
            this.pnlAdd.Name = "pnlAdd";
            this.pnlAdd.Size = new System.Drawing.Size(301, 605);
            this.pnlAdd.TabIndex = 2;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(10, 8);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(63, 23);
            this.btnBack.TabIndex = 43;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dtpJoiningdate
            // 
            this.dtpJoiningdate.CustomFormat = "yyyy-MM-dd";
            this.dtpJoiningdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpJoiningdate.Location = new System.Drawing.Point(154, 347);
            this.dtpJoiningdate.MaxDate = new System.DateTime(2023, 12, 18, 23, 28, 29, 0);
            this.dtpJoiningdate.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.dtpJoiningdate.Name = "dtpJoiningdate";
            this.dtpJoiningdate.Size = new System.Drawing.Size(134, 20);
            this.dtpJoiningdate.TabIndex = 42;
            this.dtpJoiningdate.Value = new System.DateTime(2023, 12, 18, 0, 0, 0, 0);
            // 
            // lblJoiningDate
            // 
            this.lblJoiningDate.AutoSize = true;
            this.lblJoiningDate.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJoiningDate.ForeColor = System.Drawing.Color.White;
            this.lblJoiningDate.Location = new System.Drawing.Point(12, 348);
            this.lblJoiningDate.Name = "lblJoiningDate";
            this.lblJoiningDate.Size = new System.Drawing.Size(91, 17);
            this.lblJoiningDate.TabIndex = 41;
            this.lblJoiningDate.Text = "Joining Date";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(31, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(58, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // lblManageEmployee
            // 
            this.lblManageEmployee.AutoSize = true;
            this.lblManageEmployee.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageEmployee.ForeColor = System.Drawing.Color.White;
            this.lblManageEmployee.Location = new System.Drawing.Point(99, 65);
            this.lblManageEmployee.Name = "lblManageEmployee";
            this.lblManageEmployee.Size = new System.Drawing.Size(176, 24);
            this.lblManageEmployee.TabIndex = 39;
            this.lblManageEmployee.Text = "Manage Employee";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(99, 562);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(108, 31);
            this.btnExit.TabIndex = 38;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblInstraction
            // 
            this.lblInstraction.AutoSize = true;
            this.lblInstraction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstraction.ForeColor = System.Drawing.Color.White;
            this.lblInstraction.Location = new System.Drawing.Point(27, 148);
            this.lblInstraction.Name = "lblInstraction";
            this.lblInstraction.Size = new System.Drawing.Size(164, 15);
            this.lblInstraction.TabIndex = 35;
            this.lblInstraction.Text = "*Please insert Employee  ID*";
            // 
            // txtSearchByID
            // 
            this.txtSearchByID.Location = new System.Drawing.Point(15, 115);
            this.txtSearchByID.Name = "txtSearchByID";
            this.txtSearchByID.Size = new System.Drawing.Size(192, 20);
            this.txtSearchByID.TabIndex = 34;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(213, 115);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 33;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(214, 468);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 32;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(116, 468);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 31;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(16, 468);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 30;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtContactNumber
            // 
            this.txtContactNumber.Location = new System.Drawing.Point(153, 380);
            this.txtContactNumber.Name = "txtContactNumber";
            this.txtContactNumber.Size = new System.Drawing.Size(134, 20);
            this.txtContactNumber.TabIndex = 29;
            // 
            // lblContactNumber
            // 
            this.lblContactNumber.AutoSize = true;
            this.lblContactNumber.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactNumber.ForeColor = System.Drawing.Color.White;
            this.lblContactNumber.Location = new System.Drawing.Point(11, 381);
            this.lblContactNumber.Name = "lblContactNumber";
            this.lblContactNumber.Size = new System.Drawing.Size(116, 17);
            this.lblContactNumber.TabIndex = 28;
            this.lblContactNumber.Text = "Contact Number";
            // 
            // cmbDesignation
            // 
            this.cmbDesignation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDesignation.FormattingEnabled = true;
            this.cmbDesignation.Items.AddRange(new object[] {
            "Intern",
            "Senior Executive",
            "Junior Executive",
            "Managing Director",
            "Office Manager",
            "Program Manager ",
            "Marketing Sales"});
            this.cmbDesignation.Location = new System.Drawing.Point(154, 250);
            this.cmbDesignation.Name = "cmbDesignation";
            this.cmbDesignation.Size = new System.Drawing.Size(134, 21);
            this.cmbDesignation.TabIndex = 27;
            // 
            // dtpDOB
            // 
            this.dtpDOB.CustomFormat = "yyyy-MM-dd";
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDOB.Location = new System.Drawing.Point(154, 313);
            this.dtpDOB.MaxDate = new System.DateTime(2230, 1, 1, 0, 0, 0, 0);
            this.dtpDOB.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(134, 20);
            this.dtpDOB.TabIndex = 25;
            this.dtpDOB.Value = new System.DateTime(2000, 12, 19, 0, 0, 0, 0);
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDOB.ForeColor = System.Drawing.Color.White;
            this.lblDOB.Location = new System.Drawing.Point(12, 314);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(97, 17);
            this.lblDOB.TabIndex = 23;
            this.lblDOB.Text = "Date Of Birth";
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(154, 282);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(134, 20);
            this.txtSalary.TabIndex = 22;
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalary.ForeColor = System.Drawing.Color.White;
            this.lblSalary.Location = new System.Drawing.Point(12, 283);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(47, 17);
            this.lblSalary.TabIndex = 21;
            this.lblSalary.Text = "Salary";
            // 
            // lblDesignation
            // 
            this.lblDesignation.AutoSize = true;
            this.lblDesignation.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesignation.ForeColor = System.Drawing.Color.White;
            this.lblDesignation.Location = new System.Drawing.Point(12, 250);
            this.lblDesignation.Name = "lblDesignation";
            this.lblDesignation.Size = new System.Drawing.Size(86, 17);
            this.lblDesignation.TabIndex = 19;
            this.lblDesignation.Text = "Designation";
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.Location = new System.Drawing.Point(154, 219);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(134, 20);
            this.txtEmployeeName.TabIndex = 18;
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeName.ForeColor = System.Drawing.Color.White;
            this.lblEmployeeName.Location = new System.Drawing.Point(12, 220);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(115, 17);
            this.lblEmployeeName.TabIndex = 17;
            this.lblEmployeeName.Text = "Employee Name";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(154, 189);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(134, 20);
            this.txtID.TabIndex = 16;
            // 
            // lblemployeeID
            // 
            this.lblemployeeID.AutoSize = true;
            this.lblemployeeID.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemployeeID.ForeColor = System.Drawing.Color.White;
            this.lblemployeeID.Location = new System.Drawing.Point(12, 190);
            this.lblemployeeID.Name = "lblemployeeID";
            this.lblemployeeID.Size = new System.Drawing.Size(94, 17);
            this.lblemployeeID.TabIndex = 15;
            this.lblemployeeID.Text = "Employee ID";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblHeading);
            this.panel1.Controls.Add(this.dgvEmployeeData);
            this.panel1.Location = new System.Drawing.Point(307, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(751, 605);
            this.panel1.TabIndex = 3;
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(290, 21);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(192, 31);
            this.lblHeading.TabIndex = 1;
            this.lblHeading.Text = "Employee Data";
            // 
            // dgvEmployeeData
            // 
            this.dgvEmployeeData.AllowUserToAddRows = false;
            this.dgvEmployeeData.AllowUserToDeleteRows = false;
            this.dgvEmployeeData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployeeData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.EmpName,
            this.Designation,
            this.Salary,
            this.DOB,
            this.ContactNumber,
            this.JoiningDate});
            this.dgvEmployeeData.Location = new System.Drawing.Point(0, 65);
            this.dgvEmployeeData.Name = "dgvEmployeeData";
            this.dgvEmployeeData.ReadOnly = true;
            this.dgvEmployeeData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployeeData.Size = new System.Drawing.Size(745, 537);
            this.dgvEmployeeData.TabIndex = 0;
            this.dgvEmployeeData.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvManageEmployee);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Emp. ID";
            this.Id.HeaderText = "Emp. ID";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Name
            // 
            this.EmpName.DataPropertyName = "Emp. Name";
            this.EmpName.HeaderText = "Emp. Name";
            this.EmpName.Name = "Name";
            this.EmpName.ReadOnly = true;
            // 
            // Designation
            // 
            this.Designation.DataPropertyName = "Designation";
            this.Designation.HeaderText = "Designation";
            this.Designation.Name = "Designation";
            this.Designation.ReadOnly = true;
            // 
            // Salary
            // 
            this.Salary.DataPropertyName = "Salary";
            this.Salary.HeaderText = "Salary";
            this.Salary.Name = "Salary";
            this.Salary.ReadOnly = true;
            // 
            // DOB
            // 
            this.DOB.DataPropertyName = "DOB";
            this.DOB.HeaderText = "Date Of Birth";
            this.DOB.Name = "DOB";
            this.DOB.ReadOnly = true;
            // 
            // ContactNumber
            // 
            this.ContactNumber.DataPropertyName = "Contact Number";
            this.ContactNumber.HeaderText = "Contact Number";
            this.ContactNumber.Name = "ContactNumber";
            this.ContactNumber.ReadOnly = true;
            // 
            // JoiningDate
            // 
            this.JoiningDate.DataPropertyName = "Joining Date";
            this.JoiningDate.HeaderText = "Joining Date";
            this.JoiningDate.Name = "JoiningDate";
            this.JoiningDate.ReadOnly = true;
            // 
            // ManageEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 605);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageEmployee";
            this.Load += new System.EventHandler(this.ManageEmployee_Load);
            this.pnlAdd.ResumeLayout(false);
            this.pnlAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAdd;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblManageEmployee;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblInstraction;
        private System.Windows.Forms.TextBox txtSearchByID;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtContactNumber;
        private System.Windows.Forms.Label lblContactNumber;
        private System.Windows.Forms.ComboBox cmbDesignation;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.Label lblDesignation;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblemployeeID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.DataGridView dgvEmployeeData;
        private System.Windows.Forms.DateTimePicker dtpJoiningdate;
        private System.Windows.Forms.Label lblJoiningDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Designation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salary;
        private System.Windows.Forms.DataGridViewTextBoxColumn DOB;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContactNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn JoiningDate;
        private System.Windows.Forms.Button btnBack;
    }
}