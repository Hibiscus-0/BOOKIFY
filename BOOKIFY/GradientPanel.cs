using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BOOKIFY
{
    public class GradientPanel : Panel
    {
        private Color startColor;
        private Color endColor;
        private float angle;

        public Color StartColor
        {
            get { return startColor; }
            set
            {
                startColor = value;
                Invalidate(); // Redraw the control when the start color changes
            }
        }

        public Color EndColor
        {
            get { return endColor; }
            set
            {
                endColor = value;
                Invalidate(); // Redraw the control when the end color changes
            }
        }

        public float Angle
        {
            get { return angle; }
            set
            {
                angle = value;
                Invalidate(); // Redraw the control when the angle changes
            }
        }

        public GradientPanel()
        {
            // Set default values
            StartColor = Color.Blue;
            EndColor = Color.White;
            Angle = 0;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(ClientRectangle, StartColor, EndColor, Angle))
            {
                e.Graphics.FillRectangle(brush, ClientRectangle);
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            Invalidate(); // Force a repaint when the control is resized
        }
    }
}

