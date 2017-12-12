namespace WindowsFormsApp1
{
    partial class frmEnterTimeSheet
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
            this.lblSearchStaffPrompt = new System.Windows.Forms.Label();
            this.cboTimesheetSelect = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblMonday = new System.Windows.Forms.Label();
            this.lblTuesday = new System.Windows.Forms.Label();
            this.lblWednesday = new System.Windows.Forms.Label();
            this.lblThursday = new System.Windows.Forms.Label();
            this.lblFriday = new System.Windows.Forms.Label();
            this.lblSaturday = new System.Windows.Forms.Label();
            this.lblSunday = new System.Windows.Forms.Label();
            this.txtBeginMon = new System.Windows.Forms.TextBox();
            this.txtBeginTues = new System.Windows.Forms.TextBox();
            this.txtBeginWed = new System.Windows.Forms.TextBox();
            this.txtBeginThurs = new System.Windows.Forms.TextBox();
            this.txtBeginFri = new System.Windows.Forms.TextBox();
            this.txtBeginSat = new System.Windows.Forms.TextBox();
            this.txtBeginSun = new System.Windows.Forms.TextBox();
            this.lblTo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFinMon = new System.Windows.Forms.TextBox();
            this.txtFinTue = new System.Windows.Forms.TextBox();
            this.txtFinWed = new System.Windows.Forms.TextBox();
            this.txtFinThu = new System.Windows.Forms.TextBox();
            this.txtFinFri = new System.Windows.Forms.TextBox();
            this.txtFinSat = new System.Windows.Forms.TextBox();
            this.txtFinSun = new System.Windows.Forms.TextBox();
            this.lblBreak = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtBkMon = new System.Windows.Forms.TextBox();
            this.txtBkTue = new System.Windows.Forms.TextBox();
            this.txtBkWed = new System.Windows.Forms.TextBox();
            this.txtBkThu = new System.Windows.Forms.TextBox();
            this.txtBkFri = new System.Windows.Forms.TextBox();
            this.txtBkSat = new System.Windows.Forms.TextBox();
            this.txtBkSun = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtPeriodNo = new System.Windows.Forms.TextBox();
            this.rtxt = new System.Windows.Forms.RichTextBox();
            this.btnApprove = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.lblToDo = new System.Windows.Forms.Label();
            this.lblStaffName = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSearchStaffPrompt
            // 
            this.lblSearchStaffPrompt.AutoSize = true;
            this.lblSearchStaffPrompt.Location = new System.Drawing.Point(62, 46);
            this.lblSearchStaffPrompt.Name = "lblSearchStaffPrompt";
            this.lblSearchStaffPrompt.Size = new System.Drawing.Size(334, 13);
            this.lblSearchStaffPrompt.TabIndex = 0;
            this.lblSearchStaffPrompt.Text = "Please enter the Employee ID who\'s timesheet you would like to enter";
            // 
            // cboTimesheetSelect
            // 
            this.cboTimesheetSelect.FormattingEnabled = true;
            this.cboTimesheetSelect.Items.AddRange(new object[] {
            "<null>",
            "001",
            "002"});
            this.cboTimesheetSelect.Location = new System.Drawing.Point(417, 43);
            this.cboTimesheetSelect.MaxDropDownItems = 3;
            this.cboTimesheetSelect.Name = "cboTimesheetSelect";
            this.cboTimesheetSelect.Size = new System.Drawing.Size(121, 21);
            this.cboTimesheetSelect.TabIndex = 0;
            this.cboTimesheetSelect.SelectedIndexChanged += new System.EventHandler(this.cboTimesheetSelect_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblStaffName);
            this.groupBox1.Controls.Add(this.txtBkSun);
            this.groupBox1.Controls.Add(this.txtBkSat);
            this.groupBox1.Controls.Add(this.txtBkFri);
            this.groupBox1.Controls.Add(this.txtBkThu);
            this.groupBox1.Controls.Add(this.txtBkWed);
            this.groupBox1.Controls.Add(this.txtBkTue);
            this.groupBox1.Controls.Add(this.txtBkMon);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lblBreak);
            this.groupBox1.Controls.Add(this.txtFinSun);
            this.groupBox1.Controls.Add(this.txtFinSat);
            this.groupBox1.Controls.Add(this.txtFinFri);
            this.groupBox1.Controls.Add(this.txtFinThu);
            this.groupBox1.Controls.Add(this.txtFinWed);
            this.groupBox1.Controls.Add(this.txtFinTue);
            this.groupBox1.Controls.Add(this.txtFinMon);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblTo);
            this.groupBox1.Controls.Add(this.txtBeginSun);
            this.groupBox1.Controls.Add(this.txtBeginSat);
            this.groupBox1.Controls.Add(this.txtBeginFri);
            this.groupBox1.Controls.Add(this.txtBeginThurs);
            this.groupBox1.Controls.Add(this.txtBeginWed);
            this.groupBox1.Controls.Add(this.txtBeginTues);
            this.groupBox1.Controls.Add(this.txtBeginMon);
            this.groupBox1.Controls.Add(this.lblSunday);
            this.groupBox1.Controls.Add(this.lblSaturday);
            this.groupBox1.Controls.Add(this.lblFriday);
            this.groupBox1.Controls.Add(this.lblThursday);
            this.groupBox1.Controls.Add(this.lblWednesday);
            this.groupBox1.Controls.Add(this.lblTuesday);
            this.groupBox1.Controls.Add(this.lblMonday);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox1.Location = new System.Drawing.Point(68, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(469, 289);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Timesheet Details";
            // 
            // lblMonday
            // 
            this.lblMonday.AutoSize = true;
            this.lblMonday.Location = new System.Drawing.Point(37, 50);
            this.lblMonday.Name = "lblMonday";
            this.lblMonday.Size = new System.Drawing.Size(51, 13);
            this.lblMonday.TabIndex = 0;
            this.lblMonday.Text = "Monday :";
            // 
            // lblTuesday
            // 
            this.lblTuesday.AutoSize = true;
            this.lblTuesday.Location = new System.Drawing.Point(37, 76);
            this.lblTuesday.Name = "lblTuesday";
            this.lblTuesday.Size = new System.Drawing.Size(54, 13);
            this.lblTuesday.TabIndex = 1;
            this.lblTuesday.Text = "Tuesday :";
            // 
            // lblWednesday
            // 
            this.lblWednesday.AutoSize = true;
            this.lblWednesday.Location = new System.Drawing.Point(37, 102);
            this.lblWednesday.Name = "lblWednesday";
            this.lblWednesday.Size = new System.Drawing.Size(70, 13);
            this.lblWednesday.TabIndex = 2;
            this.lblWednesday.Text = "Wednesday :";
            // 
            // lblThursday
            // 
            this.lblThursday.AutoSize = true;
            this.lblThursday.Location = new System.Drawing.Point(37, 128);
            this.lblThursday.Name = "lblThursday";
            this.lblThursday.Size = new System.Drawing.Size(57, 13);
            this.lblThursday.TabIndex = 3;
            this.lblThursday.Text = "Thursday :";
            // 
            // lblFriday
            // 
            this.lblFriday.AutoSize = true;
            this.lblFriday.Location = new System.Drawing.Point(37, 154);
            this.lblFriday.Name = "lblFriday";
            this.lblFriday.Size = new System.Drawing.Size(41, 13);
            this.lblFriday.TabIndex = 4;
            this.lblFriday.Text = "Friday :";
            // 
            // lblSaturday
            // 
            this.lblSaturday.AutoSize = true;
            this.lblSaturday.Location = new System.Drawing.Point(37, 180);
            this.lblSaturday.Name = "lblSaturday";
            this.lblSaturday.Size = new System.Drawing.Size(55, 13);
            this.lblSaturday.TabIndex = 5;
            this.lblSaturday.Text = "Saturday :";
            // 
            // lblSunday
            // 
            this.lblSunday.AutoSize = true;
            this.lblSunday.Location = new System.Drawing.Point(37, 205);
            this.lblSunday.Name = "lblSunday";
            this.lblSunday.Size = new System.Drawing.Size(49, 13);
            this.lblSunday.TabIndex = 6;
            this.lblSunday.Text = "Sunday :";
            // 
            // txtBeginMon
            // 
            this.txtBeginMon.Location = new System.Drawing.Point(106, 47);
            this.txtBeginMon.Name = "txtBeginMon";
            this.txtBeginMon.Size = new System.Drawing.Size(69, 20);
            this.txtBeginMon.TabIndex = 1;
            // 
            // txtBeginTues
            // 
            this.txtBeginTues.Location = new System.Drawing.Point(106, 73);
            this.txtBeginTues.Name = "txtBeginTues";
            this.txtBeginTues.Size = new System.Drawing.Size(69, 20);
            this.txtBeginTues.TabIndex = 4;
            // 
            // txtBeginWed
            // 
            this.txtBeginWed.Location = new System.Drawing.Point(106, 99);
            this.txtBeginWed.Name = "txtBeginWed";
            this.txtBeginWed.Size = new System.Drawing.Size(69, 20);
            this.txtBeginWed.TabIndex = 7;
            // 
            // txtBeginThurs
            // 
            this.txtBeginThurs.Location = new System.Drawing.Point(106, 125);
            this.txtBeginThurs.Name = "txtBeginThurs";
            this.txtBeginThurs.Size = new System.Drawing.Size(69, 20);
            this.txtBeginThurs.TabIndex = 10;
            // 
            // txtBeginFri
            // 
            this.txtBeginFri.Location = new System.Drawing.Point(106, 151);
            this.txtBeginFri.Name = "txtBeginFri";
            this.txtBeginFri.Size = new System.Drawing.Size(69, 20);
            this.txtBeginFri.TabIndex = 13;
            // 
            // txtBeginSat
            // 
            this.txtBeginSat.Location = new System.Drawing.Point(106, 176);
            this.txtBeginSat.Name = "txtBeginSat";
            this.txtBeginSat.Size = new System.Drawing.Size(69, 20);
            this.txtBeginSat.TabIndex = 16;
            // 
            // txtBeginSun
            // 
            this.txtBeginSun.Location = new System.Drawing.Point(106, 202);
            this.txtBeginSun.Name = "txtBeginSun";
            this.txtBeginSun.Size = new System.Drawing.Size(69, 20);
            this.txtBeginSun.TabIndex = 19;
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(195, 50);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(16, 13);
            this.lblTo.TabIndex = 14;
            this.lblTo.Text = "to";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(195, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "to";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(195, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "to";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(195, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "to";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(195, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "to";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(195, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "to";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(195, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "to";
            // 
            // txtFinMon
            // 
            this.txtFinMon.Location = new System.Drawing.Point(232, 47);
            this.txtFinMon.Name = "txtFinMon";
            this.txtFinMon.Size = new System.Drawing.Size(69, 20);
            this.txtFinMon.TabIndex = 2;
            // 
            // txtFinTue
            // 
            this.txtFinTue.Location = new System.Drawing.Point(232, 73);
            this.txtFinTue.Name = "txtFinTue";
            this.txtFinTue.Size = new System.Drawing.Size(69, 20);
            this.txtFinTue.TabIndex = 5;
            // 
            // txtFinWed
            // 
            this.txtFinWed.Location = new System.Drawing.Point(232, 99);
            this.txtFinWed.Name = "txtFinWed";
            this.txtFinWed.Size = new System.Drawing.Size(69, 20);
            this.txtFinWed.TabIndex = 8;
            // 
            // txtFinThu
            // 
            this.txtFinThu.Location = new System.Drawing.Point(232, 125);
            this.txtFinThu.Name = "txtFinThu";
            this.txtFinThu.Size = new System.Drawing.Size(69, 20);
            this.txtFinThu.TabIndex = 11;
            // 
            // txtFinFri
            // 
            this.txtFinFri.Location = new System.Drawing.Point(232, 151);
            this.txtFinFri.Name = "txtFinFri";
            this.txtFinFri.Size = new System.Drawing.Size(69, 20);
            this.txtFinFri.TabIndex = 14;
            // 
            // txtFinSat
            // 
            this.txtFinSat.Location = new System.Drawing.Point(232, 176);
            this.txtFinSat.Name = "txtFinSat";
            this.txtFinSat.Size = new System.Drawing.Size(69, 20);
            this.txtFinSat.TabIndex = 17;
            // 
            // txtFinSun
            // 
            this.txtFinSun.Location = new System.Drawing.Point(232, 202);
            this.txtFinSun.Name = "txtFinSun";
            this.txtFinSun.Size = new System.Drawing.Size(69, 20);
            this.txtFinSun.TabIndex = 20;
            // 
            // lblBreak
            // 
            this.lblBreak.AutoSize = true;
            this.lblBreak.Location = new System.Drawing.Point(321, 50);
            this.lblBreak.Name = "lblBreak";
            this.lblBreak.Size = new System.Drawing.Size(41, 13);
            this.lblBreak.TabIndex = 28;
            this.lblBreak.Text = "Break :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(321, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Break :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(321, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Break :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(321, 128);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 31;
            this.label9.Text = "Break :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(321, 154);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 32;
            this.label10.Text = "Break :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(321, 179);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 33;
            this.label11.Text = "Break :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(321, 205);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 13);
            this.label12.TabIndex = 34;
            this.label12.Text = "Break :";
            // 
            // txtBkMon
            // 
            this.txtBkMon.Location = new System.Drawing.Point(368, 47);
            this.txtBkMon.Name = "txtBkMon";
            this.txtBkMon.Size = new System.Drawing.Size(69, 20);
            this.txtBkMon.TabIndex = 3;
            // 
            // txtBkTue
            // 
            this.txtBkTue.Location = new System.Drawing.Point(368, 73);
            this.txtBkTue.Name = "txtBkTue";
            this.txtBkTue.Size = new System.Drawing.Size(69, 20);
            this.txtBkTue.TabIndex = 6;
            // 
            // txtBkWed
            // 
            this.txtBkWed.Location = new System.Drawing.Point(368, 99);
            this.txtBkWed.Name = "txtBkWed";
            this.txtBkWed.Size = new System.Drawing.Size(69, 20);
            this.txtBkWed.TabIndex = 9;
            // 
            // txtBkThu
            // 
            this.txtBkThu.Location = new System.Drawing.Point(368, 125);
            this.txtBkThu.Name = "txtBkThu";
            this.txtBkThu.Size = new System.Drawing.Size(69, 20);
            this.txtBkThu.TabIndex = 12;
            // 
            // txtBkFri
            // 
            this.txtBkFri.Location = new System.Drawing.Point(368, 151);
            this.txtBkFri.Name = "txtBkFri";
            this.txtBkFri.Size = new System.Drawing.Size(69, 20);
            this.txtBkFri.TabIndex = 15;
            // 
            // txtBkSat
            // 
            this.txtBkSat.Location = new System.Drawing.Point(368, 176);
            this.txtBkSat.Name = "txtBkSat";
            this.txtBkSat.Size = new System.Drawing.Size(69, 20);
            this.txtBkSat.TabIndex = 18;
            // 
            // txtBkSun
            // 
            this.txtBkSun.Location = new System.Drawing.Point(368, 202);
            this.txtBkSun.Name = "txtBkSun";
            this.txtBkSun.Size = new System.Drawing.Size(69, 20);
            this.txtBkSun.TabIndex = 21;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(341, 78);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 13);
            this.label13.TabIndex = 3;
            this.label13.Text = "For Period";
            // 
            // txtPeriodNo
            // 
            this.txtPeriodNo.Location = new System.Drawing.Point(417, 78);
            this.txtPeriodNo.Name = "txtPeriodNo";
            this.txtPeriodNo.ReadOnly = true;
            this.txtPeriodNo.Size = new System.Drawing.Size(120, 20);
            this.txtPeriodNo.TabIndex = 4;
            this.txtPeriodNo.TabStop = false;
            this.txtPeriodNo.Text = "49";
            this.txtPeriodNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rtxt
            // 
            this.rtxt.BulletIndent = 1;
            this.rtxt.Location = new System.Drawing.Point(573, 112);
            this.rtxt.Name = "rtxt";
            this.rtxt.ReadOnly = true;
            this.rtxt.Size = new System.Drawing.Size(138, 117);
            this.rtxt.TabIndex = 5;
            this.rtxt.TabStop = false;
            this.rtxt.Text = "";
            this.rtxt.TextChanged += new System.EventHandler(this.rtxt_TextChanged);
            // 
            // btnApprove
            // 
            this.btnApprove.Location = new System.Drawing.Point(573, 341);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(108, 23);
            this.btnApprove.TabIndex = 22;
            this.btnApprove.Text = "Approve Times";
            this.btnApprove.UseVisualStyleBackColor = true;
            this.btnApprove.Click += new System.EventHandler(this.btnApprove_Click);
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(573, 370);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(108, 23);
            this.btnHome.TabIndex = 23;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // lblToDo
            // 
            this.lblToDo.AutoSize = true;
            this.lblToDo.Location = new System.Drawing.Point(573, 84);
            this.lblToDo.Name = "lblToDo";
            this.lblToDo.Size = new System.Drawing.Size(43, 13);
            this.lblToDo.TabIndex = 24;
            this.lblToDo.Text = "To Do :";
            this.lblToDo.Click += new System.EventHandler(this.label14_Click);
            // 
            // lblStaffName
            // 
            this.lblStaffName.AutoSize = true;
            this.lblStaffName.Location = new System.Drawing.Point(40, 20);
            this.lblStaffName.Name = "lblStaffName";
            this.lblStaffName.Size = new System.Drawing.Size(85, 13);
            this.lblStaffName.TabIndex = 35;
            this.lblStaffName.Text = "David O\'Sullivan";
            this.lblStaffName.Visible = false;
            this.lblStaffName.Click += new System.EventHandler(this.label14_Click_1);
            // 
            // enterTimeSheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 460);
            this.Controls.Add(this.lblToDo);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnApprove);
            this.Controls.Add(this.rtxt);
            this.Controls.Add(this.txtPeriodNo);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cboTimesheetSelect);
            this.Controls.Add(this.lblSearchStaffPrompt);
            this.Name = "enterTimeSheet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enter Timesheet";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSearchStaffPrompt;
        private System.Windows.Forms.ComboBox cboTimesheetSelect;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBkSun;
        private System.Windows.Forms.TextBox txtBkSat;
        private System.Windows.Forms.TextBox txtBkFri;
        private System.Windows.Forms.TextBox txtBkThu;
        private System.Windows.Forms.TextBox txtBkWed;
        private System.Windows.Forms.TextBox txtBkTue;
        private System.Windows.Forms.TextBox txtBkMon;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblBreak;
        private System.Windows.Forms.TextBox txtFinSun;
        private System.Windows.Forms.TextBox txtFinSat;
        private System.Windows.Forms.TextBox txtFinFri;
        private System.Windows.Forms.TextBox txtFinThu;
        private System.Windows.Forms.TextBox txtFinWed;
        private System.Windows.Forms.TextBox txtFinTue;
        private System.Windows.Forms.TextBox txtFinMon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.TextBox txtBeginSun;
        private System.Windows.Forms.TextBox txtBeginSat;
        private System.Windows.Forms.TextBox txtBeginFri;
        private System.Windows.Forms.TextBox txtBeginThurs;
        private System.Windows.Forms.TextBox txtBeginWed;
        private System.Windows.Forms.TextBox txtBeginTues;
        private System.Windows.Forms.TextBox txtBeginMon;
        private System.Windows.Forms.Label lblSunday;
        private System.Windows.Forms.Label lblSaturday;
        private System.Windows.Forms.Label lblFriday;
        private System.Windows.Forms.Label lblThursday;
        private System.Windows.Forms.Label lblWednesday;
        private System.Windows.Forms.Label lblTuesday;
        private System.Windows.Forms.Label lblMonday;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtPeriodNo;
        private System.Windows.Forms.RichTextBox rtxt;
        private System.Windows.Forms.Button btnApprove;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label lblToDo;
        private System.Windows.Forms.Label lblStaffName;
    }
}