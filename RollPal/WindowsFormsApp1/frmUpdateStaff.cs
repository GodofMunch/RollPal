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
    public partial class frmUpdateStaff : Form

       
    {
        public int staffId;
        public bool IsSelected = false;
        public Staff staffMember;
        public string maritalStatus;
        public string gender;

        public frmUpdateStaff()
        {
            InitializeComponent();
        }

        private void cboSelectStaff_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cboSelectStaff.Text == "<null>")
                IsSelected = false;
            else
                IsSelected = true;
            if (IsSelected)
            {
                staffMember = loadStaff(Convert.ToInt32(cboSelectStaff.Text));
                txtUpdateStaffId.Text = staffMember.getStaffId().ToString("000");
                txtForename.Text = staffMember.getForename();
                txtSurname.Text = staffMember.getSurname();
                txtPhone.Text = staffMember.getPhone();
                txtEmail.Text = staffMember.getEmail();
                txtStreet.Text = staffMember.getStreet();
                txtTown.Text = staffMember.getTown();
                txtCounty.Text = staffMember.getCounty();
                txtEircode.Text = staffMember.getEirCode();
                //DateTime tempDate = new DateTime(Convert.ToDateTime(staffMember.getDOB());
                dtDob.Value = Convert.ToDateTime(staffMember.getDOB());

                if (staffMember.getMaritalStatus() == "y")
                    optMarried.Checked = true;
                else
                    optSingle.Checked = true;

                if (staffMember.getGender() == "m")
                    optGenderMale.Checked = true;
                else
                    optGenderFemale.Checked = true;

                txtIbanUpdate.Text = staffMember.getIban();

                grpStaffDetails.Visible = true;
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            frmWelcomeScreen home = new frmWelcomeScreen();
            home.Show();
            this.Hide();
        }

        private void frmUpdateStaff_Load(object sender, EventArgs e)
        {
            for(int i = 1; i < Staff.nextStaffId(); i++)
            {
                string staffId = "00" + (i);
                cboSelectStaff.Items.Add(staffId);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        public Staff loadStaff(int staffId)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            string sqlSelectStaff = "SELECT * FROM STAFF WHERE STAFFID = " + staffId;
            OracleCommand cmdStaff = new OracleCommand(sqlSelectStaff, conn);

            OracleDataReader dataLoadedStaff = cmdStaff.ExecuteReader();
            dataLoadedStaff.Read();

            Staff newStaffMember = new Staff();

            DateTime dobHolder;

            newStaffMember.setStaffId(staffId);
            newStaffMember.setForeName(dataLoadedStaff.GetString(1));
            newStaffMember.setSurname(dataLoadedStaff.GetString(2));

            dobHolder = dataLoadedStaff.GetDateTime(3);
            newStaffMember.setDOB(dobHolder.Date.ToString("yyyy-MM-dd"));
            //newStaffMember.setDOB(dataLoadedStaff.GetString(3));
            newStaffMember.setGender(dataLoadedStaff.GetString(4));
            gender = dataLoadedStaff.GetString(4);
            newStaffMember.setMaritalStatus(dataLoadedStaff.GetString(5));
            maritalStatus = dataLoadedStaff.GetString(5);
            newStaffMember.setChildren(dataLoadedStaff.GetInt32(6));
            newStaffMember.setActive(dataLoadedStaff.GetString(7));

            string sqlSelectContact = "SELECT * FROM CONTACT WHERE STAFFID = " + staffId;

            OracleCommand cmdContact = new OracleCommand(sqlSelectContact, conn);
            OracleDataReader dataLoadedContact = cmdContact.ExecuteReader();

            dataLoadedContact.Read();

            newStaffMember.setEmail(dataLoadedContact.GetString(1));
            newStaffMember.setPhone(dataLoadedContact.GetString(2));
            newStaffMember.setStreet(dataLoadedContact.GetString(3));
            newStaffMember.setTown(dataLoadedContact.GetString(4));
            newStaffMember.setCounty(dataLoadedContact.GetString(5));
            newStaffMember.setEirCode(dataLoadedContact.GetString(6));

            string sqlSelectBanking = "SELECT * FROM BANKING WHERE STAFFID = " + staffId;

            OracleCommand cmdBanking = new OracleCommand(sqlSelectBanking, conn);
            OracleDataReader dataLoadedBanking = cmdBanking.ExecuteReader();

            dataLoadedBanking.Read();

            newStaffMember.setIban(dataLoadedBanking.GetString(1));
            
            return newStaffMember;
        }

        private void dtDob_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnRegisterStaff_Click(object sender, EventArgs e)
        {
            staffMember.setForeName(txtForename.Text);
            staffMember.setSurname(txtSurname.Text);
            staffMember.setDOB(dtDob.Value.ToString("yyyy-MM-dd"));
            staffMember.setMaritalStatus(maritalStatus);
            staffMember.setGender(gender);
            staffMember.setChildren(Convert.ToInt32(drpChildrenUpdate.Text));
            staffMember.setPhone(txtPhone.Text);
            staffMember.setEmail(txtEmail.Text);
            staffMember.setStreet(txtStreet.Text);
            staffMember.setTown(txtTown.Text);
            staffMember.setCounty(txtCounty.Text);
            staffMember.setEirCode(txtEircode.Text);
            staffMember.setIban(txtIbanUpdate.Text);

            staffMember.updateStaff();

            MessageBox.Show("Employee Details Updated! Returning Home", "Details Updated", MessageBoxButtons.OK);
            frmWelcomeScreen home = new frmWelcomeScreen();
            home.Show();
            this.Hide();
            
        }

        private void optMarried_CheckedChanged(object sender, EventArgs e)
        {
            if (optMarried.Checked)
                maritalStatus = "y";
            else
                maritalStatus = "n";
        }

        private void optGenderMale_CheckedChanged(object sender, EventArgs e)
        {
            if (optGenderMale.Checked)
                gender = "m";
            else
                gender = "f";
        }
    }
}
