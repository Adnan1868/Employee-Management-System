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
    public partial class ManageEmployee : Form
    {
        private DataAccess Da { get; set; }
        public ManageEmployee()
        {
            InitializeComponent();

            this.Da = new DataAccess();
            this.PopulateGridView();
            this.AutoIdGenerate();
        }
        private void PopulateGridView(string sql = "select * from EmployeeData;")
        {
            var ds = this.Da.ExecuteQuery(sql);

            this.dgvEmployeeData.AutoGenerateColumns = false;
            this.dgvEmployeeData.DataSource = ds.Tables[0];

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string sql = "select * from EmployeeData where [Emp. ID] = '" + txtSearchByID.Text + "'";
            this.PopulateGridView(sql);
        }

        private bool IsValidToSave()
        {
            if (String.IsNullOrEmpty(this.txtID.Text) || String.IsNullOrEmpty(this.txtEmployeeName.Text) || String.IsNullOrEmpty(this.txtContactNumber.Text) || String.IsNullOrEmpty(this.txtSalary.Text) || String.IsNullOrEmpty(this.cmbDesignation.Text))
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
                if (!IsValidToSave())
                {
                    MessageBox.Show("Please fill all the information!");
                    return;
                }
                var query = "select * from EmployeeData where [Emp. ID] = '" + this.txtID.Text + "';";
                var ds = this.Da.ExecuteQuery(query);

                if (ds.Tables[0].Rows.Count == 1)
                {
                    //update
                    var sql = @"update EmployeeData set [Emp. Name] = '" + this.txtEmployeeName.Text + "', Designation = '" + this.cmbDesignation.Text + "', Salary = " + this.txtSalary.Text + ", DOB = '" + this.dtpDOB.Text + "', [Contact Number] = '" + this.txtContactNumber.Text + "', [Joining Date] ='" + this.dtpJoiningdate.Text + "' where [Emp. ID] = '" + this.txtID.Text + "';";

                    int count = this.Da.ExecuteDMLQuery(sql);

                    if (count == 1)
                        MessageBox.Show("Data Updated!");
                    else
                    {
                        MessageBox.Show("Data is not Updated!");
                    }

                    this.PopulateGridView();
                    this.ClearAll();
                }
                else
                {
                    //insert
                    var sql = @"INSERT INTO EmployeeData ([Emp. ID] , [Emp. Name], Designation, Salary, DOB, [Contact Number], [Joining Date])
                                VALUES('" + this.txtID.Text + "', '" + this.txtEmployeeName.Text + "', '" + this.cmbDesignation.Text + "', " + this.txtSalary.Text + ", '" + this.dtpDOB.Text + "', '" + this.txtContactNumber.Text + "', '" + this.dtpJoiningdate.Text + "'); ";
                    int count = this.Da.ExecuteDMLQuery(sql);

                    if (count == 1)
                        MessageBox.Show("Data Added!");
                    else
                    {
                        MessageBox.Show("Data is not added!");
                    }
                    this.PopulateGridView();
                    this.ClearAll();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("This is an error in your input: " + exc.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvEmployeeData.SelectedRows.Count < 1)
                {
                    MessageBox.Show("Please select a row first!", "Error", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Error);
                    return;
                }
                DialogResult result = MessageBox.Show("Are you sure you want to delete?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.No)
                    return;
                {
                    var EmpID = this.dgvEmployeeData.CurrentRow.Cells[0].Value.ToString();
                    var EmpName = this.dgvEmployeeData.CurrentRow.Cells[1].Value.ToString();

                    var sql = "delete from EmployeeData where [Emp. ID] = '" + EmpID + "';";
                    int count = this.Da.ExecuteDMLQuery(sql);


                    if (count == 1)
                    {
                        MessageBox.Show(EmpName.ToUpper() + "Has been removed from the Employee List");
                    }
                    else
                    {
                        MessageBox.Show("Data is not Deleted!");
                    }
                    this.PopulateGridView();
                    this.ClearAll();
                }
            }

            catch (Exception exc)
            {
                MessageBox.Show("There is an error in your input: " + exc.Message);
            }
        }

        private void ClearAll()
        {
            this.txtID.Clear();
            this.txtEmployeeName.Clear();
            this.cmbDesignation.SelectedIndex = -1;
            this.txtSalary.Clear();
            this.txtContactNumber.Clear();

            this.txtSearchByID.Clear();

            this.dgvEmployeeData.ClearSelection();
            this.AutoIdGenerate();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearAll();
            this.PopulateGridView();
        }

        private void AutoIdGenerate()
        {
            var sql = "select [Emp. ID] from EmployeeData order by [Emp. ID] desc;";
            var dt = this.Da.ExecuteQueryTable(sql);
            string oldID = dt.Rows[0][0].ToString();
            string[] temp = oldID.Split('-');
            int num = Convert.ToInt32(temp[1]);
            string newID = "E-" + (++num).ToString("d3");
            this.txtID.Text = newID;
        }

        private void dgvManageEmployee(object sender, DataGridViewCellEventArgs e)
        {
            this.txtID.Text = this.dgvEmployeeData.CurrentRow.Cells[0].Value.ToString();
            this.txtEmployeeName.Text = this.dgvEmployeeData.CurrentRow.Cells[1].Value.ToString();
            this.cmbDesignation.Text = this.dgvEmployeeData.CurrentRow.Cells[2].Value.ToString();
            this.txtSalary.Text = this.dgvEmployeeData.CurrentRow.Cells[3].Value.ToString();
            this.dtpDOB.Text = this.dgvEmployeeData.CurrentRow.Cells[4].Value.ToString();
            this.txtContactNumber.Text = this.dgvEmployeeData.CurrentRow.Cells[5].Value.ToString();
            this.dtpJoiningdate.Text = this.dgvEmployeeData.CurrentRow.Cells[6].Value.ToString();
        }

        private void ManageEmployee_Load(object sender, EventArgs e)
        {
            this.dgvEmployeeData.ClearSelection();
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Owner().Show();
        }
    }
}
