using System.Diagnostics;

namespace drsString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            while (line != "End")
            {
               
                string reversed = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {
                    reversed += line[i];
                   
                }
                Console.WriteLine($"{line} = {reversed}");
                line = Console.ReadLine();
            }
         
        }
    }
}