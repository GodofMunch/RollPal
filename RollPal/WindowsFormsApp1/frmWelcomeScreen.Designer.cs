namespace WindowsFormsApp1
{
    partial class frmWelcomeScreen
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.staffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerStaffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateStaffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deRegisterStaffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchStaffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.payRollToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enterTimesheetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generatePayrollToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.payStaffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.queryPayRollToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taxationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createTaxationClauseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateTaxationClauseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.documentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.welcomeInstructionLbl = new System.Windows.Forms.Label();
            this.removeTaxationClauseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printP60ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bankingDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.staffToolStripMenuItem,
            this.payRollToolStripMenuItem,
            this.taxationToolStripMenuItem,
            this.documentsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(707, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // staffToolStripMenuItem
            // 
            this.staffToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registerStaffToolStripMenuItem,
            this.updateStaffToolStripMenuItem,
            this.deRegisterStaffToolStripMenuItem,
            this.searchStaffToolStripMenuItem});
            this.staffToolStripMenuItem.Name = "staffToolStripMenuItem";
            this.staffToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.staffToolStripMenuItem.Text = "Staff";
            // 
            // registerStaffToolStripMenuItem
            // 
            this.registerStaffToolStripMenuItem.Name = "registerStaffToolStripMenuItem";
            this.registerStaffToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.registerStaffToolStripMenuItem.Text = "Register Staff";
            this.registerStaffToolStripMenuItem.Click += new System.EventHandler(this.registerStaffToolStripMenuItem_Click);
            // 
            // updateStaffToolStripMenuItem
            // 
            this.updateStaffToolStripMenuItem.Name = "updateStaffToolStripMenuItem";
            this.updateStaffToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.updateStaffToolStripMenuItem.Text = "Update Staff";
            this.updateStaffToolStripMenuItem.Click += new System.EventHandler(this.updateStaffToolStripMenuItem_Click);
            // 
            // deRegisterStaffToolStripMenuItem
            // 
            this.deRegisterStaffToolStripMenuItem.Name = "deRegisterStaffToolStripMenuItem";
            this.deRegisterStaffToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.deRegisterStaffToolStripMenuItem.Text = "De-Register Staff";
            this.deRegisterStaffToolStripMenuItem.Click += new System.EventHandler(this.deRegisterStaffToolStripMenuItem_Click);
            // 
            // searchStaffToolStripMenuItem
            // 
            this.searchStaffToolStripMenuItem.Name = "searchStaffToolStripMenuItem";
            this.searchStaffToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.searchStaffToolStripMenuItem.Text = "Search Staff";
            this.searchStaffToolStripMenuItem.Click += new System.EventHandler(this.searchStaffToolStripMenuItem_Click);
            // 
            // payRollToolStripMenuItem
            // 
            this.payRollToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enterTimesheetToolStripMenuItem,
            this.generatePayrollToolStripMenuItem,
            this.payStaffToolStripMenuItem,
            this.queryPayRollToolStripMenuItem});
            this.payRollToolStripMenuItem.Name = "payRollToolStripMenuItem";
            this.payRollToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.payRollToolStripMenuItem.Text = "Pay Roll";
            // 
            // enterTimesheetToolStripMenuItem
            // 
            this.enterTimesheetToolStripMenuItem.Name = "enterTimesheetToolStripMenuItem";
            this.enterTimesheetToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.enterTimesheetToolStripMenuItem.Text = "Enter Timesheet";
            this.enterTimesheetToolStripMenuItem.Click += new System.EventHandler(this.enterTimesheetToolStripMenuItem_Click);
            // 
            // generatePayrollToolStripMenuItem
            // 
            this.generatePayrollToolStripMenuItem.Name = "generatePayrollToolStripMenuItem";
            this.generatePayrollToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.generatePayrollToolStripMenuItem.Text = "Generate Payroll";
            this.generatePayrollToolStripMenuItem.Click += new System.EventHandler(this.generatePayrollToolStripMenuItem_Click);
            // 
            // payStaffToolStripMenuItem
            // 
            this.payStaffToolStripMenuItem.Name = "payStaffToolStripMenuItem";
            this.payStaffToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.payStaffToolStripMenuItem.Text = "PayStaff";
            this.payStaffToolStripMenuItem.Click += new System.EventHandler(this.payStaffToolStripMenuItem_Click);
            // 
            // queryPayRollToolStripMenuItem
            // 
            this.queryPayRollToolStripMenuItem.Name = "queryPayRollToolStripMenuItem";
            this.queryPayRollToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.queryPayRollToolStripMenuItem.Text = "Query Pay Roll";
            this.queryPayRollToolStripMenuItem.Click += new System.EventHandler(this.queryPayRollToolStripMenuItem_Click);
            // 
            // taxationToolStripMenuItem
            // 
            this.taxationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createTaxationClauseToolStripMenuItem,
            this.updateTaxationClauseToolStripMenuItem,
            this.removeTaxationClauseToolStripMenuItem});
            this.taxationToolStripMenuItem.Name = "taxationToolStripMenuItem";
            this.taxationToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.taxationToolStripMenuItem.Text = "Taxation";
            // 
            // createTaxationClauseToolStripMenuItem
            // 
            this.createTaxationClauseToolStripMenuItem.Name = "createTaxationClauseToolStripMenuItem";
            this.createTaxationClauseToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.createTaxationClauseToolStripMenuItem.Text = "Create Taxation Clause";
            this.createTaxationClauseToolStripMenuItem.Click += new System.EventHandler(this.createTaxationClauseToolStripMenuItem_Click);
            // 
            // updateTaxationClauseToolStripMenuItem
            // 
            this.updateTaxationClauseToolStripMenuItem.Name = "updateTaxationClauseToolStripMenuItem";
            this.updateTaxationClauseToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.updateTaxationClauseToolStripMenuItem.Text = "Update Taxation Clause";
            this.updateTaxationClauseToolStripMenuItem.Click += new System.EventHandler(this.updateTaxationClauseToolStripMenuItem_Click);
            // 
            // documentsToolStripMenuItem
            // 
            this.documentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printP60ToolStripMenuItem,
            this.bankingDetailsToolStripMenuItem});
            this.documentsToolStripMenuItem.Name = "documentsToolStripMenuItem";
            this.documentsToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.documentsToolStripMenuItem.Text = "Documents";
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Location = new System.Drawing.Point(57, 72);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(103, 13);
            this.welcomeLabel.TabIndex = 1;
            this.welcomeLabel.Text = "Welcome Catherine.";
            // 
            // welcomeInstructionLbl
            // 
            this.welcomeInstructionLbl.AutoSize = true;
            this.welcomeInstructionLbl.Location = new System.Drawing.Point(95, 109);
            this.welcomeInstructionLbl.Name = "welcomeInstructionLbl";
            this.welcomeInstructionLbl.Size = new System.Drawing.Size(266, 13);
            this.welcomeInstructionLbl.TabIndex = 2;
            this.welcomeInstructionLbl.Text = "To Begin Please select an option from the menu above";
            // 
            // removeTaxationClauseToolStripMenuItem
            // 
            this.removeTaxationClauseToolStripMenuItem.Name = "removeTaxationClauseToolStripMenuItem";
            this.removeTaxationClauseToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.removeTaxationClauseToolStripMenuItem.Text = "Remove Taxation Clause";
            this.removeTaxationClauseToolStripMenuItem.Click += new System.EventHandler(this.removeTaxationClauseToolStripMenuItem_Click);
            // 
            // printP60ToolStripMenuItem
            // 
            this.printP60ToolStripMenuItem.Name = "printP60ToolStripMenuItem";
            this.printP60ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.printP60ToolStripMenuItem.Text = "Print p60";
            this.printP60ToolStripMenuItem.Click += new System.EventHandler(this.printP60ToolStripMenuItem_Click);
            // 
            // bankingDetailsToolStripMenuItem
            // 
            this.bankingDetailsToolStripMenuItem.Name = "bankingDetailsToolStripMenuItem";
            this.bankingDetailsToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.bankingDetailsToolStripMenuItem.Text = "Banking Details";
            this.bankingDetailsToolStripMenuItem.Click += new System.EventHandler(this.bankingDetailsToolStripMenuItem_Click);
            // 
            // frmWelcomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 460);
            this.Controls.Add(this.welcomeInstructionLbl);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmWelcomeScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem staffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerStaffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateStaffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deRegisterStaffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchStaffToolStripMenuItem;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Label welcomeInstructionLbl;
        private System.Windows.Forms.ToolStripMenuItem payRollToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem taxationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem documentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enterTimesheetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generatePayrollToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem payStaffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem queryPayRollToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createTaxationClauseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateTaxationClauseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeTaxationClauseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printP60ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bankingDetailsToolStripMenuItem;
    }
}