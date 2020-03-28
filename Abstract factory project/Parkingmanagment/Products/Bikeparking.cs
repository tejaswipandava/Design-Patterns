namespace Parkingmanagment
{
    class Bikeparking : Ivehicles
    {
        private Iparking Iparking;

        public Bikeparking(Iparking iparking)
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
