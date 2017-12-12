namespace WindowsFormsApp1
{
    partial class frmUpdateTaxClause
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
            this.grpUpdateTax = new System.Windows.Forms.GroupBox();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.txtAmount2 = new System.Windows.Forms.TextBox();
            this.lblAmount2 = new System.Windows.Forms.Label();
            this.cboOf = new System.Windows.Forms.ComboBox();
            this.lblOf = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblSumOrPercent = new System.Windows.Forms.Label();
            this.cboTaxType = new System.Windows.Forms.ComboBox();
            this.lblTaxClause = new System.Windows.Forms.Label();
            this.cboTaxClause = new System.Windows.Forms.ComboBox();
            this.grpUpdateTax.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpUpdateTax
            // 
            this.grpUpdateTax.Controls.Add(this.btnHome);
            this.grpUpdateTax.Controls.Add(this.btnConfirm);
            this.grpUpdateTax.Controls.Add(this.txtAmount2);
            this.grpUpdateTax.Controls.Add(this.lblAmount2);
            this.grpUpdateTax.Controls.Add(this.cboOf);
            this.grpUpdateTax.Controls.Add(this.lblOf);
            this.grpUpdateTax.Controls.Add(this.txtAmount);
            this.grpUpdateTax.Controls.Add(this.lblAmount);
            this.grpUpdateTax.Controls.Add(this.lblSumOrPercent);
            this.grpUpdateTax.Controls.Add(this.cboTaxType);
            this.grpUpdateTax.ForeColor = System.Drawing.SystemColors.Highlight;
            this.grpUpdateTax.Location = new System.Drawing.Point(91, 120);
            this.grpUpdateTax.Name = "grpUpdateTax";
            this.grpUpdateTax.Size = new System.Drawing.Size(549, 271);
            this.grpUpdateTax.TabIndex = 5;
            this.grpUpdateTax.TabStop = false;
            this.grpUpdateTax.Text = "Taxation Details";
            // 
            // btnHome
            // 
            this.btnHome.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnHome.Location = new System.Drawing.Point(396, 242);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(104, 23);
            this.btnHome.TabIndex = 9;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnConfirm.Location = new System.Drawing.Point(396, 208);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(104, 23);
            this.btnConfirm.TabIndex = 8;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // txtAmount2
            // 
            this.txtAmount2.Location = new System.Drawing.Point(146, 157);
            this.txtAmount2.Name = "txtAmount2";
            this.txtAmount2.Size = new System.Drawing.Size(121, 20);
            this.txtAmount2.TabIndex = 7;
            // 
            // lblAmount2
            // 
            this.lblAmount2.AutoSize = true;
            this.lblAmount2.Location = new System.Drawing.Point(25, 160);
            this.lblAmount2.Name = "lblAmount2";
            this.lblAmount2.Size = new System.Drawing.Size(102, 13);
            this.lblAmount2.TabIndex = 6;
            this.lblAmount2.Text = "Amount to be taxed ";
            // 
            // cboOf
            // 
            this.cboOf.FormattingEnabled = true;
            this.cboOf.Items.AddRange(new object[] {
            "Total Wage",
            "Fixed Sum",
            "Percentage"});
            this.cboOf.Location = new System.Drawing.Point(146, 122);
            this.cboOf.Name = "cboOf";
            this.cboOf.Size = new System.Drawing.Size(121, 21);
            this.cboOf.TabIndex = 5;
            // 
            // lblOf
            // 
            this.lblOf.AutoSize = true;
            this.lblOf.Location = new System.Drawing.Point(25, 125);
            this.lblOf.Name = "lblOf";
            this.lblOf.Size = new System.Drawing.Size(18, 13);
            this.lblOf.TabIndex = 4;
            this.lblOf.Text = "Of";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(146, 89);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(121, 20);
            this.txtAmount.TabIndex = 3;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(25, 92);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(43, 13);
            this.lblAmount.TabIndex = 2;
            this.lblAmount.Text = "Amount";
            // 
            // lblSumOrPercent
            // 
            this.lblSumOrPercent.AutoSize = true;
            this.lblSumOrPercent.Location = new System.Drawing.Point(25, 57);
            this.lblSumOrPercent.Name = "lblSumOrPercent";
            this.lblSumOrPercent.Size = new System.Drawing.Size(87, 13);
            this.lblSumOrPercent.TabIndex = 1;
            this.lblSumOrPercent.Text = "Type of Taxation";
            // 
            // cboTaxType
            // 
            this.cboTaxType.FormattingEnabled = true;
            this.cboTaxType.Items.AddRange(new object[] {
            "Fixed Sum",
            "Percentage"});
            this.cboTaxType.Location = new System.Drawing.Point(146, 54);
            this.cboTaxType.Name = "cboTaxType";
            this.cboTaxType.Size = new System.Drawing.Size(121, 21);
            this.cboTaxType.TabIndex = 0;
            this.cboTaxType.SelectedIndexChanged += new System.EventHandler(this.cboTaxType_SelectedIndexChanged);
            // 
            // lblTaxClause
            // 
            this.lblTaxClause.AutoSize = true;
            this.lblTaxClause.Location = new System.Drawing.Point(83, 72);
            this.lblTaxClause.Name = "lblTaxClause";
            this.lblTaxClause.Size = new System.Drawing.Size(173, 13);
            this.lblTaxClause.TabIndex = 3;
            this.lblTaxClause.Text = "Taxation Clause Name to Update : ";
            // 
            // cboTaxClause
            // 
            this.cboTaxClause.FormattingEnabled = true;
            this.cboTaxClause.Items.AddRange(new object[] {
            "U.S.C. Grade A"});
            this.cboTaxClause.Location = new System.Drawing.Point(262, 69);
            this.cboTaxClause.Name = "cboTaxClause";
            this.cboTaxClause.Size = new System.Drawing.Size(121, 21);
            this.cboTaxClause.TabIndex = 0;
            this.cboTaxClause.SelectedIndexChanged += new System.EventHandler(this.cboTaxClause_SelectedIndexChanged);
            // 
            // frmUpdateTaxClause
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 460);
            this.Controls.Add(this.cboTaxClause);
            this.Controls.Add(this.grpUpdateTax);
            this.Controls.Add(this.lblTaxClause);
            this.Name = "frmUpdateTaxClause";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Taxation Clause";
            this.grpUpdateTax.ResumeLayout(false);
            this.grpUpdateTax.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpUpdateTax;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.TextBox txtAmount2;
        private System.Windows.Forms.Label lblAmount2;
        private System.Windows.Forms.ComboBox cboOf;
        private System.Windows.Forms.Label lblOf;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblSumOrPercent;
        private System.Windows.Forms.ComboBox cboTaxType;
        private System.Windows.Forms.Label lblTaxClause;
        private System.Windows.Forms.ComboBox cboTaxClause;
    }
}