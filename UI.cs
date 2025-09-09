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
        
        public static void Price(String[] args)
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
            string[] sizes = { "Tall", "Grande", "Venti" };

        }
    }
}
