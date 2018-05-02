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
using System.Net;
using System.Net.Mail;
namespace WindowsFormsApp1
{
    public partial class frmPayStaff : Form
    {
        private static int period = (DateTime.Now.DayOfYear / 7);
        

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
                    "paid and Payslips have been generated and sent to the Staff", "Approved",
                    MessageBoxButtons.OK);
                

                sendPayslips();
               
                if (approvalMsg == DialogResult.OK)
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

        private static void sendPayslips()
        {
            for (int i = 1; i < Staff.nextStaffId(); i++)
            {
                double wageTotal;
                string staffName;
                string staffEmail;

                bool active;

                //got the code for this from youtube
                //https://www.youtube.com/watch?v=xHPil3iRkKM

                using (SmtpClient smtp = new SmtpClient())
                {
                    wageTotal = getWageTotal(i);
                    staffName = getStaffName(i);
                    staffEmail = getStaffEmail(i);
                    active = getStaffActive(i);

                    if (active)
                    {
                        smtp.Host = "smtp.mail.yahoo.com";
                        smtp.UseDefaultCredentials = false;
                        NetworkCredential netCred = new NetworkCredential("daveytheguitarist@yahoo.com", "Password90");
                        smtp.Credentials = netCred;
                        smtp.EnableSsl = true;
                        smtp.Port = 587;


                        using (MailMessage myEmail = new MailMessage("daveytheguitarist@yahoo.com", staffEmail))
                        {
                            myEmail.Subject = "Payslip for Period " + period;
                            myEmail.Body = "Dear " + staffName + ", YOUR Net Wage for this week is " + wageTotal + ". Thank you very much";
                            myEmail.IsBodyHtml = false;
                            smtp.Send(myEmail);
                        }
                    }
                }
            }
        }

        private static double getWageTotal(int staffId)
        {
            int period = (DateTime.Now.DayOfYear / 7);

            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            string strSqlStaffPaid = "SELECT WEEK" + period + " FROM STAFF_PAID WHERE STAFFID = " + staffId;

            OracleCommand cmdWage = new OracleCommand(strSqlStaffPaid, conn);
            OracleDataReader drWage = cmdWage.ExecuteReader();
            drWage.Read();

            double wage = drWage.GetDouble(0);

            conn.Close();

            return wage;
        }

        private static string getStaffName(int staffId)
        {
            string name;

            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            string strSqlStaff = "SELECT FORENAME , SURNAME FROM STAFF WHERE STAFFID = " + staffId;

            OracleCommand cmdStaff = new OracleCommand(strSqlStaff, conn);
            OracleDataReader drStaff = cmdStaff.ExecuteReader();
            drStaff.Read();

            string forename = drStaff.GetString(0);
            string surname = drStaff.GetString(1);

            name = forename + " " + surname;
            conn.Close();

            return name;

        }

        private static string getStaffEmail(int staffId)
        {
            string email;

            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            string strSqlStaff = "SELECT EMAIL FROM CONTACT WHERE STAFFID = " + staffId;

            OracleCommand cmdStaff = new OracleCommand(strSqlStaff, conn);
            OracleDataReader drStaff = cmdStaff.ExecuteReader();
            drStaff.Read();

            email = drStaff.GetString(0);
            
            conn.Close();

            return email;
        }

        private static bool getStaffActive(int staffId)
        {
            string active;

            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            string strSqlStaff = "SELECT ACTIVE FROM STAFF WHERE STAFFID = " + staffId;

            OracleCommand cmdStaff = new OracleCommand(strSqlStaff, conn);
            OracleDataReader drStaff = cmdStaff.ExecuteReader();
            drStaff.Read();

            active = drStaff.GetString(0);
            
            conn.Close();

            if (active == "y")
                return true;
            else
                return false;
        }
    }
}
