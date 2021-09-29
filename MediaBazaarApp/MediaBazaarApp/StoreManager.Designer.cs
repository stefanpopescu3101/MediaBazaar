
namespace MediaBazaarApp
{
    partial class StoreManager
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
            this.dgvShelfs = new System.Windows.Forms.DataGridView();
            this.btnAddShelf = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnRemoveShelf = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShelfs)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvShelfs
            // 
            this.dgvShelfs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShelfs.Location = new System.Drawing.Point(30, 50);
            this.dgvShelfs.Name = "dgvShelfs";
            this.dgvShelfs.RowHeadersWidth = 51;
            this.dgvShelfs.RowTemplate.Height = 29;
            this.dgvShelfs.Size = new System.Drawing.Size(434, 487);
            this.dgvShelfs.TabIndex = 0;
            // 
            // btnAddShelf
            // 
            this.btnAddShelf.Location = new System.Drawing.Point(540, 126);
            this.btnAddShelf.Name = "btnAddShelf";
            this.btnAddShelf.Size = new System.Drawing.Size(234, 58);
            this.btnAddShelf.TabIndex = 1;
            this.btnAddShelf.Text = "Add shelf";
            this.btnAddShelf.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(540, 289);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(234, 58);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnRemoveShelf
            // 
            this.btnRemoveShelf.Location = new System.Drawing.Point(540, 207);
            this.btnRemoveShelf.Name = "btnRemoveShelf";
            this.btnRemoveShelf.Size = new System.Drawing.Size(234, 58);
            this.btnRemoveShelf.TabIndex = 3;
            this.btnRemoveShelf.Text = "Remove shelf";
            this.btnRemoveShelf.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(685, 511);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(107, 41);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Log out";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(205, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Shelfs";
            // 
            // StoreManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 564);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnRemoveShelf);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAddShelf);
            this.Controls.Add(this.dgvShelfs);
            this.Name = "StoreManager";
            this.Text = "Store Manager";
            ((System.ComponentModel.ISupportInitialize)(this.dgvShelfs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvShelfs;
        private System.Windows.Forms.Button btnAddShelf;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnRemoveShelf;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogOut;
    }
}