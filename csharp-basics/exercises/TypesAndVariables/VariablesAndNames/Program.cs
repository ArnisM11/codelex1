using System;

namespace VariablesAndNames
{
    class Program
    {
        private static void Main(string[] args)
        {
            int cars, drivers, passengers, carsNotDriven, carsDriven,seatsInACar;
            double  carpoolCapacity, averagePassengersPerCar;

            cars = 100; //cars
            seatsInACar = 4.0; //seats in a car
            drivers = 28; // drivers
            passengers = 90; // passengers
            carsNotDriven = cars - (cars / drivers);// free cars
            carsDriven = cars / drivers; // cars driven at the moment
            carpoolCapacity = carsNotDriven * seatsInACar;// carpool capacity
            averagePassengersPerCar = (double)passengers/(double)drivers;

            Console.WriteLine("There are " + cars + " cars available.");
            Console.WriteLine("There are only " + drivers + " drivers available.");
            Console.WriteLine("There will be " + carsNotDriven + " empty cars today.");
            Console.WriteLine("We can transport " + carpoolCapacity + " people today.");
            Console.WriteLine("We have " + passengers + " to carpool today.");
            Console.WriteLine("We need to put about " + averagePassengersPerCar.ToString("N2") + " in each car.");
            Console.ReadKey();
        }
    }
}