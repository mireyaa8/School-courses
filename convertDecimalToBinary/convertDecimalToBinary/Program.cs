using System.Linq.Expressions;

namespace convertDecimalToBinary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = 147;
            string counter = "";
            while (input != 0)
            {
                if (input % 2 == 0)
                {
                    counter = counter + "0";
                }
                else
                {
                    counter += "1";
                }
                input = (input - input % 2) / 2;
            }
           
            Console.WriteLine($"{counter}");
        }
    }
}