using System;

namespace Parkingmanagment
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 1;
            Console.WriteLine("Hello World!");
            Console.WriteLine("You are entering a smart Parting lot");

            ParkingClient PC = new ParkingClient();
            while (counter != 0)
            {
                string Selection = PC.GetInput();
                if (Selection != "failed")
                {
                    PC.AccessParking(Selection);
                    PC.ParkingStatus();
                    PC.VehicleIn();
                    PC.ParkingStatus();
                    Console.WriteLine("Another vehicle to enter press 1 else 0");

                    if (1 != Convert.ToInt32(Console.ReadLine()))
                    {
                        counter = 0;
                    }
                }
            }

        }
    }
}