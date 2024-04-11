using System;

namespace zad5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = new List<int>();
            int divide = int.Parse(Console.ReadLine());

            Func<int,bool> filter = x => x%divide != 0;
            nums = nums.Where(filter).ToList();
            nums.Reverse();
            Console.WriteLine(string.Join(" ", nums));
        }
    }
}