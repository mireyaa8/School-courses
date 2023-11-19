namespace test1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string order = Console.ReadLine();
            double num = double.Parse(Console.ReadLine());
            Price(order,num);

        }
        static void Price(string order, double num)
        {
            

            if ((order == "water"))
            {
               
                Console.WriteLine($"{num:f2}");
            }
            if (order == "coke")
            {
                Console.WriteLine($"{num * 1.4:f2}");
            }
            if (order == "coffee")
            {
                Console.WriteLine($"{num * 1.5:f2}");
            }
            if (order == "snacks")
            {
                Console.WriteLine($"{(num * 2):f2}");
            }

        }
    }
}