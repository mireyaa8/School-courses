namespace shootForTHeWin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] target = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            string command = Console.ReadLine();
            int shot = 0;
            while (command != "End")
            {
                int inx = int.Parse(command);

                if(inx<0|| target[inx]==-1||inx>=target.Length)
                {
                    continue;
                }
                target[inx] = -1;
                shot++;
                int value = target[inx];
                for(int i=0;i<target.Length;i++)
                {
                    if (target[i]>value)
                    {
                        target[i] -= value;
                    }
                    else if (target[i] !=-1) 
                    {
                        target[i] += value;
                    }
                }
                Console.WriteLine($"Shot targets: {shot} -> {string.Join(" ", target)}");
            }

        }
    }
}