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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace bbms2
{
    public partial class BloodStock : Form
    {
        public BloodStock()
        {
            InitializeComponent();
            populateStock();
            populate();
        }
        private void populateStock()
        {
            SqlConnection con = new SqlConnection(@"Data Source=LENNY\SQLEXPRESS;Initial Catalog=blooddb;Integrated Security=True;");
            con.Open();
            SqlCommand comm = new SqlCommand("Select * from BloodTbl", con);
            SqlDataAdapter d = new SqlDataAdapter(comm);
            DataTable dt = new DataTable();
            d.Fill(dt);
            StockGrid.DataSource = dt;
        }
        private void populate()
        {
            SqlConnection con = new SqlConnection(@"Data Source=LENNY\SQLEXPRESS;Initial Catalog=blooddb;Integrated Security=True;");
            con.Open();
            SqlCommand comm = new SqlCommand("Select * from DonorTbl", con);
            SqlDataAdapter d = new SqlDataAdapter(comm);
            DataTable dt = new DataTable();
            d.Fill(dt);
            DonorGrid2.DataSource = dt;
        }
        private void BloodStock_Load(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DNameTb.Text = DonorGrid2.SelectedRows[0].Cells[1].Value.ToString();
            DBGroupTb.Text = DonorGrid2.SelectedRows[0].Cells[6].Value.ToString();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void PNameTb_TextChanged(object sender, EventArgs e)
        {

        }

        public void StockGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void Reset()
        {
            DNameTb.Text = "";
            DBGroupTb.Text = "";

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (DNameTb.Text == "")
            {
                MessageBox.Show("Select a donor");
            }
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection(@"Data Source=LENNY\SQLEXPRESS;Initial Catalog=blooddb;Integrated Security=True;");
                    String query = "update BloodTbl set BStock=Bstock+1 where BGroup='" + DBGroupTb.Text + "'";
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Donation Successfull");
                    con.Close();
                    Reset();
                    populateStock();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            BloodTransfer bt = new BloodTransfer();
            bt.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Donor donor = new Donor();
            donor.Show();
            this.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            ViewDonors viewDonors = new ViewDonors();
            viewDonors.Show();
            this.Hide();

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Patient patient = new Patient();
            patient.Show();
            this.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            ViewPatient viewPatient = new ViewPatient();
            viewPatient.Show();
            this.Hide();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            DashBoard dashBoard = new DashBoard();
            dashBoard.Show();
            this.Hide();
        }
    }
}
