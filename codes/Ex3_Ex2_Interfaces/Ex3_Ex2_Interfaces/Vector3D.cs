using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Ex3_Ex2_Interfaces
{
    internal class Vector3D : IVector
    {
        double X;
        double Y;
        double Z;
        public Vector3D(double x, double y, double z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }
        
        //Formulation of Euclidean
        public double Norm()
        {
            double n = Math.Sqrt(X * X + Y * Y + Z * Z);
            return n;
        }

        public static double DotProduct(Vector3D n
            )
        {
            double result = DotProduct(n);
            return result;
        }

        public void Print(string result)
        {
            Console.WriteLine("The result of the 3D Vector is : "+ result);
        }
    }
}
