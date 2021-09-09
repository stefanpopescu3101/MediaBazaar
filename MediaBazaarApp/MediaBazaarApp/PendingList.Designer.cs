
namespace MediaBazaarApp
{
    partial class PendingList
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
            this.lbPendingList = new System.Windows.Forms.ListBox();
            this.btnExtendContract = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbPendingList
            // 
            this.lbPendingList.FormattingEnabled = true;
            this.lbPendingList.ItemHeight = 20;
            this.lbPendingList.Location = new System.Drawing.Point(19, 26);
            this.lbPendingList.Name = "lbPendingList";
            this.lbPendingList.Size = new System.Drawing.Size(454, 384);
            this.lbPendingList.TabIndex = 0;
            // 
            // btnExtendContract
            // 
            this.btnExtendContract.Location = new System.Drawing.Point(344, 436);
            this.btnExtendContract.Name = "btnExtendContract";
            this.btnExtendContract.Size = new System.Drawing.Size(145, 29);
            this.btnExtendContract.TabIndex = 1;
            this.btnExtendContract.Text = "Extend contract";
            this.btnExtendContract.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(344, 471);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 29);
            this.button2.TabIndex = 2;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(32, 470);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(250, 27);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(85, 436);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(129, 20);
            this.label11.TabIndex = 66;
            this.label11.Text = "Last working date:";
            // 
            // PendingList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 542);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnExtendContract);
            this.Controls.Add(this.lbPendingList);
            this.Name = "PendingList";
            this.Text = "Pending List";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbPendingList;
        private System.Windows.Forms.Button btnExtendContract;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label11;
    }
}