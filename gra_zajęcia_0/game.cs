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
        List<Option> options;

        public game(int n, int r, int fleaSize)
        {
            p = new polygon(n, r);
            options = p.getDiagonalsAtPoints();
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

        public void update()
        {
            foreach(Option option in options)
            {
                foreach(flea f in fleas)
                {
                    if (f.pos.isPoint(option.corner))
                    {
                        int diagonal = f.decide(option.diagonals);
                        f.jump(p.diagonals[diagonal], diagonal);
                    }
                }
            }
        }
    }
}
