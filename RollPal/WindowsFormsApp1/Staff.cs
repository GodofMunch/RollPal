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
        private DateTime dob;
        private string iban;
        private string maritalStatus;
        private int children;
        private string gender;
        private string active;

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
            dob = DateTime.Now;
            iban = "";
            maritalStatus = "n";
            children = 0;
            gender = "m";
            active = "n";

        }

        public Staff(int staffId, string forename, string surname, string phone, 
                     string email, string street, string town, string county, 
                     string eircode, DateTime dob, string gender, string iban, 
                     string maritalStatus, int children, string active)
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

        public DateTime getDOB()
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

        public void setDOB(DateTime dob)
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
            if (active == "y")
                this.active = "n";
            else if (active == "n")
                this.active = "y";
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

            //string dobFormatted = dob.ToString("yyyy-MM-dd HH:mm:ss");

            string strSqlStaff = "INSERT INTO STAFF VALUES (" + this.staffId +
                ",'" + this.forename + "','" + this.surname + "','" + this.dob.ToString("DD/Mon/YYYY HH:mm:ss") + "','" + this.gender + "','" +
                this.maritalStatus + "'," + this.children + ",'" + this.active + "')";


            string strSqlContact = "INSERT INTO CONTACT VALUES (" + this.staffId + ",'" + this.email + "','" +
                this.phone + "','" + this.street + "','" + this.town + "','" + this.county + "','" + this.eircode
                + "')";

            string strSqlBanking = "INSERT INTO BANKING VALUES (" + this.staffId + ",'" + this.iban + "')";
            
            OracleCommand cmdStaff = new OracleCommand(strSqlStaff, conn);
            OracleCommand cmdContact = new OracleCommand(strSqlContact, conn);
            OracleCommand cmdBanking = new OracleCommand(strSqlBanking, conn);

            cmdStaff.ExecuteNonQuery();
            cmdContact.ExecuteNonQuery();
            cmdBanking.ExecuteNonQuery();

            conn.Close();
        }
    }
}
