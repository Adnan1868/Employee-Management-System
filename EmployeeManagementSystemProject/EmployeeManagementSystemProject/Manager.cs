using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagementSystemProject
{
    public partial class Manager : Form
    {
        public Manager()
        {
            InitializeComponent();
        }

        public Manager(string username, LoginForm fl) : this()
        {


        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            this.Hide();
            new OwnerChangePassword().Show();
        }

        private void btnViewEmplyee_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ViewEmployees().Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
