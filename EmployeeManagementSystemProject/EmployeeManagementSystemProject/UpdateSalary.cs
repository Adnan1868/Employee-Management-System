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

    
    public partial class UpdateSalary : Form
    {
        private DataAccess Da { get; set; }
        public UpdateSalary()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGridView();
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
            if (String.IsNullOrEmpty(this.txtID.Text) || String.IsNullOrEmpty(this.txtEmployeeName.Text) ||  String.IsNullOrEmpty(this.txtCurrentSalary.Text) || String.IsNullOrEmpty(this.cmbDesignation.Text))
                return false;
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
            this.txtCurrentSalary.Clear();
            this.txtIncrementSalary.Clear();
            

            this.txtSearchByID.Clear();

            this.dgvEmployeeData.ClearSelection();
            
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
                    var sql = @"UPDATE EmployeeData SET salary = "+this.txtCurrentSalary.Text+" + "+this.txtIncrementSalary.Text+" where [Emp. ID] = '"+this.txtID.Text+"';";

                    int count = this.Da.ExecuteDMLQuery(sql);

                    if (count == 1)
                        MessageBox.Show("Salary Updated!");
                    else
                    {
                        MessageBox.Show("Salary isn't Updated!");
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

        private void dgvUpdateSalary(object sender, DataGridViewCellEventArgs e)
        {
            this.txtID.Text = this.dgvEmployeeData.CurrentRow.Cells[0].Value.ToString();
            this.txtEmployeeName.Text = this.dgvEmployeeData.CurrentRow.Cells[1].Value.ToString();
            this.cmbDesignation.Text = this.dgvEmployeeData.CurrentRow.Cells[2].Value.ToString();
            this.txtCurrentSalary.Text = this.dgvEmployeeData.CurrentRow.Cells[3].Value.ToString();
        }

        private void UpdateSalary_Load(object sender, EventArgs e)
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
