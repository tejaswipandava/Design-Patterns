namespace Parkingmanagment
{
    public class ParkingFactory
    {
        public Ivehicles Vehicleselection (string selection)
        {
            int.TryParse(selection, out int sel);
            switch(sel)
            {
                case (int)Vehicletype.Bike:
                    return new Bikeparking();
                default:
                    return new CarParking();
            }
        }
    }
}