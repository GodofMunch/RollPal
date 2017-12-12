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
    public partial class frmBankingDetails : Form
    {
        public frmBankingDetails()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                txtSearch.Text = "David O'Sullivan";
            }

            else
            {
                txtSearch.Text = "001";
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            if (!txtSearch.Text.Equals(""))
            {
                btnDisplay.Enabled = true;
            }

            var display = MessageBox.Show("Display Banking Details for 001 - David O'Sullivan", 
                "Banking Details", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (display == DialogResult.Yes)
            {
                txtIBAN.Visible = true; 
            }
        }
    }
}
