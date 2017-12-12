namespace WindowsFormsApp1
{
    partial class deRegisterStaff
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
            this.cboSelectStaff = new System.Windows.Forms.ComboBox();
            this.lblDeRegStaff = new System.Windows.Forms.Label();
            this.grpStaffDetails = new System.Windows.Forms.GroupBox();
            this.textChildren = new System.Windows.Forms.TextBox();
            this.btnRegisterStaff = new System.Windows.Forms.Button();
            this.lblChildren = new System.Windows.Forms.Label();
            this.grpMarStatus = new System.Windows.Forms.GroupBox();
            this.optMarried = new System.Windows.Forms.RadioButton();
            this.optSingle = new System.Windows.Forms.RadioButton();
            this.txtDOB = new System.Windows.Forms.TextBox();
            this.lblDOB = new System.Windows.Forms.Label();
            this.txtEircode = new System.Windows.Forms.TextBox();
            this.txtCounty = new System.Windows.Forms.TextBox();
            this.txtTown = new System.Windows.Forms.TextBox();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.lblEircode = new System.Windows.Forms.Label();
            this.lblCounty = new System.Windows.Forms.Label();
            this.lblTown = new System.Windows.Forms.Label();
            this.lblStreet = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtForename = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblForename = new System.Windows.Forms.Label();
            this.lblStaffId = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnHome = new System.Windows.Forms.Button();
            this.grpStaffDetails.SuspendLayout();
            this.grpMarStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboSelectStaff
            // 
            this.cboSelectStaff.FormattingEnabled = true;
            this.cboSelectStaff.Items.AddRange(new object[] {
            "<null>",
            "001"});
            this.cboSelectStaff.Location = new System.Drawing.Point(362, 41);
            this.cboSelectStaff.MaxDropDownItems = 2;
            this.cboSelectStaff.Name = "cboSelectStaff";
            this.cboSelectStaff.Size = new System.Drawing.Size(58, 21);
            this.cboSelectStaff.TabIndex = 4;
            this.cboSelectStaff.Text = "<null>";
            this.cboSelectStaff.SelectedIndexChanged += new System.EventHandler(this.cboSelectStaff_SelectedIndexChanged);
            // 
            // lblDeRegStaff
            // 
            this.lblDeRegStaff.AutoSize = true;
            this.lblDeRegStaff.Location = new System.Drawing.Point(57, 44);
            this.lblDeRegStaff.Name = "lblDeRegStaff";
            this.lblDeRegStaff.Size = new System.Drawing.Size(272, 13);
            this.lblDeRegStaff.TabIndex = 6;
            this.lblDeRegStaff.Text = "Please select the Emplyee you would like to De-Register";
            // 
            // grpStaffDetails
            // 
            this.grpStaffDetails.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.grpStaffDetails.Controls.Add(this.btnHome);
            this.grpStaffDetails.Controls.Add(this.textChildren);
            this.grpStaffDetails.Controls.Add(this.btnRegisterStaff);
            this.grpStaffDetails.Controls.Add(this.lblChildren);
            this.grpStaffDetails.Controls.Add(this.grpMarStatus);
            this.grpStaffDetails.Controls.Add(this.txtDOB);
            this.grpStaffDetails.Controls.Add(this.lblDOB);
            this.grpStaffDetails.Controls.Add(this.txtEircode);
            this.grpStaffDetails.Controls.Add(this.txtCounty);
            this.grpStaffDetails.Controls.Add(this.txtTown);
            this.grpStaffDetails.Controls.Add(this.txtStreet);
            this.grpStaffDetails.Controls.Add(this.lblEircode);
            this.grpStaffDetails.Controls.Add(this.lblCounty);
            this.grpStaffDetails.Controls.Add(this.lblTown);
            this.grpStaffDetails.Controls.Add(this.lblStreet);
            this.grpStaffDetails.Controls.Add(this.txtEmail);
            this.grpStaffDetails.Controls.Add(this.txtPhone);
            this.grpStaffDetails.Controls.Add(this.txtSurname);
            this.grpStaffDetails.Controls.Add(this.txtForename);
            this.grpStaffDetails.Controls.Add(this.lblEmail);
            this.grpStaffDetails.Controls.Add(this.lblPhone);
            this.grpStaffDetails.Controls.Add(this.lblSurname);
            this.grpStaffDetails.Controls.Add(this.lblForename);
            this.grpStaffDetails.Controls.Add(this.lblStaffId);
            this.grpStaffDetails.Controls.Add(this.textBox1);
            this.grpStaffDetails.ForeColor = System.Drawing.SystemColors.Highlight;
            this.grpStaffDetails.Location = new System.Drawing.Point(60, 109);
            this.grpStaffDetails.Name = "grpStaffDetails";
            this.grpStaffDetails.Size = new System.Drawing.Size(606, 311);
            this.grpStaffDetails.TabIndex = 5;
            this.grpStaffDetails.TabStop = false;
            this.grpStaffDetails.Text = "Staff Details";
            this.grpStaffDetails.Visible = false;
            // 
            // textChildren
            // 
            this.textChildren.Location = new System.Drawing.Point(419, 146);
            this.textChildren.Name = "textChildren";
            this.textChildren.ReadOnly = true;
            this.textChildren.Size = new System.Drawing.Size(30, 20);
            this.textChildren.TabIndex = 20;
            this.textChildren.Text = "0";
            this.textChildren.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnRegisterStaff
            // 
            this.btnRegisterStaff.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRegisterStaff.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnRegisterStaff.Location = new System.Drawing.Point(431, 274);
            this.btnRegisterStaff.Name = "btnRegisterStaff";
            this.btnRegisterStaff.Size = new System.Drawing.Size(75, 23);
            this.btnRegisterStaff.TabIndex = 12;
            this.btnRegisterStaff.Text = "De-Register";
            this.btnRegisterStaff.UseVisualStyleBackColor = false;
            this.btnRegisterStaff.Click += new System.EventHandler(this.btnRegisterStaff_Click);
            // 
            // lblChildren
            // 
            this.lblChildren.AutoSize = true;
            this.lblChildren.Location = new System.Drawing.Point(362, 149);
            this.lblChildren.Name = "lblChildren";
            this.lblChildren.Size = new System.Drawing.Size(51, 13);
            this.lblChildren.TabIndex = 19;
            this.lblChildren.Text = "Children :";
            // 
            // grpMarStatus
            // 
            this.grpMarStatus.Controls.Add(this.optMarried);
            this.grpMarStatus.Controls.Add(this.optSingle);
            this.grpMarStatus.ForeColor = System.Drawing.SystemColors.Highlight;
            this.grpMarStatus.Location = new System.Drawing.Point(338, 47);
            this.grpMarStatus.Name = "grpMarStatus";
            this.grpMarStatus.Size = new System.Drawing.Size(200, 57);
            this.grpMarStatus.TabIndex = 17;
            this.grpMarStatus.TabStop = false;
            this.grpMarStatus.Text = "Marital Status";
            // 
            // optMarried
            // 
            this.optMarried.AutoSize = true;
            this.optMarried.Location = new System.Drawing.Point(27, 32);
            this.optMarried.Name = "optMarried";
            this.optMarried.Size = new System.Drawing.Size(60, 17);
            this.optMarried.TabIndex = 9;
            this.optMarried.Text = "Married";
            this.optMarried.UseVisualStyleBackColor = true;
            this.optMarried.Visible = false;
            // 
            // optSingle
            // 
            this.optSingle.AutoSize = true;
            this.optSingle.Checked = true;
            this.optSingle.Location = new System.Drawing.Point(114, 33);
            this.optSingle.Name = "optSingle";
            this.optSingle.Size = new System.Drawing.Size(54, 17);
            this.optSingle.TabIndex = 10;
            this.optSingle.TabStop = true;
            this.optSingle.Text = "Single";
            this.optSingle.UseVisualStyleBackColor = true;
            // 
            // txtDOB
            // 
            this.txtDOB.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtDOB.Location = new System.Drawing.Point(141, 281);
            this.txtDOB.Name = "txtDOB";
            this.txtDOB.ReadOnly = true;
            this.txtDOB.ShortcutsEnabled = false;
            this.txtDOB.Size = new System.Drawing.Size(100, 20);
            this.txtDOB.TabIndex = 8;
            this.txtDOB.Text = "03/01/1990";
            this.txtDOB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Location = new System.Drawing.Point(28, 284);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(42, 13);
            this.lblDOB.TabIndex = 14;
            this.lblDOB.Text = "D.O.B :";
            // 
            // txtEircode
            // 
            this.txtEircode.Location = new System.Drawing.Point(141, 255);
            this.txtEircode.Name = "txtEircode";
            this.txtEircode.ReadOnly = true;
            this.txtEircode.Size = new System.Drawing.Size(100, 20);
            this.txtEircode.TabIndex = 7;
            this.txtEircode.Text = "v92kh92";
            // 
            // txtCounty
            // 
            this.txtCounty.Location = new System.Drawing.Point(141, 229);
            this.txtCounty.Name = "txtCounty";
            this.txtCounty.ReadOnly = true;
            this.txtCounty.Size = new System.Drawing.Size(100, 20);
            this.txtCounty.TabIndex = 6;
            this.txtCounty.Text = "Kerry";
            // 
            // txtTown
            // 
            this.txtTown.Location = new System.Drawing.Point(141, 203);
            this.txtTown.Name = "txtTown";
            this.txtTown.ReadOnly = true;
            this.txtTown.Size = new System.Drawing.Size(100, 20);
            this.txtTown.TabIndex = 5;
            this.txtTown.Text = "Tralee";
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(141, 177);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.ReadOnly = true;
            this.txtStreet.Size = new System.Drawing.Size(100, 20);
            this.txtStreet.TabIndex = 4;
            this.txtStreet.Text = "35 Chapel Street";
            // 
            // lblEircode
            // 
            this.lblEircode.AutoSize = true;
            this.lblEircode.Location = new System.Drawing.Point(28, 258);
            this.lblEircode.Name = "lblEircode";
            this.lblEircode.Size = new System.Drawing.Size(50, 13);
            this.lblEircode.TabIndex = 13;
            this.lblEircode.Text = "EirCode :";
            // 
            // lblCounty
            // 
            this.lblCounty.AutoSize = true;
            this.lblCounty.Location = new System.Drawing.Point(28, 232);
            this.lblCounty.Name = "lblCounty";
            this.lblCounty.Size = new System.Drawing.Size(46, 13);
            this.lblCounty.TabIndex = 12;
            this.lblCounty.Text = "County :";
            // 
            // lblTown
            // 
            this.lblTown.AutoSize = true;
            this.lblTown.Location = new System.Drawing.Point(28, 206);
            this.lblTown.Name = "lblTown";
            this.lblTown.Size = new System.Drawing.Size(40, 13);
            this.lblTown.TabIndex = 11;
            this.lblTown.Text = "Town :";
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Location = new System.Drawing.Point(28, 180);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(41, 13);
            this.lblStreet.TabIndex = 10;
            this.lblStreet.Text = "Street :";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(141, 151);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 3;
            this.txtEmail.Text = "dave@fakemail.com";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(141, 125);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.ReadOnly = true;
            this.txtPhone.Size = new System.Drawing.Size(100, 20);
            this.txtPhone.TabIndex = 2;
            this.txtPhone.Text = "0871234567";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(141, 99);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.ReadOnly = true;
            this.txtSurname.Size = new System.Drawing.Size(100, 20);
            this.txtSurname.TabIndex = 1;
            this.txtSurname.Text = "O\'Sullivan";
            // 
            // txtForename
            // 
            this.txtForename.Location = new System.Drawing.Point(141, 73);
            this.txtForename.Name = "txtForename";
            this.txtForename.ReadOnly = true;
            this.txtForename.Size = new System.Drawing.Size(100, 20);
            this.txtForename.TabIndex = 0;
            this.txtForename.Text = "Dave";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(28, 154);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(38, 13);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "Email :";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(28, 128);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(44, 13);
            this.lblPhone.TabIndex = 4;
            this.lblPhone.Text = "Phone :";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(28, 102);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(55, 13);
            this.lblSurname.TabIndex = 3;
            this.lblSurname.Text = "Surname :";
            // 
            // lblForename
            // 
            this.lblForename.AutoSize = true;
            this.lblForename.Location = new System.Drawing.Point(28, 76);
            this.lblForename.Name = "lblForename";
            this.lblForename.Size = new System.Drawing.Size(60, 13);
            this.lblForename.TabIndex = 2;
            this.lblForename.Text = "Forename :";
            // 
            // lblStaffId
            // 
            this.lblStaffId.AutoSize = true;
            this.lblStaffId.Location = new System.Drawing.Point(28, 50);
            this.lblStaffId.Name = "lblStaffId";
            this.lblStaffId.Size = new System.Drawing.Size(49, 13);
            this.lblStaffId.TabIndex = 1;
            this.lblStaffId.Text = "Staff ID :";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox1.Location = new System.Drawing.Point(141, 47);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "001";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnHome.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnHome.Location = new System.Drawing.Point(512, 274);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(75, 23);
            this.btnHome.TabIndex = 22;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // deRegisterStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 460);
            this.Controls.Add(this.cboSelectStaff);
            this.Controls.Add(this.lblDeRegStaff);
            this.Controls.Add(this.grpStaffDetails);
            this.Name = "deRegisterStaff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "De-RegisterStaff";
            this.grpStaffDetails.ResumeLayout(false);
            this.grpStaffDetails.PerformLayout();
            this.grpMarStatus.ResumeLayout(false);
            this.grpMarStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboSelectStaff;
        private System.Windows.Forms.Label lblDeRegStaff;
        private System.Windows.Forms.GroupBox grpStaffDetails;
        private System.Windows.Forms.Button btnRegisterStaff;
        private System.Windows.Forms.Label lblChildren;
        private System.Windows.Forms.GroupBox grpMarStatus;
        private System.Windows.Forms.RadioButton optMarried;
        private System.Windows.Forms.RadioButton optSingle;
        private System.Windows.Forms.TextBox txtDOB;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.TextBox txtEircode;
        private System.Windows.Forms.TextBox txtCounty;
        private System.Windows.Forms.TextBox txtTown;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.Label lblEircode;
        private System.Windows.Forms.Label lblCounty;
        private System.Windows.Forms.Label lblTown;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtForename;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblForename;
        private System.Windows.Forms.Label lblStaffId;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textChildren;
        private System.Windows.Forms.Button btnHome;
    }
}