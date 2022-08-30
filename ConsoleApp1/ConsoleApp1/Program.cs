using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] luckyNum = {11, 22, 32, 43, 52};
            for (int i = 0; i < luckyNum.Length; i++)
            {
                Console.WriteLine(luckyNum[i]);
            }
            Console.ReadLine();
        }
    }
}