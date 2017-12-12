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
    public partial class frmQueryPayroll : Form
    {
        public frmQueryPayroll()
        {
            InitializeComponent();
            rtxtWageDetails.Text = "Staff ID\t\tName\t\tHours Worked\t\tWages Paid\n\n" +
                "001\t\tDavid O'Sullivan\t\t48\t\t567.78\n";
                
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
    }
}
