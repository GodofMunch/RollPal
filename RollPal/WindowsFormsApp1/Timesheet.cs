using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace WindowsFormsApp1
{
    class Timesheet
    {
        private double weekdayHours;
        private double sundayHours;
        private double overtimeHours;
        private double travelHours;
        private double totalWage;
        private bool isDriver;
        Staff staffToBeTaxed;


        public double[] calculateWages(Staff member)
        {
            double gross = 0;
            double[] net = new double[6];
            double hourlyWage;
            string payGrade = member.getPayGrade();
            staffToBeTaxed = member;
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            string sqlPayGrade = "SELECT VALUE FROM RATE WHERE HOURLYRATE = '" + member.getPayGrade() + "'";
            OracleCommand cmdRate = new OracleCommand(sqlPayGrade, conn);
            OracleDataReader data = cmdRate.ExecuteReader();
            data.Read();
            hourlyWage = data.GetDouble(0);

            string sqlPayMultipliers = "SELECT * FROM PAY_MULTIPLIERS";
            OracleCommand cmdPayMultipliers = new OracleCommand(sqlPayMultipliers, conn);
            OracleDataReader multipliers = cmdPayMultipliers.ExecuteReader();
            multipliers.Read();
            double overtimeMultiplier = multipliers.GetDouble(0);
            double sundayMultiplier = multipliers.GetDouble(1);
            double driverMultiPlier = multipliers.GetDouble(2);
            double passengerMultiPlier = multipliers.GetDouble(3);

            gross = weekdayHours * hourlyWage;

            gross += overtimeHours * (hourlyWage * overtimeMultiplier);

            gross += sundayHours * (hourlyWage * sundayMultiplier);

            if (this.isDriver)
                gross += travelHours * (hourlyWage * driverMultiPlier);
            else
                gross += travelHours * (hourlyWage * passengerMultiPlier);

            net = calculateTax(gross);

            net[1] = gross;

            return net;
        }

        private double[] calculateTax(double gross)
        {
            double[] netAndTaxes = new double[6];
            double net = 0;
            double totalTaxes = 0;

            double taxCredits = 0;

            if (staffToBeTaxed.getPayeGrade() == "a")
                taxCredits = 1650.00;
            else
                taxCredits = 3300.00;

            double weeklyTaxCredits = taxCredits / 52;

            double paye = calculatePaye(gross);
            double siptu = calculateSiptu(gross);
            double usc = calculateUsc(gross);
            double prsi = calculatePrsi(gross);


            totalTaxes = (usc + paye + prsi) - weeklyTaxCredits;
            totalTaxes += siptu;

            if (totalTaxes > 0)
                net = gross - totalTaxes;
            else
                net = gross;

            netAndTaxes[0] = net;
            //netAndTaxes[1] will soon become gross
            netAndTaxes[2] = usc;
            netAndTaxes[3] = siptu;
            netAndTaxes[4] = paye;
            netAndTaxes[5] = prsi;

            return netAndTaxes;
        }

        private double calculatePaye(double gross)
        {
            double paye = 0;
            double upperLimit = 0;

            
            int lowerPercent;
            int upperPercent;
            
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();
            string strSql = "SELECT * FROM PAYE WHERE PAYEGRADE = '" + staffToBeTaxed.getPayeGrade() + "'";
            OracleCommand cmdPaye = new OracleCommand(strSql, conn);
            OracleDataReader drPaye = cmdPaye.ExecuteReader();
            drPaye.Read();

            upperLimit = drPaye.GetDouble(1);
            lowerPercent = drPaye.GetInt32(2);
            upperPercent = drPaye.GetInt32(3);

            conn.Close();

            upperLimit = upperLimit / 52;
            double lowerPercentDouble = (double)lowerPercent / 100;
            double upperPercentDouble = (double)upperPercent / 100;

            if (gross >= upperLimit)
            {
                paye += upperLimit * lowerPercentDouble;
                paye = (gross - upperLimit) * upperPercentDouble;
            }
            else
                paye = gross * lowerPercentDouble;
            

            return paye;
           
        }

        private double calculateSiptu(double gross)
        {
            double siptuCost;

            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            string strSqlSiptu = "SELECT VALUE FROM SIPTU WHERE SIPTUGRADE = '" + staffToBeTaxed.getSiptuGrade() + "'";

            OracleCommand cmdSiptu = new OracleCommand(strSqlSiptu, conn);
            OracleDataReader drSiptu = cmdSiptu.ExecuteReader();
            drSiptu.Read();
            siptuCost = drSiptu.GetDouble(0);

            conn.Close();

            return siptuCost;
        }

        private double calculateUsc(double gross)
        {

            string[] uscGrades = { "a", "b", "c", "d" };
            double[] upperLimits = getUscLimits(uscGrades);
            
            double employeesUscBand = 0;

            for (int j = uscGrades.Length - 1; j >= 0; j--)
            {
                if (gross <= (upperLimits[j] * 52))
                {
                    employeesUscBand = upperLimits[j];
                    staffToBeTaxed.setUscGrade(uscGrades[j]);
                }
            }
 
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            string strSqlUpdateUsc = "UPDATE TAXATION SET USCGRADE = '" + staffToBeTaxed.getUscGrade() +
                "' WHERE STAFFID = " + staffToBeTaxed.getStaffId();

            OracleCommand cmdTaxation = new OracleCommand(strSqlUpdateUsc, conn);
            cmdTaxation.ExecuteNonQuery();
            conn.Close();

            double[] percentageOfUscs = getUscPercentages();
            double[] lowerLimits = new double[4];

            
            for (int i = 0; i < upperLimits.Length; i++)
            {
                upperLimits[i] = upperLimits[i] / 52;
               
                percentageOfUscs[i] = percentageOfUscs[i] / 100;
            }
            for (int k = 0; k < lowerLimits.Length; k++)
            {
                if (k == 0)
                    lowerLimits[k] = 0;
                else
                    lowerLimits[k] = upperLimits[k - 1] + 0.01;

            }

            double uscTotal = 0;
            if (gross > upperLimits[0])
            {
                uscTotal = upperLimits[0] * percentageOfUscs[0];

                if (gross > upperLimits[1])
                {
                    uscTotal += (upperLimits[1] - lowerLimits[1]) * percentageOfUscs[1];

                    if (gross > upperLimits[2])
                    {
                        uscTotal += upperLimits[2] - lowerLimits[2] * percentageOfUscs[2];

                        if (gross > upperLimits[3])
                            uscTotal += gross - lowerLimits[3] * percentageOfUscs[3];
                    }
                    else
                        uscTotal += (gross - lowerLimits[2]) * percentageOfUscs[2];
                }
                else
                    uscTotal += (gross - lowerLimits[1]) * percentageOfUscs[1];
            }
            else
                uscTotal = 0;

            return uscTotal;
        }

        private double calculatePrsi(double gross)
        {

            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            string strSqlPrsi = "SELECT PERCENTAGE FROM PRSI WHERE PRSIGRADE = '" + staffToBeTaxed.getPrsiGrade() + "'";

            OracleCommand cmdPrsi = new OracleCommand(strSqlPrsi, conn);

            OracleDataReader drPrsi = cmdPrsi.ExecuteReader();
            drPrsi.Read();

            double percentage = drPrsi.GetDouble(0);
            percentage = percentage / 100;

            double prsi = gross * percentage;

            return prsi;
        }

        private double[] getUscLimits(string [] uscGrades)
        {

            double[] uLimits = new double[uscGrades.Length];
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();
            
            for(int i = 0; i < uscGrades.Length; i ++)
            {
                string strSqlUsc = "SELECT UPPERLIMIT FROM USC WHERE USCGRADE = '" + uscGrades[i] + "'";
                OracleCommand cmdUsc = new OracleCommand(strSqlUsc, conn);
                OracleDataReader drUsc = cmdUsc.ExecuteReader();
                drUsc.Read();

                uLimits[i] = drUsc.GetDouble(0);
            }
            conn.Close();
            return uLimits;

        }

        private double[] getUscPercentages()
        {
            double[] uscPercentages = new double[4];
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            conn.Open();

            string[] grades = { "a", "b", "c", "d" };

            for (int i = 0; i < grades.Length; i++)
            {
                string strSqlUsc = "SELECT PERCENTAGE FROM USC WHERE USCGRADE = '" + grades[i] + "'";
                OracleCommand cmdUsc = new OracleCommand(strSqlUsc, conn);
                OracleDataReader drUsc = cmdUsc.ExecuteReader();
                drUsc.Read();

                uscPercentages[i] = drUsc.GetDouble(0);
            }
            
            conn.Close();
            return uscPercentages;
        }

        private double getAverageWage(double gross)
        {
            int weeksPaid = 0;
            int i = 3;
            double averageWage = 0;
            double expectedSalary = gross * 52;

            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            string strSqlGetUsc = "SELECT * FROM STAFF_PAID WHERE STAFFID = " + staffToBeTaxed.getStaffId();
            OracleCommand cmdStaffPaid = new OracleCommand(strSqlGetUsc, conn);
            OracleDataReader drStaffPaid = cmdStaffPaid.ExecuteReader();
            drStaffPaid.Read();


            for (i = 3; i < 55; i++)
            {
                if (drStaffPaid.GetDouble(i) != 0)
                    weeksPaid++;
            }

            if (weeksPaid > 4)
            {
                averageWage = drStaffPaid.GetDouble(1) / weeksPaid;
            }

            else
                averageWage = gross;

            return averageWage;
        }

        public Timesheet()
        {
            setWeekDayHours(0);
            setSundayHours(0);
            setOverTimeHours(0);
            setTravelHours(0);
            setTotalWage(0);
            setIsDriver(false);
        }

        public Timesheet(double week, double sun, double over, double travel, 
                         double totalWage, bool isDriver)
        {
            setWeekDayHours(week);
            setSundayHours(sun);
            setOverTimeHours(over);
            setTravelHours(travel);
            setTotalWage(totalWage);
            setIsDriver(isDriver);
        }

        public void setWeekDayHours(double week)
        {
            this.weekdayHours = week;
        }

        public void setSundayHours(double sun)
        {
            this.sundayHours = sun;
        }

        public void setOverTimeHours(double overtime)
        {
            this.overtimeHours = overtime;
        }

        public void setTravelHours(double travel)
        {
            this.travelHours = travel;
        }

        public void setTotalWage(double wage)
        {
            this.totalWage = wage;
        }

        public void setIsDriver(bool isDriver)
        {
            this.isDriver = isDriver;
        }

        public double getWeekdayHours ()
        {
            return  weekdayHours;
        }

        public double getSundayHours()
        {
            return sundayHours;
        }

        public double getOvertimeHours()
        {
            return overtimeHours;
        }

        public double getTravelHours()
        {
            return travelHours;
        }

        public double getTotalWage()
        {
            return totalWage;
        }

        public bool getisDriver()
        {
            return isDriver;
        }
    }
}
