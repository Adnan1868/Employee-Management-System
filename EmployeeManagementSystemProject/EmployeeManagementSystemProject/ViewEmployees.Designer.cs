namespace EmployeeManagementSystemProject
{
    partial class ViewEmployees
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewEmployees));
            this.pnlBackground = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlAdd = new System.Windows.Forms.Panel();
            this.lblViewEmployee = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtDesignation = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblManageEmployee = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblInstraction = new System.Windows.Forms.Label();
            this.txtSearchByID = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtContactNumber = new System.Windows.Forms.TextBox();
            this.lblContactNumber = new System.Windows.Forms.Label();
            this.lblDesignation = new System.Windows.Forms.Label();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblemployeeID = new System.Windows.Forms.Label();
            this.dgvEmployeeData = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Designation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContactNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBack = new System.Windows.Forms.Button();
            this.pnlBackground.SuspendLayout();
            this.pnlAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeData)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBackground
            // 
            this.pnlBackground.Controls.Add(this.label1);
            this.pnlBackground.Controls.Add(this.pnlAdd);
            this.pnlBackground.Controls.Add(this.dgvEmployeeData);
            this.pnlBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBackground.Location = new System.Drawing.Point(0, 0);
            this.pnlBackground.Name = "pnlBackground";
            this.pnlBackground.Size = new System.Drawing.Size(761, 520);
            this.pnlBackground.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(427, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 25);
            this.label1.TabIndex = 43;
            this.label1.Text = "Employees General Info";
            // 
            // pnlAdd
            // 
            this.pnlAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.pnlAdd.Controls.Add(this.btnBack);
            this.pnlAdd.Controls.Add(this.lblViewEmployee);
            this.pnlAdd.Controls.Add(this.btnClear);
            this.pnlAdd.Controls.Add(this.txtDesignation);
            this.pnlAdd.Controls.Add(this.pictureBox1);
            this.pnlAdd.Controls.Add(this.lblManageEmployee);
            this.pnlAdd.Controls.Add(this.btnExit);
            this.pnlAdd.Controls.Add(this.lblInstraction);
            this.pnlAdd.Controls.Add(this.txtSearchByID);
            this.pnlAdd.Controls.Add(this.btnSearch);
            this.pnlAdd.Controls.Add(this.txtContactNumber);
            this.pnlAdd.Controls.Add(this.lblContactNumber);
            this.pnlAdd.Controls.Add(this.lblDesignation);
            this.pnlAdd.Controls.Add(this.txtEmployeeName);
            this.pnlAdd.Controls.Add(this.lblEmployeeName);
            this.pnlAdd.Controls.Add(this.txtID);
            this.pnlAdd.Controls.Add(this.lblemployeeID);
            this.pnlAdd.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlAdd.Location = new System.Drawing.Point(0, 0);
            this.pnlAdd.Name = "pnlAdd";
            this.pnlAdd.Size = new System.Drawing.Size(301, 520);
            this.pnlAdd.TabIndex = 3;
            // 
            // lblViewEmployee
            // 
            this.lblViewEmployee.AutoSize = true;
            this.lblViewEmployee.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewEmployee.ForeColor = System.Drawing.Color.White;
            this.lblViewEmployee.Location = new System.Drawing.Point(104, 89);
            this.lblViewEmployee.Name = "lblViewEmployee";
            this.lblViewEmployee.Size = new System.Drawing.Size(173, 22);
            this.lblViewEmployee.TabIndex = 43;
            this.lblViewEmployee.Text = "View Employee Info";
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(110, 404);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(88, 23);
            this.btnClear.TabIndex = 42;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtDesignation
            // 
            this.txtDesignation.Location = new System.Drawing.Point(155, 305);
            this.txtDesignation.Name = "txtDesignation";
            this.txtDesignation.ReadOnly = true;
            this.txtDesignation.Size = new System.Drawing.Size(134, 20);
            this.txtDesignation.TabIndex = 41;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(28, 73);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // lblManageEmployee
            // 
            this.lblManageEmployee.AutoSize = true;
            this.lblManageEmployee.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageEmployee.ForeColor = System.Drawing.Color.White;
            this.lblManageEmployee.Location = new System.Drawing.Point(98, 89);
            this.lblManageEmployee.Name = "lblManageEmployee";
            this.lblManageEmployee.Size = new System.Drawing.Size(0, 24);
            this.lblManageEmployee.TabIndex = 39;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(17, 485);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(92, 23);
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
            this.lblInstraction.Location = new System.Drawing.Point(25, 182);
            this.lblInstraction.Name = "lblInstraction";
            this.lblInstraction.Size = new System.Drawing.Size(164, 15);
            this.lblInstraction.TabIndex = 35;
            this.lblInstraction.Text = "*Please insert Employee ID* ";
            // 
            // txtSearchByID
            // 
            this.txtSearchByID.Location = new System.Drawing.Point(13, 149);
            this.txtSearchByID.Name = "txtSearchByID";
            this.txtSearchByID.Size = new System.Drawing.Size(192, 20);
            this.txtSearchByID.TabIndex = 34;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(211, 149);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 33;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtContactNumber
            // 
            this.txtContactNumber.Location = new System.Drawing.Point(156, 335);
            this.txtContactNumber.Name = "txtContactNumber";
            this.txtContactNumber.ReadOnly = true;
            this.txtContactNumber.Size = new System.Drawing.Size(134, 20);
            this.txtContactNumber.TabIndex = 29;
            // 
            // lblContactNumber
            // 
            this.lblContactNumber.AutoSize = true;
            this.lblContactNumber.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactNumber.ForeColor = System.Drawing.Color.White;
            this.lblContactNumber.Location = new System.Drawing.Point(14, 336);
            this.lblContactNumber.Name = "lblContactNumber";
            this.lblContactNumber.Size = new System.Drawing.Size(119, 19);
            this.lblContactNumber.TabIndex = 28;
            this.lblContactNumber.Text = "Contact Number";
            // 
            // lblDesignation
            // 
            this.lblDesignation.AutoSize = true;
            this.lblDesignation.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesignation.ForeColor = System.Drawing.Color.White;
            this.lblDesignation.Location = new System.Drawing.Point(13, 305);
            this.lblDesignation.Name = "lblDesignation";
            this.lblDesignation.Size = new System.Drawing.Size(89, 19);
            this.lblDesignation.TabIndex = 19;
            this.lblDesignation.Text = "Designation";
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.Location = new System.Drawing.Point(155, 276);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.ReadOnly = true;
            this.txtEmployeeName.Size = new System.Drawing.Size(134, 20);
            this.txtEmployeeName.TabIndex = 18;
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeName.ForeColor = System.Drawing.Color.White;
            this.lblEmployeeName.Location = new System.Drawing.Point(13, 277);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(119, 19);
            this.lblEmployeeName.TabIndex = 17;
            this.lblEmployeeName.Text = "Employee Name";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(155, 248);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(134, 20);
            this.txtID.TabIndex = 16;
            // 
            // lblemployeeID
            // 
            this.lblemployeeID.AutoSize = true;
            this.lblemployeeID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemployeeID.ForeColor = System.Drawing.Color.White;
            this.lblemployeeID.Location = new System.Drawing.Point(13, 249);
            this.lblemployeeID.Name = "lblemployeeID";
            this.lblemployeeID.Size = new System.Drawing.Size(97, 19);
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
            this.ContactNumber});
            this.dgvEmployeeData.Location = new System.Drawing.Point(307, 60);
            this.dgvEmployeeData.Name = "dgvEmployeeData";
            this.dgvEmployeeData.ReadOnly = true;
            this.dgvEmployeeData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployeeData.Size = new System.Drawing.Size(447, 457);
            this.dgvEmployeeData.TabIndex = 1;
            this.dgvEmployeeData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvViewEmployee);
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
            // ContactNumber
            // 
            this.ContactNumber.DataPropertyName = "Contact Number";
            this.ContactNumber.HeaderText = "Contact Number";
            this.ContactNumber.Name = "ContactNumber";
            this.ContactNumber.ReadOnly = true;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(3, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(58, 23);
            this.btnBack.TabIndex = 44;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // ViewEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 520);
            this.Controls.Add(this.pnlBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewEmployees";
            this.Load += new System.EventHandler(this.ViewEmployees_Load);
            this.pnlBackground.ResumeLayout(false);
            this.pnlBackground.PerformLayout();
            this.pnlAdd.ResumeLayout(false);
            this.pnlAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBackground;
        private System.Windows.Forms.DataGridView dgvEmployeeData;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Designation;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContactNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlAdd;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblManageEmployee;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblInstraction;
        private System.Windows.Forms.TextBox txtSearchByID;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtContactNumber;
        private System.Windows.Forms.Label lblContactNumber;
        private System.Windows.Forms.Label lblDesignation;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblemployeeID;
        private System.Windows.Forms.TextBox txtDesignation;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblViewEmployee;
        private System.Windows.Forms.Button btnBack;
    }
}