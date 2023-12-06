using System.Xml.Linq;

namespace CheckStudents
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> here = new List<int>();
            List<int> nothere = new List<int>();

            List<int> namess= new List<int>();
            int num = int.Parse(Console.ReadLine());


            for (int i = 0; i < num; i++)
            {
                List<string> names = Console.ReadLine()
               .Split(' ', StringSplitOptions.RemoveEmptyEntries)
               .ToList();
                if(nothere.Contains(namess[0])&& names.Count<3)
                {
                    Console.WriteLine($"{names[0]} is already in the list!");

                }
                if (nothere.Contains(namess[0]) && names.Count > 3)
                {
                    Console.WriteLine($"{namess[0]} is in class!");
                    nothere.Remove(namess[0]);
                    here.Add(namess[0]);


                }
                if(names.Count>3)
                {
                    if (!nothere.Contains(namess[0]))
                    {
                        nothere.Add(namess[0]);
                    }
                }
                else
                {
                    here.Add(namess[0]);

                }
                
            }
            for (int i = 0; i < nothere.Count; i++)
            {
                Console.WriteLine(string.Join(" ", nothere[i]));
            }


        }
    }
}