using System.Diagnostics;

namespace StringMoreExrs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sb = Stopwatch.StartNew();
            sb.Start();
            string text = "";
            for(int i = 0; i<200000;i++)
            {
                text += i;
            }
            sb.Stop();
            Console.WriteLine(sb.ElapsedMilliseconds);
        }
    }
}