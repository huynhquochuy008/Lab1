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
    public partial class Profile : Form
    {
        SqlCommand cmd;
        SqlConnection cn;
        SqlDataReader dr;

        public Profile()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Profile_Load(object sender, EventArgs e)
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
    }
}
