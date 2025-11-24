using System;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Policy;
using static System.Net.Mime.MediaTypeNames;

// Parent Interface
interface IDevice
{
    void TurnOn();
    void TurnOff();
}

// Child Interface inheriting IDevice
interface ISmartDevice : IDevice
{
    void ConnectToWiFi(string ssid);
    void RunDiagnostics();
}

// Another Interface
interface IVoiceControl
{
    void ListenCommand(string command);
}
interface IRemoteLocationDetails
{
    void GetLocation(string location);
   
    
}
// Class implementing multiple interfaces
class SmartSpeaker : ISmartDevice, IVoiceControl,IRemoteLocationDetails
{
    public void TurnOn()
    {
        Console.WriteLine("Smart Speaker is turned ON.");
    }

    public void TurnOff()
    {
        Console.WriteLine("Smart Speaker is turned OFF.");
    }

    public void ConnectToWiFi(string ssid)
    {
        Console.WriteLine($"Connected to WiFi network: {ssid}");
    }

    public void RunDiagnostics()
    {
        Console.WriteLine("Running device diagnostics...");
    }

    public void ListenCommand(string command)
    {
        Console.WriteLine($"Executing voice command: {command}");
    }
    public void GetLocation(string location)
    {
        Console.WriteLine($"Getting location deails for:{location}");
    }
    public void GetPriceDetails()
    {
        Console.WriteLine("Getting price details is 300$");
    }
}

class Program5
{
    static void Main()
    {
        SmartSpeaker speaker = new SmartSpeaker();
        speaker.GetLocation("BedRoom");
        speaker.TurnOn();
        speaker.ConnectToWiFi("Home_Network");
        speaker.ListenCommand("Play Music");
        speaker.RunDiagnostics();
        speaker.TurnOff();
        
    }
}
//✅ INTERFACE INHERITANCE — Simple Theory (Line by Line)
//An interface is a template that contains only method names, no code..in interface we only declare the methods we doesnt implement them
//A class must write the code for all methods in an interface.
//Interfaces are created using the interface keyword.
//One interface can inherit another interface.
//Syntax is: interface B : A.
//If interface B inherits A, then B has all methods of A + B.
//A class that implements B must implement all methods from both A and B.
//A class can implement multiple interfaces.
//Syntax is: class MyClass : IOne, ITwo.
//Interface inheritance gives multiple inheritance support in C#.
//Interfaces help keep code flexible and loosely connected.
//Interfaces are used in big applications for clean architecture and testing.
//Interface names usually start with I (like IAnimal, IDevice).
//Interface inheritance combines small interfaces into bigger ones.
//Interfaces support polymorphism just like classes.