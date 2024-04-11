namespace findData
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> data = new List<string>();
            for(int i =0; i < n; i++)
            {
                data.Add(Console.ReadLine());
            }
            foreach(string line in data)
            {
                string name = line.Split('@', '|')[1];
                string age = line.Split('#', '*')[1];
                Console.WriteLine($"{name} is {age} years old.");

            }
        }
    }
}