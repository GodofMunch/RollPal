﻿using System;
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
    public partial class frmUpdateStaff : Form

       
    {
        public int staffId;

        public frmUpdateStaff()
        {
            InitializeComponent();
        }

        private void cboSelectStaff_SelectedIndexChanged(object sender, EventArgs e)
        {
            grpStaffDetails.Visible = true;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            frmWelcomeScreen home = new frmWelcomeScreen();
            home.Show();
            this.Hide();
        }

        private void frmUpdateStaff_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
