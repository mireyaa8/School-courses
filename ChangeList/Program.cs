using System.Xml.Serialization;

namespace ChangeList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = GetInList();
           
        }
        static List<int> GetInList()
        {
            return Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
        }
        
        static void ChangeList(List<int> list) 
        { 
            string line = Console.ReadLine();
            
            
           
        }
    }
}