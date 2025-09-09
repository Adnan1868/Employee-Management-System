namespace EmployeeManagementSystemProject
{
    partial class ManageLeave
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageLeave));
            this.pnlGridView = new System.Windows.Forms.Panel();
            this.lblHeading = new System.Windows.Forms.Label();
            this.dgvEmployeeData = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Designation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalLeaveCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlAdd = new System.Windows.Forms.Panel();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.txtLeaveIncreaseDay = new System.Windows.Forms.TextBox();
            this.lblLeaveIncreaseDay = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblManageLeave = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblInstraction = new System.Windows.Forms.Label();
            this.txtSearchByID = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.cmbDesignation = new System.Windows.Forms.ComboBox();
            this.txtTotalLeaveCount = new System.Windows.Forms.TextBox();
            this.lblTotalLeaveCount = new System.Windows.Forms.Label();
            this.lblDesignation = new System.Windows.Forms.Label();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblemployeeID = new System.Windows.Forms.Label();
            this.lblPenaltyCondition = new System.Windows.Forms.Label();
            this.pnlGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeData)).BeginInit();
            this.pnlAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlGridView
            // 
            this.pnlGridView.Controls.Add(this.lblHeading);
            this.pnlGridView.Controls.Add(this.dgvEmployeeData);
            this.pnlGridView.Location = new System.Drawing.Point(317, 0);
            this.pnlGridView.Name = "pnlGridView";
            this.pnlGridView.Size = new System.Drawing.Size(456, 568);
            this.pnlGridView.TabIndex = 6;
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
            // dgvEmployeeData
            // 
            this.dgvEmployeeData.AllowUserToAddRows = false;
            this.dgvEmployeeData.AllowUserToDeleteRows = false;
            this.dgvEmployeeData.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvEmployeeData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployeeData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.EmpName,
            this.Designation,
            this.TotalLeaveCount,
            this.Salary});
            this.dgvEmployeeData.Location = new System.Drawing.Point(6, 42);
            this.dgvEmployeeData.Name = "dgvEmployeeData";
            this.dgvEmployeeData.ReadOnly = true;
            this.dgvEmployeeData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployeeData.Size = new System.Drawing.Size(445, 514);
            this.dgvEmployeeData.TabIndex = 4;
            this.dgvEmployeeData.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvManageLeave);
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
            // TotalLeaveCount
            // 
            this.TotalLeaveCount.DataPropertyName = "Total Leave Count";
            this.TotalLeaveCount.HeaderText = "Total Leave Count";
            this.TotalLeaveCount.Name = "TotalLeaveCount";
            this.TotalLeaveCount.ReadOnly = true;
            // 
            // Salary
            // 
            this.Salary.DataPropertyName = "Salary";
            this.Salary.HeaderText = "Salary";
            this.Salary.Name = "Salary";
            this.Salary.ReadOnly = true;
            this.Salary.Visible = false;
            // 
            // pnlAdd
            // 
            this.pnlAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.pnlAdd.Controls.Add(this.lblPenaltyCondition);
            this.pnlAdd.Controls.Add(this.txtSalary);
            this.pnlAdd.Controls.Add(this.txtLeaveIncreaseDay);
            this.pnlAdd.Controls.Add(this.lblLeaveIncreaseDay);
            this.pnlAdd.Controls.Add(this.pictureBox1);
            this.pnlAdd.Controls.Add(this.lblManageLeave);
            this.pnlAdd.Controls.Add(this.btnExit);
            this.pnlAdd.Controls.Add(this.lblInstraction);
            this.pnlAdd.Controls.Add(this.txtSearchByID);
            this.pnlAdd.Controls.Add(this.btnSearch);
            this.pnlAdd.Controls.Add(this.btnClear);
            this.pnlAdd.Controls.Add(this.btnBack);
            this.pnlAdd.Controls.Add(this.btnSave);
            this.pnlAdd.Controls.Add(this.cmbDesignation);
            this.pnlAdd.Controls.Add(this.txtTotalLeaveCount);
            this.pnlAdd.Controls.Add(this.lblTotalLeaveCount);
            this.pnlAdd.Controls.Add(this.lblDesignation);
            this.pnlAdd.Controls.Add(this.txtEmployeeName);
            this.pnlAdd.Controls.Add(this.lblEmployeeName);
            this.pnlAdd.Controls.Add(this.txtID);
            this.pnlAdd.Controls.Add(this.lblemployeeID);
            this.pnlAdd.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlAdd.Location = new System.Drawing.Point(0, 0);
            this.pnlAdd.Name = "pnlAdd";
            this.pnlAdd.Size = new System.Drawing.Size(311, 568);
            this.pnlAdd.TabIndex = 5;
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(154, 208);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.ReadOnly = true;
            this.txtSalary.Size = new System.Drawing.Size(134, 20);
            this.txtSalary.TabIndex = 43;
            this.txtSalary.Visible = false;
            // 
            // txtLeaveIncreaseDay
            // 
            this.txtLeaveIncreaseDay.Location = new System.Drawing.Point(154, 352);
            this.txtLeaveIncreaseDay.Name = "txtLeaveIncreaseDay";
            this.txtLeaveIncreaseDay.Size = new System.Drawing.Size(134, 20);
            this.txtLeaveIncreaseDay.TabIndex = 42;
            // 
            // lblLeaveIncreaseDay
            // 
            this.lblLeaveIncreaseDay.AutoSize = true;
            this.lblLeaveIncreaseDay.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeaveIncreaseDay.ForeColor = System.Drawing.Color.White;
            this.lblLeaveIncreaseDay.Location = new System.Drawing.Point(12, 353);
            this.lblLeaveIncreaseDay.Name = "lblLeaveIncreaseDay";
            this.lblLeaveIncreaseDay.Size = new System.Drawing.Size(139, 17);
            this.lblLeaveIncreaseDay.TabIndex = 41;
            this.lblLeaveIncreaseDay.Text = "Leave Increase Day";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(31, 87);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(58, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // lblManageLeave
            // 
            this.lblManageLeave.AutoSize = true;
            this.lblManageLeave.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageLeave.ForeColor = System.Drawing.Color.White;
            this.lblManageLeave.Location = new System.Drawing.Point(99, 103);
            this.lblManageLeave.Name = "lblManageLeave";
            this.lblManageLeave.Size = new System.Drawing.Size(144, 24);
            this.lblManageLeave.TabIndex = 39;
            this.lblManageLeave.Text = "Manage Leave";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(103, 517);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(104, 39);
            this.btnExit.TabIndex = 38;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblInstraction
            // 
            this.lblInstraction.AutoSize = true;
            this.lblInstraction.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstraction.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblInstraction.Location = new System.Drawing.Point(27, 193);
            this.lblInstraction.Name = "lblInstraction";
            this.lblInstraction.Size = new System.Drawing.Size(147, 15);
            this.lblInstraction.TabIndex = 35;
            this.lblInstraction.Text = "*Please insert Employee ID*";
            // 
            // txtSearchByID
            // 
            this.txtSearchByID.Location = new System.Drawing.Point(15, 160);
            this.txtSearchByID.Name = "txtSearchByID";
            this.txtSearchByID.Size = new System.Drawing.Size(192, 20);
            this.txtSearchByID.TabIndex = 34;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(213, 160);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 33;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(195, 460);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 34);
            this.btnClear.TabIndex = 32;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(11, 8);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(61, 25);
            this.btnBack.TabIndex = 31;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(23, 460);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 34);
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
            this.cmbDesignation.Location = new System.Drawing.Point(154, 293);
            this.cmbDesignation.Name = "cmbDesignation";
            this.cmbDesignation.Size = new System.Drawing.Size(134, 21);
            this.cmbDesignation.TabIndex = 27;
            // 
            // txtTotalLeaveCount
            // 
            this.txtTotalLeaveCount.Location = new System.Drawing.Point(154, 323);
            this.txtTotalLeaveCount.Name = "txtTotalLeaveCount";
            this.txtTotalLeaveCount.ReadOnly = true;
            this.txtTotalLeaveCount.Size = new System.Drawing.Size(134, 20);
            this.txtTotalLeaveCount.TabIndex = 22;
            // 
            // lblTotalLeaveCount
            // 
            this.lblTotalLeaveCount.AutoSize = true;
            this.lblTotalLeaveCount.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalLeaveCount.ForeColor = System.Drawing.Color.White;
            this.lblTotalLeaveCount.Location = new System.Drawing.Point(12, 324);
            this.lblTotalLeaveCount.Name = "lblTotalLeaveCount";
            this.lblTotalLeaveCount.Size = new System.Drawing.Size(130, 17);
            this.lblTotalLeaveCount.TabIndex = 21;
            this.lblTotalLeaveCount.Text = "Total Leave Count";
            // 
            // lblDesignation
            // 
            this.lblDesignation.AutoSize = true;
            this.lblDesignation.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesignation.ForeColor = System.Drawing.Color.White;
            this.lblDesignation.Location = new System.Drawing.Point(12, 293);
            this.lblDesignation.Name = "lblDesignation";
            this.lblDesignation.Size = new System.Drawing.Size(86, 17);
            this.lblDesignation.TabIndex = 19;
            this.lblDesignation.Text = "Designation";
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.Location = new System.Drawing.Point(154, 263);
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
            this.lblEmployeeName.Location = new System.Drawing.Point(12, 264);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(115, 17);
            this.lblEmployeeName.TabIndex = 17;
            this.lblEmployeeName.Text = "Employee Name";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(154, 234);
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
            this.lblemployeeID.Location = new System.Drawing.Point(12, 235);
            this.lblemployeeID.Name = "lblemployeeID";
            this.lblemployeeID.Size = new System.Drawing.Size(94, 17);
            this.lblemployeeID.TabIndex = 15;
            this.lblemployeeID.Text = "Employee ID";
            // 
            // lblPenaltyCondition
            // 
            this.lblPenaltyCondition.AutoSize = true;
            this.lblPenaltyCondition.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPenaltyCondition.ForeColor = System.Drawing.Color.White;
            this.lblPenaltyCondition.Location = new System.Drawing.Point(35, 394);
            this.lblPenaltyCondition.Name = "lblPenaltyCondition";
            this.lblPenaltyCondition.Size = new System.Drawing.Size(246, 30);
            this.lblPenaltyCondition.TabIndex = 44;
            this.lblPenaltyCondition.Text = "*The total leave count is 20 per year,\r\nAfter each day, 500 taka salary will be d" +
    "educted.*";
            // 
            // ManageLeave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 568);
            this.Controls.Add(this.pnlGridView);
            this.Controls.Add(this.pnlAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageLeave";
            this.Load += new System.EventHandler(this.ManageLeave_Load);
            this.pnlGridView.ResumeLayout(false);
            this.pnlGridView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeData)).EndInit();
            this.pnlAdd.ResumeLayout(false);
            this.pnlAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlGridView;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.DataGridView dgvEmployeeData;
        private System.Windows.Forms.Panel pnlAdd;
        private System.Windows.Forms.TextBox txtLeaveIncreaseDay;
        private System.Windows.Forms.Label lblLeaveIncreaseDay;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblManageLeave;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblInstraction;
        private System.Windows.Forms.TextBox txtSearchByID;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cmbDesignation;
        private System.Windows.Forms.TextBox txtTotalLeaveCount;
        private System.Windows.Forms.Label lblTotalLeaveCount;
        private System.Windows.Forms.Label lblDesignation;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblemployeeID;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Designation;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalLeaveCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salary;
        private System.Windows.Forms.Label lblPenaltyCondition;
    }
}