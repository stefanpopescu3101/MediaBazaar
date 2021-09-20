using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaBazaarApp
{
    public partial class Form1 : Form
    {
        DepartmentManager departmentM;
        UserManager userM;
        public Form1()
        {
            InitializeComponent();
            departmentM = new DepartmentManager();
            userM = new UserManager();
            UpdateListInDepartmentManagement();
        
        }
        private void UpdateListInDepartmentManagement()
        {
            lbEmployeesOfDepartment.Items.Clear();
            this.dgvDepartments.Rows.Clear();
            this.dgvDepartments.ColumnCount = 3;
            this.dgvDepartments.Columns[0].Name = "Department Name";
            this.dgvDepartments.Columns[1].Name = "Manager ID";
            this.dgvDepartments.Columns[2].Name = "Manager Name";
            this.dgvDepartments.Columns[0].Width = 250;
            this.dgvDepartments.Columns[1].Width = 100;
            this.dgvDepartments.Columns[2].Width = 250;

            foreach (Department d in this.departmentM.GetDepartments())
            {
                
                    this.dgvDepartments.Rows.Add( d.DepartmentName, d.ManagerID, d.ManagerName);

            }
            foreach (DataGridViewColumn c in dgvDepartments.Columns)
            {
                c.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                c.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            this.dgvDepartments.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dgvDepartments.BackgroundColor = this.dgvDepartments.DefaultCellStyle.BackColor;

            // employees of department

            foreach (Employee employee in userM.GetAll())
            {
                lbEmployeesOfDepartment.Items.Add(employee);
            }
        }
        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
        }

        private void btnUpdateInfo_Click(object sender, EventArgs e)
        {
        }

        private void btnViewPendingList_Click(object sender, EventArgs e)
        {
        }

        private void btnAddDepartment_Click(object sender, EventArgs e)
        {
            if (lbEmployeesOfDepartment.SelectedIndex>-1)
            {
                if (tbDepartmentName.Text != "")
                {
                    string name = tbDepartmentName.Text;
                    Employee departmentManager = lbEmployeesOfDepartment.SelectedItem as Employee;
                    Department d = new Department(name, departmentManager);
                    if (!departmentM.Add(d))
                    {
                        MessageBox.Show("this department name already exsist!");
                    }

                }
                else
                {
                    MessageBox.Show("please fill in the requirements");
                }
            }
            else
            {
                MessageBox.Show("please select an employee from the list");
            }
            UpdateListInDepartmentManagement();
        }

        private void btnUpdateDepartment_Click(object sender, EventArgs e)
        {
           
        }

        private void btnTerminate_Click(object sender, EventArgs e)
        {
            TerminateEmployee_sContract terminate = new TerminateEmployee_sContract();
            terminate.Show();
        }

        private void btnViewEmployeesOfDepartment_Click(object sender, EventArgs e)
        {
            dgvDepartments.ClearSelection();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRemoveDepartment_Click(object sender, EventArgs e)
        {
            if (dgvDepartments.SelectedCells.Count > 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to remove this department?", "", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    int r = this.dgvDepartments.SelectedCells[0].RowIndex;
                    DataGridViewRow row = this.dgvDepartments.Rows[r];
                    string name = row.Cells["Department Name"].Value.ToString();
                    Department depart = this.departmentM.GetDepartment(name);
                    this.departmentM.Remove(depart);
                    MessageBox.Show("Removed successfully!");
                }
                else
                {
                    MessageBox.Show("Please select a department");
                }
            }
            UpdateListInDepartmentManagement();
           
        }
    }
}
