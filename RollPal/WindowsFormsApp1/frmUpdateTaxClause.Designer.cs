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
            this.grpUsc = new System.Windows.Forms.GroupBox();
            this.lblPercent = new System.Windows.Forms.Label();
            this.lblEuro2 = new System.Windows.Forms.Label();
            this.lblEuro1 = new System.Windows.Forms.Label();
            this.txtLowerLimit = new System.Windows.Forms.TextBox();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.txtUpperLimit = new System.Windows.Forms.TextBox();
            this.lblUpperLimit = new System.Windows.Forms.Label();
            this.lblLowerLimit = new System.Windows.Forms.Label();
            this.txtPercent = new System.Windows.Forms.TextBox();
            this.lblUscPercent = new System.Windows.Forms.Label();
            this.lblUscGrade = new System.Windows.Forms.Label();
            this.cboUscGrade = new System.Windows.Forms.ComboBox();
            this.lblTaxClause = new System.Windows.Forms.Label();
            this.cboTaxClause = new System.Windows.Forms.ComboBox();
            this.grpSiptu = new System.Windows.Forms.GroupBox();
            this.lblWeeklyCost = new System.Windows.Forms.Label();
            this.txtSiptu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpPrsi = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrsi = new System.Windows.Forms.TextBox();
            this.lblPercentage = new System.Windows.Forms.Label();
            this.grpPaye = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cboPayeGrade = new System.Windows.Forms.ComboBox();
            this.txtCutoff = new System.Windows.Forms.TextBox();
            this.txtLowerPercent = new System.Windows.Forms.TextBox();
            this.txtUpperPercent = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.grpUsc.SuspendLayout();
            this.grpSiptu.SuspendLayout();
            this.grpPrsi.SuspendLayout();
            this.grpPaye.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpUsc
            // 
            this.grpUsc.Controls.Add(this.lblPercent);
            this.grpUsc.Controls.Add(this.lblEuro2);
            this.grpUsc.Controls.Add(this.lblEuro1);
            this.grpUsc.Controls.Add(this.txtLowerLimit);
            this.grpUsc.Controls.Add(this.txtUpperLimit);
            this.grpUsc.Controls.Add(this.lblUpperLimit);
            this.grpUsc.Controls.Add(this.lblLowerLimit);
            this.grpUsc.Controls.Add(this.txtPercent);
            this.grpUsc.Controls.Add(this.lblUscPercent);
            this.grpUsc.Controls.Add(this.lblUscGrade);
            this.grpUsc.Controls.Add(this.cboUscGrade);
            this.grpUsc.ForeColor = System.Drawing.SystemColors.Highlight;
            this.grpUsc.Location = new System.Drawing.Point(36, 116);
            this.grpUsc.Name = "grpUsc";
            this.grpUsc.Size = new System.Drawing.Size(298, 271);
            this.grpUsc.TabIndex = 5;
            this.grpUsc.TabStop = false;
            this.grpUsc.Text = "USC Details";
            this.grpUsc.Visible = false;
            // 
            // lblPercent
            // 
            this.lblPercent.AutoSize = true;
            this.lblPercent.Location = new System.Drawing.Point(273, 92);
            this.lblPercent.Name = "lblPercent";
            this.lblPercent.Size = new System.Drawing.Size(15, 13);
            this.lblPercent.TabIndex = 13;
            this.lblPercent.Text = "%";
            // 
            // lblEuro2
            // 
            this.lblEuro2.AutoSize = true;
            this.lblEuro2.Location = new System.Drawing.Point(273, 128);
            this.lblEuro2.Name = "lblEuro2";
            this.lblEuro2.Size = new System.Drawing.Size(13, 13);
            this.lblEuro2.TabIndex = 12;
            this.lblEuro2.Text = "€";
            // 
            // lblEuro1
            // 
            this.lblEuro1.AutoSize = true;
            this.lblEuro1.Location = new System.Drawing.Point(273, 160);
            this.lblEuro1.Name = "lblEuro1";
            this.lblEuro1.Size = new System.Drawing.Size(13, 13);
            this.lblEuro1.TabIndex = 11;
            this.lblEuro1.Text = "€";
            // 
            // txtLowerLimit
            // 
            this.txtLowerLimit.Location = new System.Drawing.Point(146, 125);
            this.txtLowerLimit.Name = "txtLowerLimit";
            this.txtLowerLimit.Size = new System.Drawing.Size(121, 20);
            this.txtLowerLimit.TabIndex = 10;
            // 
            // btnHome
            // 
            this.btnHome.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnHome.Location = new System.Drawing.Point(558, 332);
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
            this.btnConfirm.Location = new System.Drawing.Point(558, 292);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(104, 23);
            this.btnConfirm.TabIndex = 8;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // txtUpperLimit
            // 
            this.txtUpperLimit.Location = new System.Drawing.Point(146, 157);
            this.txtUpperLimit.Name = "txtUpperLimit";
            this.txtUpperLimit.Size = new System.Drawing.Size(121, 20);
            this.txtUpperLimit.TabIndex = 7;
            // 
            // lblUpperLimit
            // 
            this.lblUpperLimit.AutoSize = true;
            this.lblUpperLimit.Location = new System.Drawing.Point(25, 160);
            this.lblUpperLimit.Name = "lblUpperLimit";
            this.lblUpperLimit.Size = new System.Drawing.Size(57, 13);
            this.lblUpperLimit.TabIndex = 6;
            this.lblUpperLimit.Text = "UpperLimit";
            // 
            // lblLowerLimit
            // 
            this.lblLowerLimit.AutoSize = true;
            this.lblLowerLimit.Location = new System.Drawing.Point(25, 125);
            this.lblLowerLimit.Name = "lblLowerLimit";
            this.lblLowerLimit.Size = new System.Drawing.Size(60, 13);
            this.lblLowerLimit.TabIndex = 4;
            this.lblLowerLimit.Text = "Lower Limit";
            // 
            // txtPercent
            // 
            this.txtPercent.Location = new System.Drawing.Point(146, 89);
            this.txtPercent.Name = "txtPercent";
            this.txtPercent.Size = new System.Drawing.Size(121, 20);
            this.txtPercent.TabIndex = 3;
            // 
            // lblUscPercent
            // 
            this.lblUscPercent.AutoSize = true;
            this.lblUscPercent.Location = new System.Drawing.Point(25, 92);
            this.lblUscPercent.Name = "lblUscPercent";
            this.lblUscPercent.Size = new System.Drawing.Size(44, 13);
            this.lblUscPercent.TabIndex = 2;
            this.lblUscPercent.Text = "Percent";
            // 
            // lblUscGrade
            // 
            this.lblUscGrade.AutoSize = true;
            this.lblUscGrade.Location = new System.Drawing.Point(25, 57);
            this.lblUscGrade.Name = "lblUscGrade";
            this.lblUscGrade.Size = new System.Drawing.Size(58, 13);
            this.lblUscGrade.TabIndex = 1;
            this.lblUscGrade.Text = "Usc Grade";
            // 
            // cboUscGrade
            // 
            this.cboUscGrade.FormattingEnabled = true;
            this.cboUscGrade.Location = new System.Drawing.Point(146, 54);
            this.cboUscGrade.Name = "cboUscGrade";
            this.cboUscGrade.Size = new System.Drawing.Size(121, 21);
            this.cboUscGrade.TabIndex = 0;
            this.cboUscGrade.SelectedIndexChanged += new System.EventHandler(this.cboUscGrade_SelectedIndexChanged);
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
            this.cboTaxClause.Location = new System.Drawing.Point(262, 69);
            this.cboTaxClause.Name = "cboTaxClause";
            this.cboTaxClause.Size = new System.Drawing.Size(121, 21);
            this.cboTaxClause.TabIndex = 0;
            this.cboTaxClause.SelectedIndexChanged += new System.EventHandler(this.cboTaxClause_SelectedIndexChanged);
            // 
            // grpSiptu
            // 
            this.grpSiptu.Controls.Add(this.label1);
            this.grpSiptu.Controls.Add(this.txtSiptu);
            this.grpSiptu.Controls.Add(this.lblWeeklyCost);
            this.grpSiptu.ForeColor = System.Drawing.SystemColors.Highlight;
            this.grpSiptu.Location = new System.Drawing.Point(42, 88);
            this.grpSiptu.Name = "grpSiptu";
            this.grpSiptu.Size = new System.Drawing.Size(418, 264);
            this.grpSiptu.TabIndex = 6;
            this.grpSiptu.TabStop = false;
            this.grpSiptu.Text = "Siptu";
            // 
            // lblWeeklyCost
            // 
            this.lblWeeklyCost.AutoSize = true;
            this.lblWeeklyCost.Location = new System.Drawing.Point(43, 60);
            this.lblWeeklyCost.Name = "lblWeeklyCost";
            this.lblWeeklyCost.Size = new System.Drawing.Size(73, 13);
            this.lblWeeklyCost.TabIndex = 0;
            this.lblWeeklyCost.Text = "Weekly Cost :";
            // 
            // txtSiptu
            // 
            this.txtSiptu.Location = new System.Drawing.Point(122, 56);
            this.txtSiptu.Name = "txtSiptu";
            this.txtSiptu.Size = new System.Drawing.Size(100, 20);
            this.txtSiptu.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(228, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "€";
            // 
            // grpPrsi
            // 
            this.grpPrsi.Controls.Add(this.lblPercentage);
            this.grpPrsi.Controls.Add(this.txtPrsi);
            this.grpPrsi.Controls.Add(this.label2);
            this.grpPrsi.ForeColor = System.Drawing.SystemColors.Highlight;
            this.grpPrsi.Location = new System.Drawing.Point(38, 96);
            this.grpPrsi.Name = "grpPrsi";
            this.grpPrsi.Size = new System.Drawing.Size(418, 263);
            this.grpPrsi.TabIndex = 10;
            this.grpPrsi.TabStop = false;
            this.grpPrsi.Text = "Prsi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Percentage";
            // 
            // txtPrsi
            // 
            this.txtPrsi.Location = new System.Drawing.Point(123, 41);
            this.txtPrsi.Name = "txtPrsi";
            this.txtPrsi.Size = new System.Drawing.Size(100, 20);
            this.txtPrsi.TabIndex = 1;
            // 
            // lblPercentage
            // 
            this.lblPercentage.AutoSize = true;
            this.lblPercentage.Location = new System.Drawing.Point(229, 44);
            this.lblPercentage.Name = "lblPercentage";
            this.lblPercentage.Size = new System.Drawing.Size(15, 13);
            this.lblPercentage.TabIndex = 2;
            this.lblPercentage.Text = "%";
            // 
            // grpPaye
            // 
            this.grpPaye.Controls.Add(this.label9);
            this.grpPaye.Controls.Add(this.label8);
            this.grpPaye.Controls.Add(this.label7);
            this.grpPaye.Controls.Add(this.txtUpperPercent);
            this.grpPaye.Controls.Add(this.txtLowerPercent);
            this.grpPaye.Controls.Add(this.txtCutoff);
            this.grpPaye.Controls.Add(this.cboPayeGrade);
            this.grpPaye.Controls.Add(this.label6);
            this.grpPaye.Controls.Add(this.label5);
            this.grpPaye.Controls.Add(this.label4);
            this.grpPaye.Controls.Add(this.label3);
            this.grpPaye.ForeColor = System.Drawing.SystemColors.Highlight;
            this.grpPaye.Location = new System.Drawing.Point(36, 112);
            this.grpPaye.Name = "grpPaye";
            this.grpPaye.Size = new System.Drawing.Size(420, 269);
            this.grpPaye.TabIndex = 11;
            this.grpPaye.TabStop = false;
            this.grpPaye.Text = "Paye";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Grade :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(85, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Cut Off :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Lower Percentage :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Upper Percentage : ";
            // 
            // cboPayeGrade
            // 
            this.cboPayeGrade.FormattingEnabled = true;
            this.cboPayeGrade.Location = new System.Drawing.Point(149, 41);
            this.cboPayeGrade.Name = "cboPayeGrade";
            this.cboPayeGrade.Size = new System.Drawing.Size(121, 21);
            this.cboPayeGrade.TabIndex = 4;
            this.cboPayeGrade.SelectedIndexChanged += new System.EventHandler(this.cboPayeGrade_SelectedIndexChanged);
            // 
            // txtCutoff
            // 
            this.txtCutoff.Location = new System.Drawing.Point(149, 76);
            this.txtCutoff.Name = "txtCutoff";
            this.txtCutoff.Size = new System.Drawing.Size(121, 20);
            this.txtCutoff.TabIndex = 5;
            // 
            // txtLowerPercent
            // 
            this.txtLowerPercent.Location = new System.Drawing.Point(149, 108);
            this.txtLowerPercent.Name = "txtLowerPercent";
            this.txtLowerPercent.Size = new System.Drawing.Size(121, 20);
            this.txtLowerPercent.TabIndex = 6;
            // 
            // txtUpperPercent
            // 
            this.txtUpperPercent.Location = new System.Drawing.Point(149, 143);
            this.txtUpperPercent.Name = "txtUpperPercent";
            this.txtUpperPercent.Size = new System.Drawing.Size(121, 20);
            this.txtUpperPercent.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(276, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "%";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(276, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "%";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(276, 78);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "€";
            // 
            // frmUpdateTaxClause
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 460);
            this.Controls.Add(this.grpPrsi);
            this.Controls.Add(this.grpPaye);
            this.Controls.Add(this.grpSiptu);
            this.Controls.Add(this.cboTaxClause);
            this.Controls.Add(this.grpUsc);
            this.Controls.Add(this.lblTaxClause);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnHome);
            this.Name = "frmUpdateTaxClause";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Taxation Clause";
            this.Load += new System.EventHandler(this.frmUpdateTaxClause_Load);
            this.grpUsc.ResumeLayout(false);
            this.grpUsc.PerformLayout();
            this.grpSiptu.ResumeLayout(false);
            this.grpSiptu.PerformLayout();
            this.grpPrsi.ResumeLayout(false);
            this.grpPrsi.PerformLayout();
            this.grpPaye.ResumeLayout(false);
            this.grpPaye.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpUsc;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.TextBox txtUpperLimit;
        private System.Windows.Forms.Label lblUpperLimit;
        private System.Windows.Forms.Label lblLowerLimit;
        private System.Windows.Forms.TextBox txtPercent;
        private System.Windows.Forms.Label lblUscPercent;
        private System.Windows.Forms.Label lblUscGrade;
        private System.Windows.Forms.ComboBox cboUscGrade;
        private System.Windows.Forms.Label lblTaxClause;
        private System.Windows.Forms.ComboBox cboTaxClause;
        private System.Windows.Forms.Label lblPercent;
        private System.Windows.Forms.Label lblEuro2;
        private System.Windows.Forms.Label lblEuro1;
        private System.Windows.Forms.TextBox txtLowerLimit;
        private System.Windows.Forms.GroupBox grpSiptu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSiptu;
        private System.Windows.Forms.Label lblWeeklyCost;
        private System.Windows.Forms.GroupBox grpPrsi;
        private System.Windows.Forms.Label lblPercentage;
        private System.Windows.Forms.TextBox txtPrsi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpPaye;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtUpperPercent;
        private System.Windows.Forms.TextBox txtLowerPercent;
        private System.Windows.Forms.TextBox txtCutoff;
        private System.Windows.Forms.ComboBox cboPayeGrade;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}