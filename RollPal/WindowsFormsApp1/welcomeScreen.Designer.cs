namespace WindowsFormsApp1
{
    partial class welcomeScreen
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
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.welcomeInstructionLbl = new System.Windows.Forms.Label();
            this.payRollToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taxationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.documentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            // payRollToolStripMenuItem
            // 
            this.payRollToolStripMenuItem.Name = "payRollToolStripMenuItem";
            this.payRollToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.payRollToolStripMenuItem.Text = "Pay Roll";
            // 
            // taxationToolStripMenuItem
            // 
            this.taxationToolStripMenuItem.Name = "taxationToolStripMenuItem";
            this.taxationToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.taxationToolStripMenuItem.Text = "Taxation";
            // 
            // documentsToolStripMenuItem
            // 
            this.documentsToolStripMenuItem.Name = "documentsToolStripMenuItem";
            this.documentsToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.documentsToolStripMenuItem.Text = "Documents";
            // 
            // welcomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 460);
            this.Controls.Add(this.welcomeInstructionLbl);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "welcomeScreen";
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
    }
}