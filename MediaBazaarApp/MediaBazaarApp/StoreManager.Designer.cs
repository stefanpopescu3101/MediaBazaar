
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnAddShelf = new System.Windows.Forms.Button();
            this.btnEditShelf = new System.Windows.Forms.Button();
            this.btnRemoveShelf = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(35, 40);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(250, 344);
            this.listBox1.TabIndex = 0;
            // 
            // btnAddShelf
            // 
            this.btnAddShelf.Location = new System.Drawing.Point(346, 96);
            this.btnAddShelf.Name = "btnAddShelf";
            this.btnAddShelf.Size = new System.Drawing.Size(156, 54);
            this.btnAddShelf.TabIndex = 1;
            this.btnAddShelf.Text = "Add shelf";
            this.btnAddShelf.UseVisualStyleBackColor = true;
            // 
            // btnEditShelf
            // 
            this.btnEditShelf.Location = new System.Drawing.Point(346, 171);
            this.btnEditShelf.Name = "btnEditShelf";
            this.btnEditShelf.Size = new System.Drawing.Size(156, 54);
            this.btnEditShelf.TabIndex = 2;
            this.btnEditShelf.Text = "Edit shelf";
            this.btnEditShelf.UseVisualStyleBackColor = true;
            // 
            // btnRemoveShelf
            // 
            this.btnRemoveShelf.Location = new System.Drawing.Point(346, 244);
            this.btnRemoveShelf.Name = "btnRemoveShelf";
            this.btnRemoveShelf.Size = new System.Drawing.Size(156, 54);
            this.btnRemoveShelf.TabIndex = 3;
            this.btnRemoveShelf.Text = "Remove shelf";
            this.btnRemoveShelf.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(125, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Shelfs:";
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(458, 409);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(94, 29);
            this.btnLogOut.TabIndex = 5;
            this.btnLogOut.Text = "Log out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            // 
            // StoreManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 450);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRemoveShelf);
            this.Controls.Add(this.btnEditShelf);
            this.Controls.Add(this.btnAddShelf);
            this.Controls.Add(this.listBox1);
            this.Name = "StoreManager";
            this.Text = "StoreManager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnAddShelf;
        private System.Windows.Forms.Button btnEditShelf;
        private System.Windows.Forms.Button btnRemoveShelf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogOut;
    }
}