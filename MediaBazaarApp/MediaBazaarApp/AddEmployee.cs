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
    public partial class AddEmployee : Form
    {
        private Form1 form1;
        EmployeeManager employeeManager;

        public AddEmployee(Form1 employeeOverviewForm)
        {
            InitializeComponent();
            this.form1 = employeeOverviewForm;
            this.CenterToParent();

            employeeManager = new EmployeeManager();
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee(tbFirstName.Text, tbSurname.Text, Convert.ToInt32(tbBSN.Text), tbEmail.Text, dtpFirstDate.Text, dtpLastWorkingDate.Text, dtpBdate.Text, "contract", 10, tbAddress.Text, "department");

            employeeManager.AddEmployee(employee);
            MessageBox.Show("New employee has been added successfully.");
            this.Close();
            this.form1.UpdateDataGridView();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                dtpLastWorkingDate.Enabled = false;
            }
            else if (!checkBox1.Checked)
            {
                dtpLastWorkingDate.Enabled = true;
            }
        }
    }
}
