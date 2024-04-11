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
            int matsD = (int)Math.Ceiling(countPeople * 1.2);
            int ballD = countPeople - (countPeople / 5);
            int blocksD = countPeople * 2;


            double needSum = ((ballD * prices[0]) + (prices[1] * blocksD) + (prices[2] * matsD) * countPeople);
            
            
            Console.WriteLine($"{needSum:F2}$ needed for equipment.");




        }
    }
}