namespace maximumLengthOfNamesFuncExam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            string[] names = Console.ReadLine().Split();
            Func<string[], int, bool> Valid = (string[] array, int length) =>
            {
                foreach (var name in array)
                {
                    if (name.Length > length)
                    {
                        return false;
                    }
                }
                return true;
            };

            Valid(names,n);
            foreach (var name in names)
            {
                Console.WriteLine(names);
            }

        }
    }
}