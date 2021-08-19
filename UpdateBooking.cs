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

namespace OSB
{
    public partial class UpdateBooking : Form
    {
        public UpdateBooking()
        {
            InitializeComponent();
        }

        private void UpdateBooking_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'oSBDataSet.NewBooking' table. You can move, or remove it, as needed.
            this.newBookingTableAdapter.Fill(this.oSBDataSet.NewBooking);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            //MessageBox.Show(e.RowIndex.ToString());
            //int bookingid = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
            //MessageBox.Show(bookingid + "");
            //this.newBookingTableAdapter.Fill(this.oSBDataSet.NewBooking);
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-OIP2TKS\SQLEXPRESS;Initial Catalog=OSB;Integrated Security=True");
            conn.Open();
            string query = "select * from NewBooking Where BookingID = '"+updatebookingid.Text+"' ";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            SqlDataAdapter adp1 = new SqlDataAdapter(cmd);
            DataSet ds1 = new DataSet();
            adp1.Fill(ds1);
            DataTable dt1 = ds1.Tables[0];
           /* updatestudentid.Text = dt1.Rows[0]["StudentID"].ToString();
            updatesport.Text = dt1.Rows[0]["Sports"].ToString();
            updateslot.Text = dt1.Rows[0]["Slot"].ToString();
            updatedate.Text = dt1.Rows[0]["Date"].ToString();*/
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = dt1;
            dataGridView1.Refresh();
            conn.Close();
        }

        private void updatesave_Click(object sender, EventArgs e)
        {
            string upsport = "", upslot = "";
            upsport = updatesport.Text;
            upslot = updateslot.Text;

            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-OIP2TKS\SQLEXPRESS;Initial Catalog=OSB;Integrated Security=True");
            conn.Open();
            string query = "Update NewBooking set Sports ='" + upsport + "', Date ='" + updatedate.Text + "', Slot = '" + upslot + "'  where BookingID= '" + updatebookingid.Text + "'  ";
            SqlCommand cmd = new SqlCommand(query, conn);
            int row = cmd.ExecuteNonQuery();
            if (row > 0)
            {
                MessageBox.Show("Successfully Updated");
            }
            //SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-OIP2TKS\SQLEXPRESS;Initial Catalog=OSB;Integrated Security=True");
            //conn.Open();
            query = "select BookingID, Name, StudentID, Sports, Slot, Date from NewBooking where StudentID = '"+updatebookingid.Text+"' ";
            cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            SqlDataAdapter adp1 = new SqlDataAdapter(cmd);
            DataSet ds1 = new DataSet();
            adp1.Fill(ds1);
            DataTable dt1 = ds1.Tables[0];

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = dt1;
            dataGridView1.Refresh();
            conn.Close();
        }

        private void ubok_Click(object sender, EventArgs e)
        {
            string ubid = updatebookingid.Text;
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-OIP2TKS\SQLEXPRESS;Initial Catalog=OSB;Integrated Security=True");
            conn.Open();
            string query = "Select * From NewBooking Where BookingID = '" + ubid + "'";
            SqlCommand cmd = new SqlCommand(query, conn);
            int row = cmd.ExecuteNonQuery();
            cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            SqlDataAdapter adp1 = new SqlDataAdapter(cmd);
            DataSet ds1 = new DataSet();
            adp1.Fill(ds1);
            DataTable dt1 = ds1.Tables[0];

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = dt1;
            dataGridView1.Refresh();
            conn.Close();
        }

        private void ubok_Click_1(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-OIP2TKS\SQLEXPRESS;Initial Catalog=OSB;Integrated Security=True");
            conn.Open();
            string query = "Select * From NewBooking Where BookingID = '" + updatebookingid.Text + "'";
            SqlCommand cmd = new SqlCommand(query, conn);
            int row = cmd.ExecuteNonQuery();
            cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            SqlDataAdapter adp1 = new SqlDataAdapter(cmd);
            DataSet ds1 = new DataSet();
            adp1.Fill(ds1);
            DataTable dt1 = ds1.Tables[0];

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = dt1;
            dataGridView1.Refresh();
            conn.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            BookingHistory bhform = new BookingHistory();
            bhform.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NewBooking nbform = new NewBooking();
            nbform.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Dashboard form = new Dashboard();
            form.Show();
            this.Hide();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            Form1 lgform = new Form1();
            lgform.Show();
            this.Hide();
        }
    }
}
