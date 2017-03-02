using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace GraphicsFormApp
{
    class Square
    {
        private int size;
        Color color;

        public List<Vector2D> vb = new List<Vector2D>();

        public Square(Color color, int size = 100)
        {
            this.color = color;
            this.size = size;

            vb.Add(new Vector2D(-size, size, 0));
            vb.Add(new Vector2D(size, size, 0));
            vb.Add(new Vector2D(size, -size, 0));
            vb.Add(new Vector2D(-size, -size, 0));
        }

        public void Draw(Graphics g, List<Vector2D> vb)
        {
            Pen pen = new Pen(color, 4f);
            g.DrawLine(pen, vb[0].x, vb[0].y, vb[1].x, vb[1].y);
            g.DrawLine(pen, vb[1].x, vb[1].y, vb[2].x, vb[2].y);
            g.DrawLine(pen, vb[2].x, vb[2].y, vb[3].x, vb[3].y);
            g.DrawLine(pen, vb[3].x, vb[3].y, vb[0].x, vb[0].y);
        }

       
        public String toString()
        {
            return vb[0].toString() + "_" + vb[1].toString() + "\n" + vb[2].toString() + "_" + vb[3].toString() + "\n";
        }

    }
}
