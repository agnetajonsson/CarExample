using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarExample
{
    public class Vehicle : IVehicle
    {
        public string RegNo { get; set; }

        public Vehicle(string regNo)
        {
            RegNo = regNo;
        }

        public virtual void  Drive(double distanceKm)
        {
           Console.WriteLine("Start drive");

        }
    }

    public class Bicycle : Vehicle
    {
        public Bicycle(string frameNumber) : base(frameNumber)
        {
        }

        public override void Drive(double distanceKm)
        {
            Console.WriteLine("Start pedaling");
        }

    }


    public class FuelVehicle : Vehicle
    {
        private double fuelLevel;

        public double FuelLevel
        {
            get { return fuelLevel; }
            set
            {
                double newLevel = Math.Max(0, value);
                fuelLevel = Math.Min(newLevel, FuelCapacity);
            }
        }

        public double FuelCapacity
        {
            get;
            set;
        }

        public FuelVehicle(string regNo, double fuelCapacity): base(regNo)
        {
            FuelCapacity = fuelCapacity;
        }

    }
}
