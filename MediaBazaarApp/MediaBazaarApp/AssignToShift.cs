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
    public partial class AssignToShift : Form
    {
        ShiftManager shiftM;
        Scheduler scheduler;
        string shiftType;
        string date;
        string monday;
        string sunday;

        public AssignToShift(Scheduler scheduler,ShiftManager shiftM, string shiftType, string date, string monday, string sunday)
        {
            InitializeComponent();
            this.shiftM = shiftM;
            this.shiftType = shiftType;
            this.date = date;
            this.sunday = sunday;
            this.monday = monday;
            this.scheduler = scheduler;
            DisplayInfo();
            DisplayAvailableEmployees();
        }

        private void DisplayInfo()
        {
            this.lDateOfShift.Text = this.date + " " + this.shiftType;

        }

        private void DisplayAvailableEmployees()
        {
            this.lbAvailablePeople.Items.Clear();

            List<Employee> availableEmployees = this.scheduler.GetAvailableEmployees( this.date, this.monday, this.sunday);

            foreach (Employee employee in availableEmployees)
            {
                this.lbAvailablePeople.Items.Add("ID: " + employee.ID + " - " + employee.FirstName + " " + employee.LastName);
            }
        }
    }
}
