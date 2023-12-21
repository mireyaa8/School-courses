namespace Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
            string[] input = Console.ReadLine().Split(' ');

            int n = int.Parse(input[0]);
            int s = int.Parse(input[1]);
            int x = int.Parse(input[2]);

            Console.WriteLine(ProcessQueueOperations(n, s, x));



        }

        static string ProcessQueueOperations(int n, int s, int x)
        {
            Queue<int> queue = new Queue<int>();

          
            string[] elements = Console.ReadLine().Split(' ');

            for (int i = 0; i < n; i++)
            {
                int element = int.Parse(elements[i]);
                queue.Enqueue(element);
            }

            for (int i = 0; i < s; i++)
            {
                if (queue.Count > 0)
                {
                    queue.Dequeue();
                }
            }

            if (queue.Contains(x))
            {
                return "true";
            }
            else if (queue.Count > 0)
            {
                return queue.Min().ToString();
            }
            else
            {
                return "0";
            }

        }
    }

}