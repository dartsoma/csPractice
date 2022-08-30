using System;

namespace day7g
{
    class Program
    {
        static void Main(string[] args)
        {
            Song holiday = new Song("Holiday", "Green Day", 200);
            Song kashmir = new Song("Kashmir", "Led Zepplin", 150);



            Console.WriteLine(Song.songCount);
            Console.WriteLine(kashmir.getSongCount());

            Console.ReadLine();
        }
    }
}