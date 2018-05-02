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
    public partial class frmQueryPayroll : Form
    {
        int period;
        public frmQueryPayroll()
        {
            InitializeComponent();
        }

        private void optStaffId_CheckedChanged(object sender, EventArgs e)
        {
            if (optStaffId.Checked == true)
            {
                lblSearch.Text = "ID Number";
            }
            else
            {
                lblSearch.Text = "Name";
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Staff[] members = new Staff[Staff.nextStaffId() - 1];
            Staff member = new Staff();
            string staffInfo = "Staff Id\tName\t\tWages";
            int i;

            
            if (optStaffName.Checked)
            {
                if (txtSearhBar.Text == "")
                    MessageBox.Show("Please Enter Text");

                else
                {
                    members = lookForStaff(txtSearhBar.Text);

                    for (int k = 0; k < members.Length; k++)
                    {
                        if (members[k].getForename() != "")
                        {
                            staffInfo += "\n" + members[k].getStaffId().ToString("000") + "\t" + members[k].getForename() +
                            " " + members[k].getSurname() + "\t\t" + frmGeneratePayRoll.getWeeklyNet(members[k].getStaffId());
                        }
                    }
                    
                    if (staffInfo == "")
                        staffInfo = "Sorry! There were no matches!";

                    rtxtWageDetails.Text = staffInfo;
                    rtxtWageDetails.Visible = true;
                    }
                }
            

            
            else if (optStaffId.Checked)
            {
                if (txtSearhBar.Text == "")
                    MessageBox.Show("Please Enter Text");


                else
                {

                    for (i = 0; i < txtSearhBar.Text.Length; i++)
                        if (optStaffId.Checked)
                            if (!Char.IsDigit(txtSearhBar.Text[i]))
                                break;
                    if (i == txtSearhBar.Text.Length)
                    {
                        int staffId = Convert.ToInt32(txtSearhBar.Text);
                        member = lookForStaff(staffId);

                        if (member.getForename() != "")
                        {
                            staffInfo += "\n" + member.getStaffId().ToString("000") + "\t" + member.getForename() +
                                      " " + member.getSurname() + "\t" + frmGeneratePayRoll.getWeeklyNet(member.getStaffId());

                        }

                        else
                        {
                            MessageBox.Show("Sorry! There were no matches!");
                        }
                        rtxtWageDetails.Text = staffInfo;
                        rtxtWageDetails.Visible = true;
                    }
                    else
                    {
                        rtxtWageDetails.Text = "Please enter a valid staff id";
                        rtxtWageDetails.Visible = true;
                    }
                }
            }
        }

        private Staff[] lookForStaff(string name)
        {
            Staff member = new Staff();
            Staff[] members = new Staff[Staff.nextStaffId() - 1];
            int noOfStaff = 0;

            for (int i = 0; i < Staff.nextStaffId(); i++)
            {

                OracleConnection conn = new OracleConnection(DBConnect.oradb);
                conn.Open();
                string strSqlSearchStaff = "SELECT * FROM STAFF WHERE FORENAME LIKE '%" + name + "' AND STAFFID = " + i;
                string strSqlSearchStaff2 = "SELECT * FROM STAFF WHERE SURNAME LIKE '%" + name + "' AND STAFFID = " + i;
                OracleCommand cmdStaff = new OracleCommand(strSqlSearchStaff, conn);
                OracleCommand cmdStaff2 = new OracleCommand(strSqlSearchStaff2, conn);
                OracleDataReader drStaff = cmdStaff.ExecuteReader();
                OracleDataReader drStaff2 = cmdStaff2.ExecuteReader();
                drStaff.Read();
                if (drStaff.HasRows)
                {
                    member = frmUpdateStaff.loadStaff(drStaff.GetInt32(0));
                    members[noOfStaff] = member;
                    noOfStaff++;
                }

                if (drStaff2.HasRows)
                {
                    member = frmUpdateStaff.loadStaff(drStaff.GetInt32(0));
                    members[noOfStaff] = member;
                    noOfStaff++;
                }
                conn.Close();
            }

            if (noOfStaff > 0)
            { 
                for (int i = noOfStaff; i < members.Length; i++)
                    members[noOfStaff] = new Staff();

                return members;
            }
           else
            {
                for(int i = 0; i < members.Length; i ++)
                    members[i] = new Staff();
                return members;
            }
            
        }

        private Staff lookForStaff(int staffId)
        {
            Staff member = new Staff();
            
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();
            string strSqlSearchStaff = "SELECT * FROM STAFF WHERE STAFFID = " + staffId;

            OracleCommand cmdStaff = new OracleCommand(strSqlSearchStaff, conn);
            OracleDataReader drStaff = cmdStaff.ExecuteReader();
            drStaff.Read();
            if (drStaff.HasRows)
                member = frmUpdateStaff.loadStaff(staffId);
            conn.Close();

            return member;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmWelcomeScreen home = new frmWelcomeScreen();
            home.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            period = comboBox1.SelectedIndex;
        }

        private void frmQueryPayroll_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 52; i++)
                comboBox1.Items.Add(i);

            comboBox1.SelectedIndex = 0;
        }
    }
}




