namespace Natetdka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input parameter:");
            double  input = double.Parse(Console.ReadLine());
            double formula1 = input * 4;
            
            Console.WriteLine(formula1);
        }
        

    }
}