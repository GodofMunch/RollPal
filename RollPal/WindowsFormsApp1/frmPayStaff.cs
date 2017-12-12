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
    public partial class frmPayStaff : Form
    {
        public frmPayStaff()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnPayStaff_Click(object sender, EventArgs e)
        {
            var payStaffMsg = MessageBox.Show("Approve?", "Approval", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if(payStaffMsg == DialogResult.Yes)
            {
                var approvalMsg = MessageBox.Show("Thank You, Each employee has been " +
                    "paid and Payslips have been generated ans sent to the Staff", "Approved",
                    MessageBoxButtons.OK);

                if(approvalMsg == DialogResult.OK)
                {
                    frmWelcomeScreen home = new frmWelcomeScreen();
                    home.Show();
                    this.Hide();
                }
            }

            else
            {
                frmPayStaff payStaff = new frmPayStaff();
                payStaff.Show();
                this.Hide();
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            frmWelcomeScreen home = new frmWelcomeScreen();
            home.Show();
            this.Hide();
        }
    }
}
