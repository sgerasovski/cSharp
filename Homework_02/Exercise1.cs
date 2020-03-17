using System;

namespace Homework_02
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercise 1

            string input = null;

            int inputParse;

            do
            {
                Console.WriteLine(input == null ? "Enter a Number" : "You entered an invaid number, please try again!");
                input = Console.ReadLine();
            } while (!int.TryParse(input, out inputParse));

            for(int i = 1; i <= inputParse; i++)
            {
                Console.WriteLine($"Counting: ...{i}");
            }

            input = null;

            do
            {
                Console.WriteLine(input == null ? "Enter another Number" : "You entered an invaid number, please try again!");
                input = Console.ReadLine();
            } while (!int.TryParse(input, out inputParse));

            for (int i = inputParse; i >= 1; i--)
            {
                Console.WriteLine($"Counting: ...{i}");
            }

        }
    }
}
