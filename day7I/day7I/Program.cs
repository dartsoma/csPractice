    using System;

    namespace day7I
    {
        class Program
        {
            static void Main(string[] args)
            {

                Chef chef = new Chef();
                chef.makeChicken();
                ItalianChef italianchef = new ItalianChef();
                italianchef.makeChicken();
                italianchef.makeSpecialDish();

                Console.ReadLine();
            }
        }
    }