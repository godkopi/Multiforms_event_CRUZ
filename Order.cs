using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multiforms_event_CRUZ
{
    public partial class Order : Form
    {

        int[,] frappe =
            {
                { 130, 145, 155 },  // Mocha
                { 140, 155, 165 },  // Cappuccino
                { 140, 155, 165 },  // Coffee Jelly
                { 145, 160, 170 }   // Java Chip
            };
        int[,] hotbev =
            {
                { 120, 130, 140 },  // Mocha
                { 120, 140, 150 },  // Cappuccino
                { 135, 145, 155 },  // Coffee Jelly
                { 140, 150, 160 }   // Java Chip
            };
        int[] pastry =
            { 80,100,80,90,85,120 };

        double total = 0;
        public Order()
        {
            InitializeComponent();



            UI.Roundcorner(panel1, 30);
            UI.Roundcorner(panel2, 30);
            UI.Roundcorner(panel3, 30);
            UI.Roundcorner(btn_adddrink, 30);
            UI.Roundcorner(btn_addpastry, 30);
            UI.Roundcorner(btn_clear, 30);

            cb_drink.SelectedIndex = 0;
            cb_size.SelectedIndex = 0;
            cb_type.SelectedIndex = 0;
            cb_pastry.SelectedIndex = 0;

            num_qty.Value = 1;
            num_qtyp.Value = 1;
        }

        public void btn_adddrink_Click(object sender, EventArgs e)
        {
            if (cb_drink.SelectedIndex == 0 || cb_size.SelectedIndex == 0 || cb_type.SelectedIndex == 0 || num_qty.Value < 1)
            {
                MessageBox.Show("Please select a drink, size, and type.");
                return;
            }

            double price = 0;
            if (cb_type.SelectedIndex == 1)
            {
                price = frappe[cb_drink.SelectedIndex - 1, cb_size.SelectedIndex - 1];
            }
            else if (cb_type.SelectedIndex == 2)
            {
                price = hotbev[cb_drink.SelectedIndex - 1, cb_size.SelectedIndex - 1];
            }
            int qty = (int)num_qty.Value;
            double amt = price * qty;

            txt_sum.AppendText($"{cb_drink.Text.ToUpper()} - {cb_type.Text.ToUpper()} - {cb_size.Text} - {qty}pc(s) - {amt}php" + Environment.NewLine);
            total += amt;

            txt_total.Text = total.ToString("F2");

            cb_drink.SelectedIndex = 0;
            cb_size.SelectedIndex = 0;
            cb_type.SelectedIndex = 0;
            num_qty.Value = 1;

        }

        public void btn_addpastry_Click(object sender, EventArgs e)
        {
            if (cb_pastry.SelectedIndex == 0 || num_qty.Value < 1)
            {
                MessageBox.Show("Please select a pastry.");
                return;
            }
            double price = pastry[cb_pastry.SelectedIndex - 1];
            int qty = (int)num_qtyp.Value;
            double amt = price * qty;

            txt_sum.AppendText($"{cb_pastry.Text.ToUpper()} - PASTY - {qty}pc(s) - {amt}php" + Environment.NewLine);
            total += amt;

            txt_total.Text = total.ToString("F2");

            cb_pastry.SelectedIndex = 0;
            num_qtyp.Value = 1;
        }

        public void btn_clear_Click(object sender, EventArgs e)
        {
            total = 0;
            txt_sum.Clear();
            txt_total.Clear();

            cb_drink.SelectedIndex = 0;
            cb_size.SelectedIndex = 0;
            cb_type.SelectedIndex = 0;
            cb_pastry.SelectedIndex = 0;

            num_qty.Value = 1;
            num_qtyp.Value = 1;

        }

        public void btn_next_Click(object sender, EventArgs e)
        {
            if(total == 0)
            {
                MessageBox.Show("Please add items to your order before proceeding.");
                return;
            }

            Payment payment = new Payment();
            payment.txt_sum2.Text = txt_sum.Text;
            payment.txt_total.Text = txt_total.Text;
            payment.Show();

            
            this.Hide();
        }
    }
}
