using System.Text;

namespace CeaserCipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            for (int i = 0;i<text.Length;i++)
            {
                char ch = (char)((int)text[i]);
                sb.Append(ch);  
            }
            string output = sb.ToString();
            Console.WriteLine(output);
        }
    }
}