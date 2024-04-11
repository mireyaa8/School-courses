using System.Text;
using System.Xml.XPath;

namespace dr2string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();
            StringBuilder result = new StringBuilder();
            foreach(string word in words)
            {
                for(int i =0;i<word.Length;i++)
                {
                    result.Append(word);
                }
            }
            Console.WriteLine(result.ToString());
        }
    }
}