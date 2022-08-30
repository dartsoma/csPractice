using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] numSet = {
            { 2,3 },
            { 4,3 },
            { 4,5 },
            { 6,5 }
            };

            Console.WriteLine(exponent(numSet[0, 0], numSet[0, 1]));
            Console.ReadLine();
        }

        static int exponent(int baseNum, int expNum)
        {
            int result = 1;


            for (int i = 0; i < expNum; i++)
            {
                result = result * baseNum;
            }

            return result;
        }
    }
}