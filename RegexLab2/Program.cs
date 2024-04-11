using System.Text.RegularExpressions;

namespace RegexLab2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b[A-Z][a-z]+\s[A-Z][a-z]+\b";
            string names = Console.ReadLine();
            Regex regex = new Regex(pattern);
            MatchCollection matchedN = regex.Matches(names);
            foreach (Match name in matchedN)
            {
                Console.WriteLine(name.Value + "/n");
            }
            Console.WriteLine();
        }
    }
}