
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbColumnChoice = new System.Windows.Forms.ComboBox();
            this.btnSearchByID = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnUpdateInfo = new System.Windows.Forms.Button();
            this.btnTerminate = new System.Windows.Forms.Button();
            this.btnRemoveEmployee = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.cbDepartmentManager = new System.Windows.Forms.ComboBox();
            this.lDepartmentManager = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.tbDepartmentName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClearD = new System.Windows.Forms.Button();
            this.dgvDepartments = new System.Windows.Forms.DataGridView();
            this.btnUpdateDepartment = new System.Windows.Forms.Button();
            this.btnRemoveDepartment = new System.Windows.Forms.Button();
            this.btnAddDepartment = new System.Windows.Forms.Button();
            this.btnStatistics = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartments)).BeginInit();
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
            this.tabControl1.Size = new System.Drawing.Size(1155, 755);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnStatistics);
            this.tabPage1.Controls.Add(this.btnAdd);
            this.tabPage1.Controls.Add(this.btnLogout);
            this.tabPage1.Controls.Add(this.dgvEmployees);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.btnUpdateInfo);
            this.tabPage1.Controls.Add(this.btnTerminate);
            this.tabPage1.Controls.Add(this.btnRemoveEmployee);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1147, 722);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Employee Management";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(579, 656);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(101, 37);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(1041, 6);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(100, 29);
            this.btnLogout.TabIndex = 10;
            this.btnLogout.Text = "Log out";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // dgvEmployees
            // 
            this.dgvEmployees.AllowUserToAddRows = false;
            this.dgvEmployees.AllowUserToDeleteRows = false;
            this.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployees.DataMember = " ";
            this.dgvEmployees.Location = new System.Drawing.Point(20, 113);
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.RowHeadersWidth = 51;
            this.dgvEmployees.RowTemplate.Height = 29;
            this.dgvEmployees.Size = new System.Drawing.Size(1044, 537);
            this.dgvEmployees.TabIndex = 9;
            this.dgvEmployees.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployees_CellContentClick);
            this.dgvEmployees.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dgvEmployees_RowStateChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cbColumnChoice);
            this.groupBox2.Controls.Add(this.btnSearchByID);
            this.groupBox2.Controls.Add(this.tbSearch);
            this.groupBox2.Controls.Add(this.btnClear);
            this.groupBox2.Location = new System.Drawing.Point(20, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(996, 92);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search employee";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(334, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Search based on:";
            // 
            // cbColumnChoice
            // 
            this.cbColumnChoice.FormattingEnabled = true;
            this.cbColumnChoice.Location = new System.Drawing.Point(154, 39);
            this.cbColumnChoice.Name = "cbColumnChoice";
            this.cbColumnChoice.Size = new System.Drawing.Size(151, 28);
            this.cbColumnChoice.TabIndex = 9;
            this.cbColumnChoice.SelectedIndexChanged += new System.EventHandler(this.cbColumnChoice_SelectedIndexChanged);
            // 
            // btnSearchByID
            // 
            this.btnSearchByID.Location = new System.Drawing.Point(740, 37);
            this.btnSearchByID.Name = "btnSearchByID";
            this.btnSearchByID.Size = new System.Drawing.Size(110, 29);
            this.btnSearchByID.TabIndex = 6;
            this.btnSearchByID.Text = "Search";
            this.btnSearchByID.UseVisualStyleBackColor = true;
            this.btnSearchByID.Click += new System.EventHandler(this.btnSearchByID_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(349, 38);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(376, 27);
            this.tbSearch.TabIndex = 3;
            this.tbSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(856, 37);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(120, 29);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear filters";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnUpdateInfo
            // 
            this.btnUpdateInfo.Location = new System.Drawing.Point(686, 656);
            this.btnUpdateInfo.Name = "btnUpdateInfo";
            this.btnUpdateInfo.Size = new System.Drawing.Size(101, 37);
            this.btnUpdateInfo.TabIndex = 4;
            this.btnUpdateInfo.Text = "Update ";
            this.btnUpdateInfo.UseVisualStyleBackColor = true;
            this.btnUpdateInfo.Click += new System.EventHandler(this.btnUpdateInfo_Click);
            // 
            // btnTerminate
            // 
            this.btnTerminate.Location = new System.Drawing.Point(900, 656);
            this.btnTerminate.Name = "btnTerminate";
            this.btnTerminate.Size = new System.Drawing.Size(164, 37);
            this.btnTerminate.TabIndex = 1;
            this.btnTerminate.Text = "Terminate contract";
            this.btnTerminate.UseVisualStyleBackColor = true;
            this.btnTerminate.Click += new System.EventHandler(this.btnTerminate_Click);
            // 
            // btnRemoveEmployee
            // 
            this.btnRemoveEmployee.Location = new System.Drawing.Point(793, 656);
            this.btnRemoveEmployee.Name = "btnRemoveEmployee";
            this.btnRemoveEmployee.Size = new System.Drawing.Size(101, 37);
            this.btnRemoveEmployee.TabIndex = 2;
            this.btnRemoveEmployee.Text = "Remove";
            this.btnRemoveEmployee.UseVisualStyleBackColor = true;
            this.btnRemoveEmployee.Click += new System.EventHandler(this.btnRemoveEmployee_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1147, 722);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Workshift Management";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.cbDepartmentManager);
            this.tabPage3.Controls.Add(this.lDepartmentManager);
            this.tabPage3.Controls.Add(this.label20);
            this.tabPage3.Controls.Add(this.label21);
            this.tabPage3.Controls.Add(this.tbDepartmentName);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.btnClearD);
            this.tabPage3.Controls.Add(this.dgvDepartments);
            this.tabPage3.Controls.Add(this.btnUpdateDepartment);
            this.tabPage3.Controls.Add(this.btnRemoveDepartment);
            this.tabPage3.Controls.Add(this.btnAddDepartment);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1147, 722);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Department Management";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // cbDepartmentManager
            // 
            this.cbDepartmentManager.FormattingEnabled = true;
            this.cbDepartmentManager.Location = new System.Drawing.Point(749, 459);
            this.cbDepartmentManager.Name = "cbDepartmentManager";
            this.cbDepartmentManager.Size = new System.Drawing.Size(379, 28);
            this.cbDepartmentManager.TabIndex = 42;
            this.cbDepartmentManager.SelectedIndexChanged += new System.EventHandler(this.cbDepartmentManager_SelectedIndexChanged);
            // 
            // lDepartmentManager
            // 
            this.lDepartmentManager.AutoSize = true;
            this.lDepartmentManager.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lDepartmentManager.Location = new System.Drawing.Point(919, 418);
            this.lDepartmentManager.Name = "lDepartmentManager";
            this.lDepartmentManager.Size = new System.Drawing.Size(0, 23);
            this.lDepartmentManager.TabIndex = 41;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(749, 418);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(155, 20);
            this.label20.TabIndex = 39;
            this.label20.Text = "Department Manager:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(768, 374);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(136, 20);
            this.label21.TabIndex = 38;
            this.label21.Text = "Department Name:";
            // 
            // tbDepartmentName
            // 
            this.tbDepartmentName.Location = new System.Drawing.Point(910, 371);
            this.tbDepartmentName.Name = "tbDepartmentName";
            this.tbDepartmentName.Size = new System.Drawing.Size(169, 27);
            this.tbDepartmentName.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(262, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 28);
            this.label2.TabIndex = 10;
            this.label2.Text = "Departments";
            // 
            // btnClearD
            // 
            this.btnClearD.Location = new System.Drawing.Point(857, 290);
            this.btnClearD.Name = "btnClearD";
            this.btnClearD.Size = new System.Drawing.Size(222, 29);
            this.btnClearD.TabIndex = 9;
            this.btnClearD.Text = "Clear";
            this.btnClearD.UseVisualStyleBackColor = true;
            this.btnClearD.Click += new System.EventHandler(this.btnViewEmployeesOfDepartment_Click);
            // 
            // dgvDepartments
            // 
            this.dgvDepartments.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvDepartments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDepartments.Location = new System.Drawing.Point(17, 62);
            this.dgvDepartments.Name = "dgvDepartments";
            this.dgvDepartments.ReadOnly = true;
            this.dgvDepartments.RowHeadersWidth = 51;
            this.dgvDepartments.RowTemplate.Height = 29;
            this.dgvDepartments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDepartments.Size = new System.Drawing.Size(715, 636);
            this.dgvDepartments.TabIndex = 8;
            this.dgvDepartments.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDepartments_CellContentClick);
            // 
            // btnUpdateDepartment
            // 
            this.btnUpdateDepartment.Location = new System.Drawing.Point(857, 255);
            this.btnUpdateDepartment.Name = "btnUpdateDepartment";
            this.btnUpdateDepartment.Size = new System.Drawing.Size(222, 29);
            this.btnUpdateDepartment.TabIndex = 7;
            this.btnUpdateDepartment.Text = "Update ";
            this.btnUpdateDepartment.UseVisualStyleBackColor = true;
            this.btnUpdateDepartment.Click += new System.EventHandler(this.btnUpdateDepartment_Click);
            // 
            // btnRemoveDepartment
            // 
            this.btnRemoveDepartment.Location = new System.Drawing.Point(857, 220);
            this.btnRemoveDepartment.Name = "btnRemoveDepartment";
            this.btnRemoveDepartment.Size = new System.Drawing.Size(222, 29);
            this.btnRemoveDepartment.TabIndex = 6;
            this.btnRemoveDepartment.Text = "Remove Department\r\n";
            this.btnRemoveDepartment.UseVisualStyleBackColor = true;
            this.btnRemoveDepartment.Click += new System.EventHandler(this.btnRemoveDepartment_Click);
            // 
            // btnAddDepartment
            // 
            this.btnAddDepartment.Location = new System.Drawing.Point(857, 185);
            this.btnAddDepartment.Name = "btnAddDepartment";
            this.btnAddDepartment.Size = new System.Drawing.Size(222, 29);
            this.btnAddDepartment.TabIndex = 5;
            this.btnAddDepartment.Text = "Add Department";
            this.btnAddDepartment.UseVisualStyleBackColor = true;
            this.btnAddDepartment.Click += new System.EventHandler(this.btnAddDepartment_Click);
            // 
            // btnStatistics
            // 
            this.btnStatistics.Location = new System.Drawing.Point(20, 656);
            this.btnStatistics.Name = "btnStatistics";
            this.btnStatistics.Size = new System.Drawing.Size(213, 37);
            this.btnStatistics.TabIndex = 12;
            this.btnStatistics.Text = "View statistics";
            this.btnStatistics.UseVisualStyleBackColor = true;
            this.btnStatistics.Click += new System.EventHandler(this.btnStatistics_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 761);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "HR Manager Form";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartments)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSearchByID;
        private System.Windows.Forms.TextBox tbSearch;

        private System.Windows.Forms.Button btnUpdateInfo;
        private System.Windows.Forms.Button btnTerminate;
        private System.Windows.Forms.Button btnRemoveEmployee;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgvDepartments;

        private System.Windows.Forms.Button btnUpdateDepartment;
        private System.Windows.Forms.Button btnRemoveDepartment;
        private System.Windows.Forms.Button btnAddDepartment;
        private System.Windows.Forms.Button btnClearD;
        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.DataGridView dgvEmployees;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox tbDepartmentName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lDepartmentManager;
        private System.Windows.Forms.ComboBox cbDepartmentManager;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbColumnChoice;
        private System.Windows.Forms.Button btnStatistics;
    }
}

