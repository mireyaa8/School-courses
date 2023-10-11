namespace ArrayRotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arry = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int n = int.Parse(Console.ReadLine());
            
            for(int i = 0; i < n; i++)
            {
                for( int j = arry.Length-1; j >= 0; j--)
                {
                    int t = arry[arry.Length-1];
                    arry[arry.Length-1] = arry[j];
                    arry[j] = t;    
                }

            }

            Console.WriteLine(string.Join(" ", arry));
        }
    }
}