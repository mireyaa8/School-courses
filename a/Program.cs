using System.Xml.Schema;

namespace a
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int arraySize = int.Parse(Console.ReadLine());

            int[] nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            for(int i = 0; i < arraySize; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }
            int totalSum = 0;
            foreach( int num in nums)
            {
                totalSum += num;
            }
            Console.WriteLine(totalSum);

        }
    }
}