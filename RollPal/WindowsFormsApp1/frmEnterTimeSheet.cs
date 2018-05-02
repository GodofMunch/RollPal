using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace WindowsFormsApp1
{
    public partial class frmEnterTimeSheet : Form
    {

        Staff member = new Staff();
        private int staffId;
        string[] staffToDo = new string[Staff.nextStaffId()-1];
        string[] staffDone = new string[Staff.nextStaffId()-1];
        int period = (DateTime.Now.DayOfYear / 7);
        Timesheet newTimeSheet = new Timesheet();
        

        public frmEnterTimeSheet()
        {
            InitializeComponent();
        }

        private void cboTimesheetSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            staffId = Convert.ToInt32(cboTimesheetSelect.Text);
            member = frmUpdateStaff.loadStaff(staffId);
            lblStaffName.Text = member.getForename() + " " + member.getSurname();
            lblStaffName.Visible = true;

        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            if (cboTimesheetSelect.Text == "")
                MessageBox.Show("Sorry! Please Select an Employee to Pay!");
            else
            {
                var proceed = MessageBox.Show("Approve hours for Staff number " + staffId.ToString("000") + "?",
                    "Approve Times", MessageBoxButtons.YesNo);

                if (proceed == DialogResult.Yes)
                {
                    double[] wages;
                    wages = calculateHours();

                    var confirm = MessageBox.Show("Gross Wage for Staff " + member.getStaffId() + " = " + wages[1] +
                        "Net wage for Employee =" + wages[0], "Approve Wages", MessageBoxButtons.YesNo);

                    if (confirm == DialogResult.Yes)
                    {
                        double annualGross = 0;
                        double annualNet = 0;
                        double annualUsc = 0;
                        double annualSiptu = 0;
                        double annualPrsi = 0;
                        double annualPaye = 0;


                        OracleConnection conn = new OracleConnection(DBConnect.oradb);
                        conn.Open();

                        string strSqlStaffPaid = "SELECT CONCURRENT_GROSS, CONCURRENT_NET FROM STAFF_PAID WHERE STAFFID = "
                            + member.getStaffId();
                        OracleCommand cmdStaffPaid = new OracleCommand(strSqlStaffPaid, conn);
                        OracleDataReader drStaffPaid = cmdStaffPaid.ExecuteReader();
                        drStaffPaid.Read();

                        annualGross = drStaffPaid.GetDouble(0);
                        annualNet = drStaffPaid.GetDouble(1);

                        annualGross += wages[1];
                        annualNet += wages[0];

                        string strSqlConcurrentTaxation = "SELECT * FROM CONCURRENT_TAXATION WHERE STAFFID = " + member.getStaffId();

                        OracleCommand cmdConcurrentTaxation = new OracleCommand(strSqlConcurrentTaxation, conn);
                        OracleDataReader drConcurrentTaxation = cmdConcurrentTaxation.ExecuteReader();

                        drConcurrentTaxation.Read();

                        annualUsc = drConcurrentTaxation.GetDouble(1);
                        annualSiptu = drConcurrentTaxation.GetDouble(3);
                        annualPaye = drConcurrentTaxation.GetDouble(5);
                        annualPrsi = drConcurrentTaxation.GetDouble(7);

                        annualUsc += wages[2];
                        annualSiptu += wages[3];
                        annualPaye += wages[4];
                        annualPrsi += wages[5];

                        strSqlStaffPaid = "UPDATE STAFF_PAID SET CONCURRENT_GROSS = " + annualGross + " , " +
                            "CONCURRENT_NET = " + annualNet + " , WEEK" + period + " = " + wages[0] +
                            " WHERE STAFFID = " + member.getStaffId();

                        cmdStaffPaid = new OracleCommand(strSqlStaffPaid, conn);
                        cmdStaffPaid.ExecuteNonQuery();

                        strSqlConcurrentTaxation = "UPDATE CONCURRENT_TAXATION SET CONCURRENTUSC = " +
                            annualUsc + ", USC = " + wages[2] + ", CONCURRENTSIPTU = " + annualSiptu +
                            ", SIPTU = " + wages[3] + ", CONCURRENTPAYE = " + annualPaye + ", PAYE = " +
                            wages[4] + ", CONCURRENTPRSI = " + annualPrsi + ", PRSI = " + wages[5] +
                            " WHERE STAFFID = " + member.getStaffId();

                        cmdConcurrentTaxation = new OracleCommand(strSqlConcurrentTaxation, conn);
                        cmdConcurrentTaxation.ExecuteNonQuery();
                        conn.Close();
                    }


                    frmEnterTimeSheet enterTimes = new frmEnterTimeSheet();
                    enterTimes.Show();
                    this.Hide();
                }

                else
                {
                    frmEnterTimeSheet enterTimes = new frmEnterTimeSheet();
                    enterTimes.Show();
                    this.Hide();
                }
            }
        }

        private double[] calculateHours()
        {
            int sunday = 0;
            int weekDayTotalMins = 0;
            int weekdayMinsDrive = 0;
            int sundayMinsDrive = 0;

            if (cbWorkedMon.Checked)
            {
                int mondayHours = Convert.ToInt32(dayFinHourMon.Text) - Convert.ToInt32(dayStartHourMon.Text) - Convert.ToInt32(breakHourMon.Text);
                int mondayMins = Convert.ToInt32(dayFinMinMon.Text) - Convert.ToInt32(dayStartMinMon.Text) - Convert.ToInt32(breakMinMon.Text);
                weekDayTotalMins += calculateDay(mondayHours, mondayMins);
                weekdayMinsDrive += calculateDay(Convert.ToInt32(cboDriveHrsMon.Text), Convert.ToInt32(cboDriveMinsMon.Text));
                
            }

            if (cbWorkedTue.Checked) {
                int tuesdayHours = Convert.ToInt32(dayFinHourTue.Text) - Convert.ToInt32(dayStartHourTue.Text) - Convert.ToInt32(breakHourTue.Text);
                int tuesdayMins = Convert.ToInt32(dayFinMinTue.Text) - Convert.ToInt32(dayStartMinTue.Text) - Convert.ToInt32(breakMinTue.Text);
                weekDayTotalMins += calculateDay(tuesdayHours, tuesdayMins);
                weekdayMinsDrive += calculateDay(Convert.ToInt32(cboDriveHrsTue.Text), Convert.ToInt32(cboDriveMinsTue.Text));
            }

            if (cbWorkedWed.Checked)
            {
                int wednesdayHours = Convert.ToInt32(dayFinHourWed.Text) - Convert.ToInt32(dayStartHourWed.Text) - Convert.ToInt32(breakHourWed.Text);
                int wednesdayMins = Convert.ToInt32(dayFinMinWed.Text) - Convert.ToInt32(dayStartMinWed.Text) - Convert.ToInt32(breakMinWed.Text);
                weekDayTotalMins += calculateDay(wednesdayHours, wednesdayMins);
                weekdayMinsDrive += calculateDay(Convert.ToInt32(cboDriveHrsWed.Text), Convert.ToInt32(cboDriveMinsWed.Text));
            }

            if (cbWorkedThu.Checked)
            {
                int thursdayHours = Convert.ToInt32(dayFinHourThu.Text) - Convert.ToInt32(dayStartHourThu.Text) - Convert.ToInt32(breakHourThu.Text);
                int thursdayMins = Convert.ToInt32(dayFinMinThu.Text) - Convert.ToInt32(dayStartMinThu.Text) - Convert.ToInt32(breakMinThu.Text);
                weekDayTotalMins += calculateDay(thursdayHours, thursdayMins);
                weekdayMinsDrive += calculateDay(Convert.ToInt32(cboDriveHrsThu.Text), Convert.ToInt32(cboDriveMinsThu.Text));
            }

            if (cbWorkedFri.Checked)
            {
                int fridayHours = Convert.ToInt32(dayFinHourFri.Text) - Convert.ToInt32(dayStartHourFri.Text) - Convert.ToInt32(breakHourFri.Text);
                int fridayMins = Convert.ToInt32(dayFinMinFri.Text) - Convert.ToInt32(dayStartMinFri.Text) - Convert.ToInt32(breakMinFri.Text);
                weekDayTotalMins += calculateDay(fridayHours, fridayMins);
                weekdayMinsDrive += calculateDay(Convert.ToInt32(cboDriveHrsFri.Text), Convert.ToInt32(cboDriveMinsFri.Text));
            }

            if (cbWorkedSat.Checked)
            {
                int saturdayHours = Convert.ToInt32(dayFinHourSat.Text) - Convert.ToInt32(dayStartHourSat.Text) - Convert.ToInt32(breakHourSat.Text);
                int saturdayMins = Convert.ToInt32(dayFinMinSat.Text) - Convert.ToInt32(dayStartMinSat.Text) - Convert.ToInt32(breakMinSat.Text);
                weekDayTotalMins += calculateDay(saturdayHours, saturdayMins);
                weekdayMinsDrive += calculateDay(Convert.ToInt32(cboDriveHrsSat.Text), Convert.ToInt32(cboDriveMinsSat.Text));
            }

            if (cbWorkedSun.Checked)
            {
                int sundayHours = Convert.ToInt32(dayFinHourSun.Text) - Convert.ToInt32(dayStartHourSun.Text) - Convert.ToInt32(breakHourSun.Text);
                int sundayMins = Convert.ToInt32(dayFinMinSun.Text) - Convert.ToInt32(dayStartMinSun.Text) - Convert.ToInt32(breakMinSun.Text);
                sunday += calculateDay(sundayHours, sundayMins);
                sundayMinsDrive += calculateDay(Convert.ToInt32(cboDriveHrsSun.Text), Convert.ToInt32(cboDriveMinsSun.Text));
            }
            
            double totalHours = 0;

            while(weekDayTotalMins >= 60)
            {
                totalHours += 1;
                weekDayTotalMins -= 60;
            }

            if (weekDayTotalMins == 15)
                totalHours += .25;
            else if (weekDayTotalMins == 30)
                totalHours += .5;
            else if (weekDayTotalMins == 45)
                totalHours += .75;

            if (totalHours > 39)
            {
                newTimeSheet.setOverTimeHours(totalHours - 39);
                newTimeSheet.setWeekDayHours(39);
            }

            else
                newTimeSheet.setWeekDayHours(39);

            while (weekdayMinsDrive >= 60)
            {
                totalHours += 1;
                weekdayMinsDrive -= 60;
            }

            if (weekdayMinsDrive == 15)
                totalHours += .25;
            else if (weekdayMinsDrive == 30)
                totalHours += .5;
            else if (weekdayMinsDrive == 45)
                totalHours += .75;

            double sundayHoursTotal = 0;

            while (sundayMinsDrive >= 60)
            {
                sundayHoursTotal += 1;
                sundayMinsDrive -= 60;
            }

            if (sundayMinsDrive == 15)
                sundayHoursTotal += .25;
            else if (sundayMinsDrive == 30)
                sundayHoursTotal += .5;
            else if (sundayMinsDrive == 45)
                sundayHoursTotal += .75;

            while (sunday >= 60)
            {
                sundayHoursTotal++;
                sunday -= 60;
            }

            if (sunday == 15)
                sundayHoursTotal += .25;
            if (sunday == 30)
                sundayHoursTotal += .50;
            if (sunday == 45)
                sundayHoursTotal += .75;

            newTimeSheet.setSundayHours(sundayHoursTotal);

            double[] wages = newTimeSheet.calculateWages(member);

            wages[0] = Math.Round(wages[0], 2);
            wages[1] = Math.Round(wages[1], 2);

            return wages;
            
            
        }
        
        private int calculateDay(int hours, int mins) 
        {
            if (mins < 0 && mins > -60)
            {
                mins = -mins;
                hours--;
            }

            else if (mins < -60)
            {
                while (mins < 0)
                {
                    mins += 60;
                    hours--;
                }
            }

            mins = mins + (hours * 60);

            return mins;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            frmWelcomeScreen home = new frmWelcomeScreen();
            home.Show();
            this.Hide();
        }

        private void frmEnterTimeSheet_Load(object sender, EventArgs e)
        {
            staffId = 1;
            member = frmUpdateStaff.loadStaff(staffId);
            lblStaffName.Text = member.getForename() + " " + member.getSurname();
            lblStaffName.Visible = true;

            txtPeriodNo.Text = period.ToString();
            ComboBox[] dayStartHours = {dayStartHourMon,  dayStartHourTue, dayStartHourWed, dayStartHourThu, dayStartHourFri, dayStartHourSat, dayStartHourSun};
            ComboBox[] dayFinHours = { dayFinHourMon, dayFinHourTue, dayFinHourWed, dayFinHourThu, dayFinHourFri, dayFinHourSat, dayFinHourSun };
            ComboBox[] dayStartMins = { dayStartMinMon, dayStartMinTue, dayStartMinWed, dayStartMinThu, dayStartMinFri, dayStartMinSat, dayStartMinSun };
            ComboBox[] dayFinMins = { dayFinMinMon, dayFinMinTue, dayFinMinWed, dayFinMinThu, dayFinMinFri, dayFinMinSat, dayFinMinSun };
            ComboBox[] breakHours = { breakHourMon, breakHourTue, breakHourWed, breakHourThu, breakHourFri, breakHourSat, breakHourSun };
            ComboBox[] breakMins = { breakMinMon, breakMinTue, breakMinWed, breakMinThu, breakMinFri, breakMinSat, breakMinSun };
            ComboBox[] drivingHours = { cboDriveHrsMon, cboDriveHrsTue, cboDriveHrsWed, cboDriveHrsThu, cboDriveHrsFri, cboDriveHrsSat, cboDriveHrsSun };
            ComboBox[] drivingMins = { cboDriveMinsMon, cboDriveMinsTue, cboDriveMinsWed, cboDriveMinsThu, cboDriveMinsFri, cboDriveMinsSat, cboDriveMinsSun };

            int[] mins = { 00, 15, 30, 45 };

            for(int i = 0; i < 7; i ++)
            {
                for(int j = 0; j < 24; j++)
                {
                    dayStartHours[i].Items.Add(j);
                    dayFinHours[i].Items.Add(j);
                    drivingHours[i].Items.Add(j);

                    if (j < 4)
                    {
                        dayStartMins[i].Items.Add(mins[j]);
                        dayFinMins[i].Items.Add(mins[j]);
                        breakMins[i].Items.Add(mins[j]);
                        drivingMins[i].Items.Add(mins[j]);
                        
                    }
                    if(j < 3)
                        breakHours[i].Items.Add(j);

                    dayStartHours[i].SelectedIndex = 0;
                    dayFinHours[i].SelectedIndex = 0;
                    drivingHours[i].SelectedIndex = 0;
                    dayStartMins[i].SelectedIndex = 0;
                    dayFinMins[i].SelectedIndex = 0;
                    breakHours[i].SelectedIndex = 0;
                    breakMins[i].SelectedIndex = 0;
                    drivingMins[i].SelectedIndex = 0;
                }
                
            }

            for (int i = 1; i < Staff.nextStaffId(); i++)
            {
                if (!staffPaid(i))
                {
                    cboTimesheetSelect.Items.Add("00" + i);
                    staffToDo[i - 1] = "00" + i;
                    rtxtToDo.Text += staffToDo[i - 1] + "\n";
                    
                }
            }
            if(staffToDo.Length > 0)
                cboTimesheetSelect.Text = staffToDo[0];
            cbWorkedSun.Checked = false;
            cbWorkedSat.Checked = false;
        }

        private bool staffPaid(int staffId)
        {
            bool active = false;

            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            string strSqlStaffPaid = "SELECT WEEK" + period + " FROM STAFF_PAID WHERE STAFFID = " + staffId;
            double data;

            OracleCommand cmdStaffPaid = new OracleCommand(strSqlStaffPaid, conn);

            OracleDataReader staffPaidData = cmdStaffPaid.ExecuteReader();

            staffPaidData.Read();
            data = staffPaidData.GetDouble(0);
            string activeStaff = "SELECT ACTIVE FROM STAFF WHERE STAFFID = " + staffId;
            OracleCommand cmdActiveStaff = new OracleCommand(activeStaff, conn);
            OracleDataReader drActive = cmdActiveStaff.ExecuteReader();
            drActive.Read();
            if (drActive.GetString(0) == "y")
                active = true;
            
            conn.Close();
            if (!data.Equals(0) || !active)
                return true;
            else
                return false;
           
        }

        private void cbWorkedMon_CheckedChanged(object sender, EventArgs e)
        {
            ComboBox[] monday = { dayStartHourMon, dayFinHourMon, dayStartMinMon, dayFinMinMon,
                                  breakHourMon, breakMinMon, cboDriveHrsMon, cboDriveMinsMon };

            if (cbWorkedMon.Checked)
                for (int i = 0; i < monday.Length; i++)
                {
                    monday[i].Enabled = true;
                    cbDroveMon.Enabled = true;
                }

            else
                for (int i = 0; i < monday.Length; i++)
                {
                    monday[i].Enabled = false;
                    cbDroveMon.Enabled = false;
                }
        }

        private void cbWorkedTue_CheckedChanged(object sender, EventArgs e)
        {

            ComboBox[] tuesday = {dayStartHourTue, dayFinHourTue, dayStartMinTue, dayFinMinTue,
                                  breakHourTue, breakMinTue, cboDriveHrsTue, cboDriveMinsTue };
            if (cbWorkedTue.Checked)
                for (int i = 0; i < tuesday.Length; i++)
                {
                    tuesday[i].Enabled = true;
                    cbDroveTue.Enabled = true;
                }

            else
                for (int i = 0; i < tuesday.Length; i++)
                {
                    tuesday[i].Enabled = false;
                    cbDroveTue.Enabled = false;
                }
        }

        private void cbWorkedWed_CheckedChanged(object sender, EventArgs e)
        {
            ComboBox[] wednesday= {dayStartHourWed, dayFinHourWed, dayStartMinWed, dayFinMinWed,
                                  breakHourWed, breakMinWed, cboDriveHrsWed, cboDriveMinsWed };
            if (cbWorkedWed.Checked)
                for (int i = 0; i < wednesday.Length; i++)
                {
                    wednesday[i].Enabled = true;
                    cbDroveWed.Enabled = true;
                }

            else
                for (int i = 0; i < wednesday.Length; i++)
                {
                    wednesday[i].Enabled = false;
                    cbDroveWed.Enabled = false;
                }
        }

        private void cbWorkedThu_CheckedChanged(object sender, EventArgs e)
        {
            ComboBox[] thursday = {dayStartHourThu, dayFinHourThu, dayStartMinThu, dayFinMinThu,
                                  breakHourThu, breakMinThu, cboDriveHrsThu, cboDriveMinsThu };
            if (cbWorkedThu.Checked)
                for (int i = 0; i < thursday.Length; i++)
                {
                    thursday[i].Enabled = true;
                    cbDroveThu.Enabled = true;
                }

            else
                for (int i = 0; i < thursday.Length; i++)
                {
                    thursday[i].Enabled = false;
                    cbDroveThu.Enabled = false;
                }
        }

        private void cbWorkedFri_CheckedChanged(object sender, EventArgs e)
        {
            ComboBox[] friday = {dayStartHourFri, dayFinHourFri, dayStartMinFri, dayFinMinFri,
                                  breakHourFri, breakMinFri, cboDriveHrsFri, cboDriveMinsFri };
            if (cbWorkedFri.Checked)
                for (int i = 0; i < friday.Length; i++)
                {
                    friday[i].Enabled = true;
                    cbDroveFri.Enabled = true;
                }

            else
                for (int i = 0; i < friday.Length; i++)
                {
                    friday[i].Enabled = false;
                    cbDroveFri.Enabled = false;
                }
        }

        private void cbWorkedSat_CheckedChanged(object sender, EventArgs e)
        {
            ComboBox[] saturday = {dayStartHourSat, dayFinHourSat, dayStartMinSat, dayFinMinSat,
                                  breakHourSat, breakMinSat, cboDriveHrsSat, cboDriveMinsSat };
            if (cbWorkedSat.Checked)
                for (int i = 0; i < saturday.Length; i++)
                {
                    saturday[i].Enabled = true;
                    cbDroveSat.Enabled = true;
                }

            else
                for (int i = 0; i < saturday.Length; i++)
                {
                    saturday[i].Enabled = false;
                    cbDroveSat.Enabled = false;
                }
        }

        private void cbWorkedSun_CheckedChanged(object sender, EventArgs e)
        {
            ComboBox[] sunday = {dayStartHourSun, dayFinHourSun, dayStartMinSun, dayFinMinSun,
                                  breakHourSun, breakMinSun, cboDriveHrsSun, cboDriveMinsSun };

            if (cbWorkedSun.Checked)
                for (int i = 0; i < sunday.Length; i++)
                {
                    sunday[i].Enabled = true;
                    cbDroveSun.Enabled = true;
                }
                    
            else
                for (int i = 0; i < sunday.Length; i++)   
                {
                    sunday[i].Enabled = false;
                    cbDroveSun.Enabled = false;
                }
        }
    }
}
