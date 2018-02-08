﻿using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace WindowsFormsApp1
{
    class Staff
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

        public void setDOB(string dob)
        {
            this.dob = dob;
        }

        public void setIban(string iban)
        {
            this.iban = iban;
        }

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
            dob = "";
            iban = "";
        }
            
        public Staff(int staffId, string forename, string surname, string phone, string email, string street, string town, string county, string eircode, string dob, string iban)
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
            setIban(iban);
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

            string strsql = "SELECT MAX(staffId) FROM STAFF";

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

        }
    }
}