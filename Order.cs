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
        public Order()
        {
            InitializeComponent();

            UI.Roundcorner(panel1, 30);
            UI.Roundcorner(panel2, 30);
            UI.Roundcorner(panel3, 30);
        }
    }
}
