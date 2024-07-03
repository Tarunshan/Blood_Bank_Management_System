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
    public partial class ViewPatient : Form
    {
        public ViewPatient()
        {
            InitializeComponent();
            populate();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void PGenderCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void PBGroupCb_SelectedIndexChanged(object sender, EventArgs e)
        {

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
                    String query = "update PatientTbl1 set PName='" + PNameTb.Text + "',PAge='" + PAgeTb.Text + "',PPhone='" + PPhoneTb.Text + "',PGender='" + PGenderCb.SelectedItem.ToString() + "',PAddress='" + PAddressTb.Text + "',PBGroup='" + PBGroupCb.SelectedItem.ToString() + "' where PNum=" + key + ";";
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Patient Successfully Updated");
                    con.Close();
                    Reset();
                    populate();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
        private void populate()
        {
            SqlConnection con = new SqlConnection(@"Data Source=LENNY\SQLEXPRESS;Initial Catalog=blooddb;Integrated Security=True;");
            con.Open();
            SqlCommand comm = new SqlCommand("Select * from PatientTbl1", con);
            SqlDataAdapter d = new SqlDataAdapter(comm);
            DataTable dt = new DataTable();
            d.Fill(dt);
            PatientGrid.DataSource = dt;
        }
        int key = 0;
        private void PatientGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PNameTb.Text = PatientGrid.SelectedRows[0].Cells[1].Value.ToString();
            PAgeTb.Text = PatientGrid.SelectedRows[0].Cells[2].Value.ToString();

            PGenderCb.SelectedText = PatientGrid.SelectedRows[0].Cells[3].Value.ToString();
            PPhoneTb.Text = PatientGrid.SelectedRows[0].Cells[4].Value.ToString();
            PAddressTb.Text = PatientGrid.SelectedRows[0].Cells[5].Value.ToString();

            PBGroupCb.SelectedText = PatientGrid.SelectedRows[0].Cells[6].Value.ToString();
            if (PNameTb.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(PatientGrid.SelectedRows[0].Cells[0].Value.ToString());
            }
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
        private void button2_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Select the Patient to Delete");
            }
            else
            {
                SqlConnection con = new SqlConnection(@"Data Source=LENNY\SQLEXPRESS;Initial Catalog=blooddb;Integrated Security=True;");
                try
                {
                    String query = "Delete from PatientTbl1 where PNum=" + key + ";";
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Patient Successfully Deleted");
                    con.Close();
                    Reset();
                    populate();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Patient pat = new Patient();
            pat.Show();
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
