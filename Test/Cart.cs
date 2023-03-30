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
    }
}
