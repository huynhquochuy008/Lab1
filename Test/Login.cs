using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class Login : Form
    {
        SqlCommand cmd;
        SqlConnection cn;
        SqlDataReader dr;

        public Login()
        {
            InitializeComponent();
        }

        private void lb_username_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            //cn = new SqlConnection(@"Data Source=DESKTOP-NNTQ8PP\SQLEXPRESS;Initial Catalog=LoginDatabse;Trusted_Connection=True;TrustServerCertificate=True;Integrated Security=True");
            //cn.Open();
        }

        private void btnregister_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration registration = new Registration();
            registration.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //if (txtpassword.Text != string.Empty || txtusername.Text != string.Empty)
            //{

            //    cmd = new SqlCommand("select * from LoginTable where Username='" + txtusername.Text + "' and Password='" + txtpassword.Text + "'", cn);
            //    dr = cmd.ExecuteReader();
            //    if (dr.Read())
            //    {
            //        dr.Close();
            //        this.Hide();
            //        Home home = new Home();
            //        home.ShowDialog();
            //    }
            //    else
            //    {
            //        dr.Close();
            //        MessageBox.Show("No Account avilable with this username and password ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }

            //}
            //else
            //{
            //    MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            
        }

        private void Login_Load_1(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.ShowDialog();
        }
    }
}
