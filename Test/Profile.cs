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
        public Profile()
        {
            InitializeComponent();
        }
        private void toolStripButton5_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.ShowDialog();
        }

        private void Profile_Load(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.dataGridView1.Rows.Add("Máy giặt", "1.000.000đ", "1", "1.000.000đ", "Sẵn sàng", "*****");
            this.dataGridView1.Rows.Add("Máy đọc sách", "2.000.000đ", "2", "4.000.000đ", "Sẵn sàng", "*****");
            this.dataGridView1.Rows.Add("Máy lạnh", "3.000.000đ", "3", "9.000.000đ", "Sẵn sàng", "*****");
            this.dataGridView1.Rows.Add("Xe đạp", "4.000.000đ", "4", "16.000.000đ", "Sẵn sàng", "*****");
            this.dataGridView1.Rows.Add("Điện thoại", "5.000.000đ", "5", "25.000.000đ", "Sẵn sàng", "*****");
        }
    }
}
