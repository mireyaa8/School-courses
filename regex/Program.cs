using System.Text.RegularExpressions;

namespace regex
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            string input = Console.ReadLine();
            string[] names = input.Split(',', StringSplitOptions.RemoveEmptyEntries);
            string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";
           
             foreach (string name in names)
            {
                if (Regex.IsMatch(name.Trim(), pattern))
                {
                    Console.WriteLine(name.Trim());
                }
            }
        }
    }

}