namespace orderStudents
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine()
                .Split('|',StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            

            List<int> num = new List<int>();
            
            for (int i = 0; i < list.Count; i++)
            {
                List<int> list1 = list[i]
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
                
                list1.Reverse();
                num.AddRange(list1);
                

            }
            num.Reverse();
            //Console.WriteLine(num + " ");
            Console.WriteLine(string.Join(" ",num));
        }
       
    }
}