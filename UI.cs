using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiforms_event_CRUZ
{
    internal class UI
    {
        public static void Roundcorner(Control ctrl, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(0, 0, radius, radius, 180, 90); // top-left
            path.AddArc(ctrl.Width - radius, 0, radius, radius, 270, 90); // top-right
            path.AddArc(ctrl.Width - radius, ctrl.Height - radius, radius, radius, 0, 90); // bottom-right
            path.AddArc(0, ctrl.Height - radius, radius, radius, 90, 90); // bottom-left
            path.CloseFigure();

            ctrl.Region = new Region(path);
        }
        public static string Name { get; set; }
        public static string Type { get; set; }
        public static DateTime Date { get; set; }
    }
}
