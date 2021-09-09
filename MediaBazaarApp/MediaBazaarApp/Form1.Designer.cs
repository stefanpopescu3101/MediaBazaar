
namespace MediaBazaarApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.ibEmployees = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnTerminate = new System.Windows.Forms.Button();
            this.btnRemoveEmployee = new System.Windows.Forms.Button();
            this.btnUpdateInfo = new System.Windows.Forms.Button();
            this.btnViewPendingList = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSearchByID = new System.Windows.Forms.Button();
            this.cbViewEmployees = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(4, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(898, 606);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cbViewEmployees);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.ibEmployees);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(890, 573);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Employee Management";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(890, 573);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Workshift Management";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Location = new System.Drawing.Point(36, 34);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(222, 29);
            this.btnAddEmployee.TabIndex = 0;
            this.btnAddEmployee.Text = "Add new Employee";
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            // 
            // ibEmployees
            // 
            this.ibEmployees.FormattingEnabled = true;
            this.ibEmployees.ItemHeight = 20;
            this.ibEmployees.Location = new System.Drawing.Point(351, 101);
            this.ibEmployees.Name = "ibEmployees";
            this.ibEmployees.Size = new System.Drawing.Size(509, 464);
            this.ibEmployees.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(84, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 27);
            this.textBox1.TabIndex = 3;
            // 
            // btnTerminate
            // 
            this.btnTerminate.Location = new System.Drawing.Point(36, 133);
            this.btnTerminate.Name = "btnTerminate";
            this.btnTerminate.Size = new System.Drawing.Size(222, 29);
            this.btnTerminate.TabIndex = 1;
            this.btnTerminate.Text = "Terminate Employee\'s contract";
            this.btnTerminate.UseVisualStyleBackColor = true;
            // 
            // btnRemoveEmployee
            // 
            this.btnRemoveEmployee.Location = new System.Drawing.Point(36, 82);
            this.btnRemoveEmployee.Name = "btnRemoveEmployee";
            this.btnRemoveEmployee.Size = new System.Drawing.Size(222, 29);
            this.btnRemoveEmployee.TabIndex = 2;
            this.btnRemoveEmployee.Text = "Remove Employee";
            this.btnRemoveEmployee.UseVisualStyleBackColor = true;
            // 
            // btnUpdateInfo
            // 
            this.btnUpdateInfo.Location = new System.Drawing.Point(36, 185);
            this.btnUpdateInfo.Name = "btnUpdateInfo";
            this.btnUpdateInfo.Size = new System.Drawing.Size(222, 29);
            this.btnUpdateInfo.TabIndex = 4;
            this.btnUpdateInfo.Text = "Update ";
            this.btnUpdateInfo.UseVisualStyleBackColor = true;
            // 
            // btnViewPendingList
            // 
            this.btnViewPendingList.Location = new System.Drawing.Point(36, 239);
            this.btnViewPendingList.Name = "btnViewPendingList";
            this.btnViewPendingList.Size = new System.Drawing.Size(222, 29);
            this.btnViewPendingList.TabIndex = 5;
            this.btnViewPendingList.Text = "View pending list";
            this.btnViewPendingList.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnViewPendingList);
            this.groupBox1.Controls.Add(this.btnUpdateInfo);
            this.groupBox1.Controls.Add(this.btnTerminate);
            this.groupBox1.Controls.Add(this.btnRemoveEmployee);
            this.groupBox1.Controls.Add(this.btnAddEmployee);
            this.groupBox1.Location = new System.Drawing.Point(18, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(309, 328);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Actions";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSearchByID);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(18, 394);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(308, 171);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search";
            // 
            // btnSearchByID
            // 
            this.btnSearchByID.Location = new System.Drawing.Point(38, 99);
            this.btnSearchByID.Name = "btnSearchByID";
            this.btnSearchByID.Size = new System.Drawing.Size(222, 29);
            this.btnSearchByID.TabIndex = 6;
            this.btnSearchByID.Text = "Search";
            this.btnSearchByID.UseVisualStyleBackColor = true;
            // 
            // cbViewEmployees
            // 
            this.cbViewEmployees.FormattingEnabled = true;
            this.cbViewEmployees.Location = new System.Drawing.Point(424, 67);
            this.cbViewEmployees.Name = "cbViewEmployees";
            this.cbViewEmployees.Size = new System.Drawing.Size(380, 28);
            this.cbViewEmployees.TabIndex = 8;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(890, 573);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Department Management";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 609);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "HR Manager Form";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox cbViewEmployees;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSearchByID;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnViewPendingList;
        private System.Windows.Forms.Button btnUpdateInfo;
        private System.Windows.Forms.Button btnTerminate;
        private System.Windows.Forms.Button btnRemoveEmployee;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.ListBox ibEmployees;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
    }
}

