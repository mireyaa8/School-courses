namespace SomethingInCommon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] ar1 =Console.ReadLine()
                .Split(' ');
            string[] ar2 = Console.ReadLine()
                .Split(' ');
            
            for(int i= 0; i < ar2.Length; i++) 
            { 
                for(int j = 0; j<ar1.Length;j++)
                {
                    if (ar1[j] == ar2[i])
                    {
                        Console.Write(ar2[i]+" ");
                    }
                }
            }
            
            Console.WriteLine(); 
        }
    }
}