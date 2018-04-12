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
            this.label13 = new System.Windows.Forms.Label();
            this.txtPeriodNo = new System.Windows.Forms.TextBox();
            this.rtxtToDo = new System.Windows.Forms.RichTextBox();
            this.btnApprove = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.lblToDo = new System.Windows.Forms.Label();
            this.lblMonday = new System.Windows.Forms.Label();
            this.lblTuesday = new System.Windows.Forms.Label();
            this.lblWednesday = new System.Windows.Forms.Label();
            this.lblThursday = new System.Windows.Forms.Label();
            this.lblFriday = new System.Windows.Forms.Label();
            this.lblSaturday = new System.Windows.Forms.Label();
            this.lblSunday = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblBreak = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblStaffName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dayStartHourMon = new System.Windows.Forms.ComboBox();
            this.dayStartMinMon = new System.Windows.Forms.ComboBox();
            this.dayFinHourMon = new System.Windows.Forms.ComboBox();
            this.dayFinMinMon = new System.Windows.Forms.ComboBox();
            this.breakHourMon = new System.Windows.Forms.ComboBox();
            this.breakMinMon = new System.Windows.Forms.ComboBox();
            this.dayStartHourTue = new System.Windows.Forms.ComboBox();
            this.dayStartMinTue = new System.Windows.Forms.ComboBox();
            this.dayFinHourTue = new System.Windows.Forms.ComboBox();
            this.dayFinMinTue = new System.Windows.Forms.ComboBox();
            this.breakHourTue = new System.Windows.Forms.ComboBox();
            this.breakMinTue = new System.Windows.Forms.ComboBox();
            this.dayStartHourWed = new System.Windows.Forms.ComboBox();
            this.dayStartMinWed = new System.Windows.Forms.ComboBox();
            this.dayFinHourWed = new System.Windows.Forms.ComboBox();
            this.dayFinMinWed = new System.Windows.Forms.ComboBox();
            this.breakHourWed = new System.Windows.Forms.ComboBox();
            this.breakMinWed = new System.Windows.Forms.ComboBox();
            this.dayStartHourThu = new System.Windows.Forms.ComboBox();
            this.dayStartMinThu = new System.Windows.Forms.ComboBox();
            this.dayFinHourThur = new System.Windows.Forms.ComboBox();
            this.dayFinMinThu = new System.Windows.Forms.ComboBox();
            this.breakHourThur = new System.Windows.Forms.ComboBox();
            this.breakMinThu = new System.Windows.Forms.ComboBox();
            this.dayStartHourFri = new System.Windows.Forms.ComboBox();
            this.dayStartMinFri = new System.Windows.Forms.ComboBox();
            this.dayFinHourFri = new System.Windows.Forms.ComboBox();
            this.dayFinMinFri = new System.Windows.Forms.ComboBox();
            this.breakHourFri = new System.Windows.Forms.ComboBox();
            this.breakMinFri = new System.Windows.Forms.ComboBox();
            this.dayStartHourSat = new System.Windows.Forms.ComboBox();
            this.dayStartMinSat = new System.Windows.Forms.ComboBox();
            this.dayFinHourSat = new System.Windows.Forms.ComboBox();
            this.dayFinMinSat = new System.Windows.Forms.ComboBox();
            this.breakHourSat = new System.Windows.Forms.ComboBox();
            this.breakMinSat = new System.Windows.Forms.ComboBox();
            this.dayStartHourSun = new System.Windows.Forms.ComboBox();
            this.dayStartMinSun = new System.Windows.Forms.ComboBox();
            this.dayFinHourSun = new System.Windows.Forms.ComboBox();
            this.dayFinMinSun = new System.Windows.Forms.ComboBox();
            this.breakHourSun = new System.Windows.Forms.ComboBox();
            this.breakMinSun = new System.Windows.Forms.ComboBox();
            this.cbWorkedMon = new System.Windows.Forms.CheckBox();
            this.cbWorkedTue = new System.Windows.Forms.CheckBox();
            this.cbWorkedWed = new System.Windows.Forms.CheckBox();
            this.cbWorkedThu = new System.Windows.Forms.CheckBox();
            this.cbWorkedFri = new System.Windows.Forms.CheckBox();
            this.cbWorkedSat = new System.Windows.Forms.CheckBox();
            this.cbWorkedSun = new System.Windows.Forms.CheckBox();
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
            this.cboTimesheetSelect.Location = new System.Drawing.Point(417, 43);
            this.cboTimesheetSelect.MaxDropDownItems = 3;
            this.cboTimesheetSelect.Name = "cboTimesheetSelect";
            this.cboTimesheetSelect.Size = new System.Drawing.Size(121, 21);
            this.cboTimesheetSelect.TabIndex = 0;
            this.cboTimesheetSelect.SelectedIndexChanged += new System.EventHandler(this.cboTimesheetSelect_SelectedIndexChanged);
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
            // rtxtToDo
            // 
            this.rtxtToDo.BulletIndent = 1;
            this.rtxtToDo.Location = new System.Drawing.Point(573, 112);
            this.rtxtToDo.Name = "rtxtToDo";
            this.rtxtToDo.ReadOnly = true;
            this.rtxtToDo.Size = new System.Drawing.Size(138, 117);
            this.rtxtToDo.TabIndex = 5;
            this.rtxtToDo.TabStop = false;
            this.rtxtToDo.Text = "";
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
            // 
            // lblMonday
            // 
            this.lblMonday.AutoSize = true;
            this.lblMonday.Location = new System.Drawing.Point(37, 72);
            this.lblMonday.Name = "lblMonday";
            this.lblMonday.Size = new System.Drawing.Size(51, 13);
            this.lblMonday.TabIndex = 0;
            this.lblMonday.Text = "Monday :";
            // 
            // lblTuesday
            // 
            this.lblTuesday.AutoSize = true;
            this.lblTuesday.Location = new System.Drawing.Point(37, 101);
            this.lblTuesday.Name = "lblTuesday";
            this.lblTuesday.Size = new System.Drawing.Size(54, 13);
            this.lblTuesday.TabIndex = 1;
            this.lblTuesday.Text = "Tuesday :";
            // 
            // lblWednesday
            // 
            this.lblWednesday.AutoSize = true;
            this.lblWednesday.Location = new System.Drawing.Point(37, 128);
            this.lblWednesday.Name = "lblWednesday";
            this.lblWednesday.Size = new System.Drawing.Size(70, 13);
            this.lblWednesday.TabIndex = 2;
            this.lblWednesday.Text = "Wednesday :";
            // 
            // lblThursday
            // 
            this.lblThursday.AutoSize = true;
            this.lblThursday.Location = new System.Drawing.Point(37, 157);
            this.lblThursday.Name = "lblThursday";
            this.lblThursday.Size = new System.Drawing.Size(57, 13);
            this.lblThursday.TabIndex = 3;
            this.lblThursday.Text = "Thursday :";
            // 
            // lblFriday
            // 
            this.lblFriday.AutoSize = true;
            this.lblFriday.Location = new System.Drawing.Point(37, 184);
            this.lblFriday.Name = "lblFriday";
            this.lblFriday.Size = new System.Drawing.Size(41, 13);
            this.lblFriday.TabIndex = 4;
            this.lblFriday.Text = "Friday :";
            // 
            // lblSaturday
            // 
            this.lblSaturday.AutoSize = true;
            this.lblSaturday.Location = new System.Drawing.Point(37, 211);
            this.lblSaturday.Name = "lblSaturday";
            this.lblSaturday.Size = new System.Drawing.Size(55, 13);
            this.lblSaturday.TabIndex = 5;
            this.lblSaturday.Text = "Saturday :";
            // 
            // lblSunday
            // 
            this.lblSunday.AutoSize = true;
            this.lblSunday.Location = new System.Drawing.Point(37, 237);
            this.lblSunday.Name = "lblSunday";
            this.lblSunday.Size = new System.Drawing.Size(49, 13);
            this.lblSunday.TabIndex = 6;
            this.lblSunday.Text = "Sunday :";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(195, 72);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(16, 13);
            this.lblTo.TabIndex = 14;
            this.lblTo.Text = "to";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(195, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "to";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(195, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "to";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(195, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "to";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(195, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "to";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(195, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "to";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(195, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "to";
            // 
            // lblBreak
            // 
            this.lblBreak.AutoSize = true;
            this.lblBreak.Location = new System.Drawing.Point(321, 72);
            this.lblBreak.Name = "lblBreak";
            this.lblBreak.Size = new System.Drawing.Size(41, 13);
            this.lblBreak.TabIndex = 28;
            this.lblBreak.Text = "Break :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(321, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Break :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(321, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Break :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(321, 157);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 31;
            this.label9.Text = "Break :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(321, 184);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 32;
            this.label10.Text = "Break :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(321, 211);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 33;
            this.label11.Text = "Break :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(321, 237);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 13);
            this.label12.TabIndex = 34;
            this.label12.Text = "Break :";
            // 
            // lblStaffName
            // 
            this.lblStaffName.AutoSize = true;
            this.lblStaffName.ForeColor = System.Drawing.Color.Red;
            this.lblStaffName.Location = new System.Drawing.Point(37, 32);
            this.lblStaffName.Name = "lblStaffName";
            this.lblStaffName.Size = new System.Drawing.Size(85, 13);
            this.lblStaffName.TabIndex = 35;
            this.lblStaffName.Text = "David O\'Sullivan";
            this.lblStaffName.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbWorkedSun);
            this.groupBox1.Controls.Add(this.cbWorkedSat);
            this.groupBox1.Controls.Add(this.cbWorkedFri);
            this.groupBox1.Controls.Add(this.cbWorkedThu);
            this.groupBox1.Controls.Add(this.cbWorkedWed);
            this.groupBox1.Controls.Add(this.cbWorkedTue);
            this.groupBox1.Controls.Add(this.cbWorkedMon);
            this.groupBox1.Controls.Add(this.breakMinSun);
            this.groupBox1.Controls.Add(this.breakHourSun);
            this.groupBox1.Controls.Add(this.dayFinMinSun);
            this.groupBox1.Controls.Add(this.dayFinHourSun);
            this.groupBox1.Controls.Add(this.dayStartMinSun);
            this.groupBox1.Controls.Add(this.dayStartHourSun);
            this.groupBox1.Controls.Add(this.breakMinSat);
            this.groupBox1.Controls.Add(this.breakHourSat);
            this.groupBox1.Controls.Add(this.dayFinMinSat);
            this.groupBox1.Controls.Add(this.dayFinHourSat);
            this.groupBox1.Controls.Add(this.dayStartMinSat);
            this.groupBox1.Controls.Add(this.dayStartHourSat);
            this.groupBox1.Controls.Add(this.breakMinFri);
            this.groupBox1.Controls.Add(this.breakHourFri);
            this.groupBox1.Controls.Add(this.dayFinMinFri);
            this.groupBox1.Controls.Add(this.dayFinHourFri);
            this.groupBox1.Controls.Add(this.dayStartMinFri);
            this.groupBox1.Controls.Add(this.dayStartHourFri);
            this.groupBox1.Controls.Add(this.breakMinThu);
            this.groupBox1.Controls.Add(this.breakHourThur);
            this.groupBox1.Controls.Add(this.dayFinMinThu);
            this.groupBox1.Controls.Add(this.dayFinHourThur);
            this.groupBox1.Controls.Add(this.dayStartMinThu);
            this.groupBox1.Controls.Add(this.dayStartHourThu);
            this.groupBox1.Controls.Add(this.breakMinWed);
            this.groupBox1.Controls.Add(this.breakHourWed);
            this.groupBox1.Controls.Add(this.dayFinMinWed);
            this.groupBox1.Controls.Add(this.dayFinHourWed);
            this.groupBox1.Controls.Add(this.dayStartMinWed);
            this.groupBox1.Controls.Add(this.dayStartHourWed);
            this.groupBox1.Controls.Add(this.breakMinTue);
            this.groupBox1.Controls.Add(this.breakHourTue);
            this.groupBox1.Controls.Add(this.dayFinMinTue);
            this.groupBox1.Controls.Add(this.dayFinHourTue);
            this.groupBox1.Controls.Add(this.dayStartMinTue);
            this.groupBox1.Controls.Add(this.dayStartHourTue);
            this.groupBox1.Controls.Add(this.breakMinMon);
            this.groupBox1.Controls.Add(this.breakHourMon);
            this.groupBox1.Controls.Add(this.dayFinMinMon);
            this.groupBox1.Controls.Add(this.dayFinHourMon);
            this.groupBox1.Controls.Add(this.dayStartMinMon);
            this.groupBox1.Controls.Add(this.dayStartHourMon);
            this.groupBox1.Controls.Add(this.lblStaffName);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lblBreak);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblTo);
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
            // dayStartHourMon
            // 
            this.dayStartHourMon.FormattingEnabled = true;
            this.dayStartHourMon.Location = new System.Drawing.Point(107, 69);
            this.dayStartHourMon.Name = "dayStartHourMon";
            this.dayStartHourMon.Size = new System.Drawing.Size(38, 21);
            this.dayStartHourMon.TabIndex = 1;
            // 
            // dayStartMinMon
            // 
            this.dayStartMinMon.FormattingEnabled = true;
            this.dayStartMinMon.Location = new System.Drawing.Point(151, 69);
            this.dayStartMinMon.Name = "dayStartMinMon";
            this.dayStartMinMon.Size = new System.Drawing.Size(38, 21);
            this.dayStartMinMon.TabIndex = 2;
            // 
            // dayFinHourMon
            // 
            this.dayFinHourMon.FormattingEnabled = true;
            this.dayFinHourMon.Location = new System.Drawing.Point(228, 69);
            this.dayFinHourMon.Name = "dayFinHourMon";
            this.dayFinHourMon.Size = new System.Drawing.Size(42, 21);
            this.dayFinHourMon.TabIndex = 3;
            // 
            // dayFinMinMon
            // 
            this.dayFinMinMon.FormattingEnabled = true;
            this.dayFinMinMon.Location = new System.Drawing.Point(276, 69);
            this.dayFinMinMon.Name = "dayFinMinMon";
            this.dayFinMinMon.Size = new System.Drawing.Size(39, 21);
            this.dayFinMinMon.TabIndex = 4;
            // 
            // breakHourMon
            // 
            this.breakHourMon.FormattingEnabled = true;
            this.breakHourMon.Location = new System.Drawing.Point(368, 69);
            this.breakHourMon.Name = "breakHourMon";
            this.breakHourMon.Size = new System.Drawing.Size(47, 21);
            this.breakHourMon.TabIndex = 5;
            // 
            // breakMinMon
            // 
            this.breakMinMon.FormattingEnabled = true;
            this.breakMinMon.Location = new System.Drawing.Point(421, 69);
            this.breakMinMon.Name = "breakMinMon";
            this.breakMinMon.Size = new System.Drawing.Size(42, 21);
            this.breakMinMon.TabIndex = 6;
            // 
            // dayStartHourTue
            // 
            this.dayStartHourTue.FormattingEnabled = true;
            this.dayStartHourTue.Location = new System.Drawing.Point(107, 98);
            this.dayStartHourTue.Name = "dayStartHourTue";
            this.dayStartHourTue.Size = new System.Drawing.Size(38, 21);
            this.dayStartHourTue.TabIndex = 7;
            // 
            // dayStartMinTue
            // 
            this.dayStartMinTue.FormattingEnabled = true;
            this.dayStartMinTue.Location = new System.Drawing.Point(151, 98);
            this.dayStartMinTue.Name = "dayStartMinTue";
            this.dayStartMinTue.Size = new System.Drawing.Size(38, 21);
            this.dayStartMinTue.TabIndex = 8;
            // 
            // dayFinHourTue
            // 
            this.dayFinHourTue.FormattingEnabled = true;
            this.dayFinHourTue.Location = new System.Drawing.Point(228, 98);
            this.dayFinHourTue.Name = "dayFinHourTue";
            this.dayFinHourTue.Size = new System.Drawing.Size(42, 21);
            this.dayFinHourTue.TabIndex = 9;
            // 
            // dayFinMinTue
            // 
            this.dayFinMinTue.FormattingEnabled = true;
            this.dayFinMinTue.Location = new System.Drawing.Point(276, 98);
            this.dayFinMinTue.Name = "dayFinMinTue";
            this.dayFinMinTue.Size = new System.Drawing.Size(39, 21);
            this.dayFinMinTue.TabIndex = 10;
            // 
            // breakHourTue
            // 
            this.breakHourTue.FormattingEnabled = true;
            this.breakHourTue.Location = new System.Drawing.Point(368, 98);
            this.breakHourTue.Name = "breakHourTue";
            this.breakHourTue.Size = new System.Drawing.Size(47, 21);
            this.breakHourTue.TabIndex = 11;
            // 
            // breakMinTue
            // 
            this.breakMinTue.FormattingEnabled = true;
            this.breakMinTue.Location = new System.Drawing.Point(421, 98);
            this.breakMinTue.Name = "breakMinTue";
            this.breakMinTue.Size = new System.Drawing.Size(42, 21);
            this.breakMinTue.TabIndex = 12;
            // 
            // dayStartHourWed
            // 
            this.dayStartHourWed.FormattingEnabled = true;
            this.dayStartHourWed.Location = new System.Drawing.Point(107, 125);
            this.dayStartHourWed.Name = "dayStartHourWed";
            this.dayStartHourWed.Size = new System.Drawing.Size(38, 21);
            this.dayStartHourWed.TabIndex = 13;
            // 
            // dayStartMinWed
            // 
            this.dayStartMinWed.FormattingEnabled = true;
            this.dayStartMinWed.Location = new System.Drawing.Point(151, 125);
            this.dayStartMinWed.Name = "dayStartMinWed";
            this.dayStartMinWed.Size = new System.Drawing.Size(38, 21);
            this.dayStartMinWed.TabIndex = 14;
            // 
            // dayFinHourWed
            // 
            this.dayFinHourWed.FormattingEnabled = true;
            this.dayFinHourWed.Location = new System.Drawing.Point(228, 125);
            this.dayFinHourWed.Name = "dayFinHourWed";
            this.dayFinHourWed.Size = new System.Drawing.Size(42, 21);
            this.dayFinHourWed.TabIndex = 15;
            // 
            // dayFinMinWed
            // 
            this.dayFinMinWed.FormattingEnabled = true;
            this.dayFinMinWed.Location = new System.Drawing.Point(276, 125);
            this.dayFinMinWed.Name = "dayFinMinWed";
            this.dayFinMinWed.Size = new System.Drawing.Size(39, 21);
            this.dayFinMinWed.TabIndex = 16;
            // 
            // breakHourWed
            // 
            this.breakHourWed.FormattingEnabled = true;
            this.breakHourWed.Location = new System.Drawing.Point(368, 125);
            this.breakHourWed.Name = "breakHourWed";
            this.breakHourWed.Size = new System.Drawing.Size(47, 21);
            this.breakHourWed.TabIndex = 17;
            // 
            // breakMinWed
            // 
            this.breakMinWed.FormattingEnabled = true;
            this.breakMinWed.Location = new System.Drawing.Point(421, 125);
            this.breakMinWed.Name = "breakMinWed";
            this.breakMinWed.Size = new System.Drawing.Size(42, 21);
            this.breakMinWed.TabIndex = 18;
            // 
            // dayStartHourThu
            // 
            this.dayStartHourThu.FormattingEnabled = true;
            this.dayStartHourThu.Location = new System.Drawing.Point(107, 154);
            this.dayStartHourThu.Name = "dayStartHourThu";
            this.dayStartHourThu.Size = new System.Drawing.Size(38, 21);
            this.dayStartHourThu.TabIndex = 19;
            // 
            // dayStartMinThu
            // 
            this.dayStartMinThu.FormattingEnabled = true;
            this.dayStartMinThu.Location = new System.Drawing.Point(151, 154);
            this.dayStartMinThu.Name = "dayStartMinThu";
            this.dayStartMinThu.Size = new System.Drawing.Size(38, 21);
            this.dayStartMinThu.TabIndex = 20;
            // 
            // dayFinHourThur
            // 
            this.dayFinHourThur.FormattingEnabled = true;
            this.dayFinHourThur.Location = new System.Drawing.Point(228, 154);
            this.dayFinHourThur.Name = "dayFinHourThur";
            this.dayFinHourThur.Size = new System.Drawing.Size(42, 21);
            this.dayFinHourThur.TabIndex = 21;
            // 
            // dayFinMinThu
            // 
            this.dayFinMinThu.FormattingEnabled = true;
            this.dayFinMinThu.Location = new System.Drawing.Point(276, 154);
            this.dayFinMinThu.Name = "dayFinMinThu";
            this.dayFinMinThu.Size = new System.Drawing.Size(39, 21);
            this.dayFinMinThu.TabIndex = 22;
            // 
            // breakHourThur
            // 
            this.breakHourThur.FormattingEnabled = true;
            this.breakHourThur.Location = new System.Drawing.Point(368, 154);
            this.breakHourThur.Name = "breakHourThur";
            this.breakHourThur.Size = new System.Drawing.Size(47, 21);
            this.breakHourThur.TabIndex = 23;
            // 
            // breakMinThu
            // 
            this.breakMinThu.FormattingEnabled = true;
            this.breakMinThu.Location = new System.Drawing.Point(421, 154);
            this.breakMinThu.Name = "breakMinThu";
            this.breakMinThu.Size = new System.Drawing.Size(42, 21);
            this.breakMinThu.TabIndex = 24;
            // 
            // dayStartHourFri
            // 
            this.dayStartHourFri.FormattingEnabled = true;
            this.dayStartHourFri.Location = new System.Drawing.Point(107, 181);
            this.dayStartHourFri.Name = "dayStartHourFri";
            this.dayStartHourFri.Size = new System.Drawing.Size(38, 21);
            this.dayStartHourFri.TabIndex = 25;
            // 
            // dayStartMinFri
            // 
            this.dayStartMinFri.FormattingEnabled = true;
            this.dayStartMinFri.Location = new System.Drawing.Point(151, 181);
            this.dayStartMinFri.Name = "dayStartMinFri";
            this.dayStartMinFri.Size = new System.Drawing.Size(38, 21);
            this.dayStartMinFri.TabIndex = 26;
            // 
            // dayFinHourFri
            // 
            this.dayFinHourFri.FormattingEnabled = true;
            this.dayFinHourFri.Location = new System.Drawing.Point(228, 181);
            this.dayFinHourFri.Name = "dayFinHourFri";
            this.dayFinHourFri.Size = new System.Drawing.Size(42, 21);
            this.dayFinHourFri.TabIndex = 27;
            // 
            // dayFinMinFri
            // 
            this.dayFinMinFri.FormattingEnabled = true;
            this.dayFinMinFri.Location = new System.Drawing.Point(276, 181);
            this.dayFinMinFri.Name = "dayFinMinFri";
            this.dayFinMinFri.Size = new System.Drawing.Size(39, 21);
            this.dayFinMinFri.TabIndex = 28;
            // 
            // breakHourFri
            // 
            this.breakHourFri.FormattingEnabled = true;
            this.breakHourFri.Location = new System.Drawing.Point(368, 181);
            this.breakHourFri.Name = "breakHourFri";
            this.breakHourFri.Size = new System.Drawing.Size(47, 21);
            this.breakHourFri.TabIndex = 29;
            // 
            // breakMinFri
            // 
            this.breakMinFri.FormattingEnabled = true;
            this.breakMinFri.Location = new System.Drawing.Point(421, 181);
            this.breakMinFri.Name = "breakMinFri";
            this.breakMinFri.Size = new System.Drawing.Size(42, 21);
            this.breakMinFri.TabIndex = 30;
            // 
            // dayStartHourSat
            // 
            this.dayStartHourSat.FormattingEnabled = true;
            this.dayStartHourSat.Location = new System.Drawing.Point(107, 208);
            this.dayStartHourSat.Name = "dayStartHourSat";
            this.dayStartHourSat.Size = new System.Drawing.Size(38, 21);
            this.dayStartHourSat.TabIndex = 31;
            // 
            // dayStartMinSat
            // 
            this.dayStartMinSat.FormattingEnabled = true;
            this.dayStartMinSat.Location = new System.Drawing.Point(151, 208);
            this.dayStartMinSat.Name = "dayStartMinSat";
            this.dayStartMinSat.Size = new System.Drawing.Size(38, 21);
            this.dayStartMinSat.TabIndex = 32;
            // 
            // dayFinHourSat
            // 
            this.dayFinHourSat.FormattingEnabled = true;
            this.dayFinHourSat.Location = new System.Drawing.Point(228, 208);
            this.dayFinHourSat.Name = "dayFinHourSat";
            this.dayFinHourSat.Size = new System.Drawing.Size(42, 21);
            this.dayFinHourSat.TabIndex = 33;
            // 
            // dayFinMinSat
            // 
            this.dayFinMinSat.FormattingEnabled = true;
            this.dayFinMinSat.Location = new System.Drawing.Point(276, 208);
            this.dayFinMinSat.Name = "dayFinMinSat";
            this.dayFinMinSat.Size = new System.Drawing.Size(39, 21);
            this.dayFinMinSat.TabIndex = 34;
            // 
            // breakHourSat
            // 
            this.breakHourSat.FormattingEnabled = true;
            this.breakHourSat.Location = new System.Drawing.Point(368, 208);
            this.breakHourSat.Name = "breakHourSat";
            this.breakHourSat.Size = new System.Drawing.Size(47, 21);
            this.breakHourSat.TabIndex = 35;
            // 
            // breakMinSat
            // 
            this.breakMinSat.FormattingEnabled = true;
            this.breakMinSat.Location = new System.Drawing.Point(421, 208);
            this.breakMinSat.Name = "breakMinSat";
            this.breakMinSat.Size = new System.Drawing.Size(42, 21);
            this.breakMinSat.TabIndex = 36;
            // 
            // dayStartHourSun
            // 
            this.dayStartHourSun.FormattingEnabled = true;
            this.dayStartHourSun.Location = new System.Drawing.Point(107, 234);
            this.dayStartHourSun.Name = "dayStartHourSun";
            this.dayStartHourSun.Size = new System.Drawing.Size(38, 21);
            this.dayStartHourSun.TabIndex = 37;
            // 
            // dayStartMinSun
            // 
            this.dayStartMinSun.FormattingEnabled = true;
            this.dayStartMinSun.Location = new System.Drawing.Point(151, 234);
            this.dayStartMinSun.Name = "dayStartMinSun";
            this.dayStartMinSun.Size = new System.Drawing.Size(38, 21);
            this.dayStartMinSun.TabIndex = 38;
            // 
            // dayFinHourSun
            // 
            this.dayFinHourSun.FormattingEnabled = true;
            this.dayFinHourSun.Location = new System.Drawing.Point(228, 234);
            this.dayFinHourSun.Name = "dayFinHourSun";
            this.dayFinHourSun.Size = new System.Drawing.Size(42, 21);
            this.dayFinHourSun.TabIndex = 39;
            // 
            // dayFinMinSun
            // 
            this.dayFinMinSun.FormattingEnabled = true;
            this.dayFinMinSun.Location = new System.Drawing.Point(276, 234);
            this.dayFinMinSun.Name = "dayFinMinSun";
            this.dayFinMinSun.Size = new System.Drawing.Size(39, 21);
            this.dayFinMinSun.TabIndex = 40;
            // 
            // breakHourSun
            // 
            this.breakHourSun.FormattingEnabled = true;
            this.breakHourSun.Location = new System.Drawing.Point(368, 234);
            this.breakHourSun.Name = "breakHourSun";
            this.breakHourSun.Size = new System.Drawing.Size(47, 21);
            this.breakHourSun.TabIndex = 41;
            // 
            // breakMinSun
            // 
            this.breakMinSun.FormattingEnabled = true;
            this.breakMinSun.Location = new System.Drawing.Point(421, 234);
            this.breakMinSun.Name = "breakMinSun";
            this.breakMinSun.Size = new System.Drawing.Size(42, 21);
            this.breakMinSun.TabIndex = 42;
            // 
            // cbWorkedMon
            // 
            this.cbWorkedMon.AutoSize = true;
            this.cbWorkedMon.Location = new System.Drawing.Point(6, 71);
            this.cbWorkedMon.Name = "cbWorkedMon";
            this.cbWorkedMon.Size = new System.Drawing.Size(15, 14);
            this.cbWorkedMon.TabIndex = 43;
            this.cbWorkedMon.UseVisualStyleBackColor = true;
            // 
            // cbWorkedTue
            // 
            this.cbWorkedTue.AutoSize = true;
            this.cbWorkedTue.Location = new System.Drawing.Point(6, 101);
            this.cbWorkedTue.Name = "cbWorkedTue";
            this.cbWorkedTue.Size = new System.Drawing.Size(15, 14);
            this.cbWorkedTue.TabIndex = 44;
            this.cbWorkedTue.UseVisualStyleBackColor = true;
            // 
            // cbWorkedWed
            // 
            this.cbWorkedWed.AutoSize = true;
            this.cbWorkedWed.Location = new System.Drawing.Point(6, 128);
            this.cbWorkedWed.Name = "cbWorkedWed";
            this.cbWorkedWed.Size = new System.Drawing.Size(15, 14);
            this.cbWorkedWed.TabIndex = 45;
            this.cbWorkedWed.UseVisualStyleBackColor = true;
            // 
            // cbWorkedThu
            // 
            this.cbWorkedThu.AutoSize = true;
            this.cbWorkedThu.Location = new System.Drawing.Point(6, 157);
            this.cbWorkedThu.Name = "cbWorkedThu";
            this.cbWorkedThu.Size = new System.Drawing.Size(15, 14);
            this.cbWorkedThu.TabIndex = 46;
            this.cbWorkedThu.UseVisualStyleBackColor = true;
            // 
            // cbWorkedFri
            // 
            this.cbWorkedFri.AutoSize = true;
            this.cbWorkedFri.Location = new System.Drawing.Point(6, 184);
            this.cbWorkedFri.Name = "cbWorkedFri";
            this.cbWorkedFri.Size = new System.Drawing.Size(15, 14);
            this.cbWorkedFri.TabIndex = 47;
            this.cbWorkedFri.UseVisualStyleBackColor = true;
            // 
            // cbWorkedSat
            // 
            this.cbWorkedSat.AutoSize = true;
            this.cbWorkedSat.Location = new System.Drawing.Point(6, 211);
            this.cbWorkedSat.Name = "cbWorkedSat";
            this.cbWorkedSat.Size = new System.Drawing.Size(15, 14);
            this.cbWorkedSat.TabIndex = 48;
            this.cbWorkedSat.UseVisualStyleBackColor = true;
            // 
            // cbWorkedSun
            // 
            this.cbWorkedSun.AutoSize = true;
            this.cbWorkedSun.Location = new System.Drawing.Point(6, 237);
            this.cbWorkedSun.Name = "cbWorkedSun";
            this.cbWorkedSun.Size = new System.Drawing.Size(15, 14);
            this.cbWorkedSun.TabIndex = 49;
            this.cbWorkedSun.UseVisualStyleBackColor = true;
            // 
            // frmEnterTimeSheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 460);
            this.Controls.Add(this.lblToDo);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnApprove);
            this.Controls.Add(this.rtxtToDo);
            this.Controls.Add(this.txtPeriodNo);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cboTimesheetSelect);
            this.Controls.Add(this.lblSearchStaffPrompt);
            this.Name = "frmEnterTimeSheet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enter Timesheet";
            this.Load += new System.EventHandler(this.frmEnterTimeSheet_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSearchStaffPrompt;
        private System.Windows.Forms.ComboBox cboTimesheetSelect;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtPeriodNo;
        private System.Windows.Forms.RichTextBox rtxtToDo;
        private System.Windows.Forms.Button btnApprove;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label lblToDo;
        private System.Windows.Forms.Label lblMonday;
        private System.Windows.Forms.Label lblTuesday;
        private System.Windows.Forms.Label lblWednesday;
        private System.Windows.Forms.Label lblThursday;
        private System.Windows.Forms.Label lblFriday;
        private System.Windows.Forms.Label lblSaturday;
        private System.Windows.Forms.Label lblSunday;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblBreak;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblStaffName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox breakMinSun;
        private System.Windows.Forms.ComboBox breakHourSun;
        private System.Windows.Forms.ComboBox dayFinMinSun;
        private System.Windows.Forms.ComboBox dayFinHourSun;
        private System.Windows.Forms.ComboBox dayStartMinSun;
        private System.Windows.Forms.ComboBox dayStartHourSun;
        private System.Windows.Forms.ComboBox breakMinSat;
        private System.Windows.Forms.ComboBox breakHourSat;
        private System.Windows.Forms.ComboBox dayFinMinSat;
        private System.Windows.Forms.ComboBox dayFinHourSat;
        private System.Windows.Forms.ComboBox dayStartMinSat;
        private System.Windows.Forms.ComboBox dayStartHourSat;
        private System.Windows.Forms.ComboBox breakMinFri;
        private System.Windows.Forms.ComboBox breakHourFri;
        private System.Windows.Forms.ComboBox dayFinMinFri;
        private System.Windows.Forms.ComboBox dayFinHourFri;
        private System.Windows.Forms.ComboBox dayStartMinFri;
        private System.Windows.Forms.ComboBox dayStartHourFri;
        private System.Windows.Forms.ComboBox breakMinThu;
        private System.Windows.Forms.ComboBox breakHourThur;
        private System.Windows.Forms.ComboBox dayFinMinThu;
        private System.Windows.Forms.ComboBox dayFinHourThur;
        private System.Windows.Forms.ComboBox dayStartMinThu;
        private System.Windows.Forms.ComboBox dayStartHourThu;
        private System.Windows.Forms.ComboBox breakMinWed;
        private System.Windows.Forms.ComboBox breakHourWed;
        private System.Windows.Forms.ComboBox dayFinMinWed;
        private System.Windows.Forms.ComboBox dayFinHourWed;
        private System.Windows.Forms.ComboBox dayStartMinWed;
        private System.Windows.Forms.ComboBox dayStartHourWed;
        private System.Windows.Forms.ComboBox breakMinTue;
        private System.Windows.Forms.ComboBox breakHourTue;
        private System.Windows.Forms.ComboBox dayFinMinTue;
        private System.Windows.Forms.ComboBox dayFinHourTue;
        private System.Windows.Forms.ComboBox dayStartMinTue;
        private System.Windows.Forms.ComboBox dayStartHourTue;
        private System.Windows.Forms.ComboBox breakMinMon;
        private System.Windows.Forms.ComboBox breakHourMon;
        private System.Windows.Forms.ComboBox dayFinMinMon;
        private System.Windows.Forms.ComboBox dayFinHourMon;
        private System.Windows.Forms.ComboBox dayStartMinMon;
        private System.Windows.Forms.ComboBox dayStartHourMon;
        private System.Windows.Forms.CheckBox cbWorkedSun;
        private System.Windows.Forms.CheckBox cbWorkedSat;
        private System.Windows.Forms.CheckBox cbWorkedFri;
        private System.Windows.Forms.CheckBox cbWorkedThu;
        private System.Windows.Forms.CheckBox cbWorkedWed;
        private System.Windows.Forms.CheckBox cbWorkedTue;
        private System.Windows.Forms.CheckBox cbWorkedMon;
    }
}