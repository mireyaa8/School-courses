namespace Names
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<int> names = new List<int>();
            MainPart(n, names);

        }
        static void MainPart(int n, List<int> name)
        {
            for(int i =0; i < n; i++)
            {
                string names = Console.ReadLine();
                name.Add(i);
                

            }
           
            for(int i = 0; i < n; i++)
            {
                name.Sort();
                Console.WriteLine(string.Join(", ", name[i]));
            }

            
        }
    }
}