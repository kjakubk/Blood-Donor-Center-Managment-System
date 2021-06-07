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
    public partial class ViewPatient : Form
    {

        int key = 0;
        SqlConnection Connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jakub\Documents\BloodBankDB.mdf;Integrated Security=True;Connect Timeout=30");

        public ViewPatient()
        {
            InitializeComponent();
            PatientsPopulation();
        }

        private void PatientsPopulation()
        {
            Connect.Open();
            string query = "Select * from Patient";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, Connect);
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
            var dataSet = new DataSet();

            sqlDataAdapter.Fill(dataSet);
            VPDataGrid.DataSource = dataSet.Tables[0];
            Connect.Close();

        }
        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void VPDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PNameTb.Text = VPDataGrid.SelectedRows[0].Cells[1].Value.ToString();
            PAgeTb.Text = VPDataGrid.SelectedRows[0].Cells[2].Value.ToString();
            PPhoneNumberTb.Text = VPDataGrid.SelectedRows[0].Cells[3].Value.ToString();
            PGenderCB.SelectedItem = VPDataGrid.SelectedRows[0].Cells[4].Value.ToString();
            PBloodTypeCB.SelectedItem = VPDataGrid.SelectedRows[0].Cells[5].Value.ToString();
            PAddressTb.Text = VPDataGrid.SelectedRows[0].Cells[6].Value.ToString();

            if (PNameTb.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(VPDataGrid.SelectedRows[0].Cells[0].Value.ToString());
            }
        }
        private void ClearFields()
        {
            PNameTb.Text = "";
            PPhoneNumberTb.Text = "";
            PAgeTb.Text = "";
            PGenderCB.SelectedIndex = -1;
            PBloodTypeCB.SelectedIndex = -1;
            PAddressTb.Text = "";
            key = 0;
        }

        private void VPDelete_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Select the Patient to Delete");
            }
            else
                try
                {
                    Connect.Open();
                    string query = "DELETE FROM Patient WHERE PNum=" + key + ";";
                    SqlCommand command = new SqlCommand(query, Connect);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Patient Successfully Healed");
                    Connect.Close();
                    ClearFields();
                }
                catch (Exception Ex)
                {

                    MessageBox.Show(Ex.Message);
                    Connect.Close();
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
    }
}

