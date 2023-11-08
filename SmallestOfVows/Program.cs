using System.Diagnostics.Metrics;
namespace SmallestOfVows
{
    internal class Program
    {
        static void Vows(string word, int count)
        {
            foreach (char c in word)
            {
                if (c == 'a' || c == 'A' || c == 'o' || c == 'O' || c == 'u' || c == 'U' || c == 'e' || c == 'E' || c == 'i' || c == 'I')
                {
                    count++;
                }
              
            }
            Console.WriteLine(count);
        }
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            int count = 0;
            Vows(word, count);

        }
        
    }
}