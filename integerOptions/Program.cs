namespace integerOptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal num1 = decimal.Parse(Console.ReadLine());
            decimal num2 = decimal.Parse(Console.ReadLine());
            decimal num3  = decimal.Parse(Console.ReadLine());
            decimal num4 = decimal.Parse(Console.ReadLine());

            decimal formula1 = num1 + num2;
            decimal formula2 = formula1 / num3;
            decimal formula3 = formula2 * num4;

            Console.WriteLine(Math.Floor(formula3));
        }
    }
}