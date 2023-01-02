using System;

namespace Factorial_Ex2
{
    internal class FactorialEx
    {
        //a function named 'Factorial' is defined that it takes one integer-type input and returns integer type value
        public static int Factorial(int number)
        {
            if (number == 0)
                return 1;
            else
                return number * Factorial(number - 1);  //n! = n*(n-1)!
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a non-negative number: ");
            int inputNumber = Convert.ToInt32(Console.ReadLine());   //reading and converting the user input

            while (inputNumber < 0)    //checking for negative  numbers
            {
                Console.WriteLine("Number can not be negative. \nEnter a number: ");
                inputNumber = Convert.ToInt32(Console.ReadLine());
            }

            int result = FactorialEx.Factorial(inputNumber);    //function call to 'Faktorial' defined above
            Console.WriteLine(inputNumber + "! is " + result);

            Console.ReadKey();
        }
        
    }
}
