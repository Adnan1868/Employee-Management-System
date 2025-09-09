using EmployeeManagementSystemProject;
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
    

    public partial class LoginForm : Form
    {
        private DataAccess Da { get; set; }

        internal Owner admin { get; set; }

        internal Manager employee { get; set; }
        public LoginForm()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }

        private void cbPassword_CheckedChanged(object sender, EventArgs e)
        {
            this.txtPassword.PasswordChar = this.cbPassword.Checked ? '\0' : '*';
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {

                if (this.txtUserId.Text.Length == 0 || this.txtPassword.Text.Length == 0)
                {
                    MessageBox.Show("Please Enter all information", "", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    return;
                }

                string query = @"select * from UserInfo where Id = '"+this.txtUserId.Text+"' and Password = '"+this.txtPassword.Text+"'";
                var ds = this.Da.ExecuteQuery(query);

                if (ds.Tables[0].Rows.Count == 1)
                {
                    MessageBox.Show("Welcome to Alchem Enterprise");

                    if (ds.Tables[0].Rows[0][3].ToString() == "Owner")
                    {                        
                        this.Hide();
                        new Owner(ds.Tables[0].Rows[0][1].ToString(), this).Show();
                    }
                    else if (ds.Tables[0].Rows[0][3].ToString() == "Manager")
                    {
                        this.Hide();
                        new Manager(ds.Tables[0].Rows[0][1].ToString(), this).Show();
                    }
                }
                else
                    MessageBox.Show("Invalid Credentials!");
            }
            catch(Exception exc)
            {
                MessageBox.Show("There is an error!" + exc.Message);
            }
        }
    }
}
