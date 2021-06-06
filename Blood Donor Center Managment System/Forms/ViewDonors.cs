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
    }
}
