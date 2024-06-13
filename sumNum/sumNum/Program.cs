namespace sumNum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Print the sum of the numbers
            int[] num = { 1, 2, 3, 4 };
            int sum = 0;
            for (int i = 0; i < num.Length; i++)
            {
                sum = sum + num[i];
            }
            Console.WriteLine($"The su of the numbers:{sum}");

            /////////////////////////////////////////////////////////////


            //print numbers that cannot be divided by 3


            int[] numbers = { 1, 2, 3, 4, 5 };
            List<int> list = new List<int>();
            for (int i = 0; i< numbers.Length; i++)
            {
                if (numbers[i] % 3 !=0)
                {
                    list.Add(numbers[i]);
                }
            }
            Console.WriteLine(list);
        }
    }
}