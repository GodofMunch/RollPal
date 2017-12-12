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
    public partial class frmRemoveTaxationClause : Form
    {
        public frmRemoveTaxationClause()
        {
            InitializeComponent();
        }

        private void btnDeRegTax_Click(object sender, EventArgs e)
        {
            var deactivate = MessageBox.Show("Are you sure you would like to deactivate this?",
                "De-Activate Taxation", MessageBoxButtons.YesNo);

            if(deactivate == DialogResult.Yes)
            {
                var accept = MessageBox.Show("Returning Home!", "Dome!",
                    MessageBoxButtons.OK);

                if(accept == DialogResult.OK)
                {
                    frmWelcomeScreen home = new frmWelcomeScreen();
                    home.Show();
                    this.Hide();
                }

                else
                {
                    frmRemoveTaxationClause removeTax = new frmRemoveTaxationClause();
                    removeTax.Show();
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
