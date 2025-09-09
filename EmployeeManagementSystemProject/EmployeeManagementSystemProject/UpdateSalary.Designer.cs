namespace EmployeeManagementSystemProject
{
    partial class UpdateSalary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateSalary));
            this.pnlAdd = new System.Windows.Forms.Panel();
            this.txtIncrementSalary = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblManageEmployee = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblInstraction = new System.Windows.Forms.Label();
            this.txtSearchByID = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.cmbDesignation = new System.Windows.Forms.ComboBox();
            this.txtCurrentSalary = new System.Windows.Forms.TextBox();
            this.lblCurrentSalary = new System.Windows.Forms.Label();
            this.lblDesignation = new System.Windows.Forms.Label();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblemployeeID = new System.Windows.Forms.Label();
            this.dgvEmployeeData = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Designation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlGridView = new System.Windows.Forms.Panel();
            this.lblHeading = new System.Windows.Forms.Label();
            this.pnlAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeData)).BeginInit();
            this.pnlGridView.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAdd
            // 
            this.pnlAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.pnlAdd.Controls.Add(this.txtIncrementSalary);
            this.pnlAdd.Controls.Add(this.label1);
            this.pnlAdd.Controls.Add(this.pictureBox1);
            this.pnlAdd.Controls.Add(this.lblManageEmployee);
            this.pnlAdd.Controls.Add(this.btnExit);
            this.pnlAdd.Controls.Add(this.lblInstraction);
            this.pnlAdd.Controls.Add(this.txtSearchByID);
            this.pnlAdd.Controls.Add(this.btnSearch);
            this.pnlAdd.Controls.Add(this.btnClear);
            this.pnlAdd.Controls.Add(this.btnBack);
            this.pnlAdd.Controls.Add(this.btnSave);
            this.pnlAdd.Controls.Add(this.cmbDesignation);
            this.pnlAdd.Controls.Add(this.txtCurrentSalary);
            this.pnlAdd.Controls.Add(this.lblCurrentSalary);
            this.pnlAdd.Controls.Add(this.lblDesignation);
            this.pnlAdd.Controls.Add(this.txtEmployeeName);
            this.pnlAdd.Controls.Add(this.lblEmployeeName);
            this.pnlAdd.Controls.Add(this.txtID);
            this.pnlAdd.Controls.Add(this.lblemployeeID);
            this.pnlAdd.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlAdd.Location = new System.Drawing.Point(0, 0);
            this.pnlAdd.Name = "pnlAdd";
            this.pnlAdd.Size = new System.Drawing.Size(301, 541);
            this.pnlAdd.TabIndex = 3;
            // 
            // txtIncrementSalary
            // 
            this.txtIncrementSalary.Location = new System.Drawing.Point(154, 346);
            this.txtIncrementSalary.Name = "txtIncrementSalary";
            this.txtIncrementSalary.Size = new System.Drawing.Size(134, 20);
            this.txtIncrementSalary.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 347);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 17);
            this.label1.TabIndex = 41;
            this.label1.Text = "Increment Amount";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(31, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(58, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // lblManageEmployee
            // 
            this.lblManageEmployee.AutoSize = true;
            this.lblManageEmployee.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageEmployee.ForeColor = System.Drawing.Color.White;
            this.lblManageEmployee.Location = new System.Drawing.Point(99, 84);
            this.lblManageEmployee.Name = "lblManageEmployee";
            this.lblManageEmployee.Size = new System.Drawing.Size(159, 26);
            this.lblManageEmployee.TabIndex = 39;
            this.lblManageEmployee.Text = "Update Salary";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(97, 501);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(110, 28);
            this.btnExit.TabIndex = 38;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblInstraction
            // 
            this.lblInstraction.AutoSize = true;
            this.lblInstraction.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstraction.ForeColor = System.Drawing.Color.White;
            this.lblInstraction.Location = new System.Drawing.Point(27, 168);
            this.lblInstraction.Name = "lblInstraction";
            this.lblInstraction.Size = new System.Drawing.Size(157, 15);
            this.lblInstraction.TabIndex = 35;
            this.lblInstraction.Text = "*Please insert Employee ID*";
            // 
            // txtSearchByID
            // 
            this.txtSearchByID.Location = new System.Drawing.Point(15, 138);
            this.txtSearchByID.Name = "txtSearchByID";
            this.txtSearchByID.Size = new System.Drawing.Size(192, 20);
            this.txtSearchByID.TabIndex = 34;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(213, 138);
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
            this.btnClear.Location = new System.Drawing.Point(193, 415);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 32;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(10, 9);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(57, 23);
            this.btnBack.TabIndex = 31;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(30, 415);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 30;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            this.cmbDesignation.Location = new System.Drawing.Point(154, 289);
            this.cmbDesignation.Name = "cmbDesignation";
            this.cmbDesignation.Size = new System.Drawing.Size(134, 21);
            this.cmbDesignation.TabIndex = 27;
            // 
            // txtCurrentSalary
            // 
            this.txtCurrentSalary.Location = new System.Drawing.Point(154, 318);
            this.txtCurrentSalary.Name = "txtCurrentSalary";
            this.txtCurrentSalary.ReadOnly = true;
            this.txtCurrentSalary.Size = new System.Drawing.Size(134, 20);
            this.txtCurrentSalary.TabIndex = 22;
            // 
            // lblCurrentSalary
            // 
            this.lblCurrentSalary.AutoSize = true;
            this.lblCurrentSalary.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentSalary.ForeColor = System.Drawing.Color.White;
            this.lblCurrentSalary.Location = new System.Drawing.Point(12, 319);
            this.lblCurrentSalary.Name = "lblCurrentSalary";
            this.lblCurrentSalary.Size = new System.Drawing.Size(103, 17);
            this.lblCurrentSalary.TabIndex = 21;
            this.lblCurrentSalary.Text = "Current Salary";
            // 
            // lblDesignation
            // 
            this.lblDesignation.AutoSize = true;
            this.lblDesignation.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesignation.ForeColor = System.Drawing.Color.White;
            this.lblDesignation.Location = new System.Drawing.Point(12, 289);
            this.lblDesignation.Name = "lblDesignation";
            this.lblDesignation.Size = new System.Drawing.Size(86, 17);
            this.lblDesignation.TabIndex = 19;
            this.lblDesignation.Text = "Designation";
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.Location = new System.Drawing.Point(154, 262);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.ReadOnly = true;
            this.txtEmployeeName.Size = new System.Drawing.Size(134, 20);
            this.txtEmployeeName.TabIndex = 18;
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeName.ForeColor = System.Drawing.Color.White;
            this.lblEmployeeName.Location = new System.Drawing.Point(12, 263);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(115, 17);
            this.lblEmployeeName.TabIndex = 17;
            this.lblEmployeeName.Text = "Employee Name";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(154, 235);
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
            this.lblemployeeID.Location = new System.Drawing.Point(12, 236);
            this.lblemployeeID.Name = "lblemployeeID";
            this.lblemployeeID.Size = new System.Drawing.Size(94, 17);
            this.lblemployeeID.TabIndex = 15;
            this.lblemployeeID.Text = "Employee ID";
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
            this.Salary});
            this.dgvEmployeeData.Location = new System.Drawing.Point(6, 42);
            this.dgvEmployeeData.Name = "dgvEmployeeData";
            this.dgvEmployeeData.ReadOnly = true;
            this.dgvEmployeeData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployeeData.Size = new System.Drawing.Size(445, 487);
            this.dgvEmployeeData.TabIndex = 4;
            this.dgvEmployeeData.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUpdateSalary);
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
            // pnlGridView
            // 
            this.pnlGridView.Controls.Add(this.lblHeading);
            this.pnlGridView.Controls.Add(this.dgvEmployeeData);
            this.pnlGridView.Location = new System.Drawing.Point(307, 0);
            this.pnlGridView.Name = "pnlGridView";
            this.pnlGridView.Size = new System.Drawing.Size(458, 541);
            this.pnlGridView.TabIndex = 4;
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(163, 9);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(142, 25);
            this.lblHeading.TabIndex = 43;
            this.lblHeading.Text = "Employee Data";
            // 
            // UpdateSalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 541);
            this.Controls.Add(this.pnlGridView);
            this.Controls.Add(this.pnlAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.UpdateSalary_Load);
            this.pnlAdd.ResumeLayout(false);
            this.pnlAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeData)).EndInit();
            this.pnlGridView.ResumeLayout(false);
            this.pnlGridView.PerformLayout();
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
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cmbDesignation;
        private System.Windows.Forms.TextBox txtCurrentSalary;
        private System.Windows.Forms.Label lblCurrentSalary;
        private System.Windows.Forms.Label lblDesignation;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblemployeeID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvEmployeeData;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Designation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salary;
        private System.Windows.Forms.Panel pnlGridView;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.TextBox txtIncrementSalary;
    }
}