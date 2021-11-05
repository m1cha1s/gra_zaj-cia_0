using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace gra_zajęcia_0
{
    class line
    {
        public point start;
        public point end;

        public line(point start, point end)
        {
            this.start = start;
            this.end = end;
        }

        public void draw(Graphics g)
        {
            g.DrawLine(Pens.Black, start.toDrawingPoint(), end.toDrawingPoint());
        }

        public bool isAttachedAt(point p)
        {
            return start.isPoint(p) || end.isPoint(p);
        }

        public point getOtherEnd(point p)
        {
            if (start.isPoint(p)) return end;
            if (end.isPoint(p)) return start;
            return end;
    }
}
