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
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
            Getdata();
        }
        public void Getdata()
        {
            SqlConnection con = new SqlConnection(@"Data Source=LENNY\SQLEXPRESS;Initial Catalog=blooddb;Integrated Security=True;");
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select sum(BStock) from Bloodtbl ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            int BStock = Convert.ToInt32(dt.Rows[0][0].ToString());
            TotalLbl.Text = "" + BStock;
            
            SqlDataAdapter sda1 = new SqlDataAdapter("Select BStock from Bloodtbl where BGroup='" + "O+" + "'", con);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);
            Opluslabel.Text = dt1.Rows[0][0].ToString();
            Double OplusPercentage = (Convert.ToDouble(dt1.Rows[0][0].ToString()) / BStock) * 100;
            OplusProgress.Value = Convert.ToInt32(OplusPercentage);

            SqlDataAdapter sda2 = new SqlDataAdapter("Select BStock from Bloodtbl where BGroup='" + "A+" + "'", con);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);
            label17.Text = dt2.Rows[0][0].ToString();
            Double AplusPercentage = (Convert.ToDouble(dt2.Rows[0][0].ToString()) / BStock) * 100;
            guna2CircleProgressBar1.Value = Convert.ToInt32(AplusPercentage);

            SqlDataAdapter sda3 = new SqlDataAdapter("Select BStock from Bloodtbl where BGroup='" + "AB+" + "'", con);
            DataTable dt3 = new DataTable();
            sda3.Fill(dt3);
            label18.Text = dt3.Rows[0][0].ToString();
            Double ABposPercentage = (Convert.ToDouble(dt3.Rows[0][0].ToString()) / BStock) * 100;
            guna2CircleProgressBar2.Value = Convert.ToInt32(ABposPercentage);

            SqlDataAdapter sda4 = new SqlDataAdapter("Select BStock from Bloodtbl where BGroup='" + "AB-" + "'", con);
            DataTable dt4 = new DataTable();
            sda4.Fill(dt4);
            label19.Text = dt4.Rows[0][0].ToString();
            Double ABnegPercentage = (Convert.ToDouble(dt4.Rows[0][0].ToString()) / BStock) * 100;
            guna2CircleProgressBar3.Value = Convert.ToInt32(ABnegPercentage);

            SqlDataAdapter sda5 = new SqlDataAdapter("Select BStock from Bloodtbl where BGroup='" + "B+" + "'", con);
            DataTable dt5 = new DataTable();
            sda5.Fill(dt5);
            label20.Text = dt5.Rows[0][0].ToString();
            Double BposPercentage = (Convert.ToDouble(dt5.Rows[0][0].ToString()) / BStock) * 100;
            guna2CircleProgressBar4.Value = Convert.ToInt32(BposPercentage);

            SqlDataAdapter sda6 = new SqlDataAdapter("Select BStock from Bloodtbl where BGroup='" + "B-" + "'", con);
            DataTable dt6 = new DataTable();
            sda6.Fill(dt6);
            label21.Text = dt6.Rows[0][0].ToString();
            Double BnegPercentage = (Convert.ToDouble(dt6.Rows[0][0].ToString()) / BStock) * 100;
            guna2CircleProgressBar7.Value = Convert.ToInt32(BnegPercentage);

            SqlDataAdapter sda7 = new SqlDataAdapter("Select BStock from Bloodtbl where BGroup='" + "O-" + "'", con);
            DataTable dt7 = new DataTable();
            sda7.Fill(dt7);
            label23.Text = dt7.Rows[0][0].ToString();
            Double OnegPercentage = (Convert.ToDouble(dt7.Rows[0][0].ToString()) / BStock) * 100;
            guna2CircleProgressBar6.Value = Convert.ToInt32(OnegPercentage);


        }

        private void guna2CircleProgressBar4_ValueChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void DashBoard_Load(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click_1(object sender, EventArgs e)
        {

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

        private void label4_Click(object sender, EventArgs e)
        {
            Patient patient = new Patient();
            patient.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            ViewPatient patient = new ViewPatient();
            patient.Show();
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

        private void label17_Click(object sender, EventArgs e)
        {

        }
    }
}
