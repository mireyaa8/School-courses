namespace LicensePlate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
           string[] allowedLetters = Console.ReadLine()
               .Split(", ");
            int licensePlatesNum = int.Parse(Console.ReadLine());
            
            for(int i = 0; i<licensePlatesNum; i++)
            {
               
                string[] carPlates = Console.ReadLine()
                    .Split()
                    .ToArray();
                if (carPlates[i] == @"^[A-Z]{2}\d{4}[A-Z]{2}$")
                {
                    Console.WriteLine($"{carPlates[i]}");
                }

                
            }
        }
       
    }
}