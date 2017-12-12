namespace WindowsFormsApp1
{
    partial class generatePayRoll
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnGenWages = new System.Windows.Forms.Button();
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
            this.rtxtWageDetails.TextChanged += new System.EventHandler(this.rtxtWageDetails_TextChanged);
            // 
            // lblPeriodNo
            // 
            this.lblPeriodNo.AutoSize = true;
            this.lblPeriodNo.Location = new System.Drawing.Point(39, 36);
            this.lblPeriodNo.Name = "lblPeriodNo";
            this.lblPeriodNo.Size = new System.Drawing.Size(43, 13);
            this.lblPeriodNo.TabIndex = 1;
            this.lblPeriodNo.Text = "Period :";
            this.lblPeriodNo.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(107, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "49";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // generatePayRoll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 460);
            this.Controls.Add(this.btnGenWages);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblPeriodNo);
            this.Controls.Add(this.rtxtWageDetails);
            this.Name = "generatePayRoll";
            this.Text = "Generate Pay Roll";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxtWageDetails;
        private System.Windows.Forms.Label lblPeriodNo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnGenWages;
    }
}