using System.Text;

namespace TextFiltur
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] banList = Console.ReadLine().Split(", ");
            StringBuilder txt = new StringBuilder(Console.ReadLine());
          
            
                foreach(string ban in banList)
                {
                    if (txt.ToString().Contains(ban))
                    {
                        txt.Replace(ban, new string('*', ban.Length));
                       
                    }
                }
                Console.WriteLine(txt.ToString());


            
        }
    }
}