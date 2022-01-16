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
        private RequestManager requestManager;
        public StockManager()
        {
            InitializeComponent();
            this.productManager = new ProductManager();           
            productManager.Load();
            LoadAllProducts();

            requestManager = new RequestManager();
            GridViewConfiguration();
            foreach (RestockRequest request in this.requestManager.GetAll())
            {
                this.dataGridViewRequests.Rows.Add(request.ID, request.RequestedAmount, request.SentTime, request.ProductName);
            }

            this.timerTable.Start();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAddProduct_Click_1(object sender, EventArgs e)
        {
            AddProduct ap = new AddProduct();
            ap.ShowDialog();
            this.LoadAllProducts();


        }
        private void LoadAllProducts()
        {

            this.DGVProducts.Rows.Clear();
            //this.DGVProducts.ColumnCount = 11;
            //this.DGVProducts.Columns[0].Name = "ID";
            //this.DGVProducts.Columns[1].Name = "Name";
            //this.DGVProducts.Columns[2].Name = "Brand";
            //this.DGVProducts.Columns[3].Name = "Cost Price";
            //this.DGVProducts.Columns[4].Name = "Sell Price";
            //this.DGVProducts.Columns[5].Name = "In Stock";
            //this.DGVProducts.Columns[6].Name = "Max Capacity";
            //this.DGVProducts.Columns[7].Name = "Threshold";
            //this.DGVProducts.Columns[8].Name = "Sold";
            //this.DGVProducts.Columns[9].Name = "Measurements";
            //this.DGVProducts.Columns[10].Name = "Box Size";

            foreach (Product p in productManager.GetProducts())
            {
               this.DGVProducts.Rows.Add(p.ID, p.Name, p.Brand, p.CostPrice + " €", p.SellPrice + " €", p.InStock, p.MaxCapacity, p.Threshold, p.Sold, p.Measurements, p.BoxSize + " cm³");
            }
          
            foreach (DataGridViewRow row in DGVProducts.Rows)

                if (Convert.ToInt32(row.Cells[5].Value) < Convert.ToInt32(row.Cells[7].Value))

                {

                    row.DefaultCellStyle.BackColor = Color.Red;

                }

        }

        private void btnRemoveProduct_Click_1(object sender, EventArgs e)
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

        private void btnUpdate_Click_1(object sender, EventArgs e)
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

       

        private void btnViewProduct_Click_1(object sender, EventArgs e)
        {
            if (this.DGVProducts.SelectedCells.Count > 0)
            {
                Product product = this.GetProduct();

                ViewProductForm form = new ViewProductForm(product);
                DialogResult result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    this.LoadAllProducts();
                }
            }
        }

        private void DGVProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnViewProduct_Click(object sender, EventArgs e)
        {

        }
        private void GridViewConfiguration()
        {
            this.dataGridViewRequests.ColumnCount = 4;
            this.dataGridViewRequests.Columns[0].Name = "ID";
            this.dataGridViewRequests.Columns[1].Name = "Requested Amount";
            this.dataGridViewRequests.Columns[2].Name = "Sent Time";
            this.dataGridViewRequests.Columns[3].Name = "Product Name";
            this.dataGridViewRequests.Columns[0].Width = 50;

            this.dataGridViewRequests.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            foreach (DataGridViewColumn column in this.dataGridViewRequests.Columns)
            {
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            this.dataGridViewRequests.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewRequests.BackgroundColor = this.dataGridViewRequests.DefaultCellStyle.BackColor;
        }
        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewRequests.SelectedCells.Count > 0)
            {
                DialogResult confirmation = MessageBox.Show("Are you sure you want to confirm this request?", "Confirmation", MessageBoxButtons.OKCancel);
                if (confirmation == DialogResult.OK)
                {
                    RestockRequest request = this.GetRequest();
                    int quantity = request.RequestedAmount;
                    Product product = this.productManager.Get(request.ProductId);
                    if (this.requestManager.Remove(request))
                    {
                        product.RestockProduct(quantity);
                        this.productManager.Update(product);
                        MessageBox.Show("Request accepted successfully");
                    }
                    else { MessageBox.Show("Failed"); }
                }
            }
            else
            {
                MessageBox.Show("Please select a request!");
            }
        }
        private RestockRequest GetRequest()
        {
            int r = this.dataGridViewRequests.SelectedCells[0].RowIndex;
            DataGridViewRow row = dataGridViewRequests.Rows[r];
            int id = Convert.ToInt32(row.Cells["ID"].Value);
            RestockRequest request = this.requestManager.Get(id);
            return request;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.dataGridViewRequests.SelectedCells.Count > 0)
            {
                int rowIndex = dataGridViewRequests.CurrentCell.RowIndex;
                int columnIndex = dataGridViewRequests.CurrentCell.ColumnIndex;

                this.dataGridViewRequests.Rows.Clear();

                foreach (RestockRequest request in this.requestManager.GetAll())
                {
                    this.dataGridViewRequests.Rows.Add(request.ID, request.RequestedAmount, request.SentTime, request.ProductName);
                }


                if (this.dataGridViewRequests.Rows.Count >= rowIndex + 1)
                {
                    this.dataGridViewRequests.ClearSelection();
                    this.dataGridViewRequests.CurrentCell = this.dataGridViewRequests.Rows[rowIndex].Cells[columnIndex];
                }

            }
            else
            {
                this.dataGridViewRequests.Rows.Clear();
                foreach (RestockRequest request in this.requestManager.GetAll())
                {
                    this.dataGridViewRequests.Rows.Add(request.ID, request.RequestedAmount, request.SentTime, request.ProductName);
                }
            }
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewRequests.SelectedCells.Count > 0)
            {
                DialogResult confirmation = MessageBox.Show("Are you sure you want to reject this request?", "Confirmation", MessageBoxButtons.OKCancel);
                if (confirmation == DialogResult.OK)
                {
                    RestockRequest request = this.GetRequest();

                    if (this.requestManager.Remove(request))
                    {
                        MessageBox.Show("Request rejected successfully");
                    }
                    else { MessageBox.Show("Failed"); }
                }
            }
            else { MessageBox.Show("Please select a request!"); }
        }

        private void StockManager_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void btnProductStatistics_Click(object sender, EventArgs e)
        {
            ProductStatistics productStatistics = new ProductStatistics();
            productStatistics.ShowDialog();

        }
    }
}
