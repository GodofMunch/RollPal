using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
namespace WindowsFormsApp1
{
    public partial class frmPayStaff : Form
    {
        int period = (DateTime.Now.DayOfYear / 7);

        public frmPayStaff()
        {
            InitializeComponent();
        }
        

        private void btnPayStaff_Click(object sender, EventArgs e)
        {
            var payStaffMsg = MessageBox.Show("Approve?", "Approval", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if(payStaffMsg == DialogResult.Yes)
            {
                var approvalMsg = MessageBox.Show("Thank You, Each employee has been " +
                    "paid and Payslips have been generated ans sent to the Staff", "Approved",
                    MessageBoxButtons.OK);

                if(approvalMsg == DialogResult.OK)
                {
                    System.Diagnostics.Process.Start("https://digital.ulsterbank.ie/business/accounts-and-services/business-current-accounts.html");
                    MessageBox.Show(displayBankingDetails());
                    frmWelcomeScreen home = new frmWelcomeScreen();
                    home.Show();
                    this.Hide();
                }
            }

            else
            {
                frmPayStaff payStaff = new frmPayStaff();
                payStaff.Show();
                this.Hide();
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            frmWelcomeScreen home = new frmWelcomeScreen();
            home.Show();
            this.Hide();
        }

        private void frmPayStaff_Load(object sender, EventArgs e)
        {
            txtApprovalBy.Text = "David O'Sullivan";
            txtPeriod.Text = period.ToString();
            txtTotalAmount.Text = getTotalWage();
        }

        private string getTotalWage()
        {
            double total = 0;
            for(int i = 1; i < Staff.nextStaffId(); i ++)
            {
                total += frmGeneratePayRoll.getWeeklyNet(i);
            }
            return total.ToString("00000.00");
        }

        private string displayBankingDetails()
        {
            string iban;
            string wage;
            string text = "\tIBAN\t\t\tAmount";
            for (int i = 1; i < Staff.nextStaffId(); i++)
            {
                string strSqlBanking = "SELECT IBAN FROM BANKING WHERE STAFFID = " + i;
                string strSqlNetWage = "SELECT WEEK" + period + " FROM STAFF_PAID WHERE STAFFID = " + i;
                OracleConnection conn = new OracleConnection(DBConnect.oradb);
                conn.Open();
                
                OracleCommand cmdBanking = new OracleCommand(strSqlBanking, conn);
                OracleCommand cmdStaffPaid = new OracleCommand(strSqlNetWage, conn);

                OracleDataReader drBanking = cmdBanking.ExecuteReader();
                OracleDataReader drStaffPaid = cmdStaffPaid.ExecuteReader();

                drBanking.Read();
                iban = drBanking.GetString(0);

                drStaffPaid.Read(); 
                wage = drStaffPaid.GetDouble(0).ToString();

                text += "\n" + iban + "\t\t" + wage;

            }
            return text;
        }
    }
}
