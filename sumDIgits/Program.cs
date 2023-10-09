namespace sumDIgits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int sum = 0;
            for (int i = 0; i < input.Length; i++)
            {
                sum+= input[i];

                }
            Console.WriteLine(sum); 

            }
    }
}