using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace WindowsFormsApp1
{
    public class Staff
    {
        private int staffId;
        private string surname;
        private string forename;
        private string phone;
        private string email;
        private string street;
        private string town;
        private string county;
        private string eircode;
        private string dob;
        private string iban;
        private string maritalStatus;
        private int children;
        private string gender;
        private string active;
        private string payGrade;
        private string payeGrade;
        private string siptuGrade;
        private string prsiGrade;
        private string uscGrade;

        public Staff()
        {
            staffId = 000;
            forename = "";
            surname = "";
            phone = "";
            email = "";
            street = "";
            town = "";
            county = "";
            eircode = "";
            dob = DateTime.Now.ToString("YYYY-MM-DD");
            iban = "";
            maritalStatus = "n";
            children = 0;
            gender = "m";
            active = "n";
            payGrade = "a";
            payeGrade = "a";
            siptuGrade = "a";
            prsiGrade = "a";
            uscGrade = "a";

        }

        public Staff(int staffId, string forename, string surname, string phone,
                     string email, string street, string town, string county,
                     string eircode, string dob, string gender, string iban,
                     string maritalStatus, int children, string active, string payGrade,
                     string payeGrade, string prsiGrade, string uscGrade, string siptuGrade)
        {
            setStaffId(staffId);
            setForeName(forename);
            setSurname(surname);
            setPhone(phone);
            setEmail(email);
            setStreet(street);
            setTown(town);
            setCounty(county);
            setEirCode(eircode);
            setDOB(dob);
            setGender(gender);
            setIban(iban);
            setMaritalStatus(maritalStatus);
            setChildren(children);
            setActive("y");
            setPayGrade(payGrade);
            setPayeGrade(payeGrade);
            setSiptuGrade(siptuGrade);
            setPrsiGrade(prsiGrade);
            setUscGrade(uscGrade);
        }

        public int getStaffId()
        {
            return staffId;
        }

        public string getSurname()
        {
            return surname;
        }

        public string getForename()
        {
            return forename;
        }

        public string getPhone()
        {
            return phone;
        }

        public string getEmail()
        {
            return email;
        }

        public string getStreet()
        {
            return street;
        }

        public string getTown()
        {
            return town;
        }

        public string getCounty()
        {
            return county;
        }

        public string getEirCode()
        {
            return eircode;
        }

        public string getDOB()
        {
            return dob;
        }

        public string getIban()
        {
            return iban;
        }

        public string getMaritalStatus()
        {
            return maritalStatus;
        }

        public int getChildren()
        {
            return children;
        }

        public string getGender()
        {
            return gender;
        }

        public string getActive()
        {
            return active;
        }

        public string getPayGrade()
        {
            return payGrade;
        }

        public string getPayeGrade()
        {
            return payeGrade;
        }

        public string getPrsiGrade()
        {
            return prsiGrade;
        }

        public string getUscGrade()
        {
            return uscGrade;
        }

        public string getSiptuGrade()
        {
            return uscGrade;
        }

        public void setStaffId(int staffId)
        {
            this.staffId = staffId;
        }

        public void setForeName(string forename)
        {
            this.forename = forename;
        }

        public void setSurname(string surname)
        {
            int apostrophePlace = 0;
            string newSurname = "";

            if (surname.Contains("'"))
            {
                for (int i = 0; i < surname.Length; i++)
                {
                    if (surname[i].Equals('\''))
                        apostrophePlace = i;
                }
                
                for(int j = 0; j < surname.Length; j++)
                {
                    newSurname += surname[j];
                    if(apostrophePlace == j)
                    {
                        newSurname += "\'";
                    }
                }
                this.surname = newSurname;
            }
            else
                this.surname = surname;
        }

        public void setPhone(string phone)
        {
            this.phone = phone;
        }

        public void setEmail(string email)
		{
			this.email = email;
		}

        public void setStreet(string street)
        {
            this.street = street;
        }

		public void setTown(string town)
        {
            this.town = town;
        } 

        public void setCounty(string county)
        {
            this.county = county;
        }

        public void setEirCode(string eircode)
        {
            this.eircode = eircode;
        }

        public void setDOB(string dob)
        {
            this.dob = dob;
        }

        public void setIban(string iban)
        {
            this.iban = iban;
        }

        public void setMaritalStatus(string maritalStatus)
        {
            this.maritalStatus = maritalStatus;
        }

        public void setChildren(int children)
        {
            this.children = children;
        }


        public void setGender(string gender)
        {
            this.gender = gender;
        }

        public void setActive(string active)
        {
            if (active == "y" || active == "n")
                this.active = active;
        }

        public void setPayGrade(string payGrade)
        {
            this.payGrade = payGrade;
        }

        public void setPayeGrade(string payeGrade)
        {
            this.payeGrade = payeGrade;
        }

        public void setPrsiGrade(string prsiGrade)
        {
            this.prsiGrade = prsiGrade;
        } 

        public void setSiptuGrade(string siptuGrade)
        {
            this.siptuGrade = siptuGrade;
        }

        public void setUscGrade(string uscGrade)
        {
            this.uscGrade = uscGrade;
        }

        public static DataSet getStaff(DataSet ds, string type)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            string strsql = "SELECT * FROM STAFF ORDER BY " + type;

            OracleCommand cmd = new OracleCommand(strsql, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(ds, "ss");

            conn.Close();

            return ds;
        }

        public static int nextStaffId()
        {
            int nextStaffId;

            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            string strsql = "SELECT MAX(StaffId) FROM STAFF";

            OracleCommand cmd = new OracleCommand(strsql, conn);

            OracleDataReader dr = cmd.ExecuteReader();

            dr.Read();

            if (dr.IsDBNull(0))
                nextStaffId = 1;
            else
                nextStaffId = Convert.ToInt32(dr.GetValue(0)) + 1;

            conn.Close();

            return nextStaffId;
        }

        public void registerStaff()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();
            
            setActive("y");
            string strSqlStaff = "INSERT INTO STAFF VALUES (" + this.staffId +
                ",'" + this.forename + "','" + this.surname + "',DATE '" + this.dob + "','" + this.gender + "','" +
                this.maritalStatus + "','" + this.children + "','" + this.active + "','" + this.payGrade + "')";


            string strSqlContact = "INSERT INTO CONTACT VALUES (" + this.staffId + ",'" + this.email + "','" +
                this.phone + "','" + this.street + "','" + this.town + "','" + this.county + "','" + this.eircode
                + "')";

            string strSqlBanking = "INSERT INTO BANKING VALUES (" + this.staffId + ",'" + this.iban + "')";

            string strSqlStaffPaid = "INSERT INTO STAFF_PAID VALUES (" + this.staffId + ",";

            for (int i = 1; i <= 52; i++)
            {
                strSqlStaffPaid += "'N'";

                if (i != 52)
                    strSqlStaffPaid += ",";
            }

            strSqlStaffPaid += ")";


            string strSqlTaxation = "INSERT INTO TAXATION VALUES (" + this.staffId + ",'" +
                this.payeGrade + "','" + this.prsiGrade + "','" + this.siptuGrade + "','" + 
                this.uscGrade + "','" + this.payGrade + "')"; 
            
            OracleCommand cmdStaff = new OracleCommand(strSqlStaff, conn);
            OracleCommand cmdContact = new OracleCommand(strSqlContact, conn);
            OracleCommand cmdBanking = new OracleCommand(strSqlBanking, conn);
            OracleCommand cmdStaffPaid = new OracleCommand(strSqlStaffPaid, conn);
            OracleCommand cmdTaxation = new OracleCommand(strSqlTaxation, conn);

            cmdStaff.ExecuteNonQuery();
            cmdContact.ExecuteNonQuery();
            cmdBanking.ExecuteNonQuery();
            cmdStaffPaid.ExecuteNonQuery();
            cmdTaxation.ExecuteNonQuery();

            conn.Close();
        }

        public void updateStaff()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            string strSqlUpdateStaff = "UPDATE STAFF SET FORENAME = '" + this.forename + "', " +
                   "SURNAME = '" + this.surname + "', DATEOFBIRTH = DATE '" + this.dob + "', GENDER = '" +
                   this.gender + "', MARITALSTATUS = '" + this.maritalStatus + "', CHILDREN = " +
                   this.children + ", PAYGRADE = " + this.payGrade + "WHERE STAFFID = " + this.staffId;

            string strSqlUpdateContact = "UPDATE CONTACT SET EMAIL = '" + this.email + "', PHONE = '" +
                   this.phone + "', STREET = '" + this.street + "', TOWN = '" + this.town + "', COUNTY = '" +
                   this.county + "', EIRCODE = '" + this.eircode + "' WHERE STAFFID = " + this.staffId;

            string strSqlUpdateBanking = "UPDATE BANKING SET IBAN = '" + this.iban + "' WHERE STAFFID = " +
                   this.staffId;

            string strSqlUpdateTaxation = "UPDATE TAXATION SET PAYEGRADE = '" + this.payeGrade + 
                "',PRSIGRADE = '" + this.prsiGrade + "', SIPTUGRADE = '" + this.siptuGrade + 
                "', USCGRADE = '" + this.uscGrade + "', HOURLYRATE = '" + this.payGrade + "'";

            OracleCommand cmdStaff = new OracleCommand(strSqlUpdateStaff, conn);
            OracleCommand cmdContact = new OracleCommand(strSqlUpdateContact, conn);
            OracleCommand cmdBanking = new OracleCommand(strSqlUpdateBanking, conn);
            OracleCommand cmdTaxation = new OracleCommand(strSqlUpdateTaxation, conn);

            cmdStaff.ExecuteNonQuery();
            cmdContact.ExecuteNonQuery();
            cmdBanking.ExecuteNonQuery();
            cmdTaxation.ExecuteNonQuery();

            conn.Close();
        }
    }
}
