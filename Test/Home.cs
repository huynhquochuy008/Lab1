using System.Drawing.Drawing2D;

namespace Test
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Detail cart = new Detail();
            cart.ShowDialog();
        }

        private void AddToCart2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Detail cart = new Detail();
            cart.ShowDialog();
        }

        private void AddToCart3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Detail cart = new Detail();
            cart.ShowDialog();
        }

        private void AddToCart4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Detail cart = new Detail();
            cart.ShowDialog();
        }

        private void toolStripButton11_Click(object sender, EventArgs e)
        {
            this.Hide();
            Profile profile = new Profile();
            profile.ShowDialog();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cart cart = new Cart();
            cart.ShowDialog();
        }

        private void toolStripButton11_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Profile profile = new Profile();
            profile.ShowDialog();
        }

        private void toolStripButton14_Click(object sender, EventArgs e)
        {
            this.Hide();
            Detail cart = new Detail();
            cart.ShowDialog();
        }

        private void toolStripButton15_Click(object sender, EventArgs e)
        {
            this.Hide();
            Detail cart = new Detail();
            cart.ShowDialog();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButton5_Click_1(object sender, EventArgs e)
        {

        }
    }
}