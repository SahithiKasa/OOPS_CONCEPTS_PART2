using System;

class Vehicle
{
    public virtual void Service()
    {
        Console.WriteLine("General vehicle service started");
    }
}

class Car : Vehicle
{
    public override void Service()
    {
        Console.WriteLine("Car Service:");
        Console.WriteLine("→ Engine oil change");
        Console.WriteLine("→ Wheel alignment");
        Console.WriteLine("→ AC filter cleaning");
    }
}

class Bike : Vehicle
{
    public override void Service()
    {
        Console.WriteLine("Bike Service:");
        Console.WriteLine("→ Chain lubrication");
        Console.WriteLine("→ Brake adjustment");
        Console.WriteLine("→ Spark plug check");
    }
}

class Program8
{
    static void Main()
    {
        
      Vehicle v= new Car();
          v.Service();
        Console.WriteLine();
       Vehicle v1 = new Bike();
        v1.Service();
    }
}
