using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsFormApp
{

    class Matrix
    {
        float[,] mat = new float[2,2];

        public Matrix(float a11, float a12,
                float a21, float a22)
        {
            mat[0, 0] = a11; mat[0, 1] = a12;
            mat[1, 0] = a21; mat[1, 1] = a22;
        }

        public Matrix() : this(0, 0, 0, 0) { }

        public Matrix(float f) : this(f,0,0,f)
        {
        }

        public static Vector2D ToVector2D(Matrix m1)
        {
            return new Vector2D(m1.mat[0, 0], m1.mat[0, 1], 0);
        }

        public static Matrix operator*(Matrix mt, float f)
        {
            Matrix m = new Matrix();
            for(int r = 0; r < 1; r++)
            {
                for(int c = 0; c < 2; c++)
                {
                    m.mat[r, c] = mt.mat[r, c] * f;
                }
            }
            return m;
        }

        public static Matrix operator*(Matrix mt1, Matrix mt2)
        {
            Matrix m = new Matrix();
            for(int r= 0; r < 2; r++)
            {
                for(int c= 0; c < 2; c++)
                {
                    float sum = 0f;
                    for (int i = 0; i < 2; i++)
                    {
                        sum += mt1.mat[r, i] * mt2.mat[i, c];
                    }
                    m.mat[r, c] = sum;
                }
            }
            return m;
        }

        public static Matrix Scale(float s)
        {
            Matrix m = new Matrix(s);
            return m;
        }

        public static Vector2D operator*(Matrix m1, Vector2D v)
        {
            Matrix m = m1 * new Matrix(v);
            return ToVector2D(m);
        }

 
        public Matrix(Vector2D a)
        {

        }

        public void addMatrix(Matrix a)
        {
            
        }

        public void subtractMatrix(Matrix a)
        {

        }

    }
}
