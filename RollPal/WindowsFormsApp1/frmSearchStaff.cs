using System;
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
    public partial class frmSearchStaff : Form
    {

        Staff searchMember = new Staff();
        int staffId;

        public frmSearchStaff()
        {
            InitializeComponent();

            for (int i = 1; i < Staff.nextStaffId(); i++)
            {
                cboSelectStaff.Items.Add("00" + i);
                
            }
        }

        private void cboSelectStaff_SelectedIndexChanged(object sender, EventArgs e)
        {
            staffId = Convert.ToInt32(cboSelectStaff.Text);
            

            searchMember = frmUpdateStaff.loadStaff(staffId);
            txtStaffId.Text = staffId.ToString("000");
            txtForename.Text = searchMember.getForename();
            txtSurname.Text = searchMember.getSurname();
            txtPhone.Text = searchMember.getPhone();
            txtTown.Text = searchMember.getTown();
            txtStreet.Text = searchMember.getStreet();
            txtCounty.Text = searchMember.getCounty();
            txtEmail.Text = searchMember.getEmail();
            txtEircode.Text = searchMember.getEirCode();
            txtChildren.Text = searchMember.getChildren().ToString();

            DateTime tempHolder = Convert.ToDateTime(searchMember.getDOB());
            txtDOB.Text = tempHolder.ToString("dd-MMM-yyyy");

            if (searchMember.getActive() == "y")
                lblInactive.Visible = false;
            else
                lblInactive.Visible = true;

            if (searchMember.getMaritalStatus() == "y")
                optMarried.Checked = true;
            else
                optSingle.Checked = true;

            if (searchMember.getGender() == "f")
                optGenderFemale.Checked = true;
            else
                optGenderMale.Checked = true;
           

            grpStaffDetails.Visible = true;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            frmWelcomeScreen home = new frmWelcomeScreen();
            home.Show();
            this.Hide();
        }
    }
}
