using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace PPgame
{
    class Blocks
    {
        public GraphicsPath path1 = new GraphicsPath();
        
        public Blocks(int x, int y)
        {
            Point[] polypoints =
            {
                new Point(x-15,y-50),
                new Point(x+15,y-50),
                new Point(x+15,y+50),
                new Point(x-15,y+50)
            };

            path1.AddPolygon(polypoints);
        }
    }
}
