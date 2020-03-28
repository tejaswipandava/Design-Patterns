using System;
namespace Parkingmanagment
{
    public class LevelOneParking : Iparking
    {
        public int SpaceOccupied { get; set; } = 0;
        public int TotalSpace { get; set; } = 1000;


        public void ParkingStatus()
        {
            Console.WriteLine($"Level 1 : TotalCapacity: {TotalSpace} / Occupied: {SpaceOccupied}");
        }

    }
}
