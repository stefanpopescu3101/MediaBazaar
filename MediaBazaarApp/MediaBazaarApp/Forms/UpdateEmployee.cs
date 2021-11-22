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
    public partial class UpdateEmployee : Form
    {
        private Form1 form1;
        EmployeeManager employeeManager;

        DepartmentManager departmentManager;
        public UpdateEmployee(Form1 employeeOverviewForm,DepartmentManager d)
        {
            InitializeComponent();
            this.form1 = employeeOverviewForm;
            this.departmentManager = d;
            this.CenterToParent();

            employeeManager = new EmployeeManager();
            FillTextboxes();
            LoadDepartments();

            tbID.Enabled = false;
        }
        private void LoadDepartments()
        {
            cbDepartment.Items.Clear();
            foreach (Department d in departmentManager.GetDepartments())
            {
                cbDepartment.Items.Add(d.DepartmentName);
            }
        }
        public void FillTextboxes()
        {
            tbID.Text = form1.SelectedItemID();

            foreach(Employee e in employeeManager.GetEmployees())
            {
                if(Convert.ToInt32(tbID.Text) == e.ID)
                {
                    tbFirstName.Text = e.FirstName;
                    tbSurname.Text = e.LastName;
                    tbEmail.Text = e.Email;
                    cbContractType.Text = e.ContractType;
                    cbDepartment.Text = e.Department;
                    tbAddress.Text = e.Address;
                }
            }
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(tbID.Text);
            string firstName = tbFirstName.Text;
            string lastName = tbSurname.Text;
            string email = tbEmail.Text;
            string typeOfContract = cbContractType.Text;
            string department = cbDepartment.Text;
            string address = tbAddress.Text;

            if(firstName == "" || lastName == "" || email == "" || typeOfContract == "" || department == "" || address == "")
            {
                MessageBox.Show("Please provide required data.");
            }
            else
            {
                Employee employee = this.employeeManager.GetEmployee(id);
                employeeManager.Update(employee, firstName, lastName, email, typeOfContract, address, department);
                
                MessageBox.Show("Employee has been updated successfully.");
                this.Close();
                this.form1.UpdateDataGridView();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void tbAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }
    }
}
