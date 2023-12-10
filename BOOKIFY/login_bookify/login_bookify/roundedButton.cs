using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login_bookify
{
    public class roundedButton : Button
    {
        private Color _borderColor = Color.Silver;
        private float _borderThickness = 1.75f;
        private int _borderRadius = 50;

        public Color BorderColor
        {
            get { return _borderColor; }
            set
            {
                if (_borderColor != value)
                {
                    _borderColor = value;
                    Invalidate(); // Redraw the button when the border color changes
                }
            }
        }

        public float BorderThickness
        {
            get { return _borderThickness; }
            set
            {
                if (_borderThickness != value)
                {
                    _borderThickness = value;
                    Invalidate(); // Redraw the button when the border thickness changes
                }
            }
        }

        public int BorderRadius
        {
            get { return _borderRadius; }
            set
            {
                if (_borderRadius != value)
                {
                    _borderRadius = value;
                    Invalidate(); // Redraw the button when the border radius changes
                }
            }
        }

        public roundedButton()
        {
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            Padding = new Padding(10);
            BackColor = Color.FromArgb(255, 128, 128); // Change this to your desired background color
            ForeColor = Color.White; // Change this to your desired text color
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            RectangleF rect = new RectangleF(0, 0, Width, Height);
            GraphicsPath path = GetRoundPath(rect, _borderRadius);

            Region = new Region(path);

            using (Pen pen = new Pen(_borderColor, _borderThickness))
            {
                pen.Alignment = PenAlignment.Inset;
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                e.Graphics.DrawPath(pen, path);
            }
        }

        private GraphicsPath GetRoundPath(RectangleF rect, int radius)
        {
            float m = 2.75F;
            float r2 = radius / 2f;
            GraphicsPath graphPath = new GraphicsPath();

            graphPath.AddArc(rect.X + m, rect.Y + m, radius, radius, 180, 90);
            graphPath.AddLine(rect.X + r2 + m, rect.Y + m, rect.Width - r2 - m, rect.Y + m);
            graphPath.AddArc(rect.X + rect.Width - radius - m, rect.Y + m, radius, radius, 270, 90);
            graphPath.AddLine(rect.Width - m, rect.Y + r2, rect.Width - m, rect.Height - r2 - m);
            graphPath.AddArc(rect.X + rect.Width - radius - m, rect.Y + rect.Height - radius - m, radius, radius, 0, 90);
            graphPath.AddLine(rect.Width - r2 - m, rect.Height - m, rect.X + r2 - m, rect.Height - m);
            graphPath.AddArc(rect.X + m, rect.Y + rect.Height - radius - m, radius, radius, 90, 90);
            graphPath.AddLine(rect.X + m, rect.Height - r2 - m, rect.X + m, rect.Y + r2 + m);

            graphPath.CloseFigure();
            return graphPath;
        }
    }
}