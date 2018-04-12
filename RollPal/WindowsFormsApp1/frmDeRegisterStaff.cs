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
    public partial class frmDeRegisterStaff : Form
    {

        int staffId;
        Staff deRegStaffMember = new Staff();

        public frmDeRegisterStaff()
        {
            InitializeComponent();
        }

        private void btnRegisterStaff_Click(object sender, EventArgs e)
        {
            if (deRegStaffMember.getActive() == "y")
            {
                var warning = MessageBox.Show("Are you sure you want to De- Resister" +
                    " this Employee? They will no longer be paid or receive " +
                    "communication from the company.", "De-Register Employee",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (warning == DialogResult.Yes)
                {
                    deRegStaffMember.setActive("n");
                    deRegStaff();
                    var home = MessageBox.Show("Employee has been De-Registered",
                        "De-Register Employee", MessageBoxButtons.OK);

                    if (home == DialogResult.OK)
                    {
                        frmWelcomeScreen returnHome = new frmWelcomeScreen();
                        returnHome.Show();
                        this.Hide();
                    }
                }

                else
                {
                    frmDeRegisterStaff back = new frmDeRegisterStaff();
                    back.Show();
                    this.Hide();
                }
            }
            else
            {
                var warning = MessageBox.Show("This Staff Member is already De-Registered, " +
                              "Are you sure you want to Re-Register this Employee? They will " +
                              "once again become available to be paid and will receive " +
                              "communications from the company?", "Re-Register Employee",
                              MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (warning == DialogResult.Yes)
                {
                    MessageBox.Show("Employee has been re-registered on the system",
                        "Re-Register Employee", MessageBoxButtons.OK);
                    deRegStaffMember.setActive("y");
                    deRegStaff();
                    frmWelcomeScreen home = new frmWelcomeScreen();
                    home.Show();
                    this.Hide();
                }

                else
                {
                    frmDeRegisterStaff back = new frmDeRegisterStaff();
                    back.Show();
                    this.Hide();
                }
            }
        }

        private void cboSelectStaff_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(cboSelectStaff.Text) >= 1 &&
                Convert.ToInt32(cboSelectStaff.Text) < Staff.nextStaffId())
            {
                staffId = Convert.ToInt32(cboSelectStaff.Text);

                deRegStaffMember = frmUpdateStaff.loadStaff(staffId);

                txtStaffId.Text = deRegStaffMember.getStaffId().ToString("000");
                txtForename.Text = deRegStaffMember.getForename();
                txtSurname.Text = deRegStaffMember.getSurname();
                txtPhone.Text = deRegStaffMember.getPhone();
                txtStreet.Text = deRegStaffMember.getStreet();
                txtTown.Text = deRegStaffMember.getTown();
                txtCounty.Text = deRegStaffMember.getCounty();
                txtEmail.Text = deRegStaffMember.getEmail();
                txtEircode.Text = deRegStaffMember.getEirCode();
                txtIban.Text = deRegStaffMember.getIban();

                if (deRegStaffMember.getMaritalStatus() == "y")
                    optMarried.Checked = true;
                else if (deRegStaffMember.getMaritalStatus() == "n")
                    optSingle.Checked = true;

                if (deRegStaffMember.getGender() == "m")
                    optGenderMale.Checked = true;
                else if (deRegStaffMember.getGender() == "f")
                    optGenderFemale.Checked = true;

                dtDob.Value = Convert.ToDateTime(deRegStaffMember.getDOB());

                txtChildren.Text = deRegStaffMember.getChildren().ToString();

                if (deRegStaffMember.getActive() == "y")
                {
                    lblInactive.Visible = false;
                    btnRegisterStaff.Text = "De-Register";
                }
                else if (deRegStaffMember.getActive() == "n")
                {
                    lblInactive.Visible = true;
                    btnRegisterStaff.Text = "Re-Register";
                }
                grpStaffDetails.Visible = true;
                

            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            frmWelcomeScreen home = new frmWelcomeScreen();
            home.Show();
            this.Hide();
        }

        private void frmDeRegisterStaff_Load(object sender, EventArgs e)
        {
            for (int i = 1; i < Staff.nextStaffId(); i++)
                cboSelectStaff.Items.Add("00" + i);
        }

        private void deRegStaff()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            string active;

            if (deRegStaffMember.getActive() == "y")
                active = "y";
            else
                active = "n";

                string sqlChangeActive = "UPDATE STAFF SET ACTIVE = '" + 
                                         active +  "' WHERE STAFFID = " + staffId;
            OracleCommand cmdStaff = new OracleCommand(sqlChangeActive, conn);

            cmdStaff.ExecuteNonQuery();

            conn.Close();
        }

    }
}
