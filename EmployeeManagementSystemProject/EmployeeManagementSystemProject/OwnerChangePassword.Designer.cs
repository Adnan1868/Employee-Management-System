namespace EmployeeManagementSystemProject
{
    partial class OwnerChangePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OwnerChangePassword));
            this.pnlBackground = new System.Windows.Forms.Panel();
            this.pnlChangeYourPassword = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtReTypeNewPassword = new System.Windows.Forms.TextBox();
            this.lblReTypeNewPassword = new System.Windows.Forms.Label();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.txtOldPassword = new System.Windows.Forms.TextBox();
            this.lblOldPassword = new System.Windows.Forms.Label();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.lblUserID = new System.Windows.Forms.Label();
            this.lblHeading = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.pnlBackground.SuspendLayout();
            this.pnlChangeYourPassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBackground
            // 
            this.pnlBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.pnlBackground.Controls.Add(this.pnlChangeYourPassword);
            this.pnlBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBackground.Location = new System.Drawing.Point(0, 0);
            this.pnlBackground.Name = "pnlBackground";
            this.pnlBackground.Size = new System.Drawing.Size(800, 601);
            this.pnlBackground.TabIndex = 0;
            // 
            // pnlChangeYourPassword
            // 
            this.pnlChangeYourPassword.BackColor = System.Drawing.Color.White;
            this.pnlChangeYourPassword.Controls.Add(this.label1);
            this.pnlChangeYourPassword.Controls.Add(this.btnBack);
            this.pnlChangeYourPassword.Controls.Add(this.btnSave);
            this.pnlChangeYourPassword.Controls.Add(this.btnClear);
            this.pnlChangeYourPassword.Controls.Add(this.pictureBox1);
            this.pnlChangeYourPassword.Controls.Add(this.txtReTypeNewPassword);
            this.pnlChangeYourPassword.Controls.Add(this.lblReTypeNewPassword);
            this.pnlChangeYourPassword.Controls.Add(this.txtNewPassword);
            this.pnlChangeYourPassword.Controls.Add(this.lblNewPassword);
            this.pnlChangeYourPassword.Controls.Add(this.txtOldPassword);
            this.pnlChangeYourPassword.Controls.Add(this.lblOldPassword);
            this.pnlChangeYourPassword.Controls.Add(this.txtUserId);
            this.pnlChangeYourPassword.Controls.Add(this.lblUserID);
            this.pnlChangeYourPassword.Controls.Add(this.lblHeading);
            this.pnlChangeYourPassword.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlChangeYourPassword.Location = new System.Drawing.Point(0, 55);
            this.pnlChangeYourPassword.Name = "pnlChangeYourPassword";
            this.pnlChangeYourPassword.Size = new System.Drawing.Size(800, 517);
            this.pnlChangeYourPassword.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(254, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 19);
            this.label1.TabIndex = 13;
            this.label1.Text = "Changing your Passwrod is a good initiative!";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(486, 463);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(84, 31);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(364, 463);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(85, 31);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(348, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(113, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // txtReTypeNewPassword
            // 
            this.txtReTypeNewPassword.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtReTypeNewPassword.Location = new System.Drawing.Point(349, 384);
            this.txtReTypeNewPassword.Multiline = true;
            this.txtReTypeNewPassword.Name = "txtReTypeNewPassword";
            this.txtReTypeNewPassword.Size = new System.Drawing.Size(190, 20);
            this.txtReTypeNewPassword.TabIndex = 8;
            // 
            // lblReTypeNewPassword
            // 
            this.lblReTypeNewPassword.AutoSize = true;
            this.lblReTypeNewPassword.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReTypeNewPassword.Location = new System.Drawing.Point(133, 387);
            this.lblReTypeNewPassword.Name = "lblReTypeNewPassword";
            this.lblReTypeNewPassword.Size = new System.Drawing.Size(168, 17);
            this.lblReTypeNewPassword.TabIndex = 7;
            this.lblReTypeNewPassword.Text = "Re-Type New Password:";
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtNewPassword.Location = new System.Drawing.Point(349, 339);
            this.txtNewPassword.Multiline = true;
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(190, 20);
            this.txtNewPassword.TabIndex = 6;
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewPassword.Location = new System.Drawing.Point(193, 339);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(108, 17);
            this.lblNewPassword.TabIndex = 5;
            this.lblNewPassword.Text = "New Password:";
            // 
            // txtOldPassword
            // 
            this.txtOldPassword.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtOldPassword.Location = new System.Drawing.Point(349, 296);
            this.txtOldPassword.Multiline = true;
            this.txtOldPassword.Name = "txtOldPassword";
            this.txtOldPassword.Size = new System.Drawing.Size(190, 20);
            this.txtOldPassword.TabIndex = 4;
            // 
            // lblOldPassword
            // 
            this.lblOldPassword.AutoSize = true;
            this.lblOldPassword.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOldPassword.Location = new System.Drawing.Point(194, 295);
            this.lblOldPassword.Name = "lblOldPassword";
            this.lblOldPassword.Size = new System.Drawing.Size(107, 17);
            this.lblOldPassword.TabIndex = 3;
            this.lblOldPassword.Text = "Old Password: ";
            // 
            // txtUserId
            // 
            this.txtUserId.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtUserId.Location = new System.Drawing.Point(349, 251);
            this.txtUserId.Multiline = true;
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(190, 20);
            this.txtUserId.TabIndex = 2;
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserID.Location = new System.Drawing.Point(235, 251);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(66, 17);
            this.lblUserID.TabIndex = 1;
            this.lblUserID.Text = "User ID:";
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(254, 137);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(302, 24);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "Want to Change your Password?";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Black;
            this.btnBack.Location = new System.Drawing.Point(258, 463);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(74, 31);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // OwnerChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 601);
            this.Controls.Add(this.pnlBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OwnerChangePassword";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangeYourPassword";
            this.pnlBackground.ResumeLayout(false);
            this.pnlChangeYourPassword.ResumeLayout(false);
            this.pnlChangeYourPassword.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBackground;
        private System.Windows.Forms.Panel pnlChangeYourPassword;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtReTypeNewPassword;
        private System.Windows.Forms.Label lblReTypeNewPassword;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.TextBox txtOldPassword;
        private System.Windows.Forms.Label lblOldPassword;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label1;
    }
}