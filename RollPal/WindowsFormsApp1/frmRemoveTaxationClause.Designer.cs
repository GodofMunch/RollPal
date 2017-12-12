namespace WindowsFormsApp1
{
    partial class frmRemoveTaxationClause
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
            this.btnHome = new System.Windows.Forms.Button();
            this.btnDeRegTax = new System.Windows.Forms.Button();
            this.lblSelectTaxDeactivate = new System.Windows.Forms.Label();
            this.cboDeregTax = new System.Windows.Forms.ComboBox();
            this.lblDeactivateTaxInstruc = new System.Windows.Forms.Label();
            this.grpDeActivateTax = new System.Windows.Forms.GroupBox();
            this.grpDeActivateTax.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(563, 352);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(75, 23);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnDeRegTax
            // 
            this.btnDeRegTax.Location = new System.Drawing.Point(418, 352);
            this.btnDeRegTax.Name = "btnDeRegTax";
            this.btnDeRegTax.Size = new System.Drawing.Size(117, 23);
            this.btnDeRegTax.TabIndex = 1;
            this.btnDeRegTax.Text = "De-Activate Taxation Clause";
            this.btnDeRegTax.UseVisualStyleBackColor = true;
            this.btnDeRegTax.Click += new System.EventHandler(this.btnDeRegTax_Click);
            // 
            // lblSelectTaxDeactivate
            // 
            this.lblSelectTaxDeactivate.AutoSize = true;
            this.lblSelectTaxDeactivate.Location = new System.Drawing.Point(-73, -3);
            this.lblSelectTaxDeactivate.Name = "lblSelectTaxDeactivate";
            this.lblSelectTaxDeactivate.Size = new System.Drawing.Size(35, 13);
            this.lblSelectTaxDeactivate.TabIndex = 2;
            this.lblSelectTaxDeactivate.Text = "label1";
            // 
            // cboDeregTax
            // 
            this.cboDeregTax.FormattingEnabled = true;
            this.cboDeregTax.Items.AddRange(new object[] {
            "U.S.C. Grade A"});
            this.cboDeregTax.Location = new System.Drawing.Point(370, 185);
            this.cboDeregTax.Name = "cboDeregTax";
            this.cboDeregTax.Size = new System.Drawing.Size(121, 21);
            this.cboDeregTax.TabIndex = 3;
            // 
            // lblDeactivateTaxInstruc
            // 
            this.lblDeactivateTaxInstruc.AutoSize = true;
            this.lblDeactivateTaxInstruc.Location = new System.Drawing.Point(152, 188);
            this.lblDeactivateTaxInstruc.Name = "lblDeactivateTaxInstruc";
            this.lblDeactivateTaxInstruc.Size = new System.Drawing.Size(164, 13);
            this.lblDeactivateTaxInstruc.TabIndex = 4;
            this.lblDeactivateTaxInstruc.Text = "Please Select Tax to De-Activate";
            // 
            // grpDeActivateTax
            // 
            this.grpDeActivateTax.Controls.Add(this.btnDeRegTax);
            this.grpDeActivateTax.Controls.Add(this.lblDeactivateTaxInstruc);
            this.grpDeActivateTax.Controls.Add(this.btnHome);
            this.grpDeActivateTax.Controls.Add(this.cboDeregTax);
            this.grpDeActivateTax.Controls.Add(this.lblSelectTaxDeactivate);
            this.grpDeActivateTax.ForeColor = System.Drawing.SystemColors.Highlight;
            this.grpDeActivateTax.Location = new System.Drawing.Point(26, 34);
            this.grpDeActivateTax.Name = "grpDeActivateTax";
            this.grpDeActivateTax.Size = new System.Drawing.Size(685, 414);
            this.grpDeActivateTax.TabIndex = 5;
            this.grpDeActivateTax.TabStop = false;
            this.grpDeActivateTax.Text = "De-Activate Tax";
            // 
            // frmRemoveTaxationClause
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 460);
            this.Controls.Add(this.grpDeActivateTax);
            this.Name = "frmRemoveTaxationClause";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Remove Taxation Clause";
            this.grpDeActivateTax.ResumeLayout(false);
            this.grpDeActivateTax.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnDeRegTax;
        private System.Windows.Forms.Label lblSelectTaxDeactivate;
        private System.Windows.Forms.ComboBox cboDeregTax;
        private System.Windows.Forms.Label lblDeactivateTaxInstruc;
        private System.Windows.Forms.GroupBox grpDeActivateTax;
    }
}