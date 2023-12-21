using System;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int order = int.Parse(Console.ReadLine());
            int[] arr = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            Queue<int> queue = new Queue<int>(arr);
            int Max = queue.Max();


            while (queue.Count > 0)
            {
                int curOrder = queue.Peek();
                if (order >= curOrder)
                {
                    queue.Enqueue(curOrder);
                    if (curOrder > Max)
                    {
                        curOrder = Max;


                    }
                    order -= curOrder;
                    
                    queue.Dequeue();
                }
                else
                {
                    break;
                }

            }
           
            if(queue.Count==0)
            {
                Console.Write("All orders are completed");
            }
            else
            {
                Console.Write($"Orders left:{string.Join(", ", queue)}");
            }



        }
        
    }
}