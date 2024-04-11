using System.Text.RegularExpressions;

namespace matchDates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(?<day>\d{2})(?<separator>[./-])(?<month>[A-Z][a-z]{2})\k<separator>(?<year>\d{4})\b";
            string input = Console.ReadLine();
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(input);
            foreach (Match match in matches)
            {
                string day = match.Groups["day"].Value;
                string month = match.Groups["month"].Value;
                string year = match.Groups["year"].Value;

                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }   
        }
    }
}