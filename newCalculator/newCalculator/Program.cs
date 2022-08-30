using System;

namespace newCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            try {
                Console.Write("Enter a Number: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter an Operator:");
                string op = Console.ReadLine();

                Console.Write("Enter a Number: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                if (op == "+")
                {
                    Console.WriteLine(num1 + num2);
                }
                else if (op == "-")
                {

                    Console.WriteLine(num1 - num2);
                }
                else if (op == "/")
                {

                    Console.WriteLine(num1 / num2);
                }
                else if (op == "*")
                {

                    Console.WriteLine(num1 * num2);
                }
                else
                {
                    Console.WriteLine("Invalid Operator!");
                }

            }
           catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
           catch (FormatException e)
           {
                Console.WriteLine(e.Message);
           } finally
           {
                Console.WriteLine("Process Ended.");
           }


            Console.ReadLine();
        }
    }


}