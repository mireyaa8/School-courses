namespace drDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> keyMaterials = new Dictionary<string, int>
        {
            { "shards", 0 },
            { "fragments", 0 },
            { "motes", 0 }
        };
            SortedDictionary<string, int> junk = new SortedDictionary<string, int>();

            string obtainedItem = "";

            while (true)
            {
                string[] input = Console.ReadLine().ToLower().Split();

                for (int i = 0; i < input.Length; i += 2)
                {
                    int quantity = int.Parse(input[i]);
                    string material = input[i + 1];

                    if (keyMaterials.ContainsKey(material))
                    {
                        keyMaterials[material] += quantity;
                        if (keyMaterials[material] >= 250)
                        {
                            if (material == "shards")
                                obtainedItem = "Shadowmourne";
                            else if (material == "fragments")
                                obtainedItem = "Valanyr";
                            else if (material == "motes")
                                obtainedItem = "Dragonwrath";

                            keyMaterials[material] -= 250;
                            PrintResult(obtainedItem, keyMaterials, junk);
                            return;
                        }
                    }
                    else
                    {
                        if (!junk.ContainsKey(material))
                        {
                            junk.Add(material, 0);
                        }
                        junk[material] += quantity;
                    }
                }
            }
        }

        static void PrintResult(string obtainedItem, Dictionary<string, int> keyMaterials, SortedDictionary<string, int> junk)
        {
            Console.WriteLine($"{obtainedItem} obtained!");
            foreach (var item in keyMaterials.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
            foreach (var item in junk)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
    
}