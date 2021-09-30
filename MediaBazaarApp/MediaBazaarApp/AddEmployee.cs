﻿using System;
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
        DepartmentManager departmentManager;


        public AddEmployee(Form1 employeeOverviewForm,DepartmentManager departmentManager)
        {
            InitializeComponent();
            this.form1 = employeeOverviewForm;
            this.CenterToParent();

            employeeManager = new EmployeeManager();
            this.departmentManager = departmentManager;
            LoadDepartments();
        }
        private void LoadDepartments()
        {
            cbDepartment.Items.Clear();
            foreach (Department d in departmentManager.GetDepartments())
            {
                cbDepartment.Items.Add(d.DepartmentName);
            }
        }
        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee(tbFirstName.Text, tbSurname.Text, Convert.ToInt32(tbBSN.Text), tbEmail.Text, dtpFirstDate.Text, dtpLastWorkingDate.Text, dtpBdate.Text, cbContractType.Text,Convert.ToDouble( tbHourlyWage.Text), tbAddress.Text, cbDepartment.Text,cbRole.Text);

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
