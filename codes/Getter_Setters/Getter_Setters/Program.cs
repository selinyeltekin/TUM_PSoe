using System;
using System.Net.NetworkInformation;

namespace Getter_Setters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Movie avengers = new Movie("The Avengers", "Joss Whedon", "PG-13");    //when ı changed the rating into dog it gave me NR as the result
            Movie shrek = new Movie("The Shrek", "Adam Adamson", "PG");
            //G, PG, PG-13, R, NR -- we need to make sure that it is only taking rating parameters so we have to use getters and setters

            //avengers.rating = "Dog"; //not let me do to this because it is private but setter will allow me to do so

            shrek.Rating = "Cat";
            Console.WriteLine(shrek.Rating);    //gave NR as a result not cat because we secured the code by getters and setter
            Console.WriteLine(avengers.Rating);    //gives error becuase it is private and cannot reached by out of the class so we need to use getters and setters
            Console.ReadKey();
        }
    }
}
