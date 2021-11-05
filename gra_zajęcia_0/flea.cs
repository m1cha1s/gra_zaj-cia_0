using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace gra_zajęcia_0
{
    class flea
    {
        public point pos;
        public point size;

        public int prevDiagonal;

        public int fleaNum;

        public flea(point pos, point size, int fleaNum)
        {
            this.pos = pos;
            this.size = size;
            this.fleaNum = fleaNum;
        }

        public int decide(List<int> options)
        {
            int smallest = options[0];
            foreach(int option in options)
            {
                if (option < smallest) smallest = option;
            }
            return smallest;
        }

        public void jump(point target, int diagonalNum)
        {
            pos.setPoint(target);
            prevDiagonal = diagonalNum;
        }

        public void draw(Graphics g)
        {
            g.FillEllipse(Brushes.Red, pos.x - (size.x / 2), pos.y - (size.y / 2), size.x, size.y);
            g.DrawString(Convert.ToString(fleaNum), SystemFonts.DefaultFont, Brushes.Black, pos.toDrawingPoint());
        }
    }
}
