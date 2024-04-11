namespace dictionaryDr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<double, int> count = new Dictionary<double, int>();
            double[] values = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(double.Parse)
                    .ToArray();
            foreach (double value in values)
            {
                
                if (count.ContainsKey(value))
                {
                    count[value]++;

                }
                else
                {
                    count[value] = 1;
                }
            }
            foreach(var pair in count)
            {
                Console.WriteLine($"{pair.Key} - {pair.Value} times");
            }

        }
    }
}