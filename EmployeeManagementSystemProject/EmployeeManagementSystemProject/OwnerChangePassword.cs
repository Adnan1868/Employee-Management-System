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
    public partial class OwnerChangePassword : Form
    {

        private DataAccess Da { get; set; }
        public OwnerChangePassword()
        {
            InitializeComponent();

            this.Da = new DataAccess();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Owner().Show();
        }

        private void ClearAll()
        {
            this.txtUserId.Clear();
            this.txtOldPassword.Clear();
            this.txtNewPassword.Clear();
            this.txtReTypeNewPassword.Clear();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearAll();
        }

        private bool IsValidToSave()
        {
            if (String.IsNullOrEmpty(this.txtUserId.Text) || String.IsNullOrEmpty(this.txtOldPassword.Text) || String.IsNullOrEmpty(this.txtNewPassword.Text) || String.IsNullOrEmpty(this.txtReTypeNewPassword.Text))
                return false;
            else
            {
                return true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string query = @"select * from UserInfo where Id = '" + this.txtUserId.Text + "' and Password = '" + this.txtOldPassword.Text + "'";
                var ds = this.Da.ExecuteQuery(query);


                string UserId = this.txtUserId.Text;
                string OldPassword = this.txtOldPassword.Text;
                string NewPassword = this.txtNewPassword.Text;
                string retypePassword = this.txtReTypeNewPassword.Text; 

                if (ds.Tables[0].Rows.Count == 1)
                {
                    {
                        if (!IsValidToSave())
                        {
                            MessageBox.Show("Please fill all the information!");
                            return;
                        }
                        //var query1 = "select * from UserInfo where id = '" + this.txtUserId + "'and Password = '" + this.txtOldPassword + "';;";
                        //var ds1 = this.Da.ExecuteQuery(query1);

                        //update
                        var sql = @"update UserInfo set Password = '"+this.txtNewPassword.Text+"' where Id = '"+this.txtUserId.Text+"';";

                        int count = this.Da.ExecuteDMLQuery(sql);

                        if (count == 1 && NewPassword == retypePassword)
                        {
                            MessageBox.Show("Password Updated! You Need to login Again for security purposes!");
                            this.Hide();
                            new LoginForm().Show();
                        }
                        else
                        {
                            MessageBox.Show("Password is not Updated!");
                        }                        
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Credentials! Please fillup all the informations correctly!");
                }

            }
            catch (Exception exc)
            {
                MessageBox.Show("There is an error: " + exc.Message);
            }
        }

       
    }
}

