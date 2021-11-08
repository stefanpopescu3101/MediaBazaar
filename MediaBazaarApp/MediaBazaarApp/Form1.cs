using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace MediaBazaarApp
{
    public partial class Form1 : Form
    {
        EmployeeManager employeeManager;
        private AddEmployee addEmployeeForm;
        private UpdateEmployee updateEmployeeForm;
        private TerminateEmployee_sContract terminateEmployeeForm;
        private EmployeeStatistics employeeStatisticsForm;
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
            tbSearch.Enabled = false;
            ClearFilters();
            UpdateDataGridView();

            dgvEmployees.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        public void UpdateDataGridView()
        {
            cbDepartmentManager.Items.Clear();
            LoadDGVColumns();
            LoadColumnsIntoCombobox();

            foreach (Employee e in employeeManager.GetEmployees())
            {
                this.dgvEmployees.Rows.Add(e.ID, e.FirstName, e.LastName, e.Bsn, e.Email, e.FirstWorkingDate, e.LastWorkingDate, e.Birthdate, e.ContractType, e.HourlyWage, e.Address, e.Department, e.DepartureReason);
                cbDepartmentManager.Items.Add(e);
                
            }

            foreach (DataGridViewRow row in dgvEmployees.Rows)
            {
                if (row.Cells[12].Value != "")
                {
                    row.DefaultCellStyle.BackColor = Color.LightCoral;
                }

            }
        }

        public void LoadDGVColumns()
        {
            dgvEmployees.Rows.Clear();
            cbDepartmentManager.Items.Clear();
            this.dgvEmployees.ColumnCount = 14;
            this.dgvEmployees.Columns[0].Name = "ID";
            this.dgvEmployees.Columns[1].Name = "First name";
            this.dgvEmployees.Columns[2].Name = "Last name";
            this.dgvEmployees.Columns[3].Name = "BSN";
            this.dgvEmployees.Columns[4].Name = "Email";
            this.dgvEmployees.Columns[5].Name = "Start date";
            this.dgvEmployees.Columns[6].Name = "End date";
            this.dgvEmployees.Columns[7].Name = "Birthdate";
            this.dgvEmployees.Columns[8].Name = "Contract type";
            this.dgvEmployees.Columns[9].Name = "Hourly wage"; 
            this.dgvEmployees.Columns[10].Name = "Address";
            this.dgvEmployees.Columns[11].Name = "Department";
            this.dgvEmployees.Columns[12].Name = "Departure reason";
            this.dgvEmployees.Columns[13].Name = "Role";

        }

        public void LoadColumnsIntoCombobox()
        {
            cbColumnChoice.Items.Clear();
            for (int i = 0; i < 4; i++)
            {
                cbColumnChoice.Items.Add(dgvEmployees.Columns[i].Name);
            }
        }

        public void SearchEmployeeByID()
        {
            LoadDGVColumns();
            if (Regex.IsMatch(tbSearch.Text, @"^\d+$"))
            {
                foreach (Employee e in employeeManager.GetEmployees())
                {
                    if (e.ID == Convert.ToInt32(tbSearch.Text))
                    {
                        this.dgvEmployees.Rows.Add(e.ID, e.FirstName, e.LastName, e.Bsn, e.Email, e.FirstWorkingDate, e.LastWorkingDate, e.Birthdate, e.ContractType, e.HourlyWage, e.Address, e.Department);
                    }
                }

            }
            else
            {
                ClearFilters();
                MessageBox.Show("Please enter a number.");
            }
        }

        public void SearchEmployeeByFirstName()
        {
            LoadDGVColumns();

            foreach (Employee e in employeeManager.GetEmployees())
            {
                if (e.FirstName == tbSearch.Text)
                {
                    this.dgvEmployees.Rows.Add(e.ID, e.FirstName, e.LastName, e.Bsn, e.Email, e.FirstWorkingDate, e.LastWorkingDate, e.Birthdate, e.ContractType, e.HourlyWage, e.Address, e.Department);
                }
            }
        }

        public void SearchEmployeeByLastName()
        {
            LoadDGVColumns();

            foreach (Employee e in employeeManager.GetEmployees())
            {
                if (e.LastName == tbSearch.Text)
                {
                    this.dgvEmployees.Rows.Add(e.ID, e.FirstName, e.LastName, e.Bsn, e.Email, e.FirstWorkingDate, e.LastWorkingDate, e.Birthdate, e.ContractType, e.HourlyWage, e.Address, e.Department);
                }
            }
        }

        public void SearchEmployeeByBSN()
        {
            LoadDGVColumns();

            if (Regex.IsMatch(tbSearch.Text, @"^\d+$"))
            {
                foreach (Employee e in employeeManager.GetEmployees())
                {
                    if (e.Bsn == Convert.ToInt32(tbSearch.Text))
                    {
                        this.dgvEmployees.Rows.Add(e.ID, e.FirstName, e.LastName, e.Bsn, e.Email, e.FirstWorkingDate, e.LastWorkingDate, e.Birthdate, e.ContractType, e.HourlyWage, e.Address, e.Department);
                    }
                }
            }
            else
            {
                ClearFilters();
                MessageBox.Show("Please enter a number.");
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
            if(dgvEmployees.SelectedRows.Count > -1)
            {
                Employee employee = employeeManager.GetEmployee(Convert.ToInt32(SelectedItemID()));
                if (employee.DepartureReason == "")
                {
                    updateEmployeeForm = new UpdateEmployee(this, this.departmentM);
                    updateEmployeeForm.Show();
                }
                else MessageBox.Show("This employee's contract is no longer active.");
            }
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
            if (dgvEmployees.SelectedRows.Count > -1)
            {
                int r = this.dgvEmployees.SelectedCells[0].RowIndex;
                DataGridViewRow row = this.dgvEmployees.Rows[r];
                int id = Convert.ToInt32(row.Cells["ID"].Value);
                Employee emp = this.employeeManager.GetEmployee(id);
                Employee employee = employeeManager.GetEmployee(Convert.ToInt32(SelectedItemID()));
                if (emp.DepartureReason == "")
                {
                    terminateEmployeeForm = new TerminateEmployee_sContract(this);
                    terminateEmployeeForm.Show();
                }
                else MessageBox.Show("This employee's contract had already been terminated");
            }
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
            addEmployeeForm = new AddEmployee(this, departmentM);
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
            string columnName = cbColumnChoice.Text;

            if(columnName == "ID")
            {
                SearchEmployeeByID();
            }
            else if(columnName == "First name")
            {
                SearchEmployeeByFirstName();
            }
            else if(columnName == "Last name")
            {
                SearchEmployeeByLastName();
            }
            else if(columnName == "BSN")
            {
                SearchEmployeeByBSN();
            }

            //this.dgvEmployees.Rows.Clear();
            //if (searchValue != "")
            //{
            //    Employee emp = this.employeeManager.GetEmployee(Convert.ToInt32(searchValue));
            //    if (emp != null)
            //    {
            //        this.dgvEmployees.Rows.Add(emp.ID, emp.FirstName, emp.LastName, emp.Bsn, emp.Email, emp.FirstWorkingDate, emp.LastWorkingDate, emp.Birthdate, emp.ContractType, emp.HourlyWage, emp.Address, emp.Department);
            //    }
            //    else MessageBox.Show("No employee found.");
            //}
            //else
            //{
            //    UpdateDataGridView();
            //    MessageBox.Show("Enter the required data in order to search for an employee."); 
            //}

            //try
            //{
            //    foreach (DataGridViewRow row in dgvEmployees.Rows)
            //    {
            //        if (row.Cells[2].Value.ToString().Equals(searchValue))
            //        {
            //            SearchEmployee();
            //            break;
            //        }
            //    }
            //}
            //catch (Exception exc)
            //{
            //    MessageBox.Show(exc.Message);
            //}

            //(dgvEmployees.DataSource as DataTable).DefaultView = String.Format("First name like '%'" + tbSearch.Text + "'%'");

            //if (tbSearch.Text != string.Empty)
            //{
            //    foreach (DataGridViewRow row in dgvEmployees.Rows)
            //    {
            //        if (row.Cells[1].ToString().Trim().Contains(tbSearch.Text.Trim()))
            //        {
            //            row.Visible = true;
            //        }
            //        else
            //            row.Visible = false;
            //    }
            //}
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFilters();
        }

        private void ClearFilters()
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

        private void cbColumnChoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbSearch.Enabled = true;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            employeeStatisticsForm = new EmployeeStatistics(this);
            employeeStatisticsForm.ShowDialog();
        }
    }
}
