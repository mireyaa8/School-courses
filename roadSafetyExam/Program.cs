namespace roadSafetyExam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int secGreenLight = int.Parse(Console.ReadLine());
            int freeWindow = int.Parse(Console.ReadLine());

            List<string> cars  = new List<string>();
            int total = 0;
            bool accident = false;
            string carsHit = string.Empty;

            string input = Console.ReadLine();
            while (input != "STOP")
            {
                if (input == "light")
                {

                    while(cars.Count > 0 && secGreenLight > 0)
                    {
                        int carsLength = Math.Min(secGreenLight, cars[0].Length);
                        secGreenLight-= carsLength;
                        if (carsLength < cars[0].Length)
                        {
                            accident= true;
                            carsHit = cars[0][secGreenLight].ToString();
                            break;
                        }
                        total++;
                        cars.RemoveAt(0);
                    }

                }
                else
                {
                    cars.Add(input);
                }
                input = Console.ReadLine();
               

                
            }
            while (secGreenLight > 0 && cars.Count > 0)
            {
                int carsLength = Math.Min(secGreenLight, cars[0].Length);

                secGreenLight -= carsLength;
                if (carsLength < cars[0].Length)
                {
                    accident = true;
                    carsHit = cars[0][carsLength ].ToString();
                    break;
                }
                total++;
                cars.RemoveAt(0);

            }
            if (accident )
            {
                Console.WriteLine("Accident!");
                Console.WriteLine($"{cars[0]} was crushed at {carsHit}");
            }
            else
            {
                Console.WriteLine("Success!");
                Console.WriteLine($"{total} cars are gone");
            }
            

            
            
        }
    }
}