using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyLocker
{
    public partial class MyLabel : Label
    {
        private Color backColorStart = Color.Orange;

        public Color BackColorStart
        {
            get { return backColorStart; }
            set
            {
                if (!value.IsEmpty)
                {
                    backColorStart = value;
                }
                else
                {
                    backColorStart = Color.Orange;
                }
            }
        }
        private Color backColorEnd = Color.FromArgb(255, 206, 157);

        public Color BackColorEnd
        {
            get { return backColorEnd; }
            set
            {
                if (!value.IsEmpty)
                {
                    backColorEnd = value;
                }
                else
                {
                    backColorEnd = Color.FromArgb(255, 206, 157);
                }
            }
        }

        public MyLabel()
        {

            this.AutoSize = false;
            SetStyle(ControlStyles.UserPaint, true);
        }


        private void ExLabel_Paint(object sender, PaintEventArgs e)
        {
            Rectangle rect = new Rectangle(0, 0, Width, Height);
            LinearGradientBrush b = new LinearGradientBrush(rect,
                               BackColorStart, BackColorEnd, 90);
            GraphicsPath path = Suporte.GetRoundRectPath(rect, 8);
            e.Graphics.FillPath(b, path);

            ContentAlignment align = this.TextAlign;

            StringFormat format = new StringFormat();

            switch (align)
            {
                case ContentAlignment.TopLeft:
                    format.Alignment = StringAlignment.Near;
                    format.LineAlignment = StringAlignment.Near;
                    break;
                case ContentAlignment.TopCenter:
                    format.Alignment = StringAlignment.Center;
                    format.LineAlignment = StringAlignment.Near;
                    break;
                case ContentAlignment.TopRight:
                    format.Alignment = StringAlignment.Far;
                    format.LineAlignment = StringAlignment.Near;
                    break;
                case ContentAlignment.MiddleLeft:
                    format.Alignment = StringAlignment.Near;
                    format.LineAlignment = StringAlignment.Center;
                    break;
                case ContentAlignment.MiddleCenter:
                    format.Alignment = StringAlignment.Center;
                    format.LineAlignment = StringAlignment.Center;
                    break;
                case ContentAlignment.MiddleRight:
                    format.Alignment = StringAlignment.Far;
                    format.LineAlignment = StringAlignment.Center;
                    break;
                case ContentAlignment.BottomLeft:
                    format.Alignment = StringAlignment.Near;
                    format.LineAlignment = StringAlignment.Far;
                    break;
                case ContentAlignment.BottomCenter:
                    format.Alignment = StringAlignment.Center;
                    format.LineAlignment = StringAlignment.Far;
                    break;
                case ContentAlignment.BottomRight:
                    format.Alignment = StringAlignment.Far;
                    format.LineAlignment = StringAlignment.Far;
                    break;
            }

            rect.Inflate(-10, 0);


            e.Graphics.DrawString(Text, Font,
               new SolidBrush(ForeColor), rect, format);
        }
    }
}
