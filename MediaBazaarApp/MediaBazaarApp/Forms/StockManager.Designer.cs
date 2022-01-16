

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


            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();

            this.btnLogout = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.DGVProducts = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnReject = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            this.dataGridViewRequests = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RequestAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SentTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductNameR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timerTable = new System.Windows.Forms.Timer(this.components);

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

            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVProducts)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRequests)).BeginInit();

            this.SuspendLayout();
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;

            this.tabControl1.Size = new System.Drawing.Size(985, 593);

            this.tabControl1.TabIndex = 9;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged_1);
            // 
            // tabPage1
            // 

            this.tabPage1.Controls.Add(this.btnLogout);

            this.tabPage1.Controls.Add(this.btnUpdate);
            this.tabPage1.Controls.Add(this.btnAddProduct);
            this.tabPage1.Controls.Add(this.DGVProducts);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);

            this.tabPage1.Size = new System.Drawing.Size(977, 560);

            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Stock Manipulation";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 

            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(830, 488);

            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(104, 57);
            this.btnLogout.TabIndex = 17;
            this.btnLogout.Text = "Log out";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 

            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(309, 372);

            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(198, 87);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnAddProduct
            // 

            this.btnAddProduct.Location = new System.Drawing.Point(45, 372);

            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(198, 87);
            this.btnAddProduct.TabIndex = 13;
            this.btnAddProduct.Text = "Add Product";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click_1);
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

            this.ProductSold});

            this.DGVProducts.Location = new System.Drawing.Point(30, 29);
            this.DGVProducts.Name = "DGVProducts";
            this.DGVProducts.ReadOnly = true;
            this.DGVProducts.RowHeadersWidth = 51;

            this.DGVProducts.Size = new System.Drawing.Size(931, 313);
            this.DGVProducts.TabIndex = 10;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnReject);
            this.tabPage2.Controls.Add(this.btnAccept);
            this.tabPage2.Controls.Add(this.dataGridViewRequests);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(977, 560);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Restock Request";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnReject
            // 
            this.btnReject.BackColor = System.Drawing.Color.Red;
            this.btnReject.Location = new System.Drawing.Point(508, 306);
            this.btnReject.Name = "btnReject";
            this.btnReject.Size = new System.Drawing.Size(229, 86);
            this.btnReject.TabIndex = 2;
            this.btnReject.Text = "Reject Request";
            this.btnReject.UseVisualStyleBackColor = false;
            this.btnReject.Click += new System.EventHandler(this.btnReject_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.BackColor = System.Drawing.Color.Green;
            this.btnAccept.Location = new System.Drawing.Point(186, 306);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(229, 86);
            this.btnAccept.TabIndex = 1;
            this.btnAccept.Text = "Accept Request";
            this.btnAccept.UseVisualStyleBackColor = false;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // dataGridViewRequests
            // 
            this.dataGridViewRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRequests.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.RequestAmount,
            this.SentTime,
            this.ProductNameR});
            this.dataGridViewRequests.Location = new System.Drawing.Point(186, 61);
            this.dataGridViewRequests.Name = "dataGridViewRequests";
            this.dataGridViewRequests.RowHeadersWidth = 51;
            this.dataGridViewRequests.RowTemplate.Height = 29;
            this.dataGridViewRequests.Size = new System.Drawing.Size(556, 205);
            this.dataGridViewRequests.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 125;
            // 
            // RequestAmount
            // 
            this.RequestAmount.HeaderText = "Request Amount";
            this.RequestAmount.MinimumWidth = 6;
            this.RequestAmount.Name = "RequestAmount";
            this.RequestAmount.ReadOnly = true;
            this.RequestAmount.Width = 125;
            // 
            // SentTime
            // 
            this.SentTime.HeaderText = "Sent Time";
            this.SentTime.MinimumWidth = 6;
            this.SentTime.Name = "SentTime";
            this.SentTime.ReadOnly = true;
            this.SentTime.Width = 125;
            // 
            // ProductNameR
            // 
            this.ProductNameR.HeaderText = "Product Name";
            this.ProductNameR.MinimumWidth = 6;
            this.ProductNameR.Name = "ProductNameR";
            this.ProductNameR.ReadOnly = true;
            this.ProductNameR.Width = 125;
            // 
            // timerTable
            // 
            this.timerTable.Tick += new System.EventHandler(this.timer1_Tick);

            // 
            // ProductID
            // 
            this.ProductID.HeaderText = "ProductID";

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
            this.btnSendRestockRequest.Enabled = false;
            this.btnSendRestockRequest.Location = new System.Drawing.Point(807, 425);
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

            // StockManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;

            this.ClientSize = new System.Drawing.Size(998, 607);

            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label2);
            this.Name = "StockManager";
            this.Text = "StockManager";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StockManager_FormClosed);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVProducts)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRequests)).EndInit();

            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridViewRequests;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn RequestAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn SentTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductNameR;
        private System.Windows.Forms.TabPage tabPage1;

        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.DataGridView DGVProducts;
        private System.Windows.Forms.Button btnReject;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Timer timerTable;

        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductBrand;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductCostPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductSellPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductInStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductMaxCapacity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductThershold;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductSold;


    }
}