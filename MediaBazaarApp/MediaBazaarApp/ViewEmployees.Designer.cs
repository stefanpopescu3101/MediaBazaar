
namespace MediaBazaarApp
{
    partial class ViewEmployees
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
            this.lbEmployeesOfDepartment = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbEmployeesOfDepartment
            // 
            this.lbEmployeesOfDepartment.FormattingEnabled = true;
            this.lbEmployeesOfDepartment.ItemHeight = 20;
            this.lbEmployeesOfDepartment.Location = new System.Drawing.Point(25, 40);
            this.lbEmployeesOfDepartment.Name = "lbEmployeesOfDepartment";
            this.lbEmployeesOfDepartment.Size = new System.Drawing.Size(534, 404);
            this.lbEmployeesOfDepartment.TabIndex = 0;
            // 
            // ViewEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 476);
            this.Controls.Add(this.lbEmployeesOfDepartment);
            this.Name = "ViewEmployees";
            this.Text = "ViewEmployees";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbEmployeesOfDepartment;
    }
}