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
    public partial class AddingProductToShelfs : Form
    {
        private ProductManager productManager;
        private ShelfManager shelfManager;
        private RequestManager requestManager;
        //private ShelfMediator shelfMediator = new ShelfMediator();
        private int s {get; set;}
     
        public AddingProductToShelfs(int id)
        {
            InitializeComponent();
            this.productManager = new ProductManager();
            this.shelfManager = new ShelfManager();
            this.requestManager = new RequestManager();
            this.s = id;
            productManager.Load();
            LoadAllProducts();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void LoadAllProducts()
        {

            this.DGVProducts.Rows.Clear();

            this.DGVProducts.ColumnCount = 9;

            this.DGVProducts.Columns[0].Name = "ID";
            this.DGVProducts.Columns[1].Name = "Name";
            this.DGVProducts.Columns[2].Name = "Brand";
            this.DGVProducts.Columns[3].Name = "Cost Price";
            this.DGVProducts.Columns[4].Name = "Sell Price";
            this.DGVProducts.Columns[5].Name = "In Stock";
            this.DGVProducts.Columns[6].Name = "Max Capacity";
            this.DGVProducts.Columns[7].Name = "Threshold";
            this.DGVProducts.Columns[8].Name = "Sold";

           // this.DGVProducts.Columns[9].Name = "Measurements";
          //  this.DGVProducts.Columns[10].Name = "Box Size";

            foreach (Product p in productManager.GetProducts())
            {
                this.DGVProducts.Rows.Add(p.ID, p.Name, p.Brand, p.CostPrice + " €", p.SellPrice + " €", p.InStock, p.MaxCapacity, p.Threshold, p.Sold);

            }
            foreach (DataGridViewRow row in DGVProducts.Rows)

                if (Convert.ToInt32(row.Cells[5].Value) < Convert.ToInt32(row.Cells[7].Value))

                {

                    row.DefaultCellStyle.BackColor = Color.Red;

                }


        }
        private int GetProduct()
        {
            int selectedRowIndex = this.DGVProducts.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = this.DGVProducts.Rows[selectedRowIndex];
            return Convert.ToInt32(selectedRow.Cells["ID"].Value);
        }
        //this is a bit more practical 
        private Product GetProduct2()
        {
            int selectedRowIndex = this.DGVProducts.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = this.DGVProducts.Rows[selectedRowIndex];
            Product product = this.productManager.Get(Convert.ToInt32(selectedRow.Cells["ID"].Value));
            return product;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
          if(this.DGVProducts.SelectedCells.Count > 0)
            {

                DialogResult dialogResult = MessageBox.Show($"Are you sure you want to store {numericUpDown1.Value} amount of this product on shelf ID:{s} ?", "", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    int selectedRowIndex = this.DGVProducts.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = this.DGVProducts.Rows[selectedRowIndex];

                    int p = this.GetProduct();
                    int stockAmount = Convert.ToInt32(selectedRow.Cells["In Stock"].Value);
                    if ((stockAmount - numericUpDown1.Value) >= 0)
                    {

                        shelfManager.AddProductToshelf(s, p, Convert.ToInt32(numericUpDown1.Value));
                        this.Close();

                    }
                    else
                    {
                        MessageBox.Show("Not enough of this item is in stock!");
                    }
                }

            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void btnSendRestockRequest_Click(object sender, EventArgs e)
        {
            if (this.DGVProducts.SelectedCells.Count > 0)
            {
                Product product = this.GetProduct2();
                if (product.InStock < product.MaxCapacity)
                {
                    RestockRequest restockRequest = new RestockRequest(product);

                    if (!requestManager.CheckRequestAlreadySent(restockRequest))

                    {
                        requestManager.Add(new RestockRequest(product));
                        MessageBox.Show("Restock request has been sent successfully! ");
                    }
                    else { MessageBox.Show("A restock request for this product has already been sent."); }
                }
                else
                {
                    MessageBox.Show("Can not send a restock request when the product is at full capacity.");
                }
            }
            else { MessageBox.Show("Please select a product from the table."); }
        }
    }
}
