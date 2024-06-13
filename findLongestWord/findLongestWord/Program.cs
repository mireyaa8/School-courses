namespace findLongestWord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Find the Longest Word in a Sentence:
            string[] input = { "this", "is", "the", "biggestWord" };
            string biggestWord = "";
            for (int i = 0; i < input.Length; i++)
            {
                string currentWord = input[i];
                if (currentWord.Length>biggestWord.Length)
                {
                    biggestWord = currentWord;
                }
            }
            Console.WriteLine(biggestWord);
        }
    }
}