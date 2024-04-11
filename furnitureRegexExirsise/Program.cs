using System.Text.RegularExpressions;
namespace furnitureRegexExirsise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Regex regex =new Regex(@">>(?<name>[A-Za-z\s]+)<<(?<price>\d+(\.\d+)?)!(?<quantity>\d+)");
            string divadors = @"[!<]";
            double total = 0;
            List<string> furniture = new List<string>();
            string input = Console.ReadLine();
            while (input.ToLower() != "purchase")
            {
                
                if (regex.IsMatch(input))
                {
                    Match match = regex.Match(input);
                    string name = match.Groups["name"].Value;
                    double price = double.Parse(match.Groups["price"].Value);
                    double quantity = double.Parse(match.Groups["quantity"].Value);
                    total += quantity * price;
                    furniture.Add(input);
                }
                input = Console.ReadLine();
            }
            Console.WriteLine("Bought furniture:");
            foreach(string furniturs in furniture)
            {
                Console.WriteLine("");
                Console.WriteLine(furniturs);
            }

        }
    }
}