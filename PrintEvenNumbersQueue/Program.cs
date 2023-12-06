namespace PrintEvenNumbersQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int[] numbers = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            Queue<int> numberQueue = new Queue<int>(numbers);
            Console.WriteLine(GetEvenNumbersAsString(numberQueue));
        }

        static string GetEvenNumbersAsString(Queue<int> queue)
        {
            List<int> evenNumbers = new List<int>();
            while (queue.Count > 0)
            {
                int number = queue.Dequeue();
                if (number % 2 == 0)
                {
                    evenNumbers.Add(number);
                }
            }
            return string.Join(", ", evenNumbers);
        }
    }

}
