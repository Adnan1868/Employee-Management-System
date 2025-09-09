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
    public partial class ManageLeave : Form
    {

        private DataAccess Da { get; set; }
        public ManageLeave()
        {
            InitializeComponent();

            this.Da = new DataAccess();
            this.PopulateGridView();
        }

        
       
        
        private void PopulateGridView(string sql = "select * from EmployeeData;")
        {
            try
            {
                var ds = this.Da.ExecuteQuery(sql);

                this.dgvEmployeeData.AutoGenerateColumns = false;
                this.dgvEmployeeData.DataSource = ds.Tables[0];
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error!" +exc.Message);
            }
        }
    


        private void btnSearch_Click(object sender, EventArgs e)
        {
            string sql = "select * from EmployeeData where [Emp. ID] = '" + txtSearchByID.Text + "'";
            this.PopulateGridView(sql);
        }

        private bool IsValidToSave()
        {
            if (String.IsNullOrEmpty(this.txtID.Text) || String.IsNullOrEmpty(this.txtEmployeeName.Text) || String.IsNullOrEmpty(this.cmbDesignation.Text) || String.IsNullOrEmpty(this.txtTotalLeaveCount.Text))
            {
          
                return false;
            }
            else
            {
                return true;
            }
        }

        private void ClearAll()
        {
            this.txtID.Clear();
            this.txtEmployeeName.Clear();
            this.cmbDesignation.SelectedIndex = -1;
            this.txtTotalLeaveCount.Clear();
            this.txtLeaveIncreaseDay.Clear();

            this.txtSearchByID.Clear();

            this.dgvEmployeeData.ClearSelection();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                int TotalLeaveCount = Convert.ToInt32(this.txtTotalLeaveCount.Text);
                int LeaveCountDays = Convert.ToInt32(this.txtLeaveIncreaseDay.Text);
                int penaltyDay = TotalLeaveCount + LeaveCountDays;

                var query = "select * from EmployeeData where [Emp. ID] = '" + this.txtID.Text + "';";
                var ds = this.Da.ExecuteQuery(query);

                if (!IsValidToSave())
                {

                    if (TotalLeaveCount < 0) { MessageBox.Show("Sorry this is not valid"); }
                    MessageBox.Show("Please fill all the information!");
                    return;
                }

                if (ds.Tables[0].Rows.Count == 1)
                {
                    //update
                    var sql = @"UPDATE EmployeeData SET [Total Leave Count] = " + this.txtTotalLeaveCount.Text + " + " + this.txtLeaveIncreaseDay.Text + " where [Emp. ID] =  '" + this.txtID.Text + "';";

                    int count = this.Da.ExecuteDMLQuery(sql);

                    if (count == 1)

                    {
                        MessageBox.Show("Leave Count updated!");


                        if (penaltyDay > 20)
                        {
                            MessageBox.Show("This employee has taken more than 20 leaves. Penalty: 500 BDT");

                            int penalty = 500;
                            int days = penaltyDay - 20;
                            var sql1 = "UPDATE EmployeeData SET Salary = " + this.txtSalary.Text + " - " + penalty + " * " + days + " where [Emp. ID] = '" + this.txtID.Text + "'";
                            int Count1 = this.Da.ExecuteDMLQuery(sql1);

                            this.PopulateGridView();

                        }

                    }


                    else
                    {
                        MessageBox.Show("Leave Count isn't Updated!");
                    }

                    this.PopulateGridView();
                    this.ClearAll();
                }

            }
            catch (Exception exc)
            {
                MessageBox.Show("This is an error: " + exc.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearAll();
            this.PopulateGridView();
        }

        private void dgvManageLeave(object sender, DataGridViewCellEventArgs e)
        {
            this.txtID.Text = this.dgvEmployeeData.CurrentRow.Cells[0].Value.ToString();
            this.txtEmployeeName.Text = this.dgvEmployeeData.CurrentRow.Cells[1].Value.ToString();
            this.cmbDesignation.Text = this.dgvEmployeeData.CurrentRow.Cells[2].Value.ToString();
            this.txtTotalLeaveCount.Text = this.dgvEmployeeData.CurrentRow.Cells[3].Value.ToString();
            this.txtSalary.Text = this.dgvEmployeeData.CurrentRow.Cells[4].Value.ToString();
        }

        private void ManageLeave_Load(object sender, EventArgs e)
        {
            this.dgvEmployeeData.ClearSelection();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LoginForm().Show();
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

