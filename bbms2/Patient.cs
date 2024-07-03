using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bbms2
{
    public partial class Patient : Form
    {
        public Patient()
        {
            InitializeComponent();
        }
        private void Reset()
        {
            PNameTb.Text = "";
            PAgeTb.Text = "";
            PPhoneTb.Text = "";
            PGenderCb.SelectedItem = -1;
            PBGroupCb.SelectedItem = -1;
            PAddressTb.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LENNY\SQLEXPRESS;Initial Catalog=blooddb;Integrated Security=True;");
            if (PNameTb.Text == "" || PPhoneTb.Text == "" || PAgeTb.Text == "" || PGenderCb.SelectedIndex == -1 || PBGroupCb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    String query = "insert into PatientTbl1 values('" + PNameTb.Text + "','" + PAgeTb.Text + "','" + PGenderCb.SelectedItem + "','" + PPhoneTb.Text + "','" + PAddressTb.Text + "','" + PBGroupCb.SelectedItem + "')";
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Patient Successfully Saved");
                    con.Close();
                    Reset();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            ViewPatient Vp = new ViewPatient();
            Vp.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            BloodTransfer Bt = new BloodTransfer();
            Bt.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Donor donor = new Donor();
            donor.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            ViewDonors viewDonors = new ViewDonors();
            viewDonors.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            BloodStock bloodStock = new BloodStock();
            bloodStock.Show();
            this.Hide();
        }

        private void label15_Click(object sender, EventArgs e)
        {
            DashBoard dashBoard = new DashBoard();  
            dashBoard.Show();
            this.Hide();
        }
    }
}
