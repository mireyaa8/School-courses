namespace tryreopirow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
          
            string[] names = Console.ReadLine().Split();
            Func<string, int> sum = f => f.Select(c => (int)c).Sum();

            foreach (var name in names)
            {
                if (sum(name) <= n)
                {
                    Console.WriteLine(name);
                }
            }

        }
    }
}