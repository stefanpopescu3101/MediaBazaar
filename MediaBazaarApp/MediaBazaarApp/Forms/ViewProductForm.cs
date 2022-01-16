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
    public partial class ViewProductForm : Form
    {
        private Product product;
        public ViewProductForm( Product product)
        {
            InitializeComponent();
            this.product = product;
            LoadData(this.product);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click/*"Back" button*/(object sender, EventArgs e)
        {
            this.Close();
        }
        private void LoadData(Product product)
        {
         
            this.tbProductName.Text = product.Name;
            this.tbProductBrand.Text = product.Brand;
            this.tbProductBoughtFor.Text = product.CostPrice.ToString();
            this.tbProductSelling.Text = product.SellPrice.ToString();
            this.tbMaxCapacity.Text = product.MaxCapacity.ToString();
            this.tbThreshold.Text = product.Threshold.ToString();
        
            //this.category
            this.tbInStock.Text = product.InStock.ToString();
           
          
           

        }
    }
}
