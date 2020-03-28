namespace Parkingmanagment
{
    public interface Iparking
    {
        public int SpaceOccupied { get; set; }
        public int TotalSpace { get; set; }

        public void ParkingStatus();
    }
}
