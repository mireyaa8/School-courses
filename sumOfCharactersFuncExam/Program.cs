namespace sumOfCharactersFuncExam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine().Split();
            Func<string, int> sum = f => f.Select(i => (int)i).Sum();

            foreach (var name in names)
            {
                if (sum(name) <= n)
                {
                    Console.WriteLine(name);
                }
            }
        }
    }
}