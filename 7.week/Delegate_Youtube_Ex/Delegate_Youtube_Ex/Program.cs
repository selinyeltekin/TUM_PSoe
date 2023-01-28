using System;

namespace Delegate_Youtube_Ex
{
    class Program
    {
        delegate void Dikdortgen(double x, double y); 
    
        static void Main(string[] args)
        {
            //delegate - temsilci, delegeler referans tipli oldugu icin obje olusturabilirim.
            Dikdortgen test = new Dikdortgen(alan);
            test += cevre; // olarak yazdigimizda alan ve cevre ikisini de cagirmis olacak.
           
            test(4, 6);

            Console.WriteLine("----------------------------");

            test -= alan;    //sadece cevre sonucunu yazdiracak.

            test(4, 6);

            Console.ReadKey();
        }

        static void cevre (double a, double b)
        {
            Console.WriteLine(2 * (a + b)); 
        }
        static void alan(double a, double b)
        {
            Console.WriteLine(a * b);
        }
    }
}
