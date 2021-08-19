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
    public partial class NewAccount : Form
        
    {
       
        public NewAccount()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblsubmit_Click(object sender, EventArgs e)
        {
            string acting = " ", name, id, email, createpassword, phoneno, gender= " ", department= " ";

            DateTime dob = Convert.ToDateTime(nadob.Text);
            name = txtnm.Text;
            id= txtid.Text;
            email = txtmail.Text;
            createpassword = txtcppass.Text;
            phoneno = txtphn.Text;
            department = combodpt.Text;
            acting = comboacting.Text;
            if (rbmale.Checked)
            {
                gender = "Male";
            }
            else if (rbfemale.Checked)
            {
                gender = "Female";
            }
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-OIP2TKS\SQLEXPRESS;Initial Catalog=OSB;Integrated Security=True");
            conn.Open();
            string query = "insert into UserAccount (Acting, Name, ID, Email, Password, Gender, DOB, Department, PhoneNo) values ('"+acting+"','"+name+"', '"+id+"', '"+email+"','"+createpassword+"', '"+gender+"', '"+dob+"', '"+department+"', '"+phoneno+"')";
            SqlCommand cmd = new SqlCommand(query,conn);
            int row = cmd.ExecuteNonQuery();
            if (row > 0)
                MessageBox.Show("Account Created");
            else
            {
                MessageBox.Show("Please Fill Up The Form Perfectly");
            }
            conn.Close();

        }

        private void NewAccount_Load(object sender, EventArgs e)
        {

        }

        private void Login_Click(object sender, EventArgs e)
        {
            Form1 lgform = new Form1();
            lgform.Show();
            this.Hide();
        }
    }
}
