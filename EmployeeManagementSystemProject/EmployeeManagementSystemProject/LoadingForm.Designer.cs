
namespace EmployeeManagementSystemProject
{
    partial class LoadingForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadingForm));
            this.pnlDesign = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblPercentage = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.lblPercenteage = new System.Windows.Forms.Label();
            this.lblLoading = new System.Windows.Forms.Label();
            this.lblHeading = new System.Windows.Forms.Label();
            this.timerLoading = new System.Windows.Forms.Timer(this.components);
            this.pnlDesign.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDesign
            // 
            this.pnlDesign.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlDesign.BackgroundImage")));
            this.pnlDesign.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlDesign.Controls.Add(this.pictureBox1);
            this.pnlDesign.Controls.Add(this.lblPercentage);
            this.pnlDesign.Controls.Add(this.progressBar);
            this.pnlDesign.Controls.Add(this.lblPercenteage);
            this.pnlDesign.Controls.Add(this.lblLoading);
            this.pnlDesign.Controls.Add(this.lblHeading);
            this.pnlDesign.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDesign.Location = new System.Drawing.Point(0, 0);
            this.pnlDesign.Name = "pnlDesign";
            this.pnlDesign.Size = new System.Drawing.Size(578, 304);
            this.pnlDesign.TabIndex = 0;
            this.pnlDesign.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDesign_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(248, 80);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(79, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // lblPercentage
            // 
            this.lblPercentage.AutoSize = true;
            this.lblPercentage.BackColor = System.Drawing.Color.Transparent;
            this.lblPercentage.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercentage.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPercentage.Location = new System.Drawing.Point(105, 260);
            this.lblPercentage.Name = "lblPercentage";
            this.lblPercentage.Size = new System.Drawing.Size(95, 19);
            this.lblPercentage.TabIndex = 5;
            this.lblPercentage.Text = "Percentage";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(0, 288);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(863, 15);
            this.progressBar.TabIndex = 3;
            // 
            // lblPercenteage
            // 
            this.lblPercenteage.AutoSize = true;
            this.lblPercenteage.BackColor = System.Drawing.Color.Transparent;
            this.lblPercenteage.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPercenteage.Location = new System.Drawing.Point(119, 256);
            this.lblPercenteage.Name = "lblPercenteage";
            this.lblPercenteage.Size = new System.Drawing.Size(0, 13);
            this.lblPercenteage.TabIndex = 2;
            // 
            // lblLoading
            // 
            this.lblLoading.AutoSize = true;
            this.lblLoading.BackColor = System.Drawing.Color.Transparent;
            this.lblLoading.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoading.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblLoading.Location = new System.Drawing.Point(12, 256);
            this.lblLoading.Name = "lblLoading";
            this.lblLoading.Size = new System.Drawing.Size(107, 22);
            this.lblLoading.TabIndex = 1;
            this.lblLoading.Text = "Loading . . .";
            // 
            // lblHeading
            // 
            this.lblHeading.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblHeading.AutoSize = true;
            this.lblHeading.BackColor = System.Drawing.Color.Transparent;
            this.lblHeading.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblHeading.Location = new System.Drawing.Point(92, 25);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(375, 31);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "Employee Management System";
            // 
            // timerLoading
            // 
            this.timerLoading.Interval = 15;
            this.timerLoading.Tick += new System.EventHandler(this.timerLoading_Tick);
            // 
            // LoadingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 304);
            this.Controls.Add(this.pnlDesign);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoadingForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoadingForm";
            this.pnlDesign.ResumeLayout(false);
            this.pnlDesign.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDesign;
        private System.Windows.Forms.Label lblPercentage;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label lblPercenteage;
        private System.Windows.Forms.Label lblLoading;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Timer timerLoading;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

