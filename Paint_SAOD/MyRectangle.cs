using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint_SAOD
{
    internal class MyRectangle:MyFigure
    {
        public int width;
        public int height;
        public MyRectangle(int x, int y, int height, int width)
        {
            this.x = x;
            this.y = y;
            this.height = height;
            this.width = width;
        }
        public override void Draw(Graphics g)
        {
            Rectangle rectangle = new Rectangle(this.x, this.y, this.height, this.width);
            Pen pen = new Pen(Color.Purple, 3);
            g.DrawRectangle(pen, rectangle);
        }
    }
}
