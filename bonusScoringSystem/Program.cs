namespace bonusScoringSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int students= int.Parse(Console.ReadLine());

            int lect = int.Parse(Console.ReadLine());
            int bonus = int.Parse(Console.ReadLine());
            double totalB = 0;
            double attending = 0;
            double maxAttending = 0;
            double maxB = 0;
            for(int i=0; i<students; i++)
            {
                attending = double.Parse(Console.ReadLine());
                if(attending>maxAttending)
                {
                    totalB = (attending/lect)*(5+bonus);
                    maxB=Math.Ceiling(totalB);
                    maxAttending= attending;

                }

            }
            Console.WriteLine($"Max Bonus: {maxB}.");
            Console.WriteLine($"The student has attended {maxAttending} lectures.");
            
        }
    }
}