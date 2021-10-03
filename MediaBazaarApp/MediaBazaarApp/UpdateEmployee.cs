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

        public UpdateEmployee(Form1 employeeOverviewForm)
        {
            InitializeComponent();
            this.form1 = employeeOverviewForm;
            this.CenterToParent();

            employeeManager = new EmployeeManager();
        }

        public void FillTextboxes()
        {

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
                employee.UpdateInfo(id);
                MessageBox.Show("Employee has been updated successfully.");
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
