namespace MiniExamDictionaries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            HashSet<string> uniqueN = new HashSet<string>();
            List<string> order = new List<string>();

            for(int i = 0; i < n; i++) 
            { 
                string name = Console.ReadLine();
                if(!uniqueN.Contains(name))
                {
                    uniqueN.Add(name);
                    order.Add(name);
                }
            }
            foreach(string name in order)
            {
                Console.WriteLine(name);
            }
        }
    }
}