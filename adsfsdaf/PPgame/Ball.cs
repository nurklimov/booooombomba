using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace PPgame
{
    class Ball
    {
        public GraphicsPath path2 = new GraphicsPath();
        

        public Ball(int x, int y)
        {
            path2.AddEllipse(x - 17, y - 17, 34, 34);
        }
    }
}
