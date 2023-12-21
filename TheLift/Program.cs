namespace TheLift
{
    internal class Program
    {
        static void Main(string[] args)
        {
          

                int peopleInQueue = int.Parse(Console.ReadLine());
                int[] wagons = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int i = 0; i < wagons.Length; i++)
                {
                    int availableSpace = 4 - wagons[i];

                    if (peopleInQueue == 0)
                    {
                        Console.WriteLine($"The lift has empty spots!\n{string.Join(" ", wagons)}");
                        return;
                    }

                    if (availableSpace > 0)
                    {
                        int peopleToAdd = Math.Min(availableSpace, peopleInQueue);
                        wagons[i] += peopleToAdd;
                        peopleInQueue -= peopleToAdd;
                    }
                }

                if (peopleInQueue == 0)
                {
                    Console.WriteLine($"The lift has empty spots! {string.Join(" ", wagons)}");
                }
                else
                {
                    Console.WriteLine($"There isn't enough space! {peopleInQueue} people in a queue! {string.Join(" ", wagons)}");
                }
        }

    }
}
