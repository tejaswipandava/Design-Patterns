using System;
namespace Parkingmanagment
{
    public sealed class LevelOneParking : Iparking
    {
        private static readonly LevelOneParking Instance = new LevelOneParking();
        public static LevelOneParking getInstance
        {
            get { return Instance; }
        }

        public int SpaceOccupied { get; set; } = 0;
        public int TotalSpace { get; set; } = 1000;

        public void In()
        {
            TotalSpace--;
            SpaceOccupied++;
        }

        public void Out()
        {
            TotalSpace++;
            SpaceOccupied--;
        }

        public void ParkingStatus()
        {
            Console.WriteLine($"Level 1 : TotalCapacity: {TotalSpace} / Occupied: {SpaceOccupied}");
        }

    }
}