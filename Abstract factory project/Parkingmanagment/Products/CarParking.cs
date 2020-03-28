namespace Parkingmanagment
{
    public class CarParking : Ivehicles
    {
        private Iparking Iparking;

        public CarParking(Iparking iparking)
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
