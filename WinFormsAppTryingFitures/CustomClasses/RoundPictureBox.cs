using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppTryingFitures
{
    internal class RoundPictureBox : PictureBox
    {
        protected override void OnPaint(PaintEventArgs pevent)
        {
            GraphicsPath g = new GraphicsPath();
           // g.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
            g.AddEllipse(0, 0, ClientSize.Width/5, ClientSize.Height/5);
            Region = new Region(g);


            base.OnPaint(pevent);
        }
    }
}
