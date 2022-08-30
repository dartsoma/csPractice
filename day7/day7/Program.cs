using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            int index = 200;

            while (index >= 1)
            {

                Console.WriteLine(index);
                index--;
            }
            //do while does the command first then checks for another rather then checking before starting
            /*
            do
            {
                Console.WriteLine(index);
                index--;
            }
            while (index >= 1);
            */

            Console.ReadLine();
        }
    }
}