﻿namespace WindowsFormsApp1
{
    partial class frmQueryPayroll
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
            this.lblSearchInfo = new System.Windows.Forms.Label();
            this.grpSearchBy = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblPeriod = new System.Windows.Forms.Label();
            this.optStaffName = new System.Windows.Forms.RadioButton();
            this.optStaffId = new System.Windows.Forms.RadioButton();
            this.rtxtWageDetails = new System.Windows.Forms.RichTextBox();
            this.txtSearhBar = new System.Windows.Forms.TextBox();
            this.grpSearchBy.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSearchInfo
            // 
            this.lblSearchInfo.AutoSize = true;
            this.lblSearchInfo.Location = new System.Drawing.Point(19, 33);
            this.lblSearchInfo.Name = "lblSearchInfo";
            this.lblSearchInfo.Size = new System.Drawing.Size(56, 13);
            this.lblSearchInfo.TabIndex = 0;
            this.lblSearchInfo.Text = "Search By";
            // 
            // grpSearchBy
            // 
            this.grpSearchBy.Controls.Add(this.comboBox1);
            this.grpSearchBy.Controls.Add(this.lblPeriod);
            this.grpSearchBy.Controls.Add(this.optStaffName);
            this.grpSearchBy.Controls.Add(this.optStaffId);
            this.grpSearchBy.Controls.Add(this.lblSearchInfo);
            this.grpSearchBy.ForeColor = System.Drawing.SystemColors.Highlight;
            this.grpSearchBy.Location = new System.Drawing.Point(53, 37);
            this.grpSearchBy.Name = "grpSearchBy";
            this.grpSearchBy.Size = new System.Drawing.Size(372, 74);
            this.grpSearchBy.TabIndex = 1;
            this.grpSearchBy.TabStop = false;
            this.grpSearchBy.Text = "Search Pay Roll";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(301, 30);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(40, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.Text = "49";
            // 
            // lblPeriod
            // 
            this.lblPeriod.AutoSize = true;
            this.lblPeriod.Location = new System.Drawing.Point(228, 33);
            this.lblPeriod.Name = "lblPeriod";
            this.lblPeriod.Size = new System.Drawing.Size(55, 13);
            this.lblPeriod.TabIndex = 3;
            this.lblPeriod.Text = "For Period";
            // 
            // optStaffName
            // 
            this.optStaffName.AutoSize = true;
            this.optStaffName.Location = new System.Drawing.Point(126, 43);
            this.optStaffName.Name = "optStaffName";
            this.optStaffName.Size = new System.Drawing.Size(53, 17);
            this.optStaffName.TabIndex = 2;
            this.optStaffName.Text = "Name";
            this.optStaffName.UseVisualStyleBackColor = true;
            // 
            // optStaffId
            // 
            this.optStaffId.AutoSize = true;
            this.optStaffId.Checked = true;
            this.optStaffId.Location = new System.Drawing.Point(126, 19);
            this.optStaffId.Name = "optStaffId";
            this.optStaffId.Size = new System.Drawing.Size(59, 17);
            this.optStaffId.TabIndex = 1;
            this.optStaffId.TabStop = true;
            this.optStaffId.Text = "Staff Id";
            this.optStaffId.UseVisualStyleBackColor = true;
            this.optStaffId.CheckedChanged += new System.EventHandler(this.optStaffId_CheckedChanged);
            // 
            // rtxtWageDetails
            // 
            this.rtxtWageDetails.Location = new System.Drawing.Point(53, 205);
            this.rtxtWageDetails.Name = "rtxtWageDetails";
            this.rtxtWageDetails.ReadOnly = true;
            this.rtxtWageDetails.Size = new System.Drawing.Size(442, 99);
            this.rtxtWageDetails.TabIndex = 2;
            this.rtxtWageDetails.Text = "";
            this.rtxtWageDetails.Visible = false;
            this.rtxtWageDetails.TextChanged += new System.EventHandler(this.rtxtWageDetails_TextChanged);
            // 
            // txtSearhBar
            // 
            this.txtSearhBar.Location = new System.Drawing.Point(136, 146);
            this.txtSearhBar.Name = "txtSearhBar";
            this.txtSearhBar.Size = new System.Drawing.Size(132, 20);
            this.txtSearhBar.TabIndex = 3;
            this.txtSearhBar.TextChanged += new System.EventHandler(this.txtSearchBar_TextChanged);
            // 
            // frmQueryPayroll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 460);
            this.Controls.Add(this.txtSearhBar);
            this.Controls.Add(this.rtxtWageDetails);
            this.Controls.Add(this.grpSearchBy);
            this.Name = "frmQueryPayroll";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Query Payroll";
            this.grpSearchBy.ResumeLayout(false);
            this.grpSearchBy.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSearchInfo;
        private System.Windows.Forms.GroupBox grpSearchBy;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblPeriod;
        private System.Windows.Forms.RadioButton optStaffName;
        private System.Windows.Forms.RadioButton optStaffId;
        private System.Windows.Forms.RichTextBox rtxtWageDetails;
        private System.Windows.Forms.TextBox txtSearhBar;
    }
}