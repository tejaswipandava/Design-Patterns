﻿namespace Parkingmanagment.ConcreateFactory
{
    public class NonEcoVehicleFactory : IVehicleFactory
    {
        public Ivehicles Vehicleselection(string selection, Iparking iparking)
        {
            int.TryParse(selection, out int sel);
            switch (sel)
            {
                case (int)Vehicletype.Bike:
                    return new Bikeparking(iparking);
                default:
                    return new CarParking(iparking);
            }
        }
    }
}