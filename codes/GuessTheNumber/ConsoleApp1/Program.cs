using System;
using System.Runtime.Intrinsics.Arm;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            string password = "password"; //user needs to guess this
            var input = " ";   //user input will be stored in here

            while (password != input)
            {
                Console.WriteLine("Type in password: ");
                input = Console.ReadLine();
                if ( input == password)
                {
                    Console.WriteLine("Correct Password!");
                }
                else
                {
                    Console.WriteLine("Wrong password, try again");
                }
            }
            */
       




            //--------GuessTheNumberEx
            int secretNumber = 37; //user needs to guess this
            Console.WriteLine("Enter a number between 35 and 40: ");
            int input = ConvertToInt(Console.ReadLine()) ;   //user input will be stored in here
        }
    }
}
