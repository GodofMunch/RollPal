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
    public partial class frmCreateTaxClause : Form
    {
        public frmCreateTaxClause()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            frmWelcomeScreen home = new frmWelcomeScreen();
            home.Show();
            this.Hide();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            var confirmTax = MessageBox.Show("You would like to add the the clause " +
                "\"U.S.C Grade A\" to to the database\n\n This clause deducts 1% of total " +
                "salary\"", "Create Tax", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(confirmTax == DialogResult.Yes)
            {
                var accepted = MessageBox.Show("You have added \"U.S.C Grade A\" to the Database", 
                    "Accept", MessageBoxButtons.OK);

                if(accepted == DialogResult.OK)
                {
                    frmWelcomeScreen home = new frmWelcomeScreen();
                    home.Show();
                    this.Hide();
                }

                else
                {
                    frmCreateTaxClause tax = new frmCreateTaxClause();
                    tax.Show();
                    this.Hide();
                }
            }
        }
    }
}
