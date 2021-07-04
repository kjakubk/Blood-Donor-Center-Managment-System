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
    public partial class Donor : Form
    {
        public Donor()
        {
            InitializeComponent();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        SqlConnection Connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jakub\Documents\BloodBankDB.mdf;Integrated Security=True;Connect Timeout=30");

        private void ClearFields()
        {
            DNameTb.Text = "";
            DPhoneTb.Text = "";
            DAgeTb.Text = "";
            DGenderCB.SelectedIndex = -1;
            DBloodTypeCB.SelectedIndex = -1;
            DAddressTB.Text = "";
        }
        private void DSave_Click(object sender, EventArgs e)
        {
            if (DNameTb.Text == ""
                || DPhoneTb.Text == ""
                || DAgeTb.Text == ""
                || DGenderCB.SelectedIndex == -1
                || DBloodTypeCB.SelectedIndex ==-1)
            {
                MessageBox.Show("Missing informations");
                Connect.Close();
            }
            else
            {
                try
                {
                    string query = "insert into DonorTab values('" + DNameTb.Text + "'," + DAgeTb.Text + ",'" + DGenderCB.SelectedItem.ToString() + "','" + DPhoneTb.Text + "','" + DAddressTB.Text + "','" + DBloodTypeCB.SelectedItem.ToString() + "')";
                    Connect.Open();

                    SqlCommand command = new SqlCommand(query, Connect);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Donnor Successfully Added");
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

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            DonateBloodcs donateBlood = new DonateBloodcs();
            donateBlood.Show();
            this.Hide();
        }
    }
}
