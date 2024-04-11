using System.Text;

namespace ValidUsername
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            StringBuilder result = new StringBuilder();
            foreach(string username in usernames)
            {
                if (username.Length >= 3 && username.Length <= 16
                    || !username.Contains('-')
                    || !username.Contains("_")
                    &&CheckForNumsLeters(username))
                {
                    result.Append(username);
                }
              
            }

        }
        static bool CheckForNumsLeters(string str)
        {
            foreach(char c in str)
            {
                if(!char.IsLetter(c) && !char.IsDigit(c))
                 {
                    return false;
                }
                
            }
            return true;
        }
    }
}