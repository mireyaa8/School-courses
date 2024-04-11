using System.Diagnostics;

namespace SortEvenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(n => int.Parse(n))
                .Where(n => n % 2 == 0)
                .OrderBy(n => n)
                .ToArray();
            string result = string.Join(", ", numbers);

            Console.WriteLine(result);


            //======================================================================================================================================================

            string input = Console.ReadLine();

            Func<string, int> parser = n => int.Parse(n);

            int[] numbers1 = input.Split(new string[] { ", " },

            StringSplitOptions.RemoveEmptyEntries)

            .Select(parser).ToArray();

            Console.WriteLine(numbers1.Length);

            Console.WriteLine(numbers1.Sum());

            //================================================================================================================================================================

            Func<string, bool> checker =
                n => n[0] == n.ToUpper()[0];
            var words = Console.ReadLine()
                .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Where(checker)
                .ToArray();
            foreach(string word in words)
            {
                Console.WriteLine(word);
            }
            //===============================================================================================================================================

            double[] prices = Console.ReadLine()

            .Split(new string[] { ", " },
             StringSplitOptions.RemoveEmptyEntries)
            .Select(double.Parse)
            .Select(n => n * 1.2)
            .ToArray();

            foreach (var price in prices)
            {
                Console.WriteLine($"{price:f2}");
            }

            //==================================================================================================================================================

            





        }
        public Func<int, bool> CreateTester(string condition, int age)

        {

            switch (condition)
            {

                case "younger": return x => x < age;

                case "older": return x => x >= age;

                default: return null;

            }


        }
        public Action<KeyValuePair<string, int>>

        CreatePrinter(string format)

        {
            switch (format)
            {

                case "name":

                    return person => Console.WriteLine($"{person.Key}");

                // TODO: complete the other cases

                default: return null;
            }
        }
        int Аggregate(int start, int end, Func<int, int, int> func)

        {
                int result = start;

                for (int i = start + 1; i <= end; i++)
                {
                    result = func(result, i);
                    return result;
                }




        }

    }
}