using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace gra_zajęcia_0
{
    class polygon
    {
        public List<point> points = new List<point>();
        public List<line> sides = new List<line>();
        public List<line> diagonals = new List<line>();

        public polygon(int n, int r)
        {
            for(int i = 0; i < n; i ++)
            {
                points.Add(new point(Convert.ToInt32(r * Math.Cos(((2 * Math.PI) / n) * i)), Convert.ToInt32(r * Math.Sin(((2 * Math.PI) / n) * i))));
            }

            for(int i = 0; i < points.Count - 1; i ++)
            {
                sides.Add(new line(points[i], points[i + 1]));
            }
            sides.Add(new line(points[points.Count - 1], points[0]));


            for (int i = 0; i < points.Count; i ++)
            {
                for(int j = i + 2; j < points.Count; j ++)
                {
                    diagonals.Add(new line(points[i], points[j]));
                }
            }
        }

        public void draw(Graphics g)
        {
            foreach(line side in sides)
            {
                side.draw(g);
            }
            foreach(line diagonal in diagonals)
            {
                diagonal.draw(g);
            }
        }
    }
}
