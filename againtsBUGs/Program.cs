namespace againtsBUGs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] plants = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int days = 0;
            int max = plants[0];
            for(int i= 1;i<n; i++)
            {
                if (plants[i] > max)
                {
                    max = plants[i];
                }
                else
                {
                    days++;
                    max = plants[i];
                }

            }
            Console.WriteLine(days);
        }
    }
}