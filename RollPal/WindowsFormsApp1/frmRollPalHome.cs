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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void userNameBText_Click(object sender, MouseEventArgs e)
        {
            userNameBText.Text = String.Empty;
        }

        private void passWordText_Click(object sender, MouseEventArgs e)
        {
            passWordBox.Text = String.Empty;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if(userNameBText.Text.Equals("CatherineWoods") && passWordBox.Text.Equals("2017"))
            {
                frmWelcomeScreen myWelcome = new frmWelcomeScreen();
                myWelcome.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Sorry, your details are incorrect, Please try again!", "Error");

                Home login = new Home();
                login.Show();
                this.Hide();
            }
            
            

            

        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void passWordBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
