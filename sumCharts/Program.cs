namespace sumCharts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int total = 0;

            for(int i = 0; i < num; i++)
            {
                decimal ch = decimal.Parse(Console.ReadLine());
                total += (int)ch;


            }
            Console.WriteLine($"The sum equals: {total}");
        }
    }
}