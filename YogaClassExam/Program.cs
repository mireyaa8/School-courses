namespace YogaClassExam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] prices = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();

            int countPeople = int.Parse(Console.ReadLine());
            double needSum = (prices[0] + (prices[1])*2 + (prices[2])*20/100.0)*countPeople ;
            
            Console.WriteLine($"{needSum:F2}$ needed for equipment.");




        }
    }
}