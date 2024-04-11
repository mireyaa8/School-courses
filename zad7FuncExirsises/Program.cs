using System.Collections.Generic;

namespace zad7FuncExirsises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            Func<int, int, bool> func = (a, b) => a % b == 0;
            List<int> dividebleNums = new List<int>();
            bool divideble = true;
            for(int i = 0; i<arr.Length; i++)
            {
                for(int j =0;j<arr.Length; j++)
                {
                    if (!func(i, arr[j]))
                    {
                        divideble = false;
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
                if(divideble==true)
                {
                    dividebleNums.Add(i);
                }
                
            }
            Action<List<int>>print =x=>Console.WriteLine(string.Join(", ", x));
            print(dividebleNums);

        }
    }
}