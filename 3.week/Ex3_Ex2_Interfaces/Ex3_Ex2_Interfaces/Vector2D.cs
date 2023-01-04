using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3_Ex2_Interfaces
{
    internal class Vector2D : IVector
    {
        public double X;
        public double Y;

        public Vector2D(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }

       
        //formulation of Euclidean
        public double Norm()
        {
            return Math.Sqrt(X * X + Y * Y);
        }

        //Nokta çarpımı, Euclidean formülü devamı
        //static kullandık çünkü bu class a özel method
        public static double DotProduct(Vector2D v1, Vector2D v2)
        {
            double result = v1.X * v2.X + v1.Y * v2.Y;
            return (result);
        }

        public void Print(string result)
        {
            Console.WriteLine("The result of the 2D vector is: " + result);

        }
    }
}
