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
    public partial class frmUpdateTaxClause : Form
    {
        public frmUpdateTaxClause()
        {
            InitializeComponent();
        }

        private void cboTaxType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboTaxClause_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboTaxType.Text = "Percentage";
            txtAmount.Text = "1%";
            cboOf.Text = "Total Salary";
            txtAmount2.Text = "100%";
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            var acceptUpdate = MessageBox.Show("Accept Changes?", "Accept",
                MessageBoxButtons.YesNo);

            if(acceptUpdate == DialogResult.Yes)
            {
                var accepted = MessageBox.Show("Returning Home", "Done!", MessageBoxButtons.OK);

                if(accepted == DialogResult.OK)
                {
                    frmWelcomeScreen home = new frmWelcomeScreen();
                    home.Show();
                    this.Hide();
                }
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
