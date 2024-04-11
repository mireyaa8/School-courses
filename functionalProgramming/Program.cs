namespace functionalProgramming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(new string[] {", "}, StringSplitOptions.RemoveEmptyEntries)
                .Select(n => int.Parse(n)) 
                .Where(n=>n%2 == 0)
                .OrderBy(n=> n)
                .ToArray();

      
        }
    }
}