namespace WindowsFormsApp1
{
    partial class frmPrintP60
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
            this.grpP60 = new System.Windows.Forms.GroupBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.optStaffId = new System.Windows.Forms.RadioButton();
            this.lblSearchText = new System.Windows.Forms.Label();
            this.btnPrintP60 = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.grpP60.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpP60
            // 
            this.grpP60.Controls.Add(this.btnHome);
            this.grpP60.Controls.Add(this.btnPrintP60);
            this.grpP60.Controls.Add(this.txtSearch);
            this.grpP60.Controls.Add(this.radioButton2);
            this.grpP60.Controls.Add(this.optStaffId);
            this.grpP60.Controls.Add(this.lblSearchText);
            this.grpP60.ForeColor = System.Drawing.SystemColors.Highlight;
            this.grpP60.Location = new System.Drawing.Point(38, 63);
            this.grpP60.Name = "grpP60";
            this.grpP60.Size = new System.Drawing.Size(582, 353);
            this.grpP60.TabIndex = 0;
            this.grpP60.TabStop = false;
            this.grpP60.Text = "print p60";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(45, 99);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(226, 20);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(218, 56);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(53, 17);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.Text = "Name";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // optStaffId
            // 
            this.optStaffId.AutoSize = true;
            this.optStaffId.Checked = true;
            this.optStaffId.Location = new System.Drawing.Point(127, 56);
            this.optStaffId.Name = "optStaffId";
            this.optStaffId.Size = new System.Drawing.Size(59, 17);
            this.optStaffId.TabIndex = 1;
            this.optStaffId.TabStop = true;
            this.optStaffId.Text = "Staff Id";
            this.optStaffId.UseVisualStyleBackColor = true;
            // 
            // lblSearchText
            // 
            this.lblSearchText.AutoSize = true;
            this.lblSearchText.Location = new System.Drawing.Point(42, 58);
            this.lblSearchText.Name = "lblSearchText";
            this.lblSearchText.Size = new System.Drawing.Size(61, 13);
            this.lblSearchText.TabIndex = 0;
            this.lblSearchText.Text = "Search by :";
            this.lblSearchText.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnPrintP60
            // 
            this.btnPrintP60.Location = new System.Drawing.Point(380, 285);
            this.btnPrintP60.Name = "btnPrintP60";
            this.btnPrintP60.Size = new System.Drawing.Size(75, 23);
            this.btnPrintP60.TabIndex = 4;
            this.btnPrintP60.Text = "Print";
            this.btnPrintP60.UseVisualStyleBackColor = true;
            this.btnPrintP60.Click += new System.EventHandler(this.btnPrintP60_Click);
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(471, 285);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(75, 23);
            this.btnHome.TabIndex = 5;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // frmPrintP60
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 460);
            this.Controls.Add(this.grpP60);
            this.Name = "frmPrintP60";
            this.Text = "frmPrintP60";
            this.grpP60.ResumeLayout(false);
            this.grpP60.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpP60;
        private System.Windows.Forms.Label lblSearchText;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton optStaffId;
        private System.Windows.Forms.Button btnPrintP60;
        private System.Windows.Forms.Button btnHome;
    }
}