
namespace MediaBazaarApp
{
    partial class StockManager
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

            this.DGVProducts = new System.Windows.Forms.DataGridView();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductBrand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductCostPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductSellPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductInStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductMaxCapacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductThershold = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Measurements = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BoxSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cBShelfCategories = new System.Windows.Forms.ComboBox();

            this.label1 = new System.Windows.Forms.Label();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnRemoveProduct = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();

            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVProducts
            // 
            this.DGVProducts.AllowUserToDeleteRows = false;
            this.DGVProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductID,
            this.ProductName,
            this.ProductBrand,
            this.ProductCostPrice,
            this.ProductSellPrice,
            this.ProductInStock,
            this.ProductMaxCapacity,
            this.ProductThershold,
            this.Measurements,
            this.BoxSize});
            this.DGVProducts.Location = new System.Drawing.Point(46, 92);
            this.DGVProducts.Name = "DGVProducts";
            this.DGVProducts.ReadOnly = true;
            this.DGVProducts.RowHeadersWidth = 51;
            this.DGVProducts.Size = new System.Drawing.Size(1304, 375);
            this.DGVProducts.TabIndex = 0;
            // 
            // ProductID
            // 
            this.ProductID.HeaderText = "ID";
            this.ProductID.MinimumWidth = 6;
            this.ProductID.Name = "ProductID";
            this.ProductID.ReadOnly = true;
            this.ProductID.Width = 125;
            // 
            // ProductName
            // 
            this.ProductName.HeaderText = "Name";
            this.ProductName.MinimumWidth = 6;
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            this.ProductName.Width = 125;
            // 
            // ProductBrand
            // 
            this.ProductBrand.HeaderText = "Brand";
            this.ProductBrand.MinimumWidth = 6;
            this.ProductBrand.Name = "ProductBrand";
            this.ProductBrand.ReadOnly = true;
            this.ProductBrand.Width = 125;
            // 
            // ProductCostPrice
            // 
            this.ProductCostPrice.HeaderText = "Cost Price";
            this.ProductCostPrice.MinimumWidth = 6;
            this.ProductCostPrice.Name = "ProductCostPrice";
            this.ProductCostPrice.ReadOnly = true;
            this.ProductCostPrice.Width = 125;
            // 
            // ProductSellPrice
            // 
            this.ProductSellPrice.HeaderText = "Sell Price";
            this.ProductSellPrice.MinimumWidth = 6;
            this.ProductSellPrice.Name = "ProductSellPrice";
            this.ProductSellPrice.ReadOnly = true;
            this.ProductSellPrice.Width = 125;
            // 
            // ProductInStock
            // 
            this.ProductInStock.HeaderText = "In Stock";
            this.ProductInStock.MinimumWidth = 6;
            this.ProductInStock.Name = "ProductInStock";
            this.ProductInStock.ReadOnly = true;
            this.ProductInStock.Width = 125;
            // 
            // ProductMaxCapacity
            // 
            this.ProductMaxCapacity.HeaderText = "Max Capacity";
            this.ProductMaxCapacity.MinimumWidth = 6;
            this.ProductMaxCapacity.Name = "ProductMaxCapacity";
            this.ProductMaxCapacity.ReadOnly = true;
            this.ProductMaxCapacity.Width = 125;
            // 
            // ProductThershold
            // 
            this.ProductThershold.HeaderText = "Threshold";
            this.ProductThershold.MinimumWidth = 6;
            this.ProductThershold.Name = "ProductThershold";
            this.ProductThershold.ReadOnly = true;
            this.ProductThershold.Width = 125;

            // 
            // Measurements
            // 

            this.Measurements.HeaderText = "Measurements";
            this.Measurements.MinimumWidth = 6;
            this.Measurements.Name = "Measurements";
            this.Measurements.ReadOnly = true;
            this.Measurements.Width = 125;
            // 
            // BoxSize
            // 
            this.BoxSize.HeaderText = "Box Size";
            this.BoxSize.MinimumWidth = 6;
            this.BoxSize.Name = "BoxSize";
            this.BoxSize.ReadOnly = true;
            this.BoxSize.Width = 125;
            // 
            // cBShelfCategories
            // 
            this.cBShelfCategories.FormattingEnabled = true;
            this.cBShelfCategories.Location = new System.Drawing.Point(70, 499);
            this.cBShelfCategories.Name = "cBShelfCategories";
            this.cBShelfCategories.Size = new System.Drawing.Size(151, 28);
            this.cBShelfCategories.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 502);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Shelf:";
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(278, 496);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(245, 87);
            this.btnAddProduct.TabIndex = 3;
            this.btnAddProduct.Text = "Add Product";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(70, 533);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(151, 32);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(885, 496);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(245, 87);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnRemoveProduct
            // 
            this.btnRemoveProduct.Location = new System.Drawing.Point(581, 496);
            this.btnRemoveProduct.Name = "btnRemoveProduct";
            this.btnRemoveProduct.Size = new System.Drawing.Size(245, 87);
            this.btnRemoveProduct.TabIndex = 6;
            this.btnRemoveProduct.Text = "Remove Product";
            this.btnRemoveProduct.UseVisualStyleBackColor = true;
            this.btnRemoveProduct.Click += new System.EventHandler(this.btnRemoveProduct_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(1267, 551);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(104, 57);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "Log out";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(591, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 38);
            this.label2.TabIndex = 8;
            this.label2.Text = "Stock Manager:";

            // 
            // StockManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;

            this.ClientSize = new System.Drawing.Size(1383, 620);
            this.Controls.Add(this.label2);

            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnRemoveProduct);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.label1);

            this.Controls.Add(this.cBShelfCategories);
            this.Controls.Add(this.DGVProducts);

            this.Name = "StockManager";
            this.Text = "StockManager";
            ((System.ComponentModel.ISupportInitialize)(this.DGVProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            this.PerformLayout();


        }

        #endregion



        private System.Windows.Forms.DataGridView DGVProducts;
        private System.Windows.Forms.ComboBox cBShelfCategories;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnRemoveProduct;
        private System.Windows.Forms.Button btnLogout;

        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductBrand;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductCostPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductSellPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductInStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductMaxCapacity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductThershold;
        private System.Windows.Forms.DataGridViewTextBoxColumn Measurements;
        private System.Windows.Forms.DataGridViewTextBoxColumn BoxSize;
        private System.Windows.Forms.Label label2;

    }
}