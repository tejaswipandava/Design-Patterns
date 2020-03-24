using System;

namespace Parkingmanagment
{
    class Program
    {
        static void Main(string[] args)
        {
            ParkingFactory PL = new ParkingFactory();
            Console.WriteLine("Hello World!");
            Console.WriteLine("You are entering a smart Parting lot");
            while(1==1)
            {
                Console.WriteLine("Please select the vehile type 1 for bike and 2 for car");
                string selection = Console.ReadLine();

                Ivehicles vehiclestatus = PL.Vehicleselection(selection);
                vehiclestatus.VehicleIn();

                Console.WriteLine($"Availble space: {vehiclestatus.vehiclestatus() }");

                if(selection == "x")
                {
                    break;
                }
            }
        }
    }
}
