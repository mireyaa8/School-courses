using System.Text.RegularExpressions;

namespace examRegexExrs1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string metalR = @"@(\w+)\|";
            string gemR = @"#(\w+)\*";
            Match metalMatch = Regex.Match(input, metalR);   
            Match gemMatch= Regex.Match(input, gemR);

           string metal1 = metalMatch.Groups[1].Value;
           string gem1 = gemMatch.Groups[1].Value;
           Console.WriteLine($"Found hidden {metal1} and {gem1} in the cave.");
            


        }
    }
}