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
    public partial class StockManager : Form
    {

        private ProductManager productManager;

        public StockManager()
        {
            InitializeComponent();
            this.productManager = new ProductManager();
            
            productManager.Load();
            LoadAllProducts();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            AddProduct ap = new AddProduct();
            DialogResult r = ap.ShowDialog();
            this.LoadAllProducts();


        }
        private void LoadAllProducts()
        {

            this.DGVProducts.Rows.Clear();
            this.DGVProducts.ColumnCount = 10;
            this.DGVProducts.Columns[0].Name = "ID";
            this.DGVProducts.Columns[1].Name = "Name";
            this.DGVProducts.Columns[2].Name = "Brand";
            this.DGVProducts.Columns[3].Name = "Cost Price";
            this.DGVProducts.Columns[4].Name = "Sell Price";
            this.DGVProducts.Columns[5].Name = "In Stock";
            this.DGVProducts.Columns[6].Name = "Max Capacity";
            this.DGVProducts.Columns[7].Name = "Threshold";
            this.DGVProducts.Columns[8].Name = "Measurements";
            this.DGVProducts.Columns[9].Name = "Box Size";

            foreach (Product p in productManager.GetProducts())
            {
               this.DGVProducts.Rows.Add(p.ID, p.Name, p.Brand, p.CostPrice + " €", p.SellPrice + " €", p.InStock, p.MaxCapacity, p.Threshold, p.Sold, p.Measurements, p.BoxSize + " cm³");
            }



        }

        private void btnRemoveProduct_Click(object sender, EventArgs e)
        {
            if (this.DGVProducts.SelectedCells.Count > 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this product?", "", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Product product = this.GetProduct();
                    this.productManager.Remove(product);

                    this.LoadAllProducts();
                    MessageBox.Show("Product has been removed successfully.");
                }
            }
            else { MessageBox.Show("Please select a product from the table."); }
        }

        private Product GetProduct()
        {
            int selectedRowIndex = this.DGVProducts.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = this.DGVProducts.Rows[selectedRowIndex];
            Product product = this.productManager.Get(Convert.ToInt32(selectedRow.Cells["ID"].Value));
            return product;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (this.DGVProducts.SelectedCells.Count > 0)
            {
                Product product = this.GetProduct();

                EditProduct form = new EditProduct(product, productManager);
                DialogResult result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    this.LoadAllProducts();
                }
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
