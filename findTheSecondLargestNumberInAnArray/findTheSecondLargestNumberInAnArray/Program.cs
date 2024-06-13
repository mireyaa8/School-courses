namespace findTheSecondLargestNumberInAnArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Find the Second Largest Number in an Array

            int[] input = { 1, 8, 2, 9, 3 };
            int maxNum = 0;
            int maxNum2 = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] > maxNum)
                {
                    maxNum = input[i];
                }
            }
            for (int j = 0; j < input.Length; j++)
            {
                if (maxNum > input[j] && maxNum2 < input[j])
                {
                    maxNum2 = input[j];
                }
            }

            Console.WriteLine($"maxNum:{maxNum} maxNum2:{maxNum2}");
        }
    }
}