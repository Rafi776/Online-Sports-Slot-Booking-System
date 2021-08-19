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
    public partial class NewBooking : Form
    {
        public NewBooking()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
             string  name, studentid, department= " ", sports=" ", slot= " ";

            DateTime date = Convert.ToDateTime(bookingdate.Text);
            name = bookingname.Text;
            studentid= bookingID.Text;
            department = bookingdate.Text;
           sports = bookingsport.Text;
            slot = bookingslot.Text;
            
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-OIP2TKS\SQLEXPRESS;Initial Catalog=OSB;Integrated Security=True");
            conn.Open();
            string query = "insert into NewBooking (Name, StudentID, Department, Date, Sports, Slot) values ('"+name+"', '"+studentid+"', '"+department+"', '"+date+"', '"+sports+"', '"+slot+"')";
            SqlCommand cmd = new SqlCommand(query,conn);
            int row = cmd.ExecuteNonQuery();
            if (row > 0)
            {MessageBox.Show("Slot Booked");}
            else
            {
                MessageBox.Show("Please Fill Up All Required Data");
            }
            conn.Close();

        }

        private void button1_Click(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            BookingHistory bhform = new BookingHistory();
            bhform.Show();
            this.Hide();

        }

        private void logout_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UpdateBooking ubform = new UpdateBooking();
            ubform.Show();
            this.Hide();
        }
        }
    }

