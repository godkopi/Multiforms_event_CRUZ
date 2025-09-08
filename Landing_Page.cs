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
            button1.Paint += RoundButton;
        }

        private void RoundButton(object sender, PaintEventArgs e)
        {
            int radius = 30;
            Button btn = sender as Button;

            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(0, 0, radius, radius, 180, 90); // Top-left corner
            path.AddArc(btn.Width - radius, 0, radius, radius, 270, 90); // Top-right corner
            path.AddArc(btn.Width - radius, btn.Height - radius, radius, radius, 0, 90); // Bottom-right
            path.AddArc(0, btn.Height - radius, radius, radius, 90, 90); // Bottom-left
            path.CloseFigure();
            btn.Region = new Region(path);

            using (Pen pen = new Pen(Color.White, 4)) // outline
            {
                e.Graphics.DrawPath(pen, path);
            }
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
