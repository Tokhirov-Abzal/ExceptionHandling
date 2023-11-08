using System;

namespace Task1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // TODO: Implement the task here.

            while (true)
            {
                try
                {
                    Console.WriteLine("Please enter string:");
                    var enteredInp = Console.ReadLine();
                    char firstChar = GetFirstChar(enteredInp);

                    Console.WriteLine($"First char is: {firstChar} \n");
                }
                catch (ArgumentNullException e)
                {
                    Console.WriteLine(e.Message);
                    continue;
                }

            }

        }

        static char GetFirstChar(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                throw new ArgumentNullException("Invalid input. Please enter non-empty string");
            }

            return input[0];
        }
    }
}