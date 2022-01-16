
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

            this.btnAddShelf = new System.Windows.Forms.Button();

            this.cbFloor = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddProduct2Shelfs = new System.Windows.Forms.Button();
            this.lbProductsOnShelf = new System.Windows.Forms.ListBox();

            this.groupBox2 = new System.Windows.Forms.GroupBox();

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

            // btnAddShelf
            // 
            this.btnAddShelf.Location = new System.Drawing.Point(51, 167);
            this.btnAddShelf.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddShelf.Name = "btnAddShelf";
            this.btnAddShelf.Size = new System.Drawing.Size(138, 69);

            this.btnAddShelf.TabIndex = 5;
            this.btnAddShelf.Text = "ADD";
            this.btnAddShelf.UseVisualStyleBackColor = true;
            this.btnAddShelf.Click += new System.EventHandler(this.btnAddShelf_Click_1);
            // 

            // cbFloor
            // 
            this.cbFloor.FormattingEnabled = true;
            this.cbFloor.Location = new System.Drawing.Point(38, 97);

            this.cbFloor.Name = "cbFloor";
            this.cbFloor.Size = new System.Drawing.Size(151, 28);
            this.cbFloor.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;

            this.label3.Location = new System.Drawing.Point(38, 74);

            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Floor:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbFloor);

            this.groupBox1.Controls.Add(this.btnAddShelf);
            this.groupBox1.Location = new System.Drawing.Point(27, 87);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(229, 265);

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

            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.dtgvManipulateShelf);

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

        private System.Windows.Forms.Button btnAddShelf;

        private System.Windows.Forms.ComboBox cbFloor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddProduct2Shelfs;
        private System.Windows.Forms.ListBox lbProductsOnShelf;

        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Floor;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnReturnProduct;

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}