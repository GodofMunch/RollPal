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
using System.Net.Mail;
using System.Net;

namespace WindowsFormsApp1
{
    public partial class frmGeneratePayRoll : Form
    {
        static int period = (DateTime.Now.DayOfYear / 7);
        double net;
        Staff member;
        double wageTotal = 0;
        public frmGeneratePayRoll()
        {
            InitializeComponent();
        }

        private void btnGenWages_Click(object sender, EventArgs e)
        {
            var genWages = MessageBox.Show("Would you like to approve wage bill for Period " + period +
                " with wages totalling " + wageTotal + " euro?", "Generate Wage Bill", MessageBoxButtons.YesNo,
                MessageBoxIcon.Exclamation);

            if(genWages == DialogResult.Yes)
            {

                sendEmail(wageTotal);
                var approved = MessageBox.Show("Wages have sent for Approval", "Sent", MessageBoxButtons.OK);

                if(approved == DialogResult.OK)
                {
                    frmWelcomeScreen home = new frmWelcomeScreen();
                    home.Show();
                    this.Hide();
                }

                else
                {
                    frmGeneratePayRoll payRollGen = new frmGeneratePayRoll();
                    payRollGen.Show();
                    this.Hide();
                }
            }
        }

        private void sendEmail(double wageTotal)
        {
            //got the code for this from youtube
            //https://www.youtube.com/watch?v=xHPil3iRkKM

            using (SmtpClient smtp = new SmtpClient())
            {
                smtp.Host = "smtp.mail.yahoo.com";
                smtp.UseDefaultCredentials = false;
                NetworkCredential netCred = new NetworkCredential("daveytheguitarist@yahoo.com", "Password90");
                smtp.Credentials = netCred;
                smtp.EnableSsl = true;
                smtp.Port = 587;
                

                using(MailMessage myEmail = new MailMessage("daveytheguitarist@yahoo.com", "david.osullivan5@students.ittralee.ie"))
                {
                    myEmail.Subject = "Wage Total for the week";
                    myEmail.Body = "Hi Dave, The wage bill this week is " + wageTotal + ". Please confirm the processing of this bill";
                    myEmail.IsBodyHtml = false;
                    MailAddress myGmail = new MailAddress("daveosullivan90@gmail.com");
                    /*MailAddress catherine = new MailAddress("catherine.woods@staff.ittralee.ie");
                    MailAddress anne = new MailAddress("anne.obrien@staff.ittralee.ie");
                    myEmail.CC.Add(catherine);
                    myEmail.CC.Add(anne);*/
                    myEmail.CC.Add(myGmail);
                    smtp.Send(myEmail);
                }
            }
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            frmWelcomeScreen payRollGen = new frmWelcomeScreen();
            payRollGen.Show();
            this.Hide();
        }

        private void frmGeneratePayRoll_Load(object sender, EventArgs e)
        {
            rtxtWageDetails.Text = "Staff ID\t\tName\t\tWages Owed\n\n";

            txtPeriod.Text = period.ToString();

                for(int i = 1; i < Staff.nextStaffId(); i ++)
            {
                member = frmUpdateStaff.loadStaff(i);
                net = getWeeklyNet(i);
                wageTotal += net;
                rtxtWageDetails.Text += member.getStaffId().ToString("000") + "\t\t" + member.getForename() +
                " " + member.getSurname() + "\t\t" + net.ToString() + "\n";
            }
        }

        public static double getWeeklyNet(int staffId)
        {
            string strSql = "SELECT WEEK" + period + " FROM STAFF_PAID WHERE STAFFID = " + staffId;

            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            OracleCommand cmdNet = new OracleCommand(strSql, conn);
            OracleDataReader dr = cmdNet.ExecuteReader();
            dr.Read();
            double net = dr.GetDouble(0);

            conn.Close();

            return net; 
        }
    }
}
