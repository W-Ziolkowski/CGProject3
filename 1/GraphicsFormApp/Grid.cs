using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GraphicsFormApp
{
    class Grid
    {
        private int size;
        private int spacing;

        public List<Vector2D> vb = new List<Vector2D>();


        public Grid(int size, int spacing)
        {
            this.size = size;
            this.spacing = spacing;

            for(int i = 0; i < size; i++)
            {
                vb.Add(new Vector2D(-size, size - i * spacing, 0));
                vb.Add(new Vector2D(size, size - i * spacing, 0));
                vb.Add(new Vector2D(size - i* spacing, -size, 0));
                vb.Add(new Vector2D(size - i * spacing, size, 0));
            }
        }

        public void Draw(Graphics g, List<Vector2D> vb)
        {
            Pen pen = new Pen(Color.Gray, 2f);
            for (int i = 0; i < size / 4; i++)
            {
                g.DrawLine(pen, vb[i].x, vb[i].y, vb[i+1].x, vb[i+1].y);
                g.DrawLine(pen, vb[i+2].x, vb[i+2].y, vb[i+3].x, vb[i+3].y);
                i = i + 3;
            }
           
        }

    }
}

