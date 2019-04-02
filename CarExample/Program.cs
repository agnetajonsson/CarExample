using System;

namespace CarExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car(regNo: "ABC127", fuelCapacity: 100) {
                FuelLevel = -10,
                Mileage = 100
            };


            Car car2 = new Car("XYZ987", 200);

            car1.StatusReport();
            car2.StatusReport();

            Console.WriteLine("Odometer: " + Car.GlobalMileage);
            Console.WriteLine();
           
            // tanka             
            car1.FuelLevel += 100;
            car2.FuelLevel += 50;

            // kör en massa
            car1.Drive(600);
            car1.Drive(600);
            car2.Drive(100000);

            car1.StatusReport();
            car2.StatusReport();
            System.Console.WriteLine("Odometer: " + Car.GlobalMileage);


        }
    }
}