using System;

namespace Exercise_4
{
    public interface IVector
    {
        public interface IVector
        {
            /* interface can't be instanciated just like an abstract class
             * interface properties and methods are public and abstract by default
             * therefore, no implementations are allowed inside an interface 
             * interface can't have static methods */
            double X { get; set; }
            double Y { get; set; }
            double Norm();
            void Print();
            //...exercise3 un 2. orneginin,, last weeks's methods

            //Revision-Ex4-Interfaces
            IVector CalculateDotProduct(IVector otherVector);
        }

        public class Vector2D : IVector
        {
            public double X { get; set; }
            public double Y { get; set; }
            public Vector2D(double x, double y)
            {
                this.X = x;
                this.Y = y;
            }
            public double Norm()
            {
                return Math.Sqrt(X * X + Y * Y);
            }
            public static double DotProduct(Vector2D v1, Vector2D v2) // static method implemented inside derived class
            {
                return (v1.X * v2.X + v1.Y * v2.Y);
            }
            public void Print()
            {
                Console.WriteLine("2D-Vector: [" + X + "," + Y + "]");
            }
            //...constructors, properties and last week's methods..

            Vector2D CalculateDotProduct(Vector2D otherVector)
            {
                return this.X * otherVector.X + this.Y * otherVector.Y;
            }
            
        } // Vector2D

        public class Vector3D : IVector
        {
            public double X { get; set; }
            public double Y { get; set; }
            public double Z { get; set; }
            public Vector3D(double x, double y, double z)
            {
                this.X = x;
                this.Y = y;
                this.Z = z;
            }
            public double Norm()
            {
                return Math.Sqrt(X * X + Y * Y + Z * Z);
            }
            public static double DotProduct(Vector3D v1, Vector3D v2)
            {
                return (v1.X * v2.X + v1.Y * v2.Y + v1.Z * v2.Z);
            }
            public void Print()
            {
                Console.WriteLine("3D-Vector: [" + X + "," + Y + "," + Z + "]");
            }
            //...constructors, properties and last week's methods..

            Vector3D CalculateDotProduct(Vector3D otherVector)
            {
                return this.X * otherVector.X + this.Y * otherVector.Y + this.Z * otherVector.Z;
            }


            //WHY WOULD THIS IMPLEMENTATION FAIL?
            //HINT: Look upcasting and downcasting.

        } // Vector3D
    }// Lecture3
}
