using System;
using System.Security.Cryptography.X509Certificates;

namespace Generics_YT_L4
{
    class Program
    {
        static void Main(string[] args)
        {
            //generic = "not specific to a particular data type"
            //          add <T> to: classes, methods, fields, etc.
            //          allows for code reusability for different data types

            int[] intArray = { 1, 2, 3 };
            double[] doubleArray = { 1.0, 2.0, 3.0 };
            String[] stringArray = { "1", "2", "3" };

            displayElements(intArray);
            displayElements(doubleArray);
            displayElements(stringArray);


            Console.ReadKey();
        }

        //It is kinda hard to write codes creating methods each time so we need generics
        //Creating a method to display the elements

        /*
        public static void displayElements(int[] array)
        {
            foreach (int element in array)
            {
                Console.WriteLine(element + " ");
            }
        }

        public static void displayElements(double[] array)
        {
            foreach (int element in array)
            {
                Console.WriteLine(element + " ");
            }
        }
        */


        //We will turn this into generics
        public static void displayElements<Thing>(Thing[] array)
        {
            foreach (Thing element in array)
            {
                Console.WriteLine(element + " ");
            }
        }
    }
}
