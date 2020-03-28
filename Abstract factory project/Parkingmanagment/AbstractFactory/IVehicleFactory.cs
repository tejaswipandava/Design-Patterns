namespace Parkingmanagment
{
    public interface IVehicleFactory
    {
        public Ivehicles Vehicleselection(string selection, Iparking iparking);
    }
}
