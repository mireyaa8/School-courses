namespace CarAddMoreMembersClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();

            car.Make = "VM";
            car.Model = "MK3";
            car.Yea = 1992;
            car.FuelConsumption = 200;
            car.FuelQuantity = 200;
            car.Drive(2000);
            Console.WriteLine(car.WhoAmI());
        }
    }
}