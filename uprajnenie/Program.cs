using System.Reflection;

namespace uprajnenie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { -3, -1, -2, -1, -5, -9, -1, -2 };
            // Console.ReadLine()
            // .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            // .Select(int.Parse)
            // .ToArray();
            
            int maxNum = int.MinValue;
            for (int i = 0; i < nums.Length; i++)
            {

                if (nums[i] > maxNum)
                {
                    maxNum = nums[i];
                }
            }
            Console.WriteLine($"The biggest number from the given numbers is: {maxNum}");
            int[] inpNums = { 3, 1, 2, 1, 5, 9, 1, 2 };
            PrintMinValue(inpNums);

            inpNums = new [] { -3, -1, -2, -1, -5, -9, -1, -2 };

            PrintMinValue(inpNums);

        }
        static void PrintMinValue(int[] numbers)
        {
          
            int minNum = int.MaxValue;
            for(int i = 0; i< numbers.Length; i++)
            {
                if (numbers[i]<minNum)
                {
                    minNum= numbers[i];
                }
            }
            Console.WriteLine($"The smallest number from the given numbers is: {minNum}");
            
        }
    }
}