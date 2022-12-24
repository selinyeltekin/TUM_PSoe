using System;

namespace Ex2_ComplexNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //these are two objects, creating

            Book book1 = new Book("Harry Potter", "Jk Rowling", 400); //calligng the constructer method

            Book book2 = new Book("Lord of the Rings", "Tolkein", 500);

            Console.WriteLine(book1.title, book1.author);

            //Wait before closing
            Console.ReadKey();
        }
    }
}
