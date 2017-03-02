using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicsFormApp
{
    public partial class Form1 : Form
    {
        Square sq1 = new Square(Color.Blue);
        Square sq2 = new Square(Color.Red);
        Grid grid = new Grid(800, 50);
        Axis axis = new Axis(1000);
        public Form1()
        {
            InitializeComponent();
            Matrix m1 = new Matrix(1,3,1,1);
            Matrix m2 = new Matrix(2, 4, -1, 3);
            this.Size = new Size(800, 600);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            List<Vector2D> vb;
           
            //Matrix s = Matrix.Scale(1.5f);
            vb = new List<Vector2D>();
           // Console.Write(sq1.toString());
           // Console.Write("\n");
            foreach (Vector2D v in sq1.vb)
            {
                Vector2D vp = new Vector2D();
                vp = v.addVector(new Vector2D(0, 0, 0));
                vb.Add(vp);
                Console.Write(vp.toString() + "_");
            }
            vb = ViewportTransformation(800, 600, vb);
            sq1.Draw(e.Graphics, vb);
            // vb = ViewportTransformation(800, 600, sq2.vb);
            // sq2.Draw(e.Graphics, vb);
            vb = new List<Vector2D>();
            foreach(Vector2D v in grid.vb)
            {
                vb.Add(v.addVector(new Vector2D(400, -300, 0)));
            }
            vb = ViewportTransformation(800, 600, grid.vb);
            grid.Draw(e.Graphics, vb);

            vb = ViewportTransformation(800, 600, axis.vb);
            axis.Draw(e.Graphics, vb);
        }

        static List<Vector2D> ViewportTransformation(float width, float height, List<Vector2D> vb)
        {
            List<Vector2D> res = new List<Vector2D>();
            
            float delta_x = width / 2;
            float delta_y = height / 2;

            foreach (Vector2D v in vb)
            {
                res.Add(new Vector2D(v.x + delta_x, v.y + delta_y, 0));
            }
            return res;
        }
    }
}
