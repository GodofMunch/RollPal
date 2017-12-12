namespace WindowsFormsApp1
{
    partial class frmBankingDetails
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
            this.grpBanking = new System.Windows.Forms.GroupBox();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.optStaffId = new System.Windows.Forms.RadioButton();
            this.lblSearchText = new System.Windows.Forms.Label();
            this.txtIBAN = new System.Windows.Forms.TextBox();
            this.grpBanking.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBanking
            // 
            this.grpBanking.Controls.Add(this.txtIBAN);
            this.grpBanking.Controls.Add(this.btnHome);
            this.grpBanking.Controls.Add(this.btnDisplay);
            this.grpBanking.Controls.Add(this.txtSearch);
            this.grpBanking.Controls.Add(this.radioButton2);
            this.grpBanking.Controls.Add(this.optStaffId);
            this.grpBanking.Controls.Add(this.lblSearchText);
            this.grpBanking.ForeColor = System.Drawing.SystemColors.Highlight;
            this.grpBanking.Location = new System.Drawing.Point(70, 54);
            this.grpBanking.Name = "grpBanking";
            this.grpBanking.Size = new System.Drawing.Size(582, 353);
            this.grpBanking.TabIndex = 1;
            this.grpBanking.TabStop = false;
            this.grpBanking.Text = "print p60";
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(471, 285);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(75, 23);
            this.btnHome.TabIndex = 5;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(380, 285);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(75, 23);
            this.btnDisplay.TabIndex = 4;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(45, 99);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(226, 20);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // 
            // txtIBAN
            // 
            this.txtIBAN.Enabled = false;
            this.txtIBAN.Location = new System.Drawing.Point(298, 99);
            this.txtIBAN.Name = "txtIBAN";
            this.txtIBAN.Size = new System.Drawing.Size(157, 20);
            this.txtIBAN.TabIndex = 6;
            this.txtIBAN.Text = "IE678345234DFGERTYT345";
            this.txtIBAN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtIBAN.Visible = false;
            // 
            // frmBankingDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 460);
            this.Controls.Add(this.grpBanking);
            this.Name = "frmBankingDetails";
            this.Text = "frmBankingDetails";
            this.grpBanking.ResumeLayout(false);
            this.grpBanking.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBanking;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton optStaffId;
        private System.Windows.Forms.Label lblSearchText;
        private System.Windows.Forms.TextBox txtIBAN;
    }
}