using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Ex2
{
    //creating abstract class
    public abstract class Vector
    {
        //abstract methods dont require definitions, just declarations are enough but must be overriden/implemented in derived classes
        public abstract double Norm();

        //regular methods require definitions which can't be overriden in derived class but can be overloaded
        public static double DotProduct(Vector2D v1, Vector2D v2)
        {
            return (v1.x * v2.x + v1.y * v2.y);
        }

        public virtual void Print()
        {

        }
       
           
        
    }
    public class Vector2D : Vector
    {
        public double x, y;

        public Vector2D(double X, double Y)
        {
            this.x = X;
            this.y = Y;
        }
        public override double Norm()
        {
            return Math.Sqrt(x * x + y * y);
        }

        public override void Print()
        {
            Console.WriteLine("The x value of vector is : " + this.x + "  the y value of vector is: " + this.y);
            
        }
    }
    public class Vector3D : Vector
    {
        public double x, y, z;
        public Vector3D(double X, double Y, double Z)
        {
            this.x = X;
            this.y = Y;
            this.z = Z;
        }

        public override double Norm()
        {
            return Math.Sqrt(x * x + y * y + z * z);
        }

        //overload ettim
        public static double DotProduct(Vector3D v1, Vector3D v2)
        {

            return (v1.x * v2.x + v1.y * v2.y + v1.z * v2.z);
        }

        public override void Print()
        {
            Console.WriteLine("The x value of vector is : " + this.x + "  the y value of vector is: " + this.y + " z value is: "+ this.z);

        }
    }
}
