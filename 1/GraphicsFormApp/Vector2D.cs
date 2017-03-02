using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsFormApp
{
    class Vector2D
    {
        public float x;
        public float y;
        public float z;

        public Vector2D() : this(0, 0, 0)
        {
        }

        public Vector2D(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public Vector2D addVector(Vector2D a)
        {
            Vector2D v = new Vector2D();
            v.x = x + a.x;
            v.y = y + a.y;
            v.z = z + a.z;
            return v;
        }

        public String toString()
        {
            return x + "," + y;
        }


    }
}