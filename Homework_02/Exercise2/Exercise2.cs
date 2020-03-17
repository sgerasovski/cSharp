using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercise 2

            string input = null;

            int inputParse;

            do
            {
                Console.WriteLine(input == null ? "Enter a Number" : "You entered an invaid number, please try again!");
                input = Console.ReadLine();
            } while (!int.TryParse(input, out inputParse));

            for (int i = 2; i <= inputParse; i++)
            {
                if(i % 2 == 0)
                {
                    Console.WriteLine($"Counting: ...{i}");
                }
            }

            input = null;

            do
            {
                Console.WriteLine(input == null ? "Enter another Number" : "You entered an invaid number, please try again!");
                input = Console.ReadLine();
            } while (!int.TryParse(input, out inputParse));

            for (int i = inputParse; i >= 1; i--)
            {
                if(i % 2 != 0 || i == 1)
                {
                    Console.WriteLine($"Counting: ...{i}");
                }
            }
        }
    }
}
