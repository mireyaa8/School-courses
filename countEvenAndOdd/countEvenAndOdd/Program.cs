namespace countEvenAndOdd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Count Even and Odd Numbers in an Array
            int[] input = {2, 3, 4, 5, 6, 7};
            int evenCounter = 0;
            int oddCounter = 0;
            for(int i = 0; i < input.Length; i++)
            {
                if (input[i] % 2 == 0)
                {
                    evenCounter++;
                }
                else 
                {
                    oddCounter++;
                }
            }
            Console.WriteLine($"The count of the even numbers is:{evenCounter}. The count of the odd numbers is:{oddCounter}.");
        }

    }
}