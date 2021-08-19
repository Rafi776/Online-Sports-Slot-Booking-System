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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'oSBDataSet.UserAccount' table. You can move, or remove it, as needed.
            this.userAccountTableAdapter.Fill(this.oSBDataSet.UserAccount);
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-OIP2TKS\SQLEXPRESS;Initial Catalog=OSB;Integrated Security=True");
            conn.Open();
            string query = "select ID, Name, Gender, Email, Department from UserAccount Where ID = '"+txtid+"' ";
            SqlCommand cmd = new SqlCommand(query,conn);
            cmd.ExecuteNonQuery();
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            DataTable dt = ds.Tables[0];
            dataGridViewmain.AutoGenerateColumns = false;
            dataGridViewmain.DataSource = dt;
            dataGridViewmain.Refresh();
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewBooking nbform = new NewBooking();
            nbform.Show();
            this.Hide();
        }

        private void dataGridViewmain_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            BookingHistory bhform = new BookingHistory();
            bhform.Show();
            this.Hide();
        }

        private void dataGridViewmain_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show(e.RowIndex.ToString());
            //int bookingid = Convert.ToInt32(dataGridViewmain.Rows[e.RowIndex].Cells[0].Value.ToString());
            //MessageBox.Show(bookingid + "");
            //this.newBookingTableAdapter.Fill(this.oSBDataSet.NewBooking);
            
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-OIP2TKS\SQLEXPRESS;Initial Catalog=OSB;Integrated Security=True");
            conn.Open();
            string query = "select * from UserAccount where ID =";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            DataTable dt = ds.Tables[0];
             /*= dt.Rows[0]["StudentID"].ToString();
            updatesport.Text = dt1.Rows[0]["Sports"].ToString();
            updateslot.Text = dt1.Rows[0]["Slot"].ToString();
            updatedate.Text = dt1.Rows[0]["Date"].ToString();*/
            dataGridViewmain.AutoGenerateColumns = false;
            dataGridViewmain.DataSource = dt;
            dataGridViewmain.Refresh();
            conn.Close();
        }

        private void udview_Click(object sender, EventArgs e)
        {
            string udid = udidtxt.Text;

            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-OIP2TKS\SQLEXPRESS;Initial Catalog=OSB;Integrated Security=True");
            conn.Open();
            string query = "Select * From UserAccount Where ID = '"+udid+"'";
            SqlCommand cmd = new SqlCommand(query, conn);
            int row = cmd.ExecuteNonQuery();
           /* if (row > 0)
            {
                MessageBox.Show("Successfully Updated");
            }*/
            //SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-OIP2TKS\SQLEXPRESS;Initial Catalog=OSB;Integrated Security=True");
            //conn.Open();
            
            cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            DataTable dt = ds.Tables[0];

            dataGridViewmain.AutoGenerateColumns = false;
            dataGridViewmain.DataSource = dt;
            dataGridViewmain.Refresh();
            conn.Close();
        }

        private void udrefresh_Click(object sender, EventArgs e)
        {
            udidtxt.Text = "";
        }

        private void logout_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void updatebooking_Click(object sender, EventArgs e)
        {
            UpdateBooking ubform = new UpdateBooking();
            ubform.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
