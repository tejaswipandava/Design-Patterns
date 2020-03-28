namespace Parkingmanagment
{
    public class CarParking : ParkingLot, Ivehicles
    {
        public void VehicleIn()
        {
            TotalSpace--;
            SpaceOccupied++;
        }

        public void VehicleOut()
        {
            TotalSpace++;
            SpaceOccupied--;
        }

        public int vehiclestatus()
        {
            return TotalSpace;
        }
    }
}
