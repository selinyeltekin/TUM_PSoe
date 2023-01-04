using System;

namespace StaticMethods_Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //is method that belongs to the actual class, you dont have to create an objects in order to use it or access it
            //example of static method
            //Console.WriteLine(Math.Sqrt(144));

            //static çevirince hata verdi, 
            UsefulTools tools = new UsefulTools();

            //Direkt classın yanına methodu yazıyoruz object yaratmadan
            UsefulTools.SayHi("Mike");

            Console.ReadKey();
        }
    }
}
