namespace EmployeeManagementSystemProject
{
    partial class Manager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manager));
            this.pnlEmployee = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblHeading = new System.Windows.Forms.Label();
            this.pbLeaveHistory = new System.Windows.Forms.PictureBox();
            this.pbMangeEmployee = new System.Windows.Forms.PictureBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.btnViewEmplyee = new System.Windows.Forms.Button();
            this.lblWelcoming = new System.Windows.Forms.Label();
            this.pnlEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLeaveHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMangeEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlEmployee
            // 
            this.pnlEmployee.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pnlEmployee.Controls.Add(this.btnExit);
            this.pnlEmployee.Controls.Add(this.lblHeading);
            this.pnlEmployee.Controls.Add(this.pbLeaveHistory);
            this.pnlEmployee.Controls.Add(this.pbMangeEmployee);
            this.pnlEmployee.Controls.Add(this.btnLogout);
            this.pnlEmployee.Controls.Add(this.btnChangePassword);
            this.pnlEmployee.Controls.Add(this.btnViewEmplyee);
            this.pnlEmployee.Controls.Add(this.lblWelcoming);
            this.pnlEmployee.Location = new System.Drawing.Point(0, 34);
            this.pnlEmployee.Name = "pnlEmployee";
            this.pnlEmployee.Size = new System.Drawing.Size(788, 343);
            this.pnlEmployee.TabIndex = 1;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(589, 297);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(186, 33);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.ForeColor = System.Drawing.Color.Black;
            this.lblHeading.Location = new System.Drawing.Point(266, 16);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(275, 31);
            this.lblHeading.TabIndex = 14;
            this.lblHeading.Text = "Manager\'s Dashboard";
            // 
            // pbLeaveHistory
            // 
            this.pbLeaveHistory.Image = ((System.Drawing.Image)(resources.GetObject("pbLeaveHistory.Image")));
            this.pbLeaveHistory.Location = new System.Drawing.Point(468, 105);
            this.pbLeaveHistory.Name = "pbLeaveHistory";
            this.pbLeaveHistory.Size = new System.Drawing.Size(103, 92);
            this.pbLeaveHistory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLeaveHistory.TabIndex = 13;
            this.pbLeaveHistory.TabStop = false;
            // 
            // pbMangeEmployee
            // 
            this.pbMangeEmployee.Image = ((System.Drawing.Image)(resources.GetObject("pbMangeEmployee.Image")));
            this.pbMangeEmployee.Location = new System.Drawing.Point(209, 105);
            this.pbMangeEmployee.Name = "pbMangeEmployee";
            this.pbMangeEmployee.Size = new System.Drawing.Size(104, 92);
            this.pbMangeEmployee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMangeEmployee.TabIndex = 12;
            this.pbMangeEmployee.TabStop = false;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.btnLogout.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(12, 297);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(186, 33);
            this.btnLogout.TabIndex = 11;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.btnChangePassword.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePassword.ForeColor = System.Drawing.Color.White;
            this.btnChangePassword.Location = new System.Drawing.Point(426, 203);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(186, 33);
            this.btnChangePassword.TabIndex = 9;
            this.btnChangePassword.Text = "Change Password";
            this.btnChangePassword.UseVisualStyleBackColor = false;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // btnViewEmplyee
            // 
            this.btnViewEmplyee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.btnViewEmplyee.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewEmplyee.ForeColor = System.Drawing.Color.White;
            this.btnViewEmplyee.Location = new System.Drawing.Point(170, 203);
            this.btnViewEmplyee.Name = "btnViewEmplyee";
            this.btnViewEmplyee.Size = new System.Drawing.Size(186, 33);
            this.btnViewEmplyee.TabIndex = 8;
            this.btnViewEmplyee.Text = "View Employees";
            this.btnViewEmplyee.UseVisualStyleBackColor = false;
            this.btnViewEmplyee.Click += new System.EventHandler(this.btnViewEmplyee_Click);
            // 
            // lblWelcoming
            // 
            this.lblWelcoming.AutoSize = true;
            this.lblWelcoming.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcoming.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblWelcoming.Location = new System.Drawing.Point(294, 21);
            this.lblWelcoming.Name = "lblWelcoming";
            this.lblWelcoming.Size = new System.Drawing.Size(205, 26);
            this.lblWelcoming.TabIndex = 0;
            this.lblWelcoming.Text = "Welcome to Alchem";
            // 
            // Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(787, 413);
            this.Controls.Add(this.pnlEmployee);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Manager";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee";
            this.pnlEmployee.ResumeLayout(false);
            this.pnlEmployee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLeaveHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMangeEmployee)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlEmployee;
        private System.Windows.Forms.Label lblWelcoming;
        private System.Windows.Forms.PictureBox pbLeaveHistory;
        private System.Windows.Forms.PictureBox pbMangeEmployee;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Button btnViewEmplyee;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Button btnExit;
    }
}