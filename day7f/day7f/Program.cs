using System;

namespace day7f
{
    class Program
    {
        static void Main(string[] args)
        {
            Movie avengers = new Movie("The Avengers", "Joss Whendon", "PG-13");
            Movie shrek = new Movie("Shrek", "Adamn Adamnson", "Pg");
            // G, PG, PG-13, R, NR
            Console.WriteLine(avengers.Rating);
            Console.WriteLine(avengers.title);
            Console.WriteLine(shrek.Rating);
            Console.ReadLine();
        }
    }
}