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

    public partial class LoginForm : Form
    {
        private EmployeeManager manager;
        public LoginForm()

        {
            InitializeComponent();
            manager = new EmployeeManager();
            manager.Load();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbUsername.Text!="" && tbPassword.Text!="")
            {
                if (manager.CheckCredentials(tbUsername.Text, tbPassword.Text)!=null)
                {
                    Employee emp = manager.CheckCredentials(tbUsername.Text, tbPassword.Text);
                    if (emp.Role=="Hr Manager")
                    {
                        Form1 form1 = new Form1();
                        form1.ShowDialog();
                    }else if(emp.Role == "Stock Manager")
                    {
                        StockManager sm = new StockManager();
                        sm.ShowDialog();
                    }else if(emp.Role == "Store Manager")
                    {
                        ManipulateShelves shelves = new ManipulateShelves();
                        shelves.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("these credentials do not exist");
                }
            }
            else
            {
                MessageBox.Show("please fill in the requirements");
            }
           

        }

    }
}
