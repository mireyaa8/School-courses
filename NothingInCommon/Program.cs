    namespace NothingInCommon
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                int[] num1 = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                int num2 = int.Parse(Console.ReadLine());
   

            for (int i = 0; i < num1.Length-1; i++)
            {
                if (num1[i] + num1[i-1] == num2)
                    {
                        Console.WriteLine($"{num1[i]} {num1[i+1]}");
                    }
                
                
                }


            }
        }
    }