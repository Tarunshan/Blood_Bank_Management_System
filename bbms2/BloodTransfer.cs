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
    public partial class BloodTransfer : Form
    {
        public BloodTransfer()
        {
            InitializeComponent();
            fillPaitentCb();

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
        private void fillPaitentCb()
        {
            SqlConnection con = new SqlConnection(@"Data Source=LENNY\SQLEXPRESS;Initial Catalog=blooddb;Integrated Security=True;");
            con.Open();
            SqlCommand cmd = new SqlCommand("select PNum from PatientTbl1", con);
            SqlDataReader rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("PNum", typeof(string));
            dt.Load(rdr);
            PatientIdcb.ValueMember = "PNum";
            PatientIdcb.DataSource = dt;
            con.Close();
        }
        public void GetData()
        {
            SqlConnection con = new SqlConnection(@"Data Source=LENNY\SQLEXPRESS;Initial Catalog=blooddb;Integrated Security=True;");
            con.Open();
            string query = "select * from PatientTbl1 where PNum=" + PatientIdcb.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(query, con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                PNameTb.Text = dr["PName"].ToString();
                BGroupTb.Text = dr["PBGroup"].ToString();
            }
        }
        public void reset()
        {
            PNameTb.Text = "";
            BGroupTb.Text = "";
            AvailableLbl.Visible = false;
            TransferBtn.Visible = false;
        }

        private void BloodTransfer_Load(object sender, EventArgs e)
        {

        }

        private void PNameTb_TextChanged(object sender, EventArgs e)
        {

        }
        SqlConnection con = new SqlConnection(@"Data Source=LENNY\SQLEXPRESS;Initial Catalog=blooddb;Integrated Security=True;");
        int stock = 0;
        private void GetStock(string BGroupTb)
        {
            con.Open();
            string query = "select * from BloodTbl where BGroup='" + BGroupTb + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                stock = Convert.ToInt32(dr["BStock"].ToString());
            }
            con.Close();
        }

        private void PatientIdcb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetData();
            GetStock(BGroupTb.Text);
            if (stock > 0)
            {
                TransferBtn.Visible = true;
                AvailableLbl.Text = "Available";
                AvailableLbl.Visible = true;
            }
            else
            {
                AvailableLbl.Text = "Stock not Available";
                TransferBtn.Visible = false;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LENNY\SQLEXPRESS;Initial Catalog=blooddb;Integrated Security=True;");
            if (PNameTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    String query = "insert into TransferTbl values('" + PNameTb.Text + "','" + BGroupTb.Text + "')";
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Transfer Successfull");
                    String query1 = "update BloodTbl set BStock=BStock-1 where BGroup='" + BGroupTb.Text + "'";
                    SqlCommand cmd1 = new SqlCommand(query1, con);
                    cmd1.ExecuteNonQuery();
                    con.Close();
                    reset();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Patient patient = new Patient();
            patient.Show();
            this.Hide();
        }


        private void label6_Click(object sender, EventArgs e)
        {
            BloodStock Bs = new BloodStock();
            Bs.Show();
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            ViewPatient patient = new ViewPatient();
            patient.Show();
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
