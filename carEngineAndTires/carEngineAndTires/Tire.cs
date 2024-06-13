using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace carEngineAndTires
{
    internal class Tire
    {
        private int year;
        private double pressure;
        
        public int Year
        {
            get { return year; }
            set { year = value; }
        }
        public double Pressure
        {
            get { return pressure; }
            set { pressure = value; }
        }
        public Tire(int year, double pressure)
        {
            this.Year = year;
            this.Pressure = pressure;
           
            

    }
    }
}
