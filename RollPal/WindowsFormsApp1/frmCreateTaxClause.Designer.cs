namespace WindowsFormsApp1
{
    partial class frmCreateTaxClause
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
            this.lblTaxClause = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTaxClause
            // 
            this.lblTaxClause.AutoSize = true;
            this.lblTaxClause.Location = new System.Drawing.Point(55, 67);
            this.lblTaxClause.Name = "lblTaxClause";
            this.lblTaxClause.Size = new System.Drawing.Size(123, 13);
            this.lblTaxClause.TabIndex = 0;
            this.lblTaxClause.Text = "Taxation Clause Name : ";
            this.lblTaxClause.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmCreateTaxClause
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 460);
            this.Controls.Add(this.lblTaxClause);
            this.Name = "frmCreateTaxClause";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Taxation Clause";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTaxClause;
    }
}