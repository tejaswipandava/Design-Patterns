using System;

namespace Parkingmanagment
{
    public sealed class LevelTwoParking : Iparking
    {
        private static readonly LevelTwoParking Instance = new LevelTwoParking();
        public static LevelTwoParking getInstance
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
            Console.WriteLine($"Level 2 : TotalCapacity: {TotalSpace} / Occupied: {SpaceOccupied}");
        }
    }
}