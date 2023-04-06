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
    public partial class Detail : Form
    {
        public Detail()
        {
            InitializeComponent();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.ShowDialog();
        }

        private void Cart_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButton5_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.ShowDialog();
        }

        private void Detail_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButton5_Click_2(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.ShowDialog();
        }
    }
}
