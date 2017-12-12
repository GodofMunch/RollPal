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
    public partial class frmPrintP60 : Form
    {
        public frmPrintP60()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void receiveEnter(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnPrintP60_Click(object sender, EventArgs e)
        {

            if (!txtSearch.Text.Equals(""))
            {
                btnPrintP60.Enabled = true;
            }

            var print = MessageBox.Show("Print p60 for 001 - David O'Sullivan", "Print p60", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if(print == DialogResult.Yes)
            {
                var confirm = MessageBox.Show("Thank you!", "Done!", MessageBoxButtons.OK);

                if(confirm == DialogResult.OK)
                {
                    frmWelcomeScreen home = new frmWelcomeScreen();
                    home.Show();
                    this.Hide();
                }

                else
                {
                    frmPrintP60 newPrint = new frmPrintP60();
                    newPrint.Show();
                    this.Hide();
                }
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton2.Checked == true)
            {
                txtSearch.Text = "David O'Sullivan";
            }

            else
            {
                txtSearch.Text = "001";
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
