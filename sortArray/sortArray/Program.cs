namespace sortArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //sort array numbers by order
            int[] input = {1,4,3,6,5,7,8,10,9,2};

            //  int ten = 0;
            //  int nine = 0;
            //  int eight = 0;
            //  int seven = 0;
            //  int six = 0;
            //  int five = 0;
            //  int four = 0;
            //  int three = 0;
            //  int two = 0;
            //  int one = 0;
            int current = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] > input[i+1])
                {
                    input[i] = current;
                }
            }
            //for (int j = 0; j < input.Length; j++)
            //{
            //if (maxNum > input[j] && nextNum < input[j])
            //{
            //     nextNum = input[j];
            //}
            // }
            Console.WriteLine();
        }
    }
}//okayy