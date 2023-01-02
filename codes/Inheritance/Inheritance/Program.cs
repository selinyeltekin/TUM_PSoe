using System;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Chef chef = new Chef();  //creating object of the class
            chef.MakeChicken();     //calling the method telling to cook
            //chef.MakePAsta();       //gives error because MakePAsta method is described in subclass
            chef.MakeSpecialDish();

            ItalianChef italianChef = new ItalianChef();
            italianChef.MakeChicken();
            //i dont want the italianchef to make bbq ribs
            //need to do overwriting
            italianChef.MakeSpecialDish();  //same method but the output is different

            Console.ReadKey();

        }
    }
}
