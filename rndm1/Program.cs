namespace rndm1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] nums = new int[n];
            string[] input = Console.ReadLine()
                .Split(" ");
            for(int i  = 0; i < n; i++)
            {
                nums[i] = int.Parse(input[i]);
            }
            int highest = nums[0];
            for(int i = 0; i < n; i++)
            {
                if (nums[i] > highest)
                {
                    highest = nums[i];
                }
            }
            Console.WriteLine(highest);



///////////////////////////////////////////////////////////////////////////////////////////////////////////////
///

            int n1 = int.Parse(Console.ReadLine() );
            int[] r = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            int sum = 0;
            foreach(int i in r)
            {
                sum += nums[i];
            }
            Console.WriteLine(sum); 
        }
    }
}