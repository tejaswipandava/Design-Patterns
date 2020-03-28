using System;

namespace Parkingmanagment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("You are entering a smart Parting lot");
            ParkingClient PC = new ParkingClient();
            string Selection = PC.GetInput();
            if (Selection != "failed")
            {
                PC.AccessParking(Selection);
                PC.ParkingStatus();
                PC.VehicleIn();
                PC.ParkingStatus();
            }

        }
    }
}
