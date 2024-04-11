namespace calculationWithCharacters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] words = input.Split(' ');
            string word1 = words[0];
            string word2 = words[1];
            int sum = 0;
            int minLength = Math.Min(word1.Length, word2.Length);
            for (int i = 0; i < minLength; i++)
            {
                sum +=word1[i]*word2[i];
            }
            if (word1.Length != word2.Length)
            {
                string longWord = word1.Length > word2.Length ? word1 : word2;
                for (int i = minLength; i < longWord.Length; i++)
                {
                    sum += longWord[i];
                }
            }
            Console.WriteLine(sum);
        }
    }
}