
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddShelf = new System.Windows.Forms.Button();
            this.cmbShelfCategory = new System.Windows.Forms.ComboBox();
            this.tbShelfCapacity = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.btnRemoveShelf = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvManipulateShelf)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgvManipulateShelf
            // 
            this.dtgvManipulateShelf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvManipulateShelf.Location = new System.Drawing.Point(591, 139);
            this.dtgvManipulateShelf.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtgvManipulateShelf.Name = "dtgvManipulateShelf";
            this.dtgvManipulateShelf.RowHeadersWidth = 51;
            this.dtgvManipulateShelf.RowTemplate.Height = 25;
            this.dtgvManipulateShelf.Size = new System.Drawing.Size(274, 259);
            this.dtgvManipulateShelf.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnAddShelf);
            this.groupBox1.Controls.Add(this.cmbShelfCategory);
            this.groupBox1.Controls.Add(this.tbShelfCapacity);
            this.groupBox1.Location = new System.Drawing.Point(27, 125);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(229, 272);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add shelf :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Category : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Capacity : ";
            // 
            // btnAddShelf
            // 
            this.btnAddShelf.Location = new System.Drawing.Point(23, 208);
            this.btnAddShelf.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddShelf.Name = "btnAddShelf";
            this.btnAddShelf.Size = new System.Drawing.Size(138, 31);
            this.btnAddShelf.TabIndex = 5;
            this.btnAddShelf.Text = "ADD";
            this.btnAddShelf.UseVisualStyleBackColor = true;
            this.btnAddShelf.Click += new System.EventHandler(this.btnAddShelf_Click);
            // 
            // cmbShelfCategory
            // 
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
            // tbShelfCapacity
            // 
            this.tbShelfCapacity.Location = new System.Drawing.Point(23, 147);
            this.tbShelfCapacity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbShelfCapacity.Name = "tbShelfCapacity";
            this.tbShelfCapacity.Size = new System.Drawing.Size(138, 27);
            this.tbShelfCapacity.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.btnRemoveShelf);
            this.groupBox2.Location = new System.Drawing.Point(303, 125);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(229, 272);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Further actions :";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(55, 165);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(104, 35);
            this.button3.TabIndex = 7;
            this.button3.Text = "EDIT";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnRemoveShelf
            // 
            this.btnRemoveShelf.Location = new System.Drawing.Point(55, 112);
            this.btnRemoveShelf.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRemoveShelf.Name = "btnRemoveShelf";
            this.btnRemoveShelf.Size = new System.Drawing.Size(104, 31);
            this.btnRemoveShelf.TabIndex = 6;
            this.btnRemoveShelf.Text = "REMOVE";
            this.btnRemoveShelf.UseVisualStyleBackColor = true;
            this.btnRemoveShelf.Click += new System.EventHandler(this.btnRemoveShelf_Click);
            // 
            // ManipulateShelves
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtgvManipulateShelf);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ManipulateShelves";
            this.Text = "ManipulateShelf";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvManipulateShelf)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvManipulateShelf;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddShelf;
        private System.Windows.Forms.ComboBox cmbShelfCategory;
        private System.Windows.Forms.TextBox tbShelfCapacity;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnRemoveShelf;
    }
}