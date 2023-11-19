using System.Data;
using System.Diagnostics;

namespace trainList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> train = GetInList();

            int capacity = int.Parse(Console.ReadLine());

            string[] command = GetStringArray();

            while (command[0]?.ToLower() != "end")
            {
                switch (command[0]?.ToLower())
                {
                    case "add":

                       
                        train.Add(int.Parse(command[1]));

                            break;
                    default:
                        AddNumberToListElement(train, capacity, int.Parse(command[0]));
                        break;

                }

                command= GetStringArray();
               
            }
            Console.WriteLine(string.Join(" ", train));
        }
        static List<int> GetInList()
        { 
            return Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            
            
        }
        static string[] GetStringArray()
        {
            return Console.ReadLine()
                .Split(' ')
                .ToArray();
        }
        static List<int> AddNumberToListElement(List<int> train, int capacity, int command)
        {
          
            for(int i =0; i <train.Count; i++)
            {
                if (train[i] + command<= capacity)
                {
                    train[i] +=command;
                    break;
                }
            }
            return train;
        }
    }
}