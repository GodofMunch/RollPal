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
    public partial class frmRegisterStaff : Form
    {

        string forename = "";
        string surname = "";
        string phone = "";
        string email = "";
        string street = "";
        string town = "";
        string county = "";
        string eirCode = "";
        string dob = DateTime.Now.ToString("yyyy-MM-dd");
        string iban = "";
        string maritalStatus = "n";
        int children = 0;
        string gender = "m";
        string active = "n";

        public frmRegisterStaff()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void registerStaff_Load(object sender, EventArgs e)
        {
         
            txtStaffID.Text = Staff.nextStaffId().ToString("000");
            dob = DateTime.Now.ToString("yyyy-MM-dd");

        }

        private void cboChildren_SelectedIndexChanged(object sender, EventArgs e)
        {
            children = cboChildren.Text[0];
        }

        private void txtDOB_Click(object sender, MouseEventArgs e)
        {
            //txtDOB.Text = String.Empty;
        }

        private void btnRegisterStaff_Click(object sender, EventArgs e)
        {
            if(validForename() && validSurname() && validPhone() && validStreet() && validTown() 
                && validCounty() && validEircode() && validEmail() && validIban())

            //https://stackoverflow.com/questions/3845695/is-there-a-builtin-confirmation-dialog-in-windows-forms
            //to see the c# equivalent of java's JOP.showConfirmDialog()
            {


                Staff newStaff = new Staff(Convert.ToInt32(txtStaffID.Text), txtForename.Text, txtSurname.Text, txtPhone.Text, txtEmail.Text, txtStreet.Text, txtTown.Text,
                                            txtCounty.Text, txtEircode.Text, dob ,gender, txtIban.Text, maritalStatus, children, active);

                newStaff.registerStaff();

                MessageBox.Show("Thank you! Returning Home.", "Thank you", MessageBoxButtons.OK);
                frmWelcomeScreen home = new frmWelcomeScreen();

                home.Show();
                this.Hide();
            }

            else
            {
                var tryAgain = MessageBox.Show("It appears you may not have entered all the details correctly", "Try again?", MessageBoxButtons.YesNo);

                if(tryAgain==DialogResult.Yes)
                {
                    frmRegisterStaff onceMore = new frmRegisterStaff();
                    onceMore.Show();
                    this.Hide();
                }

                else
                {
                    frmWelcomeScreen backHome = new frmWelcomeScreen();
                    backHome.Show();
                    this.Hide();
                }
            }
        }

        private void txtForename_TextChanged(object sender, EventArgs e)
        {
            forename = txtForename.Text;
        }

        private void txtSurname_TextChanged(object sender, EventArgs e)
        {
            surname = txtSurname.Text;
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            phone = txtPhone.Text;
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            email = txtEmail.Text;
        }

        private void txtStreet_TextChanged(object sender, EventArgs e)
        {
            street = txtStreet.Text;
        }

        private void txtTown_TextChanged(object sender, EventArgs e)
        {
            town = txtTown.Text;
        }

        private void txtCounty_TextChanged(object sender, EventArgs e)
        {
            county = txtCounty.Text;
        }

        private void txtEircode_TextChanged(object sender, EventArgs e)
        {
            eirCode = txtEircode.Text;
        }

        private void txtDOB_TextChanged(object sender, EventArgs e)
        {
            //dob = txtDOB.Text;
        }

        private bool validForename()
        {
            bool valid = false;

            if (!forename.Equals(""))
                valid = true;

            return valid;
        }

        private bool validSurname()
        {
            bool valid = false;

            if (!surname.Equals(""))
                valid = true;

            return valid;
        }

        private bool validPhone()
        {
            int i = 10;
            bool valid = false;

            //https://msdn.microsoft.com/en-us/library/0t641e58(v=vs.110).aspx
            //To get c# equivalent of java's Character.isDigit()

            for (i = 0; i < phone.Length;i++)
            {
                if (!Char.IsDigit(phone[i]))
                    break;
            }

            if (i == 10)
                valid = true;

            return valid;
        }

        private bool validEmail()
        {
            bool valid = false;

            int atOrPeriod = 0;
            
            for(int i = 0; i<email.Length;i++)
            {
                //https://stackoverflow.com/questions/3581741/c-sharp-equivalent-to-javas-charat
                //to get c# equivalent of java's .charAt()
                if (email[i] == '@' || email[i] == '.')
                    atOrPeriod++;
            }

            if (atOrPeriod >= 2)
                valid = true;
            
            return valid;
        }

        private bool validStreet()
        {
            bool valid = false;

            if (!street.Equals(""))
                valid = true;

            return valid;
        }

        private bool validTown()
        {
            bool valid = false;

            if (!town.Equals(""))
                valid = true;

            return valid;
        }

        private bool validCounty()
        {
            bool valid = false;

            if (!county.Equals(""))
                valid = true;

            return valid;
        }

        private bool validEircode()
        {
            bool valid = false;

            if (!eirCode.Equals(""))
                valid = true;

            return valid;
        }

        private bool validDOB()
        {
            //bool valid = false;
            //if(dob.Value <= DateTime.()

            return true;
        }

        private void txtDOB_GotFocus(object sender, EventArgs e)
        {
            //txtDOB.Text = String.Empty;
        }

        private void txtDOB_LostFocus(object sender, EventArgs e)
        {
           /* if (txtDOB.Text == "")
                txtDOB.Text = "dd/mm/yyyy";
            else
                txtDOB.ForeColor = (Color.Black);*/
                
        }

        private void txtIban_TextChanged(object sender, EventArgs e)
        {
            iban = txtIban.Text;
        }

        private bool validIban()
        {
            bool valid = false;

            if (iban[0] == 'I' && iban[1] == 'E' && iban.Length == 22)
                valid = true;

            return valid;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void optMarried_CheckedChanged(object sender, EventArgs e)
        {
            if (optMarried.Checked)
                maritalStatus = "y";

            else
                maritalStatus = "n";
        }

        private void optGenderMale_CheckedChanged(object sender, EventArgs e)
        {
            if (optGenderMale.Checked)
                gender = "m";
            else
                gender = "f";
        }

        private void dtpDOB_ValueChanged(object sender, EventArgs e)
        {
            dob = dtpDOB.Value.ToString("yyyy-MM-dd");
        }
    }
}
