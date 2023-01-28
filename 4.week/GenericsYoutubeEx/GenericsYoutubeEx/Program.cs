using System;
using System.Collections.Generic;

namespace GenericsYoutubeEx
{
    // Here are 5 types of Constraints!! 
    // where T : IComparable
    // where T : Product
    // where T : struct
    // where T : class
    // where T : new()

    class Program
    {
        static void Main(string[] args)
        {
            var number = new Nullable<int>();
            Console.WriteLine("Has Value ? " + number.HasValue);
            Console.WriteLine("Value: " + number.GetValueOrDefault());









            /*
            var book = new Book { Isbn = "1111", Title = "C# Advanced" };

            //var numbers = new List();
            //numbers.Add(10);

            //var books = new BookList();
            //books.Add(book);

            var numbers = new GenericList<int>();
            numbers.Add(10);

            var books = new GenericList<Book>();
            books.Add(new Book());

            var dictionary = new GenericDictionary<string, Book>();
            dictionary.Add("1234", new Book());
            */
        }
    }
}
