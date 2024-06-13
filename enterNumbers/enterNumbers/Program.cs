using System;

namespace enterNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            for(int i = 0; i<10 ; i++)
            {
                ReadNumber(start,end);
            }

            int ReadNumber(int start, int end)
            {
                string input = Console.ReadLine();
                try
                {
                    int number = int.Parse(Console.ReadLine());
                    if (number <= start || number >= end)
                    {
                        throw new ArgumentOutOfRangeException("Your number is not in range");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid number!");
                }
                catch (ArgumentOutOfRangeException ae)
                {
                    if
                }
                return 0;
            }
        }
    }
}