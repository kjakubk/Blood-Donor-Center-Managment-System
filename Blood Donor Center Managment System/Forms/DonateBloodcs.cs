﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blood_Donor_Center_Managment_System.Forms
{
    public partial class DonateBloodcs : Form
    {
        public DonateBloodcs()
        {
            InitializeComponent();
        }





        private void DMenu_Click(object sender, EventArgs e)
        {
            Donor donor = new Donor();
            donor.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            DonateBloodcs donateBlood = new DonateBloodcs();
            donateBlood.Show();
            this.Hide();
        }

        private void DashMenu_Click_1(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }

        private void BTMenu_Click_1(object sender, EventArgs e)
        {
            BloodTransfer bloodTransfer = new BloodTransfer();
            bloodTransfer.Show();
            this.Hide();
        }

        private void BSMenu_Click_1(object sender, EventArgs e)
        {
            BloodStock bloodStock = new BloodStock();
            bloodStock.Show();
            this.Hide();
        }

        private void VPMenu_Click_1(object sender, EventArgs e)
        {
            ViewPatient viewPatient = new ViewPatient();
            viewPatient.Show();
            this.Hide();
        }

        private void PMenu_Click_1(object sender, EventArgs e)
        {
            Patient Patient = new Patient();
            Patient.Show();
            this.Hide();
        }

        private void VDMenu_Click_1(object sender, EventArgs e)
        {
            
            ViewDonors viewDonor = new ViewDonors();
            viewDonor.Show();
            this.Hide();
            
        }
    }
}
