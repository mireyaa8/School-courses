using System.Runtime.Serialization.Formatters;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {                                                           
            int[] command = Console.ReadLine()  
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int[] command1 = Console.ReadLine()
               .Split(' ', StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToArray();



            Stack<int> stack = new Stack<int>(command1);
            

            
            for (int j = 0; j < command[1]; j++)
            {
                
                stack.Pop();

            }
            if(stack.Count == 0)
            {
                Console.WriteLine("nothing found");
                return;
            }
            int min = command1.Min();
            
            while (stack.Count>0)
            {
                
                if(command[2] == stack.Peek())
                {
                    Console.WriteLine("found");
                    return;
                }
                else
                {
                    Console.WriteLine(min);
                    stack.Pop();
                }
            }
           

        }
    }
}