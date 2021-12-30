using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Durak.Classes
{
    public class TriangleButton : Button
    {
        
        public TriangleButton()
        {
            _angle = 0;
            _edgesCount = 3;
        }

        private int _edgesCount;
        private float _angle;
        public int EdgesCount
        {
            get { return _edgesCount; }
            set
            {
                if (_edgesCount == value) return;
                _edgesCount = value;
                OnSizeChanged(EventArgs.Empty);
            }
        }

        public float Angle
        {
            get { return _angle; }
            set
            {
                if (_angle == value) return;
                _angle = value;
                OnSizeChanged(EventArgs.Empty);
            }
        }
        /// <summary>
        ///  override the OnSizeChanged method to draw the triangle
        /// </summary>
        /// <param name="e"></param>
        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            OnSizeChanged(e);
        }
        /// <summary>
        ///  Draws the background image and background color of the control using a specified graphics 
        /// </summary>
        /// <param name="e"></param>
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            using var path = new GraphicsPath();
            var rect = ClientRectangle;
            rect.Inflate(-3,-3);
            var pt = new PointF(rect.X + rect.Width / 2f, rect.Y + rect.Height / 2f);
            var r = Math.Min(rect.Height, rect.Width) / 2;
            var points = new PointF[_edgesCount];
            for (int i = 0; i < points.Length; i++)
            {
                points[i] = new PointF(pt.X + r * (float)Math.Cos(_angle +2 * Math.PI * i / _edgesCount),
                    pt.Y + r * (float)Math.Sin(_angle +2 * Math.PI * i / _edgesCount));
            }
            path.AddPolygon(points);
            Region = new Region(path);
        }
    }
}