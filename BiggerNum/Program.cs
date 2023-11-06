namespace BiggerNum
{
    internal class Program
    {
        static int Max(int n1, int n2) 
            {
              return Math.Max (n1, n2);
            } 

        static void Main(string[] args)
        {
            int inp1 = int.Parse(Console.ReadLine());
            int inp2 = int.Parse(Console.ReadLine());
            int result = Max(inp1, inp2);
            Console.WriteLine(result);

        }
    }
}