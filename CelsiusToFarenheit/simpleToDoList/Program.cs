using System.Data;

namespace simpleToDoList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a simple console-based todo list application where users can add tasks,
            //view all tasks, and mark tasks as complete.
            string[] input = Console.ReadLine()
               .Split(" ", StringSplitOptions.RemoveEmptyEntries)
               .ToArray();

            while (input!="End")
            {
                if (input == "Complete")
                {
                    Console.WriteLine("The tasks above are complete");
                }
                else
                {
                    continue;
                }

            }
               
        }
    }
}