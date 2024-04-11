namespace zad6Func
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Array.ConvertAll(Console.ReadLine()
                .Split(' '), int.Parse);
            Array.Sort(nums, (x, y) =>
            {
                if (x % 2 == y % 2) 
                {
                    return x.CompareTo(y);
                }
                else 
                {
                    return (x % 2 == 0) ? -1 : 1;
                }
            });

            Console.WriteLine(string.Join(" ", nums));
        }
    }
}