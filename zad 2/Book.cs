using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_2
{
    internal class Book
    {
        string Title { get; set; }
        string Author { get; set; }
        public Book(string title, string author)
        {
            Title = title;
            Author = author;
        }
    }
}
