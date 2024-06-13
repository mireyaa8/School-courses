using System.Text.RegularExpressions;
namespace AdAstra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"(#|\|)(?<itemName>[A-Za-z\s]+)\1(?<expDate>\d{2}/\d{2}/\d{2})\1(?<calories>\d{1,5})\1";
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(input);
            List<string> foodItems = new List<string>();
            int totalCalories = 0;
            foreach (Match match in matches)
            {
                string itemName = match.Groups["itemName"].Value;
                string expDate = match.Groups["expDate"].Value;
                int calories = int.Parse(match.Groups["calories"].Value);
                foodItems.Add($"Item: {itemName}, Best before: {expDate}, Nutrition: {calories}");
                totalCalories += calories;
            }
            
            int days = totalCalories / 2000;
            Console.WriteLine($"You have food to last you for: {days} days!");
            foreach (string foodItem in foodItems)
            {
                Console.WriteLine(foodItem);
            }
        }
    }
}