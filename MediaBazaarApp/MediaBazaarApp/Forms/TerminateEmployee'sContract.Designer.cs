﻿
namespace MediaBazaarApp
{
    partial class TerminateEmployee_sContract
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
            this.dtpLastWorkingDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.rtbReason = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnTerminate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtpLastWorkingDate
            // 
            this.dtpLastWorkingDate.Location = new System.Drawing.Point(167, 57);
            this.dtpLastWorkingDate.Name = "dtpLastWorkingDate";
            this.dtpLastWorkingDate.Size = new System.Drawing.Size(250, 27);
            this.dtpLastWorkingDate.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Last working Date:";
            // 
            // rtbReason
            // 
            this.rtbReason.Location = new System.Drawing.Point(88, 148);
            this.rtbReason.Name = "rtbReason";
            this.rtbReason.Size = new System.Drawing.Size(335, 196);
            this.rtbReason.TabIndex = 2;
            this.rtbReason.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(220, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Reason";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(181, 403);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(128, 29);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnTerminate
            // 
            this.btnTerminate.Location = new System.Drawing.Point(181, 368);
            this.btnTerminate.Name = "btnTerminate";
            this.btnTerminate.Size = new System.Drawing.Size(128, 29);
            this.btnTerminate.TabIndex = 11;
            this.btnTerminate.Text = "Done";
            this.btnTerminate.UseVisualStyleBackColor = true;
            // 
            // TerminateEmployee_sContract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnTerminate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rtbReason);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpLastWorkingDate);
            this.Name = "TerminateEmployee_sContract";
            this.Text = "Terminate Employee_s Contract";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpLastWorkingDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtbReason;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnTerminate;
    }
}