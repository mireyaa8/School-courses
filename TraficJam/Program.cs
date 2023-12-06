namespace TraficJam
{
    internal class Program
    {
        static void Main(string[] args)
        {
        {
            
                int n = int.Parse(Console.ReadLine());

                var queue = new Queue<string>();

                int count = 0;

                string command;

                while ((command = Console.ReadLine()) != "end")
                {
                    if (command == "green")
                    {

                        int carsToPass = Math.Min(n, queue.Count);

                        for (int i = 0; i < carsToPass; i++)
                        {
                            Console.WriteLine($"{queue.Dequeue()} passed!");
                            count++;
                        }
                    }
                    else
                    {
                        queue.Enqueue(command);
                    }
                }

                Console.WriteLine($"{count} cars passed the crossroads.");
            
        }

    }
}
}