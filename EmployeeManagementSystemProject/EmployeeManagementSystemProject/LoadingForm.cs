using System;
using System.Windows.Forms;

namespace EmployeeManagementSystemProject
{
    public partial class LoadingForm : Form
    {
        public LoadingForm()
        {
            InitializeComponent();
        }

        private void pnlDesign_Paint(object sender, PaintEventArgs e)
        {
            timerLoading.Start();
        }

        private void timerLoading_Tick(object sender, EventArgs e)
        {
            if (progressBar.Value < 100)
            {
                progressBar.Value += 1;
                lblPercentage.Text = progressBar.Value.ToString() + "%";
            }
            else if (progressBar.Value == 100)
            {
                timerLoading.Stop();

                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                this.Hide();
            }
        }

        
    }
}
