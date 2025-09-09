using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multiforms_event_CRUZ
{
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
            UI.Roundcorner(panel1, 30);
            UI.Roundcorner(button1, 30);
            cb_ct.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
   
            if (txt_name.Text == "" || cb_ct.SelectedIndex == 0)
            {
                MessageBox.Show("Please enter your name and select customer type.");
                return;
            }

            UI.Name = txt_name.Text;
            UI.Type = cb_ct.Text;
            UI.Date = DateTime.Now;

            Order order = new Order();
            order.Show();

            this.Hide();
        }
    }
}
