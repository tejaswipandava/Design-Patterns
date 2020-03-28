using Parkingmanagment.ConcreateFactory;
using System;

namespace Parkingmanagment
{
    public class ParkingClient
    {
        private Iparking iparking;
        private Ivehicles ivehicles;
        private ParkingLotFactory parkingObject;
        private IVehicleFactory vehicleObject;

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
            if(int.Parse(sel) <= 2)
            {
                vehicleObject = new EcoVehicleFactory();
            }
            else if(int.Parse(sel) >= 2 || int.Parse(sel) <= 4)
            {
                vehicleObject = new NonEcoVehicleFactory();
            }
            else {
                return "failed";
            }
            return sel;
        }

        public void AccessParking(string selection)
        {
            iparking = parkingObject.parkingSelection(selection);
            ivehicles = vehicleObject.Vehicleselection(selection, iparking);
        }

        public void ParkingStatus()
        {
            iparking.ParkingStatus();
        }

        public void VehicleIn()
        {
            ivehicles.VehicleIn();
        }

        public void VehicleOut()
        {
            ivehicles.VehicleOut();
        }

    }
}
