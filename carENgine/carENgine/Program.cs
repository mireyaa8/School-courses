namespace carENgine
{
    internal class Program
    {
        static void Main(string[] args)


        {
            Car car = new Car();

            string make = Console.ReadLine();
            string model = Console.ReadLine();
            int year = int.Parse(Console.ReadLine());
            double fuelQuantity = double.Parse(Console.ReadLine());
            double fuelConsumption = double.Parse(Console.ReadLine());

            Car firstCar = new Car();
            Console.WriteLine($"{firstCar.Make}{firstCar.Model} {firstCar.Yea} {firstCar.FuelQuantity} {firstCar.FuelQuantity}");
            Car secondCar = new Car();
            Console.WriteLine($"{secondCar.Make}{secondCar.Model} {secondCar.Yea} {secondCar.FuelQuantity} {secondCar.FuelQuantity}");
            Car thirdCar = new Car();
            Console.WriteLine($"{thirdCar.Make}{thirdCar.Model} {thirdCar.Yea} {thirdCar.FuelQuantity} {thirdCar.FuelQuantity}");



        }
    }
}