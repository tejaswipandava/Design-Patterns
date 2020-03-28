namespace Parkingmanagment.Products
{
    public class EVParking : Ivehicles
    {
        private Iparking Iparking;

        public EVParking(Iparking iparking)
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
