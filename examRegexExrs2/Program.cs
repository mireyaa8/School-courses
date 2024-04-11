using System;
using System.Text.RegularExpressions;

namespace examRegexExrs2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, double> prices= new Dictionary<string, double>();
            while(input != "Run!")
            {
                string regex = @"<([^<>]+)><([^<>]+)>(\d+)--(\d+\.?\d*)";
                Match match = Regex.Match(input, regex);
                
                if (match.Success)
                {
                    string name = match.Groups[2].Value;
                    int quantity = int.Parse(match.Groups[3].Value);
                    double price = double.Parse(match.Groups[4].Value);
                    if(!prices.ContainsKey(name))
                    {
                        prices[name] = 0;
                    }
                    prices[name] += quantity * price;
                }
                input = Console.ReadLine();
                foreach(var kvp in prices)
                {
                    Console.Write($"{kvp.Key}");

                }
                Console.WriteLine($"Total cost: {prices.Values.Sum():F2}");
            }
            
        }
    }
}