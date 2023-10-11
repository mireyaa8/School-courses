using System.Diagnostics.CodeAnalysis;

namespace Everythingincommon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] n = Console.ReadLine()
                .Split(" ")     
                .Select(int.Parse)
                .ToArray();

            int[] n2 = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();
            int sum = 0;
            bool areEqual = false;

            for (int i =0; i < n.Length; i++)
            {
                if (n[i] != n2[i])
                {
                    Console.WriteLine($"Arrays are not identical.");
                    Console.WriteLine($"Found difference at {i} index");
                    break;

                }
                sum += n[i];
                if( i==n.Length-1 && i==n2.Length-1)
                {
                    areEqual = true;
                }
                
            }
            if(areEqual )
            {
                Console.WriteLine($"Arrays are identical.");
                Console.WriteLine($"Sum: {sum}");
            }


        }
    }
}