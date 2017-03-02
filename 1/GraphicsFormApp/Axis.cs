using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GraphicsFormApp
{
    class Axis
    {
        private int size;

        public List<Vector2D> vb = new List<Vector2D>();

        public Axis(int size)
        {
            this.size = size;
            vb.Add(new Vector2D(-size , 0, 0));
            vb.Add(new Vector2D(size, 0,0));
            vb.Add(new Vector2D(0, -size, 0));
            vb.Add(new Vector2D(0,size,0));
        }

        public void Draw(Graphics g, List<Vector2D> vb)
        {
            Pen pen = new Pen(Color.LightGreen, 2f);
            g.DrawLine(pen, vb[0].x, vb[0].y, vb[1].x, vb[1].y);
            g.DrawLine(pen, vb[2].x, vb[2].y, vb[3].x, vb[3].y);
        }
    }
}
