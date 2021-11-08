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
    public partial class EmployeeStatistics : Form
    {
        private Form1 form1;
        EmployeeManager employeeManager;

        public EmployeeStatistics(Form1 employeeOverviewForm)
        {
            InitializeComponent();
            this.form1 = employeeOverviewForm;
            this.CenterToParent();

            employeeManager = new EmployeeManager();
        }


    }
}
