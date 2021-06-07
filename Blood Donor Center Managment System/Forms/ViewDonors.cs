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
    public partial class ViewDonors : Form
    {
        public ViewDonors()
        {
            InitializeComponent();
            DonorsPopulation();
        }

       
        SqlConnection Connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jakub\Documents\BloodBankDB.mdf;Integrated Security=True;Connect Timeout=30");

        private void DonorsPopulation()
        {
            Connect.Open();
            string query = "Select * from DonorTab";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, Connect);
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
            var dataSet = new DataSet();

            sqlDataAdapter.Fill(dataSet);
            VDDataGrid.DataSource = dataSet.Tables[0];
            Connect.Close();

        }

        private void ViewDonors_Load(object sender, EventArgs e)
        {

        }

        private void VDDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
