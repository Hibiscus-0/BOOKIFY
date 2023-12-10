using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;

namespace BOOKIFY
{
    public class RoundedGradientPanel : Panel
    {
        private int cornerRadius;

        [Browsable(true)]
        [Category("Appearance")]
        [Description("The starting color of the gradient.")]
        public Color StartColor { get; set; }

        [Browsable(true)]
        [Category("Appearance")]
        [Description("The ending color of the gradient.")]
        public Color EndColor { get; set; }

        [Browsable(true)]
        [Category("Appearance")]
        [Description("The corner radius for rounded corners.")]
        public int CornerRadius
        {
            get { return cornerRadius; }
            set
            {
                cornerRadius = value;
                Invalidate(); // Redraw the control when the corner radius changes
            }
        }

        public RoundedGradientPanel()
        {
            // Set default values
            StartColor = Color.Blue;
            EndColor = Color.White;
            CornerRadius = 10;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            using (GraphicsPath path = CreateRoundedRectanglePath(ClientRectangle, CornerRadius))
            using (LinearGradientBrush brush = new LinearGradientBrush(ClientRectangle, StartColor, EndColor, LinearGradientMode.Vertical))
            {
                e.Graphics.FillPath(brush, path);
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            Invalidate(); // Force a repaint when the control is resized
        }

        private GraphicsPath CreateRoundedRectanglePath(Rectangle rectangle, int radius)
        {
            GraphicsPath path = new GraphicsPath();

            int diameter = radius * 2;
            Size size = new Size(diameter, diameter);
            Rectangle arc = new Rectangle(rectangle.Location, size);

            // Top-left corner
            path.AddArc(arc, 180, 90);

            // Top-right corner
            arc.X = rectangle.Right - diameter;
            path.AddArc(arc, 270, 90);

            // Bottom-right corner
            arc.Y = rectangle.Bottom - diameter;
            path.AddArc(arc, 0, 90);

            // Bottom-left corner
            arc.X = rectangle.Left;
            path.AddArc(arc, 90, 90);

            path.CloseFigure();

            return path;
        }
    }
}
