using System;

namespace Parkingmanagment
{
    public class ParkingClient
    {
        private Iparking iparking;
        private ParkingLotFactory parkingObject;

        public ParkingClient()
        {
            parkingObject = new ParkingLotFactory();
        }

        public string GetInput()
        {
            Console.WriteLine("Please select your vehicle");
            Console.WriteLine("1 for Bike");
            Console.WriteLine("2 for Car");
            Console.WriteLine("3 for EV");
            Console.WriteLine("4 for Transport");
            string sel =  Console.ReadLine();
            return sel;
        }

        public void AccessParking(string selection)
        {
            iparking = parkingObject.parkingSelection(selection);
        }

        public void ParkingStatus()
        {
            iparking.ParkingStatus();
        }

        public void VehicleIn()
        {
            iparking.In();
        }

        public void VehicleOut()
        {
            iparking.Out();
        }

    }
}
