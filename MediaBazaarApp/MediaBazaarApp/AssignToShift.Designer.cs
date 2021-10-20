
namespace MediaBazaarApp
{
    partial class AssignToShift
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
            this.lbPeopleInShift = new System.Windows.Forms.ListBox();
            this.lbAvailablePeople = new System.Windows.Forms.ListBox();
            this.lDateOfShift = new System.Windows.Forms.Label();
            this.lMinimum = new System.Windows.Forms.Label();
            this.btnAddToShift = new System.Windows.Forms.Button();
            this.btnRemoveFromTheShift = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbPeopleInShift
            // 
            this.lbPeopleInShift.FormattingEnabled = true;
            this.lbPeopleInShift.ItemHeight = 20;
            this.lbPeopleInShift.Location = new System.Drawing.Point(23, 74);
            this.lbPeopleInShift.Name = "lbPeopleInShift";
            this.lbPeopleInShift.Size = new System.Drawing.Size(225, 364);
            this.lbPeopleInShift.TabIndex = 0;
            // 
            // lbAvailablePeople
            // 
            this.lbAvailablePeople.FormattingEnabled = true;
            this.lbAvailablePeople.ItemHeight = 20;
            this.lbAvailablePeople.Location = new System.Drawing.Point(553, 74);
            this.lbAvailablePeople.Name = "lbAvailablePeople";
            this.lbAvailablePeople.Size = new System.Drawing.Size(225, 364);
            this.lbAvailablePeople.TabIndex = 1;
            // 
            // lDateOfShift
            // 
            this.lDateOfShift.AutoSize = true;
            this.lDateOfShift.Location = new System.Drawing.Point(376, 28);
            this.lDateOfShift.Name = "lDateOfShift";
            this.lDateOfShift.Size = new System.Drawing.Size(41, 20);
            this.lDateOfShift.TabIndex = 2;
            this.lDateOfShift.Text = "Date";
            // 
            // lMinimum
            // 
            this.lMinimum.AutoSize = true;
            this.lMinimum.Location = new System.Drawing.Point(327, 58);
            this.lMinimum.Name = "lMinimum";
            this.lMinimum.Size = new System.Drawing.Size(151, 20);
            this.lMinimum.TabIndex = 3;
            this.lMinimum.Text = "Maximum :{  } people";
            // 
            // btnAddToShift
            // 
            this.btnAddToShift.Location = new System.Drawing.Point(358, 176);
            this.btnAddToShift.Name = "btnAddToShift";
            this.btnAddToShift.Size = new System.Drawing.Size(94, 29);
            this.btnAddToShift.TabIndex = 4;
            this.btnAddToShift.Text = "Assign";
            this.btnAddToShift.UseVisualStyleBackColor = true;
            // 
            // btnRemoveFromTheShift
            // 
            this.btnRemoveFromTheShift.Location = new System.Drawing.Point(358, 211);
            this.btnRemoveFromTheShift.Name = "btnRemoveFromTheShift";
            this.btnRemoveFromTheShift.Size = new System.Drawing.Size(94, 29);
            this.btnRemoveFromTheShift.TabIndex = 5;
            this.btnRemoveFromTheShift.Text = "Remove";
            this.btnRemoveFromTheShift.UseVisualStyleBackColor = true;
            // 
            // AssignToShift
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRemoveFromTheShift);
            this.Controls.Add(this.btnAddToShift);
            this.Controls.Add(this.lMinimum);
            this.Controls.Add(this.lDateOfShift);
            this.Controls.Add(this.lbAvailablePeople);
            this.Controls.Add(this.lbPeopleInShift);
            this.Name = "AssignToShift";
            this.Text = "Assign To Shift";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbPeopleInShift;
        private System.Windows.Forms.ListBox lbAvailablePeople;
        private System.Windows.Forms.Label lDateOfShift;
        private System.Windows.Forms.Label lMinimum;
        private System.Windows.Forms.Button btnAddToShift;
        private System.Windows.Forms.Button btnRemoveFromTheShift;
    }
}