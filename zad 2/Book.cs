using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace zad_2
{
    internal class Book
    {
        public string Title { get; set; }
        string Author { get; set; }
        public Book(string title, string author)
        {
            Title = title;
            Author = author;
        }
        public override string ToString()
        {
            return $"{Title} - {Author}";
        }
    }
}
