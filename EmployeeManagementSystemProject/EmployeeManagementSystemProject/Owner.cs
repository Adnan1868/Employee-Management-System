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

    public partial class Owner : Form
    {
        private DataAccess Da { get; set; }

        internal Owner admin { get; set; }

        public Owner(string username, LoginForm fl):this() 
        { 
        }

        private LoginForm loginForm { get; set; }
        public Owner()
        {
            InitializeComponent();

            this.Da = new DataAccess();
        }
       

        private void btnManageEmplyee_Click(object sender, EventArgs e)
        {
            ManageEmployee manageEmployee = new ManageEmployee();
            manageEmployee.Show();
            this.Hide();
        }

        private void btnChangeYourPassword_Click(object sender, EventArgs e)
        {
            this.Hide();
            new OwnerChangePassword().Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
        private void btnLeaveHistory_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ManageLeave().Show();
        }

        private void btnAddUSerOrAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AddUser().Show();
        }

        private void btnUpdatesalary_Click(object sender, EventArgs e)
        {
            this.Hide();
            new UpdateSalary().Show();
        }
    }
}
