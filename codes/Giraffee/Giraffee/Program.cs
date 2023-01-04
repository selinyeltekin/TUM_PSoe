using System;

namespace Giraffee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Movie avengers = new Movie("The Avengers", "Joss Whedon", "dog");
            Movie shrek = new Movie("Shrek", "Adam Adamson", "PG");
            //G, PG, PG-13, R, NR for nat rating

            //avengers.rating = "Dog";
            shrek.Rating = "R";          //cat yazdıgımda set tekı nr ı cıktı olarak verdı ama r yazdıgımızda valıd bır deger oldugu ıcın onu yazdı
            Console.WriteLine(shrek.Rating);
            Console.ReadLine();
        }
    }
}
