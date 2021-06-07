using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Blood_Donor_Center_Managment_System.Forms
{
    public partial class Patient : Form
    {
        public Patient()
        {
            InitializeComponent();
        }

        SqlConnection Connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jakub\Documents\BloodBankDB.mdf;Integrated Security=True;Connect Timeout=30");

        private void ClearFields()
        {
            PNameTb.Text = "";
            PPhoneTb.Text = "";
            PAgeTb.Text = "";
            PGenderCB.SelectedIndex = -1;
            PBloodTypeCB.SelectedIndex = -1;
            PAddressTb.Text = "";
        }
      
        private void PSave_Click_1(object sender, EventArgs e)
        {
            if (PNameTb.Text == ""
                || PPhoneTb.Text == ""
                || PAgeTb.Text==""
                || PGenderCB.SelectedIndex == -1
                || PBloodTypeCB.SelectedIndex == -1)
            {
                MessageBox.Show("Missing informations");
                Connect.Close();
            }
            else
            {
                try
                {
                    Connect.Open();
                    string query = "INSERT INTO Patient VALUES('" + PNameTb.Text + "'," + PAgeTb.Text + ",'" + PPhoneTb.Text + "','" + PGenderCB.SelectedItem.ToString() + "','" + PBloodTypeCB.SelectedItem.ToString() + "','" + PAddressTb.Text + "')";
                    SqlCommand command = new SqlCommand(query, Connect);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Patient Successfully Added");
                    Connect.Close();
                    ClearFields();
                }
                catch (Exception Ex)
                {

                    MessageBox.Show(Ex.Message);
                    Connect.Close();
                }
            }
        }

        private void PAgeTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            ViewPatient viewPatient = new ViewPatient();
            viewPatient.Show();
            this.Hide();
        }

        private void DMenu_Click(object sender, EventArgs e)
        {
            Donor donor = new Donor();
            donor.Show();
            this.Hide();
        }

        private void VDMenu_Click(object sender, EventArgs e)
        {
            ViewDonors viewDonor = new ViewDonors();
            viewDonor.Show();
            this.Hide();
        }

        private void PMenu_Click(object sender, EventArgs e)
        {
            Patient Patient = new Patient();
            Patient.Show();
            this.Hide();
        }

        private void VPMenu_Click(object sender, EventArgs e)
        {
            ViewPatient viewPatient = new ViewPatient();
            viewPatient.Show();
            this.Hide();
        }

        private void BSMenu_Click(object sender, EventArgs e)
        {
            BloodStock bloodStock = new BloodStock();
            bloodStock.Show();
            this.Hide();
        }

        private void BTMenu_Click(object sender, EventArgs e)
        {
            BloodTransfer bloodTransfer = new BloodTransfer();
            bloodTransfer.Show();
            this.Hide();
        }

        private void DashMenu_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }
    }
}
