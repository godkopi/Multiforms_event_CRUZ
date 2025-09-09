using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Multiforms_event_CRUZ
{
    public partial class Landing_Page : Form
    {
        public Landing_Page()
        {
            InitializeComponent();
            UI.Roundcorner(button1, 30);
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.Show();
            this.Hide();
        }
    }
}
