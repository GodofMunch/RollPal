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
            this.txtClauseName = new System.Windows.Forms.TextBox();
            this.grpCreateTax = new System.Windows.Forms.GroupBox();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblAmount2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.lblOf = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblSumOrPercent = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpCreateTax.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTaxClause
            // 
            this.lblTaxClause.AutoSize = true;
            this.lblTaxClause.Location = new System.Drawing.Point(57, 67);
            this.lblTaxClause.Name = "lblTaxClause";
            this.lblTaxClause.Size = new System.Drawing.Size(169, 13);
            this.lblTaxClause.TabIndex = 0;
            this.lblTaxClause.Text = "Taxation Clause Name to Create : ";
            this.lblTaxClause.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtClauseName
            // 
            this.txtClauseName.Location = new System.Drawing.Point(232, 64);
            this.txtClauseName.Name = "txtClauseName";
            this.txtClauseName.Size = new System.Drawing.Size(100, 20);
            this.txtClauseName.TabIndex = 1;
            // 
            // grpCreateTax
            // 
            this.grpCreateTax.Controls.Add(this.btnHome);
            this.grpCreateTax.Controls.Add(this.btnConfirm);
            this.grpCreateTax.Controls.Add(this.textBox2);
            this.grpCreateTax.Controls.Add(this.lblAmount2);
            this.grpCreateTax.Controls.Add(this.comboBox2);
            this.grpCreateTax.Controls.Add(this.lblOf);
            this.grpCreateTax.Controls.Add(this.textBox1);
            this.grpCreateTax.Controls.Add(this.lblAmount);
            this.grpCreateTax.Controls.Add(this.lblSumOrPercent);
            this.grpCreateTax.Controls.Add(this.comboBox1);
            this.grpCreateTax.ForeColor = System.Drawing.SystemColors.Highlight;
            this.grpCreateTax.Location = new System.Drawing.Point(65, 115);
            this.grpCreateTax.Name = "grpCreateTax";
            this.grpCreateTax.Size = new System.Drawing.Size(549, 271);
            this.grpCreateTax.TabIndex = 2;
            this.grpCreateTax.TabStop = false;
            this.grpCreateTax.Text = "Taxation Details";
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
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(146, 157);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 20);
            this.textBox2.TabIndex = 7;
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
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Total Wage",
            "Fixed Sum",
            "Percentage"});
            this.comboBox2.Location = new System.Drawing.Point(146, 122);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 5;
            // 
            // lblOf
            // 
            this.lblOf.AutoSize = true;
            this.lblOf.Location = new System.Drawing.Point(25, 125);
            this.lblOf.Name = "lblOf";
            this.lblOf.Size = new System.Drawing.Size(18, 13);
            this.lblOf.TabIndex = 4;
            this.lblOf.Text = "Of";
            this.lblOf.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(146, 89);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 3;
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
            this.lblSumOrPercent.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Fixed Sum",
            "Percentage"});
            this.comboBox1.Location = new System.Drawing.Point(146, 54);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(208, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Due to logistics i have decided to leave this feature out of RollPal";
            // 
            // frmCreateTaxClause
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 460);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpCreateTax);
            this.Controls.Add(this.txtClauseName);
            this.Controls.Add(this.lblTaxClause);
            this.Name = "frmCreateTaxClause";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Taxation Clause";
            this.grpCreateTax.ResumeLayout(false);
            this.grpCreateTax.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTaxClause;
        private System.Windows.Forms.TextBox txtClauseName;
        private System.Windows.Forms.GroupBox grpCreateTax;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label lblOf;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblSumOrPercent;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblAmount2;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
    }
}