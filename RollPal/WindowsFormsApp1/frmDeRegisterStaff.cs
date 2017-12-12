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
    public partial class frmDeRegisterStaff : Form
    {
        public frmDeRegisterStaff()
        {
            InitializeComponent();
        }

        private void btnRegisterStaff_Click(object sender, EventArgs e)
        {
            var warning = MessageBox.Show("Are you sure you want to De- Resister" +
                " this Employee? They will no longer be paid or receive " +
                "communication from the company.", "De-Register Employee",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (warning == DialogResult.Yes)
            {
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

        private void cboSelectStaff_SelectedIndexChanged(object sender, EventArgs e)
        {
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
