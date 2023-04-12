using System.Drawing.Drawing2D;

namespace Test
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.ShowDialog();
        }

        private void toolStripButton10_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
        }

        private void toolStripButton11_Click_2(object sender, EventArgs e)
        {
            this.Hide();
            Profile profile = new Profile();
            profile.ShowDialog();
        }

        private void toolStripButton9_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Detail detail = new Detail();
            detail.ShowDialog();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cart cart = new Cart();
            cart.ShowDialog();
        }
    }
}