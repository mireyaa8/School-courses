using System;
namespace SmallestOfThreeNum
{
    internal class Program
    {
        
         static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());
            Numbers(n1,n2, n3);
        }
        static void Numbers(int n1, int n2, int n3)
        {
            if (n1 < n2 && n1 < n3)
            {
                Console.WriteLine(n1);
            }
            if (n2 < n1 && n2 < n3)
            {
                Console.WriteLine(n2);
            }
            if (n3 < n2 && n3 < n1)
            {
                Console.WriteLine(n3);
            }
        }
    }
}