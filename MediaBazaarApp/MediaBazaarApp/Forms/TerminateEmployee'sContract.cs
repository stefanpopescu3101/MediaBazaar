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
    public partial class TerminateEmployee_sContract : Form
    {
        private Form1 form1;
        EmployeeManager employeeManager;

        public TerminateEmployee_sContract(Form1 employeeOverviewForm)
        {
            InitializeComponent();
            this.form1 = employeeOverviewForm;
            this.CenterToParent();

            employeeManager = new EmployeeManager();
            GetEmployeeName(form1.SelectedItemID());
        }

        private void GetEmployeeName(string id)
        {
            //id = form1.Id;
            //lblName.Text = employeeManager.GetEmployee(Convert.ToInt32(id)).FirstName;
            Employee employee = employeeManager.GetEmployee(Convert.ToInt32(id));
            lblName.Text = employee.FirstName + " " + employee.LastName;

        }

        private void btnTerminate_Click(object sender, EventArgs e)
        {
            Employee employee = employeeManager.GetEmployee(Convert.ToInt32(form1.SelectedItemID()));
            string endDate = dtpLastWorkingDate.Text;
            string reason;
            if (rtbReason.Text == "")
            {
                reason = "Not given.";
            }
            else
            {
                reason = rtbReason.Text;
            }
            employeeManager.TerminateEmployeesContract(employee, endDate, reason);
            this.Close();
            form1.UpdateDataGridView();
        }
    }
}
