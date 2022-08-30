using System;

namespace day7e
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Jordan", "Computer Science", 3.9);
            Student student2 = new Student("Patrick", "Art", 2.8);

            Console.WriteLine(student1.HasHonors());
            Console.WriteLine(student2.HasHonors());
            Console.ReadLine();
        }

     }
}