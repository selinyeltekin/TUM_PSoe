using System;
using System.Collections;
using System.Linq;
using System.Collections.Generic;
using System.Data;

namespace Lecture_8
{
    public class People
    {
        public int Age { get; set; }
        public decimal Income { get; set; }
    }

    static public class ExtensionClass1    //name can be different its ok
    {
        //this is the extension class
        public static List<People> FilterList(this List<People> set, Func<People, bool> filterFunction)   //Takes inputs as People applies the function of filterDunction and returns it as bool.
        {
            var bucket = new List<People>();
            foreach (var p in set)
            {
                if (filterFunction(p))
                {
                    bucket.Add(p);
                }
            }
            return bucket;
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var dataset = new List<People>
            {
                new People {Age = 45, Income = 35000},
                new People {Age = 15, Income = 5000},
                new People {Age = 42, Income = 54000},
                new People {Age = 78, Income = 1135000},
                new People {Age = 25, Income = 35000},
                new People {Age = 5, Income = 35000},
                new People {Age = 98, Income = 35000},
            };


            //Önce Extension Methodsa baklaım dedi yarıda kesti.
            //var bucket = dataset.FilterList(people => people.Age > 40);
            var bucket = dataset.Where(p => p.Age > 30);

            //var bucket = FilterPeople(dataset);
            foreach(var p in bucket)
            {
                Console.WriteLine("The age is " + p.Age.ToString());
            }












            /*
             * IMPROVING THE CODE THATS WHY WE TURNED THESE INTO COMMENT*/


            //var bucket = new List<People>();    //bucket stores all the people that defined up there
            //foreach (var p in dataset)          //p is people
            //{
            //    if(p.Age > 30)
            //    {
            //        bucket.Add(p);
            //    }
            //}
            //foreach(var p in bucket)
            //{
            //    Console.WriteLine("The age is " + p.Age.ToString());
            //}

            Console.ReadKey();
        }
    }

}
