using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagementSystemProject
{
    public partial class AddUser : Form
    {
        private DataAccess Da { get; set; }
        public AddUser()
        {
            InitializeComponent();

            this.Da = new DataAccess();
            this.AutoIdGenerate();
        }
        private void AutoIdGenerate()
        {
            var sql = "select id from userinfo order by id desc;";
            var dt = this.Da.ExecuteQueryTable(sql);
            string oldID = dt.Rows[0][0].ToString();
            string[] temp = oldID.Split('-');
            int num = Convert.ToInt32(temp[1]);
            string newID = "Manager-" + (++num).ToString("d2");
            this.txtUserId.Text = newID;
        }

        private void ClearAll()
        {
            this.txtUserId.Clear();
            this.txtUserName.Clear();
            this.txtNewPassword.Clear();
            this.txtReTypeNewPassword.Clear();
            this.txtRole.Clear();

            this.AutoIdGenerate();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearAll();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            new Owner().Show();
            this.Hide();
        }

        private bool IsValidToSave()
        {
            if (String.IsNullOrEmpty(this.txtUserId.Text) || String.IsNullOrEmpty(this.txtUserName.Text) || String.IsNullOrEmpty(this.txtNewPassword.Text) || String.IsNullOrEmpty(this.txtReTypeNewPassword.Text) || String.IsNullOrEmpty(this.txtRole.Text))
                return false;
            else
            {
                return true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string NewPassword = this.txtNewPassword.Text;
                string retypePassword = this.txtReTypeNewPassword.Text;

                if (NewPassword != retypePassword)

                {
                    MessageBox.Show("New password and re-type password doesn't match");
                }

                if (!IsValidToSave())
                {
                     MessageBox.Show("Please fill all the information!");
                     return;
                }

                if (NewPassword == retypePassword)
                {
                    var sql = @"INSERT INTO UserInfo([Id] , UserName, Password, Role)
                              VALUES('" + this.txtUserId.Text + "', '" + this.txtUserName.Text + "', '" + this.txtNewPassword.Text + "', '" + this.txtRole.Text + "');  ";

                    int count = this.Da.ExecuteDMLQuery(sql);

                    MessageBox.Show("Congratulation! Your new manager has been added!");
                    this.Hide();
                    new Owner().Show();
                }

            }
            catch (Exception exc)
            {
                MessageBox.Show("There is an error: " + exc.Message);
            }
        }
    }
}

