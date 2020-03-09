using System;

namespace Homework_01
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int inputParse;

            if (int.TryParse(input, out inputParse))
            {
                if (inputParse == 1)
                {
                    Console.WriteLine("You got a new car!");
                }
                else if (inputParse == 2)
                {
                    Console.WriteLine("You got a new plane!");
                } else if (inputParse == 3)
                {
                    Console.WriteLine("You got a new bike!");
                } else
                {
                    Console.WriteLine("Please enter a number between 1 and 3");
                }
            } else
            {
                Console.WriteLine("Please enter a number");
            }
        }
    }
}
