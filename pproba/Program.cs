namespace pproba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine()
            .ToArray();

            double n = input.Length;

            if (n % 2 == 0)
            {
                getMiddlePart(input);
            }
            else
            {
                more(input);
            }




        }
        static void getMiddlePart(char[] input)
        {
            int Z = input.Length/2;
            Console.WriteLine(input[Z]);
            
        }
        static void more(char[] input)
        {
            int z = input.Length / 2;
            Console.WriteLine($"{input[z - 1]}{ input[z]}");
        }
    }
}