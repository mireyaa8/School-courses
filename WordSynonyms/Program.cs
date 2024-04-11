namespace WordSynonyms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<string>> synonyms= new Dictionary<string, List<string>>();
            for(int i = 0; i < n; i++) 
            {
                string word = Console.ReadLine();
                string wordDve = Console.ReadLine();
                if(synonyms.ContainsKey(word))
                {
                    synonyms[word].Add(wordDve);
                }
                else
                {
                    synonyms.Add(word, new List<string>());
                    synonyms[word].Add(wordDve);
                }
            }
            foreach(string word in synonyms)
            {
                Console.WriteLine($"{word.Key} - {string.Join(", ", word.Value)}");
            }
           

        }
    }
}