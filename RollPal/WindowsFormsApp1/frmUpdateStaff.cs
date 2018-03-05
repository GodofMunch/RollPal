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
        public Staff staffMember = new Staff();

        public frmUpdateStaff()
        {
            InitializeComponent();
        }

        private void cboSelectStaff_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSelectStaff.Text != "<null>")
            {
                staffMember = loadStaff(Convert.ToInt32(cboSelectStaff.Text));
                txtStaffId.Text = staffMember.getStaffId().ToString("000");
                txtForename.Text = staffMember.getForename();
                txtSurname.Text = staffMember.getSurname();
                txtPhone.Text = staffMember.getPhone();
                txtEmail.Text = staffMember.getEmail();
                txtStreet.Text = staffMember.getStreet();
                txtTown.Text = staffMember.getTown();
                txtCounty.Text = staffMember.getCounty();
                txtEircode.Text = staffMember.getEirCode();
                txtDOB.Text = staffMember.getDOB();

                if (staffMember.getMaritalStatus() == 'y')
                    optMarried.Checked = true;
                else
                    optSingle.Checked = true;

                if (staffMember.getGender() == 'm')
                    optGenderMale.Checked = true;
                else
                    optGenderFemale.Checked = true;


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

            Staff newStaffMember = new Staff();

            newStaffMember.setStaffId(staffId);
            newStaffMember.setForeName(dataLoadedStaff.GetString(1));
            newStaffMember.setSurname(dataLoadedStaff.GetString(2));
            newStaffMember.setDOB(dataLoadedStaff.GetString(3));
            newStaffMember.setGender(dataLoadedStaff.GetChar(4));
            newStaffMember.setMaritalStatus(dataLoadedStaff.GetChar(5));
            newStaffMember.setChildren(dataLoadedStaff.GetInt32(6));
            newStaffMember.setActive(dataLoadedStaff.GetChar(7));

            string sqlSelectContact = "SELECT * FROM CONTACT WHERE STAFFID = " + staffId;

            OracleCommand cmdContact = new OracleCommand(sqlSelectContact, conn);
            OracleDataReader dataLoadedContact = cmdContact.ExecuteReader();

            newStaffMember.setEmail(dataLoadedContact.GetString(1));
            newStaffMember.setPhone(dataLoadedContact.GetString(2));
            newStaffMember.setStreet(dataLoadedContact.GetString(3));
            newStaffMember.setTown(dataLoadedContact.GetString(4));
            newStaffMember.setCounty(dataLoadedContact.GetString(5));
            newStaffMember.setEirCode(dataLoadedContact.GetString(6));

            string sqlSelectBanking = "SELECT * FROM BANKING WHERE STAFFID =" + staffId;

            OracleCommand cmdBanking = new OracleCommand(sqlSelectBanking, conn);
            OracleDataReader dataLoadedBanking = cmdBanking.ExecuteReader();

            newStaffMember.setIban(dataLoadedBanking.GetString(1));
            
            return newStaffMember;
        }
        public void updateStaff()
        {


        }
        public void setTextToBeUpdated(int staffId)
        {

        }
    }
}
