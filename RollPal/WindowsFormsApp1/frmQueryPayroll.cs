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
        public frmQueryPayroll()
        {
            InitializeComponent();
            
                
        }

        private void rtxtWageDetails_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSearchBar_TextChanged(object sender, EventArgs e)
        {
            if(!txtSearhBar.Text.Equals("") || !txtSearhBar.Text.Equals("ID Number") 
                || !txtSearhBar.Text.Equals("Name"))
            {
                rtxtWageDetails.Visible = true;
            }
        }

        private void optStaffId_CheckedChanged(object sender, EventArgs e)
        {
            if (optStaffId.Checked == true)
            {
                txtSearhBar.Text = "ID Number";
            }
            else
            {
                txtSearhBar.Text = "Name";
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Staff[] members = new Staff[Staff.nextStaffId() - 1];
            Staff member = new Staff();
            string staffInfo = "Staff Id\tName\t\tWages";
            int i = 0;


            if (optStaffName.Checked)
                if (txtSearhBar.Text == "")
                    MessageBox.Show("Please Enter Text");
           
                else
                {
                    members = lookForStaff(txtSearhBar.Text);
                    
                    if(members[i].getForename() != "")
                    {
                        while(members[i].getForename() != "")
                        {
                            staffInfo += "\n" + members[i].getStaffId().ToString() + "\t" + members[i].getForename() +
                                " " + members[i].getSurname() + "\t" + frmGeneratePayRoll.getWeeklyNet(members[i].getStaffId());
                            i++;
                        }
                        rtxtWageDetails.Text = staffInfo;
                    }
                    else
                    {
                        MessageBox.Show("Sorry! There were no matches!");
                    }
                }
            else if (optStaffId.Checked)
            {
                if (txtSearhBar.Text == "")
                    MessageBox.Show("Please Enter Text");

                else
                {
                    int staffId = Convert.ToInt32(txtSearhBar.Text);
                    member = lookForStaff(staffId);

                    if (member.getForename() != "")
                    {
                        staffInfo += "\n" + member.getStaffId().ToString() + "\t" + member.getForename() +
                                  " " + member.getSurname() + "\t" + frmGeneratePayRoll.getWeeklyNet(member.getStaffId());
                        rtxtWageDetails.Text = staffInfo;
                    }

                    else
                    {
                        MessageBox.Show("Sorry! There were no matches!");
                    }
                }
            }
        }

        private Staff[] lookForStaff(string name)
        {
            Staff member = new Staff();
            Staff[] members = new Staff[Staff.nextStaffId()-1];
            int noOfStaff = 0;
            for (int i = 0; i < Staff.nextStaffId(); i++)
            {
                OracleConnection conn = new OracleConnection(DBConnect.oradb);
                conn.Open();
                string strSqlSearchStaff = "SELECT * FROM STAFF WHERE FORENAME LIKE '%" + name + "%' AND STAFFID = " + i;

                OracleCommand cmdStaff = new OracleCommand(strSqlSearchStaff, conn);
                OracleDataReader drStaff = cmdStaff.ExecuteReader();
                drStaff.Read();
                if (drStaff.HasRows)
                {
                    member = frmUpdateStaff.loadStaff(drStaff.GetInt32(0));
                    members[noOfStaff] = member;
                    noOfStaff++;
                }
                conn.Close();
            }
            

            return members;
            
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


            

        }
    }




