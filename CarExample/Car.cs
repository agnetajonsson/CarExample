using System;

namespace CarExample
{
    public class SportsCar : Car
    {
        public double MaxSpeed {get; set;}

        public SportsCar(string regNo, double fuelCapacity, double maxSpeed) : base(regNo, fuelCapacity)
        {
            MaxSpeed = maxSpeed;
        }


        public override void Drive(double distanceKm)
        {
            base.Drive(100);
        }
    }

    public class Car : FuelVehicle
    {
        private readonly double fuelConsumtion = 0.1;

        public Car(string regNo, double fuelCapacity) : base(regNo, fuelCapacity)
        {
            
        }

        public double Mileage { get; set; }

        public static double GlobalMileage { get; private set; }

        /// <summary>
        /// Här lägger man in en beskrivning av vas metoden gör
        /// </summary>
        /// <param name="distanceKm"></param>
        public override void  Drive(double distanceKm)
        {
            base.Drive(distanceKm);

            Console.WriteLine(RegNo + " vill köra " + distanceKm + " km." );
            if (distanceKm < 0)
            {
                distanceKm = 0;
                Console.WriteLine("Negativt avstånd tolkas som noll");
            }

            double maxDistance = FuelLevel / fuelConsumtion;
            if (distanceKm > maxDistance)
            {
                distanceKm = maxDistance;
                Console.WriteLine("Bränslet räcker inte så långt.");
            }

            FuelLevel -= distanceKm * fuelConsumtion;
            Mileage += distanceKm;
            GlobalMileage += distanceKm;

            Console.WriteLine(RegNo + " körde " + distanceKm + " km.");
            Console.WriteLine();            
        }

        public void StatusReport() {            
            Console.WriteLine("RegNo:   " + RegNo);
            Console.WriteLine("Fuel:    " + FuelLevel + "/" + FuelCapacity);
            Console.WriteLine("Mileage: " + Mileage);
            Console.WriteLine();
        }
    }
}