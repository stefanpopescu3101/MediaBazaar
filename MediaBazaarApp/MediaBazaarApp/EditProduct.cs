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
    public partial class EditProduct : Form
    {
        private Product product;
        private ProductManager productManager;
        public EditProduct(Product product, ProductManager productManager)
        {
            InitializeComponent();
            this.product = product;
            this.productManager = productManager;
            LoadData(this.product);
        }

        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            if(tbProductName.Text != "" || tbProductBoughtFor.Text != "" || tbProductSellingFor.Text != "" || tbProductBrand.Text != "" ||
                cbProductSize.Text != "" || tbThreshold.Text != "" || tbMaxCapacity.Text != "" || tbMeasurements.Text != "")
            {
                int maxCapacity = 0;
                int threshold = 0;
                try
                {
                    maxCapacity = Convert.ToInt32(tbMaxCapacity.Text);
                    threshold = Convert.ToInt32(tbThreshold.Text);
                    if (threshold > maxCapacity)
                    {
                        throw new CapacityExeption();
                    }


                    this.product.EditProduct(tbProductName.Name, tbProductBrand.Text, Convert.ToDecimal(tbProductBoughtFor.Text),Convert.ToDecimal(tbProductSellingFor.Text),Convert.ToInt32(tbMaxCapacity.Text),
                        Convert.ToInt32(tbThreshold.Text),Convert.ToDecimal(tbMeasurements.Text), cbProductSize.Text);

                    this.productManager.Update(this.product);
                    DialogResult box = MessageBox.Show("Data has been edited successfully.");
                    if (box == DialogResult.OK)
                    {
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
                catch (CapacityExeption)
                {
                    MessageBox.Show("Threshold or instock value can not be bigger than the maximum capacity of the product.");
                }
                catch (FormatException) { MessageBox.Show("Please enter all of the information in the right format."); }
            }
            else { MessageBox.Show("Please fill in all of the required fields."); }
        }

        private void LoadData(Product product)
        {
            //products != to null
            this.tbProductName.Text = product.Name;
            this.tbProductBrand.Text = product.Brand;
            this.tbProductBoughtFor.Text = product.CostPrice.ToString();
            this.tbProductSellingFor.Text = product.SellPrice.ToString();
            this.tbMaxCapacity.Text = product.MaxCapacity.ToString();
            this.tbThreshold.Text = product.Threshold.ToString();
            this.cbProductSize.Text = product.BoxSize.ToString();
            this.tbMeasurements.Text = product.Measurements.ToString();
            

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }


}
