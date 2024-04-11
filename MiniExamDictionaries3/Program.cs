namespace MiniExamDictionaries3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> contests = new Dictionary<string, string>();
            Dictionary<string, Dictionary<string, int>> candidates = new Dictionary<string, Dictionary<string, int>>();
            string input = Console.ReadLine();
            while (input!="the contests are ended")
            {
                string[] data=input.Split(':');
                string contest = data[0];
                string password = data[1];

                contests[contest] = password;
            }
            while ((input = Console.ReadLine()) != "the submissions are ended")
            {
                string[] submisions = Console.ReadLine().Split("->");
                string contest = submisions[0];
                string password = submisions[1];
                string candidate = submisions[2];
                int points = int.Parse(submisions[3]);
                if (contests.ContainsKey(contest)&&contests[contest]==password)
                {

                    if (!candidates.ContainsKey(candidate))
                    {
                        candidates[candidate] = new Dictionary<string, int>();
                    }
                    if (!candidates[candidate].ContainsKey(contest))
                    {
                        candidates[candidate][contest] = 0;
                    }
                    if (points > candidates[candidate][contest])
                    {
                        candidates[candidate][contest]=points;
                    }
                }
            }
            foreach (var candidate in candidates.OrderBy(c => c.Key))
            {
                Console.WriteLine(candidate.Key);
                foreach (var contest in candidate.Value.OrderByDescending(c => c.Value))
                {
                    Console.WriteLine($"# {contest.Key} -> {contest.Value}");
                }

            }    }

    }
    
}