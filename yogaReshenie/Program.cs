using System.Diagnostics;

namespace yogaReshenie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(decimal.Parse)
                .ToArray();
            int people = int.Parse(Console.ReadLine());
            decimal ballPrice = input[0];
            decimal blockPrice = input[1];
            decimal matPrice = input[2];
           
            decimal totalMats = people * matPrice * 1.2M;
            int freeBalls = people/5;
            // decimal totalMtas = (people*mat) +(people*mat*0.2)
            decimal totalPrice = people * (ballPrice - freeBalls + blockPrice * 2 + totalMats) + totalMats;
            Console.WriteLine($"{totalPrice:F2}$ needed for equipment");

                

        }
    }
}