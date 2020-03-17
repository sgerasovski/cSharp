using System;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = null;

            int inputParse;

            do
            {
                Console.WriteLine(input == null ? "Enter a Number" : "You entered an invaid number, please try again!");
                input = Console.ReadLine();
            } while (!int.TryParse(input, out inputParse));


            do
            {
                for (int i = 1; i <= inputParse; i++)
                {
                    if (!(i % 3 == 0 || i % 7 == 0))
                    {
                        Console.WriteLine($"Counting: ...{i}");
                    }
                }
            } while (inputParse <= 100);


            if(inputParse >= 100)
            {
                Console.WriteLine("The limit is reached!");
            }
        }
    }
}
