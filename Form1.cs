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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void login_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-OIP2TKS\SQLEXPRESS;Initial Catalog=OSB;Integrated Security=True");
            SqlDataAdapter sqa = new SqlDataAdapter("Select count(*) From UserAccount where ID ='" + txid.Text + "' and Password = '" + txpass.Text + "'", con);
            DataTable dt = new DataTable();
            sqa.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                Dashboard dsform = new Dashboard();
                dsform.Show();
            }
            else
            {
                MessageBox.Show("Invalid");
            }
        }

        private void lbca_Click(object sender, EventArgs e)
        {
            NewAccount form = new NewAccount();
            form.Show();
            this.Hide(); 
        }

        private void txid_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
