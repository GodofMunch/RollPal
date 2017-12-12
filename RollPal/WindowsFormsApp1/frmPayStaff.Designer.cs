namespace WindowsFormsApp1
{
    partial class frmPayStaff
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
            this.lblPayStaff = new System.Windows.Forms.Label();
            this.txtPeriod = new System.Windows.Forms.TextBox();
            this.lblIs = new System.Windows.Forms.Label();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.lblApprovedBy = new System.Windows.Forms.Label();
            this.txtApprovalBy = new System.Windows.Forms.TextBox();
            this.btnPayStaff = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPayStaff
            // 
            this.lblPayStaff.AutoSize = true;
            this.lblPayStaff.Location = new System.Drawing.Point(145, 215);
            this.lblPayStaff.Name = "lblPayStaff";
            this.lblPayStaff.Size = new System.Drawing.Size(127, 13);
            this.lblPayStaff.TabIndex = 0;
            this.lblPayStaff.Text = "Total Wage Bill for Period";
            this.lblPayStaff.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtPeriod
            // 
            this.txtPeriod.Location = new System.Drawing.Point(306, 212);
            this.txtPeriod.Name = "txtPeriod";
            this.txtPeriod.ReadOnly = true;
            this.txtPeriod.Size = new System.Drawing.Size(100, 20);
            this.txtPeriod.TabIndex = 1;
            this.txtPeriod.Text = "49";
            this.txtPeriod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblIs
            // 
            this.lblIs.AutoSize = true;
            this.lblIs.Location = new System.Drawing.Point(443, 215);
            this.lblIs.Name = "lblIs";
            this.lblIs.Size = new System.Drawing.Size(15, 13);
            this.lblIs.TabIndex = 2;
            this.lblIs.Text = "Is";
            this.lblIs.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Location = new System.Drawing.Point(485, 212);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.ReadOnly = true;
            this.txtTotalAmount.Size = new System.Drawing.Size(100, 20);
            this.txtTotalAmount.TabIndex = 3;
            this.txtTotalAmount.Text = "€6249.98";
            this.txtTotalAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblApprovedBy
            // 
            this.lblApprovedBy.AutoSize = true;
            this.lblApprovedBy.Location = new System.Drawing.Point(226, 139);
            this.lblApprovedBy.Name = "lblApprovedBy";
            this.lblApprovedBy.Size = new System.Drawing.Size(111, 13);
            this.lblApprovedBy.TabIndex = 4;
            this.lblApprovedBy.Text = "Payment Approved by";
            // 
            // txtApprovalBy
            // 
            this.txtApprovalBy.Location = new System.Drawing.Point(376, 139);
            this.txtApprovalBy.Name = "txtApprovalBy";
            this.txtApprovalBy.ReadOnly = true;
            this.txtApprovalBy.Size = new System.Drawing.Size(114, 20);
            this.txtApprovalBy.TabIndex = 5;
            this.txtApprovalBy.Text = "Tony Gahan, Director";
            this.txtApprovalBy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnPayStaff
            // 
            this.btnPayStaff.Location = new System.Drawing.Point(306, 334);
            this.btnPayStaff.Name = "btnPayStaff";
            this.btnPayStaff.Size = new System.Drawing.Size(100, 23);
            this.btnPayStaff.TabIndex = 6;
            this.btnPayStaff.Text = "Pay Staff";
            this.btnPayStaff.UseVisualStyleBackColor = true;
            this.btnPayStaff.Click += new System.EventHandler(this.btnPayStaff_Click);
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(306, 381);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(100, 23);
            this.btnHome.TabIndex = 7;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // frmPayStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 460);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnPayStaff);
            this.Controls.Add(this.txtApprovalBy);
            this.Controls.Add(this.lblApprovedBy);
            this.Controls.Add(this.txtTotalAmount);
            this.Controls.Add(this.lblIs);
            this.Controls.Add(this.txtPeriod);
            this.Controls.Add(this.lblPayStaff);
            this.Name = "frmPayStaff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pay Staff";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPayStaff;
        private System.Windows.Forms.TextBox txtPeriod;
        private System.Windows.Forms.Label lblIs;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.Label lblApprovedBy;
        private System.Windows.Forms.TextBox txtApprovalBy;
        private System.Windows.Forms.Button btnPayStaff;
        private System.Windows.Forms.Button btnHome;
    }
}