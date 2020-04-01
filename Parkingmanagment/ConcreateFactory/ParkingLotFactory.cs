namespace Parkingmanagment
{
    public class ParkingLotFactory
    {
        public Iparking parkingSelection(string selection)
        {
            int.TryParse(selection, out int sel);
            if (sel < 2)
                return new LevelTwoParking();
            else
                return new LevelOneParking();
        }
    }
}
