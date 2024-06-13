using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarAddMoreMembersClasses
{
    internal class Car
    {
        private string make;
        private string model;
        private int year;
        private double fuelQuantity;
        private double fuelConsumption;
        public string? Make
        {
            get { return make; }
            set { make = value; }
        }

        public string? Model
        {
            get { return model; }
            set { model = value; }
        }

        public int Yea
        {
            get { return year; }
            set { year = value; }
        }

        public double FuelQuantity
        {
            get { return fuelQuantity; }
            set { fuelQuantity = value; }
        }

        public double FuelConsumption
        {
            get { return fuelConsumption; }
            set { fuelConsumption = value; }
        }

        public void Drive(double distance)
        {
            double consumptionTotal = (fuelQuantity - distance) * fuelConsumption;

            if (consumptionTotal < 0)
            {
                Console.WriteLine($"Not empugh fuel to preform this trip!");
            }
            else
            {
                fuelQuantity = distance * fuelConsumption;
            }
        }
        public string WhoAmI()
        {
            return $"Make: {this.Make}\nModel: {this.Model}\nYea: {this.Yea}\nFuel:  {this.FuelQuantity:F2}L";


        }



    }
}
