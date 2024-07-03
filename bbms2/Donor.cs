using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace bbms2
{
    public partial class Donor : Form
    {
        public Donor()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void Reset()
        {
            DNameTb.Text = "";
            DAgeTb.Text = "";
            DPhoneTb.Text = "";
            DGenderCb.SelectedItem = -1;
            DBGroupCb.SelectedItem = -1;
            DAddressTb.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LENNY\SQLEXPRESS;Initial Catalog=blooddb;Integrated Security=True;");
            if (DNameTb.Text == "" || DPhoneTb.Text == "" || DAgeTb.Text == "" || DGenderCb.SelectedIndex == -1 || DBGroupCb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    String query = "insert into DonorTbl values('" + DNameTb.Text + "','" + DAgeTb.Text + "','" + DGenderCb.SelectedItem + "','" + DPhoneTb.Text + "','" + DAddressTb.Text + "','" + DBGroupCb.SelectedItem + "')";
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Donor Successfully Saved");
                    con.Close();
                    Reset();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            ViewDonors vd = new ViewDonors();
            vd.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Patient p = new Patient();
            p.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            ViewPatient viewPatient = new ViewPatient();
            viewPatient.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            BloodStock bloodStock = new BloodStock();
            bloodStock.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            BloodTransfer bloodTransfer = new BloodTransfer();
            bloodTransfer.Show();
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
