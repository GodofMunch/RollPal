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
    public partial class frmGeneratePayRoll : Form
    {
        public frmGeneratePayRoll()
        {
            InitializeComponent();
            rtxtWageDetails.Text = "Staff ID\t\tName\t\tHours Worked\t\tWages Owed\n\n" +
                "001\t\tDavid O'Sullivan\t\t48\t\t567.78\n" +
                "002\t\tAndy Tynan\t\t48\t\t567.78\n" +
                "003\t\tLiam Redmond\t\t48\t\t567.78\n" +
                "004\t\tNoel Dolan\t\t48\t\t567.78\n" +
                "005\t\tBrendan Kelly\t\t48\t\t567.78\n" +
                "006\t\tDamien Lawlor\t\t48\t\t567.78\n" +
                "007\t\tRobert Johnston\t\t48\t\t567.78\n" +
                "008\t\tJohn Begley\t\t48\t\t567.78\n" +
                "009\t\tMaurice Williams\t\t48\t\t567.78\n" +
                "010\t\tLee O'Riordan\t\t48\t\t567.78\n" +
                "011\t\tPaul White\t\t48\t\t567.78\n";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void rtxtWageDetails_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGenWages_Click(object sender, EventArgs e)
        {
            var genWages = MessageBox.Show("Would you like to approve wage bill for Period 49" +
                " with wages totalling 6249.98 euro?", "Generate Wage Bill", MessageBoxButtons.YesNo,
                MessageBoxIcon.Exclamation);

            if(genWages == DialogResult.Yes)
            {
                var approved = MessageBox.Show("Wages have sent for Approval", "Sent", MessageBoxButtons.OK);

                if(approved == DialogResult.OK)
                {
                    frmWelcomeScreen home = new frmWelcomeScreen();
                    home.Show();
                    this.Hide();
                }

                else
                {
                    frmGeneratePayRoll payRollGen = new frmGeneratePayRoll();
                    payRollGen.Show();
                    this.Hide();
                }
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            frmGeneratePayRoll payRollGen = new frmGeneratePayRoll();
            payRollGen.Show();
            this.Hide();
        }
    }
}