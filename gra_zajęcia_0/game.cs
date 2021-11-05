using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace gra_zajęcia_0
{
    class game
    {
        polygon p;
        List<flea> fleas = new List<flea>();

        public game(int n, int r, int fleaSize)
        {
            this.p = new polygon(n, r);
            for(int i = 0; i < n; i ++)
            {
                point pos = new point(0, 0);
                pos.setPoint(p.points[i]);
                fleas.Add(new flea(pos, new point(fleaSize, fleaSize), i));
            }
        }

        public void draw(Graphics g)
        {
            p.draw(g);
            foreach(flea f in fleas)
            {
                f.draw(g);
            }
        }
    }
}
