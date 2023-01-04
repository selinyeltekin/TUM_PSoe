using System;

namespace giraffe3
{
    internal class Program
    {
        static void Main(string[] args)
        
        { //Static Methods and Classes

            // Console.WriteLine(Math.Sqrt(144));  //ı am able to use the method wıthout creatıng class
            //Math myMath = new Math();  // i am not able to create an instance of math class because it is a static class

            UsefulTools tools = new UsefulTools();
            UsefulTools.SayHi("Mike");

            Console.ReadLine();
        }
    }
}
