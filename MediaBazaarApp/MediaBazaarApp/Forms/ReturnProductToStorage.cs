using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaBazaarApp.Forms
{
    public partial class ReturnProductToStorage : Form
    {

        private ProductManager productManager;
        private ShelfManager shelfManager;
        Shelf shelf;
             int s;
        public ReturnProductToStorage( ProductManager pm, int id )
        {
            InitializeComponent();
            productManager = pm;
            this.shelfManager = new ShelfManager();
            this.s = id;
            shelf = shelfManager.GetShelfByID(s);
          LoadProducts();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

          
       
        private void btnReturnProduct_Click(object sender, EventArgs e)
        {
           if(lbProducts.SelectedItems.Count > 0)
            {
                int filterd = Convert.ToInt32(lbProducts.SelectedItems.ToString().Substring(0, lbProducts.SelectedItem.ToString().IndexOf(" ")));
                string id = lbProducts.SelectedItem.ToString();
                Product product = productManager.Get(filterd);
                shelfManager.RemoveProductFromShelf(s,filterd,Convert.ToInt32(nUDProduct.Value));

            }
            else
            {
                MessageBox.Show("Error");
            }
        }
        private void LoadProducts()
        {
            lbProducts.Items.Clear();
            foreach (var product in shelfManager.GetShelfByID(s).ReturnProducts2())
            {
                lbProducts.Items.Add(product.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadProducts();
        }
    }
}
