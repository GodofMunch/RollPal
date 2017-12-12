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
    public partial class updateStaff : Form
    {
        public updateStaff()
        {
            InitializeComponent();
        }

        private void cboSelectStaff_SelectedIndexChanged(object sender, EventArgs e)
        {
            grpStaffDetails.Visible = true;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            welcomeScreen home = new welcomeScreen();
            home.Show();
            this.Hide();
        }
    }
}
