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

        private void rtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            

            var proceed = MessageBox.Show("Approve hours for Staff number 001?",
                "Approve Times", MessageBoxButtons.YesNo);

            if(proceed == DialogResult.Yes)
            {
                rtxt.Text = "002";
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

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click_1(object sender, EventArgs e)
        {

        }

        private void frmEnterTimeSheet_Load(object sender, EventArgs e)
        {
            for (int i = 1; i < Staff.nextStaffId(); i++)
            {
                cboTimesheetSelect.Items.Add("00" + i);
                
            }
            staffToDo[1] = "1";
            rtxt.AppendText(staffToDo[1] + "\n");
        }
    }
}
