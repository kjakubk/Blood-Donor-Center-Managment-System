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
        private void DSaveButton(object sender, EventArgs e)
        {
            if(DNameTb.Text == "" || DPhoneTb.Text == "" || DAgeTb.Text == "" || DGenderCB.SelectedIndex ==-1 || DBloodTypeCB.SelectedIndex =-1)
            {
                MessageBox.Show("Missing Informations");
            }
            else
               
        }
    }
}
