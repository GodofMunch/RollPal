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
            

            var proceed = MessageBox.Show("Approve hours for Staff number " + staffId.ToString() + "?",
                "Approve Times", MessageBoxButtons.YesNo);

            if(proceed == DialogResult.Yes)
            {
                OracleConnection conn = new OracleConnection(DBConnect.oradb);

                string staffPaidsql = "INSERT INTO STAFF_PAID(WEEK" + period + " VALUES('Y')";

                OracleCommand cmdStaffPaid = new OracleCommand(staffPaidsql, conn);
                cmdStaffPaid.ExecuteNonQuery();
                conn.Close();
            }

            else
            {
                frmEnterTimeSheet enterTimes = new frmEnterTimeSheet();
                enterTimes.Show();
                this.Hide();
            }
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
