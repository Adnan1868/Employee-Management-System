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
    public partial class ViewEmployees : Form
    {
        private DataAccess Da { get; set; }
        public ViewEmployees()
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

        private void ClearAll()
        {
            this.txtID.Clear();
            this.txtEmployeeName.Clear();
            this.txtDesignation.Clear(); ;
            this.txtContactNumber.Clear();

            this.txtSearchByID.Clear();

            this.dgvEmployeeData.ClearSelection();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearAll();
        }

        private void dgvViewEmployee(object sender, DataGridViewCellEventArgs e)
        {
            this.txtID.Text = this.dgvEmployeeData.CurrentRow.Cells[0].Value.ToString();
            this.txtEmployeeName.Text = this.dgvEmployeeData.CurrentRow.Cells[1].Value.ToString();
            this.txtDesignation.Text = this.dgvEmployeeData.CurrentRow.Cells[2].Value.ToString();
            this.txtContactNumber.Text = this.dgvEmployeeData.CurrentRow.Cells[3].Value.ToString();
        }

        private void ViewEmployees_Load(object sender, EventArgs e)
        {
            this.dgvEmployeeData.ClearSelection();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LoginForm ().Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Manager().Show();
        }
    }
}
