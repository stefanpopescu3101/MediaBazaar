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
    public partial class AddProduct : Form
    {
        private ProductManager productManager = new ProductManager();
        public AddProduct()
        {
            InitializeComponent();
        }

        private void btnAddP_Click(object sender, EventArgs e)
        {
            if (tbName.Text == "" || tbSellingPrice.Text == "" || tbBoughtFor.Text == "" || tbBrand.Text == "" ||
                tbInStock.Text == "" || tbThreshold.Text == "" || tbMaxCapacity.Text == "" )
            {
                MessageBox.Show("Please fill in all of the required fields!");
            }
            else
            {
                try
                {
                    string name = tbName.Text;
                    string brand = tbBrand.Text;
                    decimal boughtFor = Convert.ToDecimal(this.tbBoughtFor.Text);
                    decimal sellingPrice = Convert.ToDecimal(this.tbSellingPrice.Text);
                    int inStock = Convert.ToInt32(tbInStock.Text);
                    int maxCapacity = Convert.ToInt32(tbMaxCapacity.Text);
                    // decimal measurements = Convert.ToDecimal(this.tbMeasurements.Text);
                    int threshold = Convert.ToInt32(tbThreshold.Text);
                    //string boxSize = cbCategory.Text;
                    
                    
                    if (threshold > maxCapacity || inStock > maxCapacity)
                    {
                        throw new CapacityExeption();
                    }

                    Product product = new Product(name, brand, boughtFor, sellingPrice, inStock, maxCapacity, threshold,0);

                  if(!this.productManager.Add(product))
                    {
                        MessageBox.Show("This product exists!");
                    }
                    else
                    {
                        DialogResult box = MessageBox.Show("Product has been added successfully.");
                        if (box == DialogResult.OK)
                        {
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                    }

                }
                catch(CapacityExeption)
                {
                    MessageBox.Show("Threshold or instock value can not be bigger than the maximum capacity of the product.");
                }
                catch(FormatException)
                {
                    MessageBox.Show("Please enter all of the information in the right format.");
                }
            }
        }

        private void btnCloseWind_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
