namespace EmployeeManagementSystemProject
{
    partial class AddUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUser));
            this.pnlBackground = new System.Windows.Forms.Panel();
            this.pnlAddManager = new System.Windows.Forms.Panel();
            this.txtRole = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtReTypeNewPassword = new System.Windows.Forms.TextBox();
            this.lblReTypeNewPassword = new System.Windows.Forms.Label();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.lblUserID = new System.Windows.Forms.Label();
            this.lblHeading = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlBackground.SuspendLayout();
            this.pnlAddManager.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBackground
            // 
            this.pnlBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.pnlBackground.Controls.Add(this.pnlAddManager);
            this.pnlBackground.Controls.Add(this.btnBack);
            this.pnlBackground.Location = new System.Drawing.Point(0, 0);
            this.pnlBackground.Name = "pnlBackground";
            this.pnlBackground.Size = new System.Drawing.Size(803, 530);
            this.pnlBackground.TabIndex = 0;
            // 
            // pnlAddManager
            // 
            this.pnlAddManager.BackColor = System.Drawing.Color.White;
            this.pnlAddManager.Controls.Add(this.pictureBox1);
            this.pnlAddManager.Controls.Add(this.txtRole);
            this.pnlAddManager.Controls.Add(this.label1);
            this.pnlAddManager.Controls.Add(this.txtUserName);
            this.pnlAddManager.Controls.Add(this.lblUserName);
            this.pnlAddManager.Controls.Add(this.btnAdd);
            this.pnlAddManager.Controls.Add(this.btnClear);
            this.pnlAddManager.Controls.Add(this.txtReTypeNewPassword);
            this.pnlAddManager.Controls.Add(this.lblReTypeNewPassword);
            this.pnlAddManager.Controls.Add(this.txtNewPassword);
            this.pnlAddManager.Controls.Add(this.lblNewPassword);
            this.pnlAddManager.Controls.Add(this.txtUserId);
            this.pnlAddManager.Controls.Add(this.lblUserID);
            this.pnlAddManager.Controls.Add(this.lblHeading);
            this.pnlAddManager.Location = new System.Drawing.Point(0, 57);
            this.pnlAddManager.Name = "pnlAddManager";
            this.pnlAddManager.Size = new System.Drawing.Size(800, 449);
            this.pnlAddManager.TabIndex = 0;
            // 
            // txtRole
            // 
            this.txtRole.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtRole.Location = new System.Drawing.Point(420, 299);
            this.txtRole.Multiline = true;
            this.txtRole.Name = "txtRole";
            this.txtRole.Size = new System.Drawing.Size(190, 20);
            this.txtRole.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(323, 299);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 26;
            this.label1.Text = "Role: ";
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtUserName.Location = new System.Drawing.Point(420, 270);
            this.txtUserName.Multiline = true;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(190, 20);
            this.txtUserName.TabIndex = 25;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(284, 270);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(87, 17);
            this.lblUserName.TabIndex = 24;
            this.lblUserName.Text = "User Name:";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(448, 393);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(84, 37);
            this.btnAdd.TabIndex = 23;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.btnClear.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(326, 393);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 37);
            this.btnClear.TabIndex = 22;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(7, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(64, 29);
            this.btnBack.TabIndex = 21;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtReTypeNewPassword
            // 
            this.txtReTypeNewPassword.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtReTypeNewPassword.Location = new System.Drawing.Point(420, 358);
            this.txtReTypeNewPassword.Multiline = true;
            this.txtReTypeNewPassword.Name = "txtReTypeNewPassword";
            this.txtReTypeNewPassword.Size = new System.Drawing.Size(190, 20);
            this.txtReTypeNewPassword.TabIndex = 20;
            // 
            // lblReTypeNewPassword
            // 
            this.lblReTypeNewPassword.AutoSize = true;
            this.lblReTypeNewPassword.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReTypeNewPassword.Location = new System.Drawing.Point(203, 361);
            this.lblReTypeNewPassword.Name = "lblReTypeNewPassword";
            this.lblReTypeNewPassword.Size = new System.Drawing.Size(168, 17);
            this.lblReTypeNewPassword.TabIndex = 19;
            this.lblReTypeNewPassword.Text = "Re-Type New Password:";
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtNewPassword.Location = new System.Drawing.Point(420, 327);
            this.txtNewPassword.Multiline = true;
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(190, 20);
            this.txtNewPassword.TabIndex = 18;
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewPassword.Location = new System.Drawing.Point(263, 327);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(108, 17);
            this.lblNewPassword.TabIndex = 17;
            this.lblNewPassword.Text = "New Password:";
            // 
            // txtUserId
            // 
            this.txtUserId.Location = new System.Drawing.Point(420, 239);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.ReadOnly = true;
            this.txtUserId.Size = new System.Drawing.Size(190, 20);
            this.txtUserId.TabIndex = 14;
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserID.Location = new System.Drawing.Point(305, 239);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(66, 17);
            this.lblUserID.TabIndex = 13;
            this.lblUserID.Text = "User ID:";
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(155, 111);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(529, 72);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "                                          Welcome!\r\n\r\n*To Add an User, Please Pro" +
    "vide the informations Below.* ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(365, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 530);
            this.Controls.Add(this.pnlBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddUserOrAdmin";
            this.pnlBackground.ResumeLayout(false);
            this.pnlAddManager.ResumeLayout(false);
            this.pnlAddManager.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBackground;
        private System.Windows.Forms.Panel pnlAddManager;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtReTypeNewPassword;
        private System.Windows.Forms.Label lblReTypeNewPassword;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox txtRole;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}