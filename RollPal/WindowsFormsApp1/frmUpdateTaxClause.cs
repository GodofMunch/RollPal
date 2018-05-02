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
    public partial class frmUpdateTaxClause : Form
    {
        public frmUpdateTaxClause()
        {
            InitializeComponent();
        }
        

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            var acceptUpdate = MessageBox.Show("Accept Changes?", "Accept",
                MessageBoxButtons.YesNo);

            if(acceptUpdate == DialogResult.Yes)
            {
                if (cboTaxClause.SelectedIndex == 0)
                {
                    string grade = cboUscGrade.Text;
                    double lowerLimit = Convert.ToDouble(txtLowerLimit.Text);
                    double upperLimit = Convert.ToDouble(txtUpperLimit.Text);
                    double percentage = Convert.ToDouble(txtPercent.Text);

                    writeUsc(grade, percentage, lowerLimit, upperLimit);
                }

                if(cboTaxClause.SelectedIndex == 1)
                {
                    string grade = cboPayeGrade.Text;
                    double cutoff = Convert.ToDouble(txtCutoff.Text);
                    double lowerPercentage = Convert.ToDouble(txtLowerPercent.Text);
                    double upperPercentage = Convert.ToDouble(txtUpperPercent.Text);

                    writePaye(grade, cutoff, lowerPercentage, upperPercentage);
                }

                if(cboTaxClause.SelectedIndex == 2)
                {
                    double percentage = Convert.ToDouble(txtPrsi.Text);

                    writePrsi(percentage);
                }

                if (cboTaxClause.SelectedIndex == 3)
                {
                    double siptu = Convert.ToDouble(txtSiptu.Text);
                }
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

        private void frmUpdateTaxClause_Load(object sender, EventArgs e)
        {
            cboTaxClause.Items.Add("U.S.C");
            cboTaxClause.Items.Add("PAYE");
            cboTaxClause.Items.Add("PRSI");
            cboTaxClause.Items.Add("SIPTU");

            cboTaxClause.SelectedIndex = 0;
            grpUsc.Visible = true;
            grpPaye.Visible = false;
            grpPrsi.Visible = false;
            grpSiptu.Visible = false;
            cboUscGrade.Items.Add("A");
            cboUscGrade.Items.Add("B");
            cboUscGrade.Items.Add("C");
            cboUscGrade.Items.Add("D");

            cboUscGrade.SelectedIndex = 0;

            cboPayeGrade.Items.Add("A");
            cboPayeGrade.Items.Add("B");
            cboPayeGrade.Items.Add("C");

            cboPayeGrade.SelectedIndex = 0;
        }

        private void cboUscGrade_SelectedIndexChanged(object sender, EventArgs e)
        {
            double[] uscDetails = new double[3];
            if (cboUscGrade.SelectedIndex == 0)
                uscDetails = getUscDetails("a");

            else if (cboUscGrade.SelectedIndex == 1)
                uscDetails = getUscDetails("b");

            else if (cboUscGrade.SelectedIndex == 2)
                uscDetails = getUscDetails("c");

            else if (cboUscGrade.SelectedIndex == 4)
                uscDetails = getUscDetails("d");

            txtPercent.Text = uscDetails[0].ToString();
            txtLowerLimit.Text = uscDetails[1].ToString();
            txtUpperLimit.Text = uscDetails[2].ToString();
        }

        private double[] getUscDetails(string grade)
        {
            double[] uscDetails = new double[3];

            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            string strSqlUsc = "SELECT * FROM USC WHERE USCGRADE = '" + grade + "'";

            OracleCommand cmdUsc = new OracleCommand(strSqlUsc, conn);
            OracleDataReader drUsc = cmdUsc.ExecuteReader();
            drUsc.Read();

            uscDetails[0] = drUsc.GetDouble(1);
            uscDetails[1] = drUsc.GetDouble(2);
            uscDetails[2] = drUsc.GetDouble(3);

            conn.Close();

            return uscDetails;

        }

        private static void writeUsc(string grade, double percent, double lowerLimit, double upperLimit)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();
            string strSqlUsc = "UPDATE USC SET PERCENTAGE = " + percent + ", LOWERLIMIT = " + lowerLimit + ", " +
                "UPPERLIMIT = " + upperLimit + " WHERE USCGRADE = '" + grade + "'";

            OracleCommand cmdUsc = new OracleCommand(strSqlUsc, conn);
            cmdUsc.ExecuteNonQuery();

            conn.Close();
         }

        private static void writePaye(string grade, double cutoff, double lower, double upper)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            string strSqlPaye = "UPDATE PAYE SET CUTOFF = " + cutoff + ", LOWERPERCENTAGE = " + lower +
                ", UPPERPERCENTAGE = " + upper + " WHERE PAYEGRADE = '" + grade + "'";

            OracleCommand cmdPaye = new OracleCommand(strSqlPaye, conn);
            cmdPaye.ExecuteNonQuery();

            conn.Close();
        } 

        private static void writePrsi(double percent)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            string strSqlPrsi = "UPDATE PRSI SET PERCENTAGE = " + percent;

            OracleCommand cmdPrsi = new OracleCommand(strSqlPrsi, conn);
            cmdPrsi.ExecuteNonQuery();

            conn.Close();
        }

        private static void writeSiptu(double siptu)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            string strSqlSiptu = "UPDATE SIPTU SET VALUE = " + siptu;

            OracleCommand cmdSiptu = new OracleCommand(strSqlSiptu, conn);
            cmdSiptu.ExecuteNonQuery();

            conn.Close();
        }

        private void cboTaxClause_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTaxClause.SelectedIndex == 0)
            {
                grpUsc.Visible = true;
                grpSiptu.Visible = false;
                grpPaye.Visible = false;
                grpPrsi.Visible = false;
            }

            if (cboTaxClause.SelectedIndex == 1)
            {
                grpPaye.Visible = true;
                grpSiptu.Visible = false;
                grpUsc.Visible = false;
                grpPrsi.Visible = false;
            }

            if (cboTaxClause.Text == "PRSI")
            {
                grpPrsi.Visible = true;
                grpSiptu.Visible = false;
                grpUsc.Visible = false;
                grpPaye.Visible = false;

                double prsiInfo = getPrsiInfo();
                txtPrsi.Text = prsiInfo.ToString();

            }

            if (cboTaxClause.SelectedIndex == 3)
            {
                grpSiptu.Visible = true;
                grpUsc.Visible = false;
                grpPaye.Visible = false;
                grpPrsi.Visible = false;

                double siptuInfo = getSiptuInfo();
                txtSiptu.Text = siptuInfo.ToString();
            }
            
        }

        public  static double[] getPayeInfo(string payeGrade)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            string strSqlPaye = "SELECT * FROM PAYE WHERE PAYEGRADE = '" + payeGrade + "'";

            OracleCommand cmdPaye = new OracleCommand(strSqlPaye, conn);
            OracleDataReader drPaye = cmdPaye.ExecuteReader();
            drPaye.Read();

            double[] paye = new double[3];
            paye[0] = drPaye.GetDouble(1);
            paye[1] = Convert.ToDouble(drPaye.GetInt32(2));
            paye[2] = Convert.ToDouble(drPaye.GetInt32(3));

            conn.Close();

            return paye;
        }

        private static double getPrsiInfo()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            string strSqlPrsi = "SELECT * FROM PRSI";

            OracleCommand cmdPrsi = new OracleCommand(strSqlPrsi, conn);
            OracleDataReader drPrsi = cmdPrsi.ExecuteReader();
            drPrsi.Read();
     
            double prsi = Convert.ToDouble(drPrsi.GetInt32(1));

            conn.Close();

            return prsi;
        }

        private static double getSiptuInfo()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            string strSqlSiptu = "SELECT * FROM SIPTU";

            OracleCommand cmdSiptu = new OracleCommand(strSqlSiptu, conn);
            OracleDataReader drSiptu = cmdSiptu.ExecuteReader();
            drSiptu.Read();

            double siptu = drSiptu.GetDouble(1);

            conn.Close();

            return siptu;
        }

        private void cboPayeGrade_SelectedIndexChanged(object sender, EventArgs e)
        {
            double[] paye = new double[3];

            if (cboPayeGrade.SelectedIndex == 0)
            {
                paye = getPayeInfo("a");
                txtCutoff.Text = paye[0].ToString();
                txtLowerPercent.Text = paye[1].ToString();
                txtUpperPercent.Text = paye[2].ToString();
            }

            if (cboPayeGrade.SelectedIndex == 1)
            {
                paye = getPayeInfo("b");
                txtCutoff.Text = paye[0].ToString();
                txtLowerPercent.Text = paye[1].ToString();
                txtUpperPercent.Text = paye[2].ToString();
            }

            if (cboPayeGrade.SelectedIndex == 2)
            {
                paye = getPayeInfo("c");
                txtCutoff.Text = paye[0].ToString();
                txtLowerPercent.Text = paye[1].ToString();
                txtUpperPercent.Text = paye[2].ToString();
            }
        }
    }
}
