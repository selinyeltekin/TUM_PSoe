using System;

namespace Inheritance_Youtube
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Chef is the super class
            Chef chef = new Chef();  //object definition
            //chef.MakeChicken();    //telling chef to make some chicken
            chef.MakeSpecialDish(); 

            //sub class
            ItalianChef italianChef = new ItalianChef();  //object definition
            italianChef.MakeSpecialDish();

            Console.ReadLine();
        }
    }
}
