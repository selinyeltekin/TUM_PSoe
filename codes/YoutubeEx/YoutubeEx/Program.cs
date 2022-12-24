using System;

namespace YoutubeEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Jim", "Business", 2.8);
            Student student2 = new Student("Pam", "Art", 3.6);

            Console.WriteLine(student1.HasHonor());
            Console.WriteLine(student2.HasHonor());

            Console.ReadLine();
        }
    }
}
