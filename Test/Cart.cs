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
    public partial class Cart : Form
    {
        SqlCommand cmd;
        SqlConnection cn;
        SqlDataReader dr;

        public Cart()
        {
            InitializeComponent();
        }

        private void toolStripButton16_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cart cart = new Cart();
            cart.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Cart_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"Data Source=DESKTOP-NNTQ8PP\SQLEXPRESS;Initial Catalog=LoginDatabse;Trusted_Connection=True;TrustServerCertificate=True;Integrated Security=True");
            cn.Open();
        }

        private void btn_lsmh_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            using (cn)
            {
                using (SqlCommand cmd = new SqlCommand("SelectAllPurchases", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataReader reader = cmd.ExecuteReader();
                    dt.Load(reader);
                }
            }
            dgv_lsmh.DataSource = dt;
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.ShowDialog();
        }

        private void toolStripButton5_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.ShowDialog();
        }
    }
}
