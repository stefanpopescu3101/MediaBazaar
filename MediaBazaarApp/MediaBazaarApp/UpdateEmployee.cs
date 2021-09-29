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
        EmployeesMediator employeesMediator;

        public UpdateEmployee(Form1 employeeOverviewForm)
        {
            InitializeComponent();
            this.form1 = employeeOverviewForm;
            this.CenterToParent();

            employeesMediator = new EmployeesMediator();
        }
    }
}
