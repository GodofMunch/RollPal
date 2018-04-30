namespace WindowsFormsApp1
{
    partial class frmGeneratePayRoll
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
            this.rtxtWageDetails = new System.Windows.Forms.RichTextBox();
            this.lblPeriodNo = new System.Windows.Forms.Label();
            this.txtPeriod = new System.Windows.Forms.TextBox();
            this.btnGenWages = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtxtWageDetails
            // 
            this.rtxtWageDetails.Location = new System.Drawing.Point(39, 82);
            this.rtxtWageDetails.Name = "rtxtWageDetails";
            this.rtxtWageDetails.ReadOnly = true;
            this.rtxtWageDetails.Size = new System.Drawing.Size(442, 312);
            this.rtxtWageDetails.TabIndex = 0;
            this.rtxtWageDetails.Text = "";
            // 
            // lblPeriodNo
            // 
            this.lblPeriodNo.AutoSize = true;
            this.lblPeriodNo.Location = new System.Drawing.Point(39, 36);
            this.lblPeriodNo.Name = "lblPeriodNo";
            this.lblPeriodNo.Size = new System.Drawing.Size(43, 13);
            this.lblPeriodNo.TabIndex = 1;
            this.lblPeriodNo.Text = "Period :";
            // 
            // txtPeriod
            // 
            this.txtPeriod.Location = new System.Drawing.Point(107, 36);
            this.txtPeriod.Name = "txtPeriod";
            this.txtPeriod.ReadOnly = true;
            this.txtPeriod.Size = new System.Drawing.Size(100, 20);
            this.txtPeriod.TabIndex = 2;
            this.txtPeriod.Text = "49";
            this.txtPeriod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnGenWages
            // 
            this.btnGenWages.Location = new System.Drawing.Point(553, 329);
            this.btnGenWages.Name = "btnGenWages";
            this.btnGenWages.Size = new System.Drawing.Size(110, 23);
            this.btnGenWages.TabIndex = 3;
            this.btnGenWages.Text = "Generate Wages";
            this.btnGenWages.UseVisualStyleBackColor = true;
            this.btnGenWages.Click += new System.EventHandler(this.btnGenWages_Click);
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(553, 371);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(110, 23);
            this.btnHome.TabIndex = 4;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // frmGeneratePayRoll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 460);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnGenWages);
            this.Controls.Add(this.txtPeriod);
            this.Controls.Add(this.lblPeriodNo);
            this.Controls.Add(this.rtxtWageDetails);
            this.Name = "frmGeneratePayRoll";
            this.Text = "Generate Pay Roll";
            this.Load += new System.EventHandler(this.frmGeneratePayRoll_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxtWageDetails;
        private System.Windows.Forms.Label lblPeriodNo;
        private System.Windows.Forms.TextBox txtPeriod;
        private System.Windows.Forms.Button btnGenWages;
        private System.Windows.Forms.Button btnHome;
    }
}