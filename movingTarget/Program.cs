namespace movingTarget
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            string input = Console.ReadLine();
            while (input != "End")
            {

                string[] command = input.Split();
                string action = command[0];
                int index = int.Parse(command[1]);
                if (action == "Shoot")
                {
                    int power = int.Parse(command[2]);
                    if (index >= 0 && index < targets.Count)
                    {
                        targets[index] -= power;
                        if (targets[index] <= 0)
                        {
                            targets.RemoveAt(index);
                        }
                    }
                }
                else if (action == "Add")
                {
                    int value = int.Parse(command[2]);
                    if (index >= 0 && index < targets.Count)
                    {
                        targets.Insert(index, value);
                    }
                    else
                    {
                        Console.WriteLine("Invalid placement!");
                    }
                }
                else if (action == "Strike")
                {
                    int radius = int.Parse(command[2]);
                    if (index - radius >= 0 && index + radius < targets.Count)
                    {
                        targets.RemoveRange(index - radius, 2 * radius + 1);
                    }
                    else
                    {
                        Console.WriteLine("Strike missed!");
                    }
                }
            }

            Console.WriteLine(string.Join("|", targets));
        }
    }
}
    }
}