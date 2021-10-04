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
        EmployeeManager employeeManager;
        private AddEmployee addEmployeeForm;
        private UpdateEmployee updateEmployeeForm;
        DepartmentManager departmentM;
        UserManager userM;
        public string Id;

        public Form1()
        {
            InitializeComponent();
            employeeManager = new EmployeeManager();
            departmentM = new DepartmentManager();
            userM = new UserManager();
            departmentM.Load();
            UpdateListInDepartmentManagement();
            dgvEmployees.Rows.Clear();
            //lblSelectedId.Text = SelectedItemID();

            UpdateDataGridView();

            dgvEmployees.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        public void UpdateDataGridView()
        {
            cbDepartmentManager.Items.Clear();
            LoadDGVColumns();
            

            foreach (Employee e in employeeManager.GetEmployees())
            {
                this.dgvEmployees.Rows.Add(e.ID, e.FirstName, e.LastName, e.Bsn, e.Email, e.FirstWorkingDate, e.LastWorkingDate, e.Birthdate, e.ContractType, e.HourlyWage, e.Address, e.Department);
                cbDepartmentManager.Items.Add(e);
                
            }
        }

        public void LoadDGVColumns()
        {
            dgvEmployees.Rows.Clear();
            cbDepartmentManager.Items.Clear();
            this.dgvEmployees.ColumnCount = 13;
            this.dgvEmployees.Columns[0].Name = "ID";
            this.dgvEmployees.Columns[1].Name = "First name";
            this.dgvEmployees.Columns[2].Name = "Last name";
            this.dgvEmployees.Columns[3].Name = "BSN";
            this.dgvEmployees.Columns[4].Name = "Email";
            this.dgvEmployees.Columns[5].Name = "First working date";
            this.dgvEmployees.Columns[6].Name = "Last working date";
            this.dgvEmployees.Columns[7].Name = "Birthdate";
            this.dgvEmployees.Columns[8].Name = "Contract type";
            this.dgvEmployees.Columns[9].Name = "Hourly wage";
            this.dgvEmployees.Columns[10].Name = "Address";
            this.dgvEmployees.Columns[11].Name = "Department";
            this.dgvEmployees.Columns[12].Name = "Role";

        }

        public void SearchEmployee()
        {
            LoadDGVColumns();

            foreach (Employee e in employeeManager.GetEmployees())
            
                if(e.ID == Convert.ToInt32(tbSearch.Text))
                {
                    this.dgvEmployees.Rows.Add(e.ID, e.FirstName, e.LastName, e.Bsn, e.Email, e.FirstWorkingDate, e.LastWorkingDate, e.Birthdate, e.ContractType, e.HourlyWage, e.Address, e.Department);
                }
        }

        private void UpdateListInDepartmentManagement()
        {
            cbDepartmentManager.Items.Clear();
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

            foreach (Employee employee in employeeManager.GetEmployees())
            {
                cbDepartmentManager.Items.Add(employee);
            }
        }

        public string SelectedItemID()
        {
            if (dgvEmployees.SelectedRows.Count > 0)
            {
                var item = dgvEmployees.CurrentRow.Cells[0];
                Id = item.Value.ToString();
                return Id;
            }
            return "";
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
			
        }

        private void btnUpdateInfo_Click(object sender, EventArgs e)
        {
            updateEmployeeForm = new UpdateEmployee(this,this.departmentM);
            updateEmployeeForm.Show();
        }

        private void btnViewPendingList_Click(object sender, EventArgs e)
        {

        }


        private void btnAddDepartment_Click(object sender, EventArgs e)
        {
            if (cbDepartmentManager.SelectedIndex>-1)
            {
                if (tbDepartmentName.Text != "")
                {
                    string name = tbDepartmentName.Text;
                    Employee departmentManager = cbDepartmentManager.SelectedItem as Employee;
                    Department d = new Department(name, departmentManager);
                        if (departmentManager.Role == "Department Manager")
                        {
                            MessageBox.Show("This employee is a manager of :" + departmentManager.Department);
                        }
                        else
                        {
                        if (!departmentM.Add(d))
                        {
                            MessageBox.Show("this department already exsists");
                        }
                        else
                        {
                            d.AssignEmployee(departmentManager);
                            departmentManager.Department = d.DepartmentName;
                            departmentManager.Role = "Department Manager";
                            employeeManager.UpdateRoleAndDepartment(departmentManager, departmentManager.Department, departmentManager.Role);
                        }
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
            if (dgvDepartments.SelectedCells.Count > -1)
            {
                if (tbDepartmentName.Text != "")
                {
                    int r = this.dgvDepartments.SelectedCells[0].RowIndex;
                    DataGridViewRow row = this.dgvDepartments.Rows[r];
                    string name = row.Cells["Department Name"].Value.ToString();
                    Department depart = this.departmentM.GetDepartment(name);
                    departmentM.Update(depart, tbDepartmentName.Text, cbDepartmentManager.SelectedItem as Employee);
                    MessageBox.Show("Updated successfully");
                }
                else
                {
                    MessageBox.Show("department name cannot be empty");
                }
            }
            else
            {
                MessageBox.Show("please select a department!");
            }
            UpdateListInDepartmentManagement();
        }

        private void btnTerminate_Click(object sender, EventArgs e)
        {
       
        }

        private void btnViewEmployeesOfDepartment_Click(object sender, EventArgs e)
        {
            cbDepartmentManager.SelectedIndex = -1;
            tbDepartmentName.Text = "";
            lDepartmentManager.Text = "";
            dgvDepartments.ClearSelection();
            UpdateDataGridView();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void dtpLastWorkingDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)

        {

        }


        private void label9_Click(object sender, EventArgs e)

        {

        }


        private void label8_Click(object sender, EventArgs e)

        {

        }


        private void dtpFirstDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtpBdate_ValueChanged(object sender, EventArgs e)

        {

        }


        private void tabPage1_Click(object sender, EventArgs e)

        {

        }


        private void btnRemoveEmployee_Click(object sender, EventArgs e)
        {
            if (dgvEmployees.SelectedCells.Count > -1)
            {

                int r = this.dgvEmployees.SelectedCells[0].RowIndex;
                DataGridViewRow row = this.dgvEmployees.Rows[r];
                int id = Convert.ToInt32(row.Cells["ID"].Value);
                Employee emp = this.employeeManager.GetEmployee(id);
                employeeManager.RemoveEmployee(emp);
                UpdateDataGridView();
            }
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            addEmployeeForm = new AddEmployee(this,departmentM);
            addEmployeeForm.ShowDialog();
            UpdateDataGridView();
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

        private void dgvDepartments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDepartments.SelectedCells.Count>-1)
            {
                cbDepartmentManager.Items.Clear();
                int r = this.dgvDepartments.SelectedCells[0].RowIndex;
                DataGridViewRow row = this.dgvDepartments.Rows[r];
                string name = row.Cells["Department Name"].Value.ToString();
                Department depart = this.departmentM.GetDepartment(name);
                tbDepartmentName.Text = depart.DepartmentName;
                lDepartmentManager.Text = depart.ManagerName;
                foreach (Employee employee in employeeManager.GetEmployeeOfDepartment(depart))
                {
                    cbDepartmentManager.Items.Add(employee);
                }
            }
        }

        private void lbEmployeesOfDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {
           
        }

        private void cbDepartmentManager_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbDepartmentManager.SelectedIndex > -1)
            {
                Employee emp = cbDepartmentManager.SelectedItem as Employee;
                lDepartmentManager.Text = emp.Name;
            }          
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e) // search text box
        {

        }

        private void btnSearchByID_Click(object sender, EventArgs e)
        {
            string searchValue = tbSearch.Text;

            dgvEmployees.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                foreach (DataGridViewRow row in dgvEmployees.Rows)
                {
                    if (row.Cells[0].Value.ToString().Equals(searchValue))
                    {
                        SearchEmployee();
                        break;
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbSearch.Text = "";
            UpdateDataGridView();
        }

        private void dgvEmployees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
 
        }

        private void dgvEmployees_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
        }
    }
}
