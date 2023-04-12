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
              
        private void Detail_Load_1(object sender, EventArgs e)
        {

        }

        private void toolStripButton5_Click_3(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.ShowDialog();
        }
    }
}
