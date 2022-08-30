using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day7d
{
    internal class Book
    {
        public string title;
        public string author;
        public int pages;

        public Book(String aTitle, String aAuthor, int aPage)
        {
            title = aTitle;
            author = aAuthor;
            pages = aPage;
        }
    }
}
