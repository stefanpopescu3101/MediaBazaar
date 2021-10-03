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

        public LoginForm()

        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbUsername.Text=="HR" || tbUsername.Text=="Department")
            {
                Form1 form = new Form1();
                form.ShowDialog();
            }
            else if (tbUsername.Text == "Store")
            {
                ManipulateShelves shelves = new ManipulateShelves();
                shelves.ShowDialog();
            }
            else if(tbUsername.Text == "Stock")
            {
                StockManager stock = new StockManager();
                stock.ShowDialog();
            }

        }

    }
}
