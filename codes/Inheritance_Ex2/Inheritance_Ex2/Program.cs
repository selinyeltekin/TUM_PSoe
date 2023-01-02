using System;

namespace Inheritance_Ex2
{
    public class Program
    {
        static void Main(string[] args)
        {
            

            Vector2D a1 = new Vector2D(3, 4);
            Vector3D a3 = new Vector3D(3, 4, 5);
            //Console.WriteLine(a1.Norm()); // 5 basması lazım
            //Console.WriteLine(a3.Norm());

            //Vector.DotProduct(a1, a1);
            //Console.WriteLine(a1.x);

            a1.Print();
            a3.Print(); 

            
        }
    }
}
