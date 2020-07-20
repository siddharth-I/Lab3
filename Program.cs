using System;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            Console.WriteLine("What is your name?");
            name = Console.ReadLine();
            int number;
            Console.Write("Enter a whole number between 1 and 100: ");
            number = int.Parse(Console.ReadLine());
            if (number % 2 == 0 && number >= 2 & number <= 25)
            {
                Console.WriteLine("Even and less than 25");
            }
            else if (number % 2 == 0 && number >= 26 & number <= 60)
            {
                Console.WriteLine("Even");
            }
            else if (number % 2 == 0 && number > 60)
            {
                Console.WriteLine(number + " and even");
            }
            else if (number % 2 != 0)
            {
                Console.WriteLine(number + " and odd");
            }
            else if (number % 2 != 0 && number > 60)
            {
                Console.WriteLine(number + " and odd");
            }
        }
    }
}
