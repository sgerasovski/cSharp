using System;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a name!");
            string[] names = new string[] { };
            string firstInput = Console.ReadLine();
            Array.Resize(ref names, names.Length + 1);
            names[names.Length - 1] = firstInput;
            string input = null;
            char inputParse;

            void YesOrNo()
            {
                Console.WriteLine("Would you like to add another name?");
                do
                {
                    Console.WriteLine(input == null ? "Enter Y or N" : "You entered an invaid character, please try again!");
                    input = Console.ReadLine();
                } while (!char.TryParse(input, out inputParse));
                input = null;

                if (inputParse == 'Y' || inputParse == 'y')
                {
                    Console.WriteLine("Please enter desired name.");
                    string nThInput = Console.ReadLine();
                    Array.Resize(ref names, names.Length + 1);
                    names[names.Length - 1] = nThInput;
                    YesOrNo();
                }
                else if (inputParse == 'N' || inputParse == 'n')
                {
                    foreach (string item in names)
                    {
                        Console.WriteLine(item);
                    }
                }
                else
                {
                    Console.WriteLine("Please enter Y or N");
                    YesOrNo();
                }
            }
            YesOrNo();
        }
    }
}
