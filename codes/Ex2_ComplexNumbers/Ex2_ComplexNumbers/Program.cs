using System;

namespace Ex2_ComplexNumbers
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a complex number: ");
            var x = Console.ReadLine();

            ComplexNumbers c;   //Creating a new complex number

            bool works = ComplexNumbers.TryParseComplex(x, out c);

            if (works)   //checks if parsing worked or not
            {
                Console.WriteLine("Parsed successfully.");
            }
            else
            {
                Console.WriteLine("Parsing failed. Invalid complex number.");
            }

            Console.WriteLine("Norm: " + c.GetNorm());

            //Wait before closing
            Console.ReadKey();
        }
    }
}
