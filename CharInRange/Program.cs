using System;
namespace CharInRange
{
    internal class Program
    {
        static void Print(char start, char end)
        {
            char startCh;
            char endCh;
            if(start<end)
     
            {
                startCh = start;
                endCh = end;
            }
            else
            {
                startCh = end;
                endCh = start;
            }
            for(char i = ++startCh; i < endCh; i++)
            { 
                Console.Write(i+" ");
            }
            Console.WriteLine();
            
        }
        static void Main(string[] args)
        {
            char input1 =  char.Parse(Console.ReadLine());
            char input2 = char.Parse(Console.ReadLine());

            Print(input1,input2);
        }
    }
}