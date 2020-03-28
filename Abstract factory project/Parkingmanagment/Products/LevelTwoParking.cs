using System;
using System.Collections.Generic;
using System.Text;

namespace Parkingmanagment
{
    public class LevelTwoParking :Iparking
    {
        public int SpaceOccupied { get; set; } = 0;
        public int TotalSpace { get; set; } = 1000;

        public void ParkingStatus()
        {
            Console.WriteLine($"Level 2 : TotalCapacity: {TotalSpace} / Occupied: {SpaceOccupied}");
        }
    }
}
