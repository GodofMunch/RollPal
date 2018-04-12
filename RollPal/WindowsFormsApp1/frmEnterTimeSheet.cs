﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmEnterTimeSheet : Form
    {

        Staff member = new Staff();
        private int staffId;
        string[] staffToDo;
        string[] staffDone;

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
            

            var proceed = MessageBox.Show("Approve hours for Staff number 001?",
                "Approve Times", MessageBoxButtons.YesNo);

            if(proceed == DialogResult.Yes)
            {
                rtxtToDo.Text = "002";
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
            ComboBox[] dayStartHours = {dayStartHourMon,  dayStartHourTue, dayStartHourWed, dayStartHourThu, dayStartHourFri, dayStartHourSat, dayStartHourSun};
            ComboBox[] dayFinHours = { dayFinHourMon, dayFinHourTue, dayFinHourWed, dayFinHourThur, dayFinHourFri, dayFinHourSat, dayFinHourSun };
            ComboBox[] dayStartMins = { dayStartMinMon, dayStartMinTue, dayStartMinWed, dayStartMinThu, dayStartMinFri, dayStartMinSat, dayStartMinSun };
            ComboBox[] dayFinMins = { dayFinMinMon, dayFinMinTue, dayFinMinWed, dayFinMinThu, dayFinMinFri, dayFinMinSat, dayFinMinSun };
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
                    }
                }
            }

            for (int i = 1; i < Staff.nextStaffId(); i++)
            {
                cboTimesheetSelect.Items.Add("00" + i);
            }
        }
    }
}
