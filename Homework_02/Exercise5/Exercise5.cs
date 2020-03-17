using System;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sumArr = new int[5];

            string input = null;

            int inputParse;

            int sum = 0;





            for (int i = 0; i < sumArr.Length; i++)
            {
                do
                {
                    Console.WriteLine(input == null ? "Enter a Number" : "You entered an invaid number, please try again!");
                    input = Console.ReadLine();
                } while (!int.TryParse(input, out inputParse));
                input = null;

                sumArr[i] = inputParse;
            }


            for(int i = 0; i < sumArr.Length; i++)
            {
                sum += sumArr[i];
            }

            Console.WriteLine($"The sum of all of your input numbers is: {sum}");
        }
    }
}
