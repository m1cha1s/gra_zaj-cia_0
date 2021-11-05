using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace gra_zajęcia_0
{
    class point
    {
        public int x, y;
        Point dPoint;

        public point(int x, int y)
        {
            this.x = x;
            this.y = y;
            dPoint = new Point(x, y);
        }

        public Point toDrawingPoint()
        {
            dPoint.X = x;
            dPoint.Y = y;
            return dPoint;
        }

        public void setPoint(point target)
        {
            x = target.x;
            y = target.y;
        }

        public bool isPoint(point p)
        {
            return x == p.x && y == p.y;
        }
    }
}
