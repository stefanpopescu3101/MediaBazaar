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
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            Add_Employee add = new Add_Employee();
            add.Show();
        }

        private void btnUpdateInfo_Click(object sender, EventArgs e)
        {
            UpdateEmployee_s_Information update = new UpdateEmployee_s_Information();
            update.Show();
        }

        private void btnViewPendingList_Click(object sender, EventArgs e)
        {
            PendingList pending = new PendingList();
            pending.Show();
        }

        private void btnAddDepartment_Click(object sender, EventArgs e)
        {
            Add_Department addD = new Add_Department();
            addD.Show();

        }

        private void btnUpdateDepartment_Click(object sender, EventArgs e)
        {
            Update_Department_Info updateD = new Update_Department_Info();
            updateD.Show();
        }

        private void btnTerminate_Click(object sender, EventArgs e)
        {
            TerminateEmployee_sContract terminate = new TerminateEmployee_sContract();
            terminate.Show();
        }

        private void btnViewEmployeesOfDepartment_Click(object sender, EventArgs e)
        {
            ViewEmployees viewEmployees = new ViewEmployees();
            viewEmployees.Show();
        }
    }
}
