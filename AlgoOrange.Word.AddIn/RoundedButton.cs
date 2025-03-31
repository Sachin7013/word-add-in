using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace AlgoOrange.Word.AddIn
{
    public class RoundedButton : Button
    {
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            GraphicsPath graphicsPath = new GraphicsPath();
            graphicsPath.AddArc(0, 0, 20, 20, 180, 90);
            graphicsPath.AddArc(Width - 20, 0, 20, 20, 270, 90);
            graphicsPath.AddArc(Width - 20, Height - 20, 20, 20, 0, 90);
            graphicsPath.AddArc(0, Height - 20, 20, 20, 90, 90);
            graphicsPath.CloseAllFigures();

            this.Region = new Region(graphicsPath);

            using (Pen pen = new Pen(Color.SkyBlue, 2))
            {
                e.Graphics.DrawPath(pen, graphicsPath);
            }
        }
    }
}
