namespace SoftUniParking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var parkingLot = new Dictionary<string, string>();

            for (int i = 0; i < n; i++)
            {
                string[] car = Console.ReadLine().Split();
                if (car[0] == "register")
                {
                    string license = car[2];
                    if (!parkingLot.ContainsKey(car[1]))
                    {
                        Console.WriteLine($"{car[1]} registered {car[2]} successfully");
                        parkingLot.Add(car[1], license);
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {license}");
                    }
                }
                else
                {
                    if (!parkingLot.ContainsKey(car[1]))
                    {
                        Console.WriteLine($"ERROR: user {car[1]} not found");
                    }
                    else
                    {
                        Console.WriteLine($"{car[1]} unregistered successfully");
                        parkingLot.Remove(car[1]);
                    }
                }
            }

            foreach (var kvp in parkingLot)
            {
                Console.WriteLine($"{kvp.Key} => {kvp.Value}");
            }

     
    
        }
    }
}