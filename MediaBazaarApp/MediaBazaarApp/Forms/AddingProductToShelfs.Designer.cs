
namespace MediaBazaarApp.Forms
{
    partial class AddingProductToShelfs
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
            this.ProductSold = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Measurements = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BoxSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btnSendRestockRequest = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
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
            this.ProductSold,
            this.Measurements,
            this.BoxSize});
            this.DGVProducts.Location = new System.Drawing.Point(34, 22);
            this.DGVProducts.Name = "DGVProducts";
            this.DGVProducts.ReadOnly = true;
            this.DGVProducts.RowHeadersWidth = 51;
            this.DGVProducts.Size = new System.Drawing.Size(906, 375);
            this.DGVProducts.TabIndex = 1;
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
            this.ProductThershold.HeaderText = "Low quantity alert";
            this.ProductThershold.MinimumWidth = 6;
            this.ProductThershold.Name = "ProductThershold";
            this.ProductThershold.ReadOnly = true;
            this.ProductThershold.Width = 125;
            // 
            // ProductSold
            // 
            this.ProductSold.HeaderText = "Sold Products";
            this.ProductSold.MinimumWidth = 6;
            this.ProductSold.Name = "ProductSold";
            this.ProductSold.ReadOnly = true;
            this.ProductSold.Width = 125;
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
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(34, 416);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(175, 62);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 490);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 40);
            this.label1.TabIndex = 3;
            this.label1.Text = "Make sure you select a prodcut\r\n before you click the button";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(866, 538);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 29);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(215, 416);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(150, 27);
            this.numericUpDown1.TabIndex = 5;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnSendRestockRequest
            // 
            this.btnSendRestockRequest.Location = new System.Drawing.Point(284, 466);
            this.btnSendRestockRequest.Name = "btnSendRestockRequest";
            this.btnSendRestockRequest.Size = new System.Drawing.Size(133, 64);
            this.btnSendRestockRequest.TabIndex = 6;
            this.btnSendRestockRequest.Text = "Send Restock Request";
            this.btnSendRestockRequest.UseVisualStyleBackColor = true;
            this.btnSendRestockRequest.Click += new System.EventHandler(this.btnSendRestockRequest_Click);
            // 
            // AddingProductToShelfs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 579);
            this.Controls.Add(this.btnSendRestockRequest);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.DGVProducts);
            this.Name = "AddingProductToShelfs";
            this.Text = "AddingProductToShelfs";
            ((System.ComponentModel.ISupportInitialize)(this.DGVProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVProducts;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductBrand;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductCostPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductSellPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductInStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductMaxCapacity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductThershold;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductSold;
        private System.Windows.Forms.DataGridViewTextBoxColumn Measurements;
        private System.Windows.Forms.DataGridViewTextBoxColumn BoxSize;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btnSendRestockRequest;
    }
}