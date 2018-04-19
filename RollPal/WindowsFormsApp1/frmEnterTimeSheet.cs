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
            

            var proceed = MessageBox.Show("Approve hours for Staff number " + staffId.ToString("000") + "?",
                "Approve Times", MessageBoxButtons.YesNo);

            if(proceed == DialogResult.Yes)
            {
                OracleConnection conn = new OracleConnection(DBConnect.oradb);
                conn.Open();

                string staffPaidsql = "UPDATE STAFF_PAID SET WEEK" + period + " = 'Y' WHERE STAFFID = " + staffId;

                OracleCommand cmdStaffPaid = new OracleCommand(staffPaidsql, conn);
                cmdStaffPaid.ExecuteNonQuery();
                conn.Close();
                calculateHours();

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

        private void calculateHours()
        {
            if (dayFinHourMon.Text == "00")
                dayFinHourMon.Text = "24";
            int mondayHours = Convert.ToInt32(dayFinHourMon.Text) - Convert.ToInt32(dayStartHourMon.Text) - Convert.ToInt32(breakHourMon.Text);
            int mondayMins = Convert.ToInt32(dayFinMinMon.Text) - Convert.ToInt32(dayStartMinMon.Text) - Convert.ToInt32(breakMinMon.Text);

            int tuesdayHours = Convert.ToInt32(dayFinHourTue.Text) - Convert.ToInt32(dayStartHourTue.Text) - Convert.ToInt32(breakHourTue.Text);
            int tuesdayMins = Convert.ToInt32(dayFinMinTue.Text) - Convert.ToInt32(dayStartMinTue.Text) - Convert.ToInt32(breakMinTue.Text);

            int wednesdayHours = Convert.ToInt32(dayFinHourWed.Text) - Convert.ToInt32(dayStartHourWed.Text) - Convert.ToInt32(breakHourWed.Text);
            int wednesdayMins = Convert.ToInt32(dayFinMinWed.Text) - Convert.ToInt32(dayStartMinWed.Text) - Convert.ToInt32(breakMinWed.Text);

            int thursdayHours = Convert.ToInt32(dayFinHourThu.Text) - Convert.ToInt32(dayStartHourThu.Text) - Convert.ToInt32(breakHourThu.Text);
            int thursdayMins = Convert.ToInt32(dayFinMinThu.Text) - Convert.ToInt32(dayStartMinThu.Text) - Convert.ToInt32(breakMinThu.Text);

            int fridayHours = Convert.ToInt32(dayFinHourFri.Text) - Convert.ToInt32(dayStartHourFri.Text) - Convert.ToInt32(breakHourFri.Text);
            int fridayMins = Convert.ToInt32(dayFinMinFri.Text) - Convert.ToInt32(dayStartMinFri.Text) - Convert.ToInt32(breakMinFri.Text);

            int saturdayHours = Convert.ToInt32(dayFinHourSat.Text) - Convert.ToInt32(dayStartHourSat.Text) - Convert.ToInt32(breakHourSat.Text);
            int saturdayMins = Convert.ToInt32(dayFinMinSat.Text) - Convert.ToInt32(dayStartMinSat.Text) - Convert.ToInt32(breakMinSat.Text);

            int sundayHours = Convert.ToInt32(dayFinHourSun.Text) - Convert.ToInt32(dayStartHourSun.Text) - Convert.ToInt32(breakHourSun.Text);
            int sundayMins = Convert.ToInt32(dayFinMinSun.Text) - Convert.ToInt32(dayStartMinSun.Text) - Convert.ToInt32(breakMinSun.Text);

            int[] hours = { mondayHours, tuesdayHours, wednesdayHours, thursdayHours, fridayHours, saturdayHours, sundayHours };
            int[] mins = { mondayMins, tuesdayMins, wednesdayMins, thursdayMins, fridayMins, saturdayMins, sundayMins };

            int totalHours = 0;
            int totalMins = 0;

            for(int i = 0; i < 7; i++)
            {
                totalHours += hours[i];
                totalMins += mins[i];
            }


            /*if (mondayMins < 0)
            {
                while (mondayMins < 0)
                {
                    mondayMins = -mondayMins;
                    mondayHours--;

                    MessageBox.Show(mondayHours.ToString() + " + " + mondayMins.ToString());
                }
            }*/

            MessageBox.Show(mondayHours.ToString() + " + " + mondayMins.ToString());
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            frmWelcomeScreen home = new frmWelcomeScreen();
            home.Show();
            this.Hide();
        }

        private void frmEnterTimeSheet_Load(object sender, EventArgs e)
        {
            txtPeriodNo.Text = period.ToString();
            ComboBox[] dayStartHours = {dayStartHourMon,  dayStartHourTue, dayStartHourWed, dayStartHourThu, dayStartHourFri, dayStartHourSat, dayStartHourSun};
            ComboBox[] dayFinHours = { dayFinHourMon, dayFinHourTue, dayFinHourWed, dayFinHourThu, dayFinHourFri, dayFinHourSat, dayFinHourSun };
            ComboBox[] dayStartMins = { dayStartMinMon, dayStartMinTue, dayStartMinWed, dayStartMinThu, dayStartMinFri, dayStartMinSat, dayStartMinSun };
            ComboBox[] dayFinMins = { dayFinMinMon, dayFinMinTue, dayFinMinWed, dayFinMinThu, dayFinMinFri, dayFinMinSat, dayFinMinSun };
            ComboBox[] breakHours = { breakHourMon, breakHourTue, breakHourWed, breakHourThu, breakHourFri, breakHourSat, breakHourSun };
            ComboBox[] breakMins = { breakMinMon, breakMinTue, breakMinWed, breakMinThu, breakMinFri, breakMinSat, breakMinSun };
            int[] mins = { 00, 15, 30, 45 };

            for(int i = 0; i < 7; i ++)
            {
                for(int j = 0; j < 24; j++)
                {
                    dayStartHours[i].Items.Add(j);
                    dayFinHours[i].Items.Add(j);

                    if (j < 4)
                    {
                        dayStartMins[i].Items.Add(mins[j]);
                        dayFinMins[i].Items.Add(mins[j]);
                        breakMins[i].Items.Add(mins[j]);
                        
                    }
                    if(j < 3)
                        breakHours[i].Items.Add(j);
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

            
        }

        private bool staffPaid(int staffId)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            string strSqlStaffPaid = "SELECT WEEK" + period + " FROM STAFF_PAID WHERE STAFFID = " + staffId;
            string data;

            OracleCommand cmdStaffPaid = new OracleCommand(strSqlStaffPaid, conn);

            OracleDataReader staffPaidData = cmdStaffPaid.ExecuteReader();

            staffPaidData.Read();

            data = staffPaidData.GetString(0);
            conn.Close();
            if (data.Equals("N"))
                return false;
            else
                return true;
           
        }

        private void cbWorkedMon_CheckedChanged(object sender, EventArgs e)
        {
            if (cbWorkedMon.Checked)
            {
                dayStartHourMon.Enabled = false;
                dayFinHourMon.Enabled = false;
                dayStartMinMon.Enabled = false;
                dayFinMinMon.Enabled = false;
                breakHourMon.Enabled = false;
                breakMinMon.Enabled = false;
            }

            else
            {
                dayStartHourMon.Enabled = true;
                dayFinHourMon.Enabled = true;
                dayStartMinMon.Enabled = true;
                dayFinMinMon.Enabled = true;
                breakHourMon.Enabled = true;
                breakMinMon.Enabled = true;
            }
        }

        private void cbWorkedTue_CheckedChanged(object sender, EventArgs e)
        {
            if (cbWorkedTue.Checked)
            {
                dayStartHourTue.Enabled = false;
                dayFinHourTue.Enabled = false;
                dayStartMinTue.Enabled = false;
                dayFinMinTue.Enabled = false;
                breakHourTue.Enabled = false;
                breakMinTue.Enabled = false;
            }

            else
            {
                dayStartHourTue.Enabled = true;
                dayFinHourTue.Enabled = true;
                dayStartMinTue.Enabled = true;
                dayFinMinTue.Enabled = true;
                breakHourTue.Enabled = true;
                breakMinTue.Enabled = true;
            }
        }

        private void cbWorkedWed_CheckedChanged(object sender, EventArgs e)
        {
            if (cbWorkedWed.Checked)
            {
                dayStartHourWed.Enabled = false;
                dayFinHourWed.Enabled = false;
                dayStartMinWed.Enabled = false;
                dayFinMinWed.Enabled = false;
                breakHourWed.Enabled = false;
                breakMinWed.Enabled = false;
            }

            else
            {
                dayStartHourWed.Enabled = true;
                dayFinHourWed.Enabled = true;
                dayStartMinWed.Enabled = true;
                dayFinMinWed.Enabled = true;
                breakHourWed.Enabled = true;
                breakMinWed.Enabled = true;
            }
        }

        private void cbWorkedThu_CheckedChanged(object sender, EventArgs e)
        {
            if (cbWorkedThu.Checked)
            {
                dayStartHourThu.Enabled = false;
                dayFinHourThu.Enabled = false;
                dayStartMinThu.Enabled = false;
                dayFinMinThu.Enabled = false;
                breakHourThu.Enabled = false;
                breakMinThu.Enabled = false;
            }

            else
            {
                dayStartHourThu.Enabled = true;
                dayFinHourThu.Enabled = true;
                dayStartMinThu.Enabled = true;
                dayFinMinThu.Enabled = true;
                breakHourThu.Enabled = true;
                breakMinThu.Enabled = true;
            }
        }

        private void cbWorkedFri_CheckedChanged(object sender, EventArgs e)
        {
            if (cbWorkedFri.Checked)
            {
                dayStartHourFri.Enabled = false;
                dayFinHourFri.Enabled = false;
                dayStartMinFri.Enabled = false;
                dayFinMinFri.Enabled = false;
                breakHourFri.Enabled = false;
                breakMinFri.Enabled = false;
            }

            else
            {
                dayStartHourFri.Enabled = true;
                dayFinHourFri.Enabled = true;
                dayStartMinFri.Enabled = true;
                dayFinMinFri.Enabled = true;
                breakHourFri.Enabled = true;
                breakMinFri.Enabled = true;
            }
        }

        private void cbWorkedSat_CheckedChanged(object sender, EventArgs e)
        {
            if (cbWorkedSat.Checked)
            {
                dayStartHourSat.Enabled = false;
                dayFinHourSat.Enabled = false;
                dayStartMinSat.Enabled = false;
                dayFinMinSat.Enabled = false;
                breakHourSat.Enabled = false;
                breakMinSat.Enabled = false;
            }

            else
            {
                dayStartHourSat.Enabled = true;
                dayFinHourSat.Enabled = true;
                dayStartMinSat.Enabled = true;
                dayFinMinSat.Enabled = true;
                breakHourSat.Enabled = true;
                breakMinSat.Enabled = true;
            }
        }

        private void cbWorkedSun_CheckedChanged(object sender, EventArgs e)
        {
            if (cbWorkedSun.Checked)
            {
                dayStartHourSun.Enabled = false;
                dayFinHourSun.Enabled = false;
                dayStartMinSun.Enabled = false;
                dayFinMinSun.Enabled = false;
                breakHourSun.Enabled = false;
                breakMinSun.Enabled = false;
            }

            else
            {
                dayStartHourSun.Enabled = true;
                dayFinHourSun.Enabled = true;
                dayStartMinSun.Enabled = true;
                dayFinMinSun.Enabled = true;
                breakHourSun.Enabled = true;
                breakMinSun.Enabled = true;
            }
        }
    }
}
