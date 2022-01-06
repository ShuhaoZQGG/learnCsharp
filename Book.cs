using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learnCsharp
{
    internal class Book
    {
        // Class Attributes
        public string title;
        public string author;
        public int pages;

        // Constructor
        public Book(string aTitle, string aAuthor, int aPages)
        {
            title = aTitle;
            author = aAuthor;
            pages = aPages; 
        }
    }
}
