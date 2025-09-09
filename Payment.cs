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
    public partial class Payment : Form
    {
        public string CustomerName { get; set; }
        public Payment()
        {
            InitializeComponent();
            UI.Roundcorner(panel1, 30);
            UI.Roundcorner(btn_pay, 30);
            UI.Roundcorner(btn_close, 30);
        }



        private void btn_pay_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_payment.Text == "")
                {
                    MessageBox.Show("Please enter payment amount.");
                    return;
                }
                double change;
                change = Convert.ToDouble(txt_payment.Text) - Convert.ToDouble(txt_total.Text);
                if (change >= 0)
                {
                    txt_change.Text = change.ToString("F2");
                    MessageBox.Show("Transaction Complete", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Insufficient Amount", "ERROR", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    return;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid input. Please enter a valid number for the payment amount.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Payment_Load_1(object sender, EventArgs e)
        {
            txt_cus.AppendText("Customer Name: " + UI.Name + Environment.NewLine);
            txt_cus.AppendText("Customer Type: " + UI.Type + Environment.NewLine);
            txt_cus.AppendText("Date: " + UI.Date.ToString("g") + Environment.NewLine);
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
