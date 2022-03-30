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

namespace DRP
{
    public partial class InfoLabel : Label
    {
        public InfoLabel()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            int radius = ((Size.Width + Size.Height) / 4);
            Point center = new Point(Width / 2, Height / 2);
            Rectangle circleRect = new Rectangle(center.X - radius, center.Y - radius, radius * 2, radius * 2);
            using (GraphicsPath gp = new GraphicsPath())
            {
                Graphics g = e.Graphics;
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.CompositingQuality = CompositingQuality.HighQuality;
                g.PixelOffsetMode = PixelOffsetMode.HighQuality;
                g.InterpolationMode = InterpolationMode.HighQualityBilinear;
                using (LinearGradientBrush brush = new LinearGradientBrush(circleRect, Color.FromArgb(0, 0, 255), Color.FromArgb(0, 0, 55), 90))
                {
                    gp.AddEllipse(circleRect);
                    StringFormat format = new StringFormat();
                    format.Alignment = StringAlignment.Center;
                    format.LineAlignment = StringAlignment.Center;
                    g.FillPath(brush, gp);
                    g.DrawString("?", Font, Brushes.White, circleRect, format);
                    g = null;
                }
            }
        }
    }
}
