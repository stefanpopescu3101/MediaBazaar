using MediaBazaarApp.Classes.Enums;
using MediaBazaarApp.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Text.RegularExpressions;

using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaBazaarApp
{
    public partial class ManipulateShelves : Form
    {


        private ShelfManager shelfManager;
       // private Shelf s  ;
        private  ProductManager pm = new ProductManager();


        public ManipulateShelves()
        {
            InitializeComponent();
            shelfManager = new ShelfManager();
            shelfManager.LoadShelfs();
            this.LoadS();
            cbFloor.DataSource = Enum.GetValues(typeof(Floors));

            

        }


        public void UpdateDataGridView()
        {
        }
        private void LoadS()
        {
            dtgvManipulateShelf.Rows.Clear();

            this.dtgvManipulateShelf.Columns[0].Name = "ID";
            this.dtgvManipulateShelf.Columns[1].Name = "Floor";
            foreach(Shelf s in shelfManager.GetShelvess())
            {
                this.dtgvManipulateShelf.Rows.Add(s.ID, s.Floors);
            }
            List<Product> products = new List<Product>();
            //if (this.cbExistingFloor.SelectedItem.ToString() == null)
            //{
            //    products = this.pm.GetListProd();
            //}
            //else
            //{
            //    Shelf shelf = cbExistingFloor.SelectedItem as Shelf;
            //    products = this.pm.GetProductBySpesificShelf(shelf);
            //}
        }
        private void btnRemoveShelf_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dtgvManipulateShelf.CurrentCell.Value);

            shelfManager.RemoveShelf(id);
            UpdateDataGridView();
        }
        private void ManipulateShelves_Load(object sender, EventArgs e)
        {
        }

        private void btnAddShelf_Click_1(object sender, EventArgs e)
        {
                if (cbFloor.Text != "")
                {
                    DialogResult r = MessageBox.Show("Are you sure you want to create a new shelf on this floor?", "", MessageBoxButtons.YesNo);
                    if(r == DialogResult.Yes)
                    {
                        Shelf s = new Shelf((Floors)cbFloor.SelectedIndex);
                        this.shelfManager.AddShelf(s);
                        MessageBox.Show("Shelf added");
                        dtgvManipulateShelf.Rows.Clear();
                        LoadS();
                    }
                }
                else
                {
                   MessageBox.Show("Please select a floor!");
  
                }         
        }
        private void groupBox1_Enter_1(object sender, EventArgs e)
        {
        }
        private void btnAddProduct2Shelfs_Click(object sender, EventArgs e)
        {
            if(this.dtgvManipulateShelf.SelectedCells.Count > 0)
            {
              int id = Convert.ToInt32(dtgvManipulateShelf.Rows[dtgvManipulateShelf.CurrentCell.RowIndex].Cells[0].Value);
              AddingProductToShelfs ap = new AddingProductToShelfs(id);


                

                ap.ShowDialog();
              this.LoadS();
                loadProducts(id);
            }
            else { MessageBox.Show("Please select a shelf to move product to!"); }
          
        }
        private void dtgvManipulateShelf_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dtgvManipulateShelf.Rows[dtgvManipulateShelf.CurrentCell.RowIndex].Cells[0].Value);
            loadProducts(id);

        }
        private void btnReturnProduct_Click(object sender, EventArgs e)
        {

            if(lbProductsOnShelf.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a item you want to renturn from the list!");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to return all of the selected products back to depot?", "", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    var result = Regex.Match(lbProductsOnShelf.SelectedItem.ToString(), @"^([\w\-]+)");
                    int id = Convert.ToInt32(dtgvManipulateShelf.Rows[dtgvManipulateShelf.CurrentCell.RowIndex].Cells[0].Value);
                    int prodID = Convert.ToInt32(result.Value);
                    string[] words = lbProductsOnShelf.SelectedItem.ToString().Split(' ');
                    shelfManager.AddProductToshelf(id, prodID, -Convert.ToInt32(words[words.Length - 1]));
                    loadProducts(id);
                }
               
            }
           

        }

        private void loadProducts(int id)
        {
            lbProductsOnShelf.Items.Clear();
            foreach (var item in shelfManager.GetItemsOnShelf(id))
            {
                lbProductsOnShelf.Items.Add(item);
            }
        }
    }
}
