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
    public partial class ManipulateShelves : Form
    {

        ShelfManager shelfManager;

        public ManipulateShelves()
        {
            InitializeComponent();
            shelfManager = new ShelfManager();
        }


        public void UpdateDataGridView()
        {
            dtgvManipulateShelf.Rows.Clear();
            
            this.dtgvManipulateShelf.Columns[0].Name = "ID";
            this.dtgvManipulateShelf.Columns[1].Name = "Category";
            this.dtgvManipulateShelf.Columns[2].Name = "Capacity";
           

            foreach (Shelf shelf in shelfManager.GetShelves())
            {
                this.dtgvManipulateShelf.Rows.Add(shelf.ID, shelf.Category, shelf.Capacity);
                
            }
        }

        private void btnAddShelf_Click(object sender, EventArgs e)
        {
            Shelf shelf = new Shelf(cmbShelfCategory.Text, Convert.ToInt32(tbShelfCapacity.Text));

            shelfManager.AddShelf(shelf);
            MessageBox.Show("New shelf has been added successfully!");
            this.Close();

        }

        private void btnRemoveShelf_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dtgvManipulateShelf.CurrentCell.Value);

            shelfManager.RemoveShelf(id);
            UpdateDataGridView();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
