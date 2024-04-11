using System.Runtime.Intrinsics.X86;

namespace MinFunc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<List<int>, int> min = (numbers) =>
            {
                return numbers.Min();
            };
            string input = Console.ReadLine();
            string[] strNumbers = input.Split(' ');
            List<int> numbers = new List<int>();

            foreach(var number in strNumbers)
            {
                
            }

        }
    }
}