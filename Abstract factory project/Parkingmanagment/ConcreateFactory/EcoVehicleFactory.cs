using Parkingmanagment.Products;

namespace Parkingmanagment.ConcreateFactory
{
    public class EcoVehicleFactory : IVehicleFactory
    {
        public Ivehicles Vehicleselection(string selection, Iparking iparking)
        {
            int.TryParse(selection, out int sel);
            switch (sel)
            {
                case (int)Vehicletype.EV:
                    return new EVParking(iparking);
                default:
                    return new TransportParking(iparking);
            }
        }
    }
}
