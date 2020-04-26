namespace Parkingmanagment
{
    public sealed class ParkingLotFactory
    {
        private static readonly ParkingLotFactory Instance = new ParkingLotFactory();

        public static ParkingLotFactory getInstance
        {
            get { return Instance; }
        }

        public Iparking parkingSelection(string selection)
        {
            int.TryParse(selection, out int sel);
            if (sel <= 2)
                return LevelOneParking.getInstance;
            else
                return LevelTwoParking.getInstance;
        }
    }
}