namespace BlackFlag
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int dailyPlunder = int.Parse(Console.ReadLine());
            int expectedPlunder = int.Parse(Console.ReadLine());
            double total = 0;
            for (int i = 0; i < days; i++)
            {
                total += dailyPlunder;
                if (i % 3 == 0)
                {
                    total += 0.5 * dailyPlunder;

                }
                if (i % 5 == 0)
                {
                    total -= 0.3 * dailyPlunder;

                }

            }
            if (total >= expectedPlunder)
            {
                Console.WriteLine($"Ahoy! {total:F2} plunder gained.");
            }
            else
            {
                double percentage = (total / expectedPlunder) * 100;
                Console.WriteLine($"Collected only {percentage:F2}% of the plunder.");
            }

        }
    }
}