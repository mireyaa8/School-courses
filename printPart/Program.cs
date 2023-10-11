namespace printPart
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
             
            for(int i = start; i <= end; i++) 
            { 
                if( i != end)
                {
                    Console.WriteLine(i + " ");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}