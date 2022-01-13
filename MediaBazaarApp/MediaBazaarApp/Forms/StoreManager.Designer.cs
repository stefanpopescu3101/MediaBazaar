
namespace MediaBazaarApp
{
    partial class ManipulateShelves
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtgvManipulateShelf = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Floor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbShelfCapacity = new System.Windows.Forms.TextBox();
            this.cmbShelfCategory = new System.Windows.Forms.ComboBox();
            this.btnAddShelf = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbFloor = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddProduct2Shelfs = new System.Windows.Forms.Button();
            this.lbProductsOnShelf = new System.Windows.Forms.ListBox();
            this.cbExistingFloor = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnReturnProduct = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvManipulateShelf)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgvManipulateShelf
            // 
            this.dtgvManipulateShelf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvManipulateShelf.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Floor});
            this.dtgvManipulateShelf.Location = new System.Drawing.Point(10, 64);
            this.dtgvManipulateShelf.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtgvManipulateShelf.Name = "dtgvManipulateShelf";
            this.dtgvManipulateShelf.RowHeadersWidth = 51;
            this.dtgvManipulateShelf.RowTemplate.Height = 25;
            this.dtgvManipulateShelf.Size = new System.Drawing.Size(303, 259);
            this.dtgvManipulateShelf.TabIndex = 3;
            this.dtgvManipulateShelf.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvManipulateShelf_CellClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "Shelf Identity";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 125;
            // 
            // Floor
            // 
            this.Floor.HeaderText = "Floor";
            this.Floor.MinimumWidth = 6;
            this.Floor.Name = "Floor";
            this.Floor.ReadOnly = true;
            this.Floor.Width = 125;
            // 
            // tbShelfCapacity
            // 
            this.tbShelfCapacity.Enabled = false;
            this.tbShelfCapacity.Location = new System.Drawing.Point(23, 147);
            this.tbShelfCapacity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbShelfCapacity.Name = "tbShelfCapacity";
            this.tbShelfCapacity.Size = new System.Drawing.Size(138, 27);
            this.tbShelfCapacity.TabIndex = 4;
            // 
            // cmbShelfCategory
            // 
            this.cmbShelfCategory.Enabled = false;
            this.cmbShelfCategory.FormattingEnabled = true;
            this.cmbShelfCategory.Items.AddRange(new object[] {
            "Chargers",
            "Phones",
            "Laptops",
            "TVs"});
            this.cmbShelfCategory.Location = new System.Drawing.Point(23, 73);
            this.cmbShelfCategory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbShelfCategory.Name = "cmbShelfCategory";
            this.cmbShelfCategory.Size = new System.Drawing.Size(138, 28);
            this.cmbShelfCategory.TabIndex = 3;
            // 
            // btnAddShelf
            // 
            this.btnAddShelf.Location = new System.Drawing.Point(36, 288);
            this.btnAddShelf.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddShelf.Name = "btnAddShelf";
            this.btnAddShelf.Size = new System.Drawing.Size(138, 31);
            this.btnAddShelf.TabIndex = 5;
            this.btnAddShelf.Text = "ADD";
            this.btnAddShelf.UseVisualStyleBackColor = true;
            this.btnAddShelf.Click += new System.EventHandler(this.btnAddShelf_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(23, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Capacity : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(23, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Category : ";
            // 
            // cbFloor
            // 
            this.cbFloor.FormattingEnabled = true;
            this.cbFloor.Location = new System.Drawing.Point(23, 218);
            this.cbFloor.Name = "cbFloor";
            this.cbFloor.Size = new System.Drawing.Size(151, 28);
            this.cbFloor.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Floor:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbFloor);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnAddShelf);
            this.groupBox1.Controls.Add(this.cmbShelfCategory);
            this.groupBox1.Controls.Add(this.tbShelfCapacity);
            this.groupBox1.Location = new System.Drawing.Point(37, 47);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(229, 349);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add shelf :";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter_1);
            // 
            // btnAddProduct2Shelfs
            // 
            this.btnAddProduct2Shelfs.Location = new System.Drawing.Point(702, 86);
            this.btnAddProduct2Shelfs.Name = "btnAddProduct2Shelfs";
            this.btnAddProduct2Shelfs.Size = new System.Drawing.Size(149, 56);
            this.btnAddProduct2Shelfs.TabIndex = 6;
            this.btnAddProduct2Shelfs.Text = "Store Product to shelf";
            this.btnAddProduct2Shelfs.UseVisualStyleBackColor = true;
            this.btnAddProduct2Shelfs.Click += new System.EventHandler(this.btnAddProduct2Shelfs_Click);
            // 
            // lbProductsOnShelf
            // 
            this.lbProductsOnShelf.FormattingEnabled = true;
            this.lbProductsOnShelf.ItemHeight = 20;
            this.lbProductsOnShelf.Location = new System.Drawing.Point(343, 59);
            this.lbProductsOnShelf.Name = "lbProductsOnShelf";
            this.lbProductsOnShelf.Size = new System.Drawing.Size(353, 264);
            this.lbProductsOnShelf.TabIndex = 8;
            // 
            // cbExistingFloor
            // 
            this.cbExistingFloor.Enabled = false;
            this.cbExistingFloor.FormattingEnabled = true;
            this.cbExistingFloor.Location = new System.Drawing.Point(10, 354);
            this.cbExistingFloor.Name = "cbExistingFloor";
            this.cbExistingFloor.Size = new System.Drawing.Size(148, 28);
            this.cbExistingFloor.TabIndex = 9;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.dtgvManipulateShelf);
            this.groupBox2.Controls.Add(this.cbExistingFloor);
            this.groupBox2.Controls.Add(this.btnAddProduct2Shelfs);
            this.groupBox2.Controls.Add(this.btnReturnProduct);
            this.groupBox2.Controls.Add(this.lbProductsOnShelf);
            this.groupBox2.Location = new System.Drawing.Point(284, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(857, 406);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Manipulating Shelfs";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 331);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Shelfs per floor:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Shelfs:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(343, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Products on selected shelf:";
            // 
            // btnReturnProduct
            // 
            this.btnReturnProduct.Enabled = false;
            this.btnReturnProduct.Location = new System.Drawing.Point(702, 148);
            this.btnReturnProduct.Name = "btnReturnProduct";
            this.btnReturnProduct.Size = new System.Drawing.Size(149, 56);
            this.btnReturnProduct.TabIndex = 7;
            this.btnReturnProduct.Text = "Return selected product to storage";
            this.btnReturnProduct.UseVisualStyleBackColor = true;
            this.btnReturnProduct.Click += new System.EventHandler(this.btnReturnProduct_Click);
            // 
            // ManipulateShelves
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 513);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ManipulateShelves";
            this.Text = "Store Manager";
            this.Load += new System.EventHandler(this.ManipulateShelves_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvManipulateShelf)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvManipulateShelf;
        private System.Windows.Forms.TextBox tbShelfCapacity;
        private System.Windows.Forms.ComboBox cmbShelfCategory;
        private System.Windows.Forms.Button btnAddShelf;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbFloor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddProduct2Shelfs;
        private System.Windows.Forms.ListBox lbProductsOnShelf;
        private System.Windows.Forms.ComboBox cbExistingFloor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Floor;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnReturnProduct;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}