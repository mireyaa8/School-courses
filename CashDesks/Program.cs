namespace CashDesks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] efficiency = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int clients = int.Parse(Console.ReadLine());
            int hours = 0;
            int total = 0;
            int totalWH = 0;
            for(int i = 0; i<efficiency.Length; i++)
            {
                totalWH = totalWH + efficiency[i];
            }

            for(int j = 0; j<clients; j++)
            {
                total++;
                hours++;
                if(hours == 4)
                {
                    total++;
                    totalWH= 0;
                }
                clients = clients - totalWH;
            }
            Console.WriteLine($"Time needed: {total}h.");

        }
    }
}