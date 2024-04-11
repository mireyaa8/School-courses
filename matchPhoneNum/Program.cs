using System.Text.RegularExpressions;

namespace matchPhoneNum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(?:\+|0{2})359([ -])2\1\d{3}\1\d{4}\b";

          
            string input = Console.ReadLine();
            Regex regex = new Regex(pattern);
            var matches = regex.Matches(input)
                              .Cast<Match>()
                              .Select(m => m.Value.Trim())
                              .ToArray();
            Console.WriteLine(string.Join(", ", matches));
        }
    }
}