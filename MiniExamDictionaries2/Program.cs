namespace MiniExamDictionaries2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string,int> mineral = new Dictionary<string,int>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string type= input[0];
                string name=input[1];
                if(type=="mineral")
                {
                    if(!mineral.ContainsKey(name))
                    {
                        mineral[name]=0;
                    }
                    mineral[name]++;

                }
            }
            foreach(var minerals in mineral.OrderBy(m => m.Key))
            {
                Console.WriteLine($"{minerals.Key}: {minerals.Value} time/s");
            }




        }
    }
}