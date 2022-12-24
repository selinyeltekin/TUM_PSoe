using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2_ComplexNumbers
{
    internal class Book
    {
        public string title;
        public string author;
        public int pages;

        //is gonna be the constructer 
        public Book(string aTitle, string aAuthor, int aPages)
        {
            title = aTitle;
            author = aAuthor;
            pages = aPages;
        }
    }
}
