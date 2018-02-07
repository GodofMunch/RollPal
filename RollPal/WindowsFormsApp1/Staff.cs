using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            this.phone = phone
        }
            
    }
}
