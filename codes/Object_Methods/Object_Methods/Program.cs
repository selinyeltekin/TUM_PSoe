﻿using System;

namespace Object_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Mike", "Civil Engineering", 2.8);
            Student student2 = new Student("Pam", "Art", 3.6);


            Console.WriteLine(student1.HasHonors());
            Console.WriteLine(student2.HasHonors());

            //Wait before closing
            Console.ReadKey();

        }
    }
}
