using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint_SAOD
{
    internal class MyCircle:MyFigure
    {
        public int r;
        public MyCircle(int x, int y, int r)
        {
            this.x = x;
            this.y = y;
            this.r = r;
        }
        public override void Draw(Graphics g)
        {
            Rectangle rectangle = new Rectangle(this.x - this.r, this.y - this.r, 2 * this.r, 2 * this.r);
            Pen pen = new Pen(Color.Purple, 3);
            g.DrawEllipse(pen, rectangle);
  
        }
    }
}
