namespace Legendary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,int> materialQty = new Dictionary<string,int>();
            materialQty.Add("shards", 0);
            materialQty.Add("fragments", 0);
            materialQty.Add("motes", 0);

            SortedDictionary<string, int> junk = new SortedDictionary<string, int>();
            bool haveLegendaryItem = false;
            while (haveLegendaryItem == false)
            {
                string[] input = Console.ReadLine()
                    .Split()
                    .Select(x => x.ToLower())
                    .ToArray();
                for (int i = 0; i < input.Length; i += 2)
                {
                    int quantity = int.Parse(input[i]);
                    string material = input[i + 1];

                    if (materialQty.ContainsKey(material))
                    {
                        materialQty[material] += quantity;
                    }
                    else if (junk.ContainsKey(material))
                    {
                        junk[material] += quantity;
                    }
                    else
                    {
                        junk.Add(material, quantity);
                    }

                    if (materialQty["shards"] >= 250)
                    {
                        materialQty["shards"] -= 250;
                        Console.WriteLine($"Shadowmourne obtained!");
                        haveLegendaryItem = true;
                        break;
                    }


                    if (materialQty["fragments"] >= 250)
                    {
                        materialQty["fragments"] -= 250;
                        Console.WriteLine($"Valanyr obtained!");
                        haveLegendaryItem = true;
                        break;
                    }


                    if (materialQty["motes"] >= 250)
                    {
                        materialQty["motes"] -= 250;
                        Console.WriteLine($"Dragonwrath obtained!");
                        haveLegendaryItem = true;
                        break;
                    }
                }

            }

            foreach (var kvp in materialQty.OrderByDescending(kvp => kvp.Value)
                .ThenBy(kvp => kvp.Key))
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }

            foreach (var kvp in junk)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }

        }
    }
}