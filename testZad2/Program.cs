namespace testZad2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n1 = double.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());
            double n3 = double.Parse(Console.ReadLine());
            Calculations(n1, n2, n3);
            
        }
        static void Calculations(double n1, double n2,double n3)
        {
            Console.WriteLine(n1 + n2 - n3);
        }
    }
}