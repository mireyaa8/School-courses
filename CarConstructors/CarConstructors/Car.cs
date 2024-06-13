using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CarConstructors
{

    internal class Car
    {
        

    }
    public Car()
    {

        this.Make = make;
        this.Model = model;
        this.Year = year;
        this.FuelQuantity = fuelQuantity;
        this.FuelConsumtion = fuelConsumtion;
    }
    public Car(string make, string model, int year, double fuelQuantity,double fuelConsumtion)
        : this(make, model, year)
    {
        this.FuelQuantity = fuelQuantity;
        this.FuelConsumtion = fuelConsumtion;
    }

}
