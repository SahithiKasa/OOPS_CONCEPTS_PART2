using System;
using System.Security.Policy;

namespace VehicleConfigurationSystem
{
    abstract class Vechile
    {
        public string FuelType { get; set; }
        public int Capacity { get; set; }


        //Abstract methods or rules
        public abstract void Start();   // rule
        public abstract void Stop();
        public abstract void EngineType();


        //Concrete methods
        public void ShowDetails()
        {
            Console.WriteLine($"Fuel Type: {FuelType}");
            Console.WriteLine($"Capacity: {Capacity} passengers");   // 5(car) , 8 ,  7 , 4  , 2(Bike)
        }
    }

    //child class or derived class 
    class Car : Vechile
    {
        public override void Start()
        {
            Console.WriteLine("Car is starting with a key ignition.");
        }  // rule
        public override void Stop()
        {
            Console.WriteLine("Car has stopped .");
        }
        public override void EngineType()
        {
            Console.WriteLine("Car engine is a 4-cylinder petrol engine.");
        }
        public void CarPurcahseDateandTime()
        {
            Console.WriteLine("12-06-2024:12:35:00");
        }

    }

    class Bike : Vechile
    {
        public override void EngineType()
        {
            Console.WriteLine("Bike engine is a 2-stroke petrol engine.");
        }

        public override void Start()
        {
            Console.WriteLine("Bike is starting with a self-start or kick-start.");
        }

        public override void Stop()
        {
            Console.WriteLine("Bike has stopped .");
        }
    }


    class Program
    {
        // 1. For Abastract class you cnnot create instance like interfacce 
        // 2. But Abstract class we can refer the to the child or dervied classs
        static void Main()
        {
            //Vechile carVehicle = new Car();
            //carVehicle.FuelType = "petrol";
            //carVehicle.Capacity = 5;

            Vechile carVehicle = new Car()
            {
                FuelType = "Petrol",
                Capacity = 5
            };

            carVehicle.Start();   // Abstract method
            carVehicle.Stop();    // Abstract mehod
            carVehicle.EngineType(); //Abstract method.
            carVehicle.ShowDetails();  //Concrete mehtods.





            Vechile bikeVehicle = new Bike()
            {
                Capacity = 2,
                FuelType = "Petrol"
            };

            bikeVehicle.ShowDetails(); // Focus on essentials (high-level details) //concreate method
            bikeVehicle.Start(); // abstart method.
            bikeVehicle.Stop();  // abstract method.
            bikeVehicle.EngineType();










        }
    }
}