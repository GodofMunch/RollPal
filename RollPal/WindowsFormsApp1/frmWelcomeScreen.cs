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
    public partial class frmWelcomeScreen : Form
    {
        public frmWelcomeScreen()
        {
            InitializeComponent();
        }

        private void registerStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegisterStaff regStaff = new frmRegisterStaff();
            regStaff.Show();
            this.Hide();
        }

        private void updateStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpdateStaff upStaff = new frmUpdateStaff();
            upStaff.Show();
            this.Hide();
        }

        private void deRegisterStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDeRegisterStaff deregStaff = new frmDeRegisterStaff();
            deregStaff.Show();
            this.Hide();
        }

        private void searchStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSearchStaff search = new frmSearchStaff();
            search.Show();
            this.Hide();
        }

        private void enterTimesheetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEnterTimeSheet enterTimes = new frmEnterTimeSheet();
            enterTimes.Show();
            this.Hide();
        }

        private void generatePayrollToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGeneratePayRoll payRollGen = new frmGeneratePayRoll();
            payRollGen.Show();
            this.Hide();
        }

        private void payStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPayStaff payStaff = new frmPayStaff();
            payStaff.Show();
            this.Hide();
        }

        private void queryPayRollToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQueryPayroll query = new frmQueryPayroll();
            query.Show();
            this.Hide();
        }

        private void createTaxationClauseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCreateTaxClause newTax = new frmCreateTaxClause();
            newTax.Show();
            this.Hide();
        }

        private void updateTaxationClauseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpdateTaxClause upTax = new frmUpdateTaxClause();
            upTax.Show();
            this.Hide();
        }

        private void removeTaxationClauseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRemoveTaxationClause removeTax = new frmRemoveTaxationClause();
            removeTax.Show();
            this.Hide();
        }

        private void printP60ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrintP60 print = new frmPrintP60();
            print.Show();
            this.Hide();
        }

        private void bankingDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBankingDetails banking = new frmBankingDetails();
            banking.Show();
            this.Hide();
        }
    }
}
