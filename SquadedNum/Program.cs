namespace SquadedNum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            
            Console.WriteLine(Square(num));
            static int Square(int x) => x * x;
            //Console.WriteLine(new int[] { 1, 2, 3, 40, -1, 5, 0, 50 }.Min());
            int[] arr = { 1, 2, 3, 40, -1, 5, 0, 50 };
            Console.WriteLine(arr.Min());

        }
    }
}