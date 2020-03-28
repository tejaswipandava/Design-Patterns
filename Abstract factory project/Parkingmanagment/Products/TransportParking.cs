namespace Parkingmanagment.Products
{
    public class TransportParking : Ivehicles
    {
        private Iparking Iparking;

        public TransportParking(Iparking iparking)
        {
            this.Iparking = iparking;
        }

        public void VehicleIn()
        {
            Iparking.TotalSpace--;
            Iparking.SpaceOccupied++;
        }

        public void VehicleOut()
        {
            Iparking.TotalSpace++;
            Iparking.SpaceOccupied--;
        }
    }
}
