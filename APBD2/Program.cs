using System;

namespace APBD2
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = "input.txt"; 
            DeviceManager manager = new DeviceManager(filePath);
            Console.WriteLine("Loaded Devices:");
            manager.ShowDevices();
            Console.WriteLine("Turn Off SmartWatch with ID=1");
            manager.TurnOffDevice("SW", 1);
            Console.WriteLine("Turning ON PC with ID=1");
            manager.TurnOnDevice("P", 1);
            Console.WriteLine("Editing PC with ID=2");
            manager.EditDeviceData("P", 2, new object[] { 2, "Updated PC", "Ubuntu" });
            Console.WriteLine("Adding a New Device");
            SmartWatches newWatch = new SmartWatches(100, "FitBit Versa", 50);
            manager.AddDevice(newWatch);
            Console.WriteLine("Removing ED with ID=2");
            manager.RemoveDevice("ED", 2);
            Console.WriteLine("Saving");
            manager.SaveDevices();
            manager.ShowDevices();
        }
    }
}

