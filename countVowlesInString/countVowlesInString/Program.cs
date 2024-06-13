namespace countVowlesInString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Count the Number of Vowels in a String
            string[] input = Console.ReadLine().ToLower()
                .Split(" ");
            int vowlesCount = 0;
            string[] vowels = {"a","e","o","u","i"};
            for(int i =0;i<input.Length;i++)
            {
                if (vowels.Contains(input[i]))
                {
                    vowlesCount++;
                }
            }
            Console.WriteLine(vowlesCount);
        }
    }
}
