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

        public Form1()
        {
            InitializeComponent();
            employeeManager = new EmployeeManager();
            UpdateDataGridView();

            dgvEmployees.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        public void UpdateDataGridView()
        {
            LoadDGVColumns();

            foreach (Employee e in employeeManager.GetEmployees())
            {
                this.dgvEmployees.Rows.Add(e.ID, e.FirstName, e.LastName, e.Bsn, e.Email, e.FirstWorkingDate, e.LastWorkingDate, e.Birthdate, e.ContractType, e.HourlyWage, e.Address, e.Department);
            }
        }

        public void LoadDGVColumns()
        {
            dgvEmployees.Rows.Clear();

            this.dgvEmployees.ColumnCount = 14;
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

        //public string SelectedItemID()
        //{
        //    if (dgvEmployees.SelectedRows.Count > 0)
        //    {
        //        var item = dgvEmployees.SelectedCells;
        //        Id = item.Text;
        //        return Id;
        //    }
        //    return "";
        //}

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdateInfo_Click(object sender, EventArgs e)
        {
            updateEmployeeForm = new UpdateEmployee(this);
            updateEmployeeForm.Show();
        }

        private void btnViewPendingList_Click(object sender, EventArgs e)
        {
        
        }

        private void btnAddDepartment_Click(object sender, EventArgs e)
        {
       
        }

        private void btnUpdateDepartment_Click(object sender, EventArgs e)
        {
         
        }

        private void btnTerminate_Click(object sender, EventArgs e)
        {
       
        }

        private void btnViewEmployeesOfDepartment_Click(object sender, EventArgs e)
        {
        
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
            int id = Convert.ToInt32(dgvEmployees.SelectedRows[0].Cells[0].Value);
            
            employeeManager.RemoveEmployee(id);
            UpdateDataGridView();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            addEmployeeForm = new AddEmployee(this);
            addEmployeeForm.Show();            
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
    }
}
