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
    public partial class welcomeScreen : Form
    {
        public welcomeScreen()
        {
            InitializeComponent();
        }

        private void registerStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            registerStaff regStaff = new registerStaff();
            regStaff.Show();
            this.Hide();
        }

        private void updateStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            updateStaff upStaff = new updateStaff();
            upStaff.Show();
            this.Hide();
        }

        private void deRegisterStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deRegisterStaff deregStaff = new deRegisterStaff();
            deregStaff.Show();
            this.Hide();
        }

        private void searchStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            searchStaff search = new searchStaff();
            search.Show();
            this.Hide();
        }
    }
}
