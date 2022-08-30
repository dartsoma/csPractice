using System;

namespace day7d
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("To Kill a MockingBird", "Aaron Sorkin", 281);
/*            book1.title = "To Kill a MockingBird";
            book1.author = "Aaron Sorkin";
            book1.pages = 281;*/

            Book book2 = new Book("Lord of the Rings", "Tolkien", 400);
            /*           book2.title = "Lord of the Rings";
                       book2.author = "Tolkien";
                       book2.pages = 700;
            */

            book1.pages = 100000;
            Console.WriteLine(book1.author);
            Console.WriteLine(book1.pages);

            Console.ReadLine();
        }
    }
}