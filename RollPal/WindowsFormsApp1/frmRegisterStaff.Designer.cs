namespace WindowsFormsApp1
{
    partial class frmRegisterStaff
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
            this.components = new System.ComponentModel.Container();
            this.grpStaffDetails = new System.Windows.Forms.GroupBox();
            this.cboPayGrade = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.grpGender = new System.Windows.Forms.GroupBox();
            this.optGenderFemale = new System.Windows.Forms.RadioButton();
            this.optGenderMale = new System.Windows.Forms.RadioButton();
            this.lblban = new System.Windows.Forms.Label();
            this.txtIban = new System.Windows.Forms.TextBox();
            this.lblChildren = new System.Windows.Forms.Label();
            this.cboChildren = new System.Windows.Forms.ComboBox();
            this.grpMarStatus = new System.Windows.Forms.GroupBox();
            this.optMarried = new System.Windows.Forms.RadioButton();
            this.optSingle = new System.Windows.Forms.RadioButton();
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
            this.txtStaffID = new System.Windows.Forms.TextBox();
            this.btnRegisterStaff = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.epInvalidEntry = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpStaffDetails.SuspendLayout();
            this.grpGender.SuspendLayout();
            this.grpMarStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epInvalidEntry)).BeginInit();
            this.SuspendLayout();
            // 
            // grpStaffDetails
            // 
            this.grpStaffDetails.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.grpStaffDetails.Controls.Add(this.cboPayGrade);
            this.grpStaffDetails.Controls.Add(this.label1);
            this.grpStaffDetails.Controls.Add(this.dtpDOB);
            this.grpStaffDetails.Controls.Add(this.grpGender);
            this.grpStaffDetails.Controls.Add(this.lblban);
            this.grpStaffDetails.Controls.Add(this.txtIban);
            this.grpStaffDetails.Controls.Add(this.lblChildren);
            this.grpStaffDetails.Controls.Add(this.cboChildren);
            this.grpStaffDetails.Controls.Add(this.grpMarStatus);
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
            this.grpStaffDetails.Controls.Add(this.txtStaffID);
            this.grpStaffDetails.ForeColor = System.Drawing.SystemColors.Highlight;
            this.grpStaffDetails.Location = new System.Drawing.Point(48, 77);
            this.grpStaffDetails.Name = "grpStaffDetails";
            this.grpStaffDetails.Size = new System.Drawing.Size(606, 311);
            this.grpStaffDetails.TabIndex = 1;
            this.grpStaffDetails.TabStop = false;
            this.grpStaffDetails.Text = "Staff Details";
            // 
            // cboPayGrade
            // 
            this.cboPayGrade.FormattingEnabled = true;
            this.cboPayGrade.Location = new System.Drawing.Point(417, 260);
            this.cboPayGrade.Name = "cboPayGrade";
            this.cboPayGrade.Size = new System.Drawing.Size(121, 21);
            this.cboPayGrade.TabIndex = 23;
            this.cboPayGrade.SelectedIndexChanged += new System.EventHandler(this.cboPayGrade_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(280, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Starting Hourly Wage :";
            // 
            // dtpDOB
            // 
            this.dtpDOB.CustomFormat = "dd-MMM-yy";
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDOB.Location = new System.Drawing.Point(141, 281);
            this.dtpDOB.MaxDate = new System.DateTime(2018, 2, 27, 0, 0, 0, 0);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(100, 20);
            this.dtpDOB.TabIndex = 8;
            this.dtpDOB.Value = new System.DateTime(2018, 2, 27, 0, 0, 0, 0);
            this.dtpDOB.ValueChanged += new System.EventHandler(this.dtpDOB_ValueChanged);
            // 
            // grpGender
            // 
            this.grpGender.Controls.Add(this.optGenderFemale);
            this.grpGender.Controls.Add(this.optGenderMale);
            this.grpGender.ForeColor = System.Drawing.SystemColors.Highlight;
            this.grpGender.Location = new System.Drawing.Point(338, 125);
            this.grpGender.Name = "grpGender";
            this.grpGender.Size = new System.Drawing.Size(200, 57);
            this.grpGender.TabIndex = 10;
            this.grpGender.TabStop = false;
            this.grpGender.Text = "Gender";
            // 
            // optGenderFemale
            // 
            this.optGenderFemale.AutoSize = true;
            this.optGenderFemale.Location = new System.Drawing.Point(92, 20);
            this.optGenderFemale.Name = "optGenderFemale";
            this.optGenderFemale.Size = new System.Drawing.Size(59, 17);
            this.optGenderFemale.TabIndex = 12;
            this.optGenderFemale.Text = "Female";
            this.optGenderFemale.UseVisualStyleBackColor = true;
            // 
            // optGenderMale
            // 
            this.optGenderMale.AutoSize = true;
            this.optGenderMale.Checked = true;
            this.optGenderMale.Location = new System.Drawing.Point(21, 20);
            this.optGenderMale.Name = "optGenderMale";
            this.optGenderMale.Size = new System.Drawing.Size(48, 17);
            this.optGenderMale.TabIndex = 11;
            this.optGenderMale.TabStop = true;
            this.optGenderMale.Text = "Male";
            this.optGenderMale.UseVisualStyleBackColor = true;
            this.optGenderMale.CheckedChanged += new System.EventHandler(this.optGenderMale_CheckedChanged);
            // 
            // lblban
            // 
            this.lblban.AutoSize = true;
            this.lblban.Location = new System.Drawing.Point(280, 235);
            this.lblban.Name = "lblban";
            this.lblban.Size = new System.Drawing.Size(38, 13);
            this.lblban.TabIndex = 21;
            this.lblban.Text = "IBAN :";
            // 
            // txtIban
            // 
            this.txtIban.Location = new System.Drawing.Point(338, 232);
            this.txtIban.Name = "txtIban";
            this.txtIban.Size = new System.Drawing.Size(200, 20);
            this.txtIban.TabIndex = 12;
            this.txtIban.TextChanged += new System.EventHandler(this.txtIban_TextChanged);
            // 
            // lblChildren
            // 
            this.lblChildren.AutoSize = true;
            this.lblChildren.Location = new System.Drawing.Point(280, 203);
            this.lblChildren.Name = "lblChildren";
            this.lblChildren.Size = new System.Drawing.Size(51, 13);
            this.lblChildren.TabIndex = 19;
            this.lblChildren.Text = "Children :";
            // 
            // cboChildren
            // 
            this.cboChildren.FormattingEnabled = true;
            this.cboChildren.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.cboChildren.Location = new System.Drawing.Point(359, 200);
            this.cboChildren.Name = "cboChildren";
            this.cboChildren.Size = new System.Drawing.Size(38, 21);
            this.cboChildren.TabIndex = 11;
            this.cboChildren.Text = "0";
            this.cboChildren.SelectedIndexChanged += new System.EventHandler(this.cboChildren_SelectedIndexChanged);
            // 
            // grpMarStatus
            // 
            this.grpMarStatus.Controls.Add(this.optMarried);
            this.grpMarStatus.Controls.Add(this.optSingle);
            this.grpMarStatus.ForeColor = System.Drawing.SystemColors.Highlight;
            this.grpMarStatus.Location = new System.Drawing.Point(338, 47);
            this.grpMarStatus.Name = "grpMarStatus";
            this.grpMarStatus.Size = new System.Drawing.Size(200, 57);
            this.grpMarStatus.TabIndex = 9;
            this.grpMarStatus.TabStop = false;
            this.grpMarStatus.Text = "Marital Status";
            // 
            // optMarried
            // 
            this.optMarried.AutoSize = true;
            this.optMarried.Location = new System.Drawing.Point(92, 25);
            this.optMarried.Name = "optMarried";
            this.optMarried.Size = new System.Drawing.Size(60, 17);
            this.optMarried.TabIndex = 10;
            this.optMarried.TabStop = true;
            this.optMarried.Text = "Married";
            this.optMarried.UseVisualStyleBackColor = true;
            this.optMarried.CheckedChanged += new System.EventHandler(this.optMarried_CheckedChanged);
            // 
            // optSingle
            // 
            this.optSingle.AutoSize = true;
            this.optSingle.Checked = true;
            this.optSingle.Location = new System.Drawing.Point(21, 26);
            this.optSingle.Name = "optSingle";
            this.optSingle.Size = new System.Drawing.Size(54, 17);
            this.optSingle.TabIndex = 9;
            this.optSingle.TabStop = true;
            this.optSingle.Text = "Single";
            this.optSingle.UseVisualStyleBackColor = true;
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
            this.txtEircode.Size = new System.Drawing.Size(100, 20);
            this.txtEircode.TabIndex = 7;
            this.txtEircode.TextChanged += new System.EventHandler(this.txtEircode_TextChanged);
            // 
            // txtCounty
            // 
            this.txtCounty.Location = new System.Drawing.Point(141, 229);
            this.txtCounty.Name = "txtCounty";
            this.txtCounty.Size = new System.Drawing.Size(100, 20);
            this.txtCounty.TabIndex = 6;
            this.txtCounty.TextChanged += new System.EventHandler(this.txtCounty_TextChanged);
            // 
            // txtTown
            // 
            this.txtTown.Location = new System.Drawing.Point(141, 203);
            this.txtTown.Name = "txtTown";
            this.txtTown.Size = new System.Drawing.Size(100, 20);
            this.txtTown.TabIndex = 5;
            this.txtTown.TextChanged += new System.EventHandler(this.txtTown_TextChanged);
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(141, 177);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(100, 20);
            this.txtStreet.TabIndex = 4;
            this.txtStreet.TextChanged += new System.EventHandler(this.txtStreet_TextChanged);
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
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 3;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(141, 125);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(100, 20);
            this.txtPhone.TabIndex = 2;
            this.txtPhone.TextChanged += new System.EventHandler(this.txtPhone_TextChanged);
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(141, 99);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(100, 20);
            this.txtSurname.TabIndex = 1;
            this.txtSurname.TextChanged += new System.EventHandler(this.txtSurname_TextChanged);
            // 
            // txtForename
            // 
            this.txtForename.Location = new System.Drawing.Point(141, 73);
            this.txtForename.Name = "txtForename";
            this.txtForename.Size = new System.Drawing.Size(100, 20);
            this.txtForename.TabIndex = 0;
            this.txtForename.TextChanged += new System.EventHandler(this.txtForename_TextChanged);
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
            // txtStaffID
            // 
            this.txtStaffID.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtStaffID.Enabled = false;
            this.txtStaffID.Location = new System.Drawing.Point(141, 47);
            this.txtStaffID.Name = "txtStaffID";
            this.txtStaffID.ReadOnly = true;
            this.txtStaffID.Size = new System.Drawing.Size(100, 20);
            this.txtStaffID.TabIndex = 1;
            this.txtStaffID.TabStop = false;
            this.txtStaffID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnRegisterStaff
            // 
            this.btnRegisterStaff.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRegisterStaff.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnRegisterStaff.Location = new System.Drawing.Point(478, 404);
            this.btnRegisterStaff.Name = "btnRegisterStaff";
            this.btnRegisterStaff.Size = new System.Drawing.Size(75, 23);
            this.btnRegisterStaff.TabIndex = 13;
            this.btnRegisterStaff.Text = "Register";
            this.btnRegisterStaff.UseVisualStyleBackColor = false;
            this.btnRegisterStaff.Click += new System.EventHandler(this.btnRegisterStaff_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(56, 42);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(199, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Please enter the new Employee\'s details.";
            // 
            // epInvalidEntry
            // 
            this.epInvalidEntry.ContainerControl = this;
            // 
            // frmRegisterStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 460);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.grpStaffDetails);
            this.Controls.Add(this.btnRegisterStaff);
            this.Name = "frmRegisterStaff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register Staff";
            this.Load += new System.EventHandler(this.registerStaff_Load);
            this.grpStaffDetails.ResumeLayout(false);
            this.grpStaffDetails.PerformLayout();
            this.grpGender.ResumeLayout(false);
            this.grpGender.PerformLayout();
            this.grpMarStatus.ResumeLayout(false);
            this.grpMarStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epInvalidEntry)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox grpStaffDetails;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblForename;
        private System.Windows.Forms.Label lblStaffId;
        private System.Windows.Forms.TextBox txtStaffID;
        private System.Windows.Forms.Label lblEircode;
        private System.Windows.Forms.Label lblCounty;
        private System.Windows.Forms.Label lblTown;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtForename;
        private System.Windows.Forms.TextBox txtEircode;
        private System.Windows.Forms.TextBox txtCounty;
        private System.Windows.Forms.TextBox txtTown;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox grpMarStatus;
        private System.Windows.Forms.RadioButton optMarried;
        private System.Windows.Forms.RadioButton optSingle;
        private System.Windows.Forms.Label lblChildren;
        private System.Windows.Forms.ComboBox cboChildren;
        private System.Windows.Forms.Button btnRegisterStaff;
        private System.Windows.Forms.Label lblban;
        private System.Windows.Forms.TextBox txtIban;
        private System.Windows.Forms.GroupBox grpGender;
        private System.Windows.Forms.RadioButton optGenderFemale;
        private System.Windows.Forms.RadioButton optGenderMale;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.ErrorProvider epInvalidEntry;
        private System.Windows.Forms.ComboBox cboPayGrade;
        private System.Windows.Forms.Label label1;
    }
}