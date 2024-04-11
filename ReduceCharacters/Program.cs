namespace ReduceCharacters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] vowls = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            string result = "";
            foreach(char ch in input)
            {
                if (!(vowls.Contains(ch)))
                {
                    result += ch;
                }
            }
          

            Console.WriteLine(result);
          
        }
    }
}