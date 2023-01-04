using System;

namespace PassBeyValue_Ex2
{
    class Program
    {
        public static void ReplacePoint(Point a, Point b)  //Passing by value 
        {
            a = b;
        }
        public static void ReplacePoint(ref Point a, Point b)
        {

        }
        public static void Main()
        {
            Point firstPoint = new Point(0,0);
            Point secondPoint = new Point(1,1);

            Console.WriteLine("Original: (" + firstPoint.x + "," + firstPoint.y+")");
            Program.ReplacePoint(firstPoint, secondPoint);

            Console.WriteLine("Modified (pass by value): (" + firstPoint.x +"," + firstPoint.y +")");
            Program.ReplacePoint(ref firstPoint, secondPoint);

            Console.WriteLine("Modified (pass by reference): (" + firstPoint.x + "," + firstPoint.y + ")");
        }
    }
}
