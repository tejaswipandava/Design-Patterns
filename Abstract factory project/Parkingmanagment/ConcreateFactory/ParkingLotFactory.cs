namespace Parkingmanagment
{
    public class ParkingLotFactory
    {
        public Iparking parkingSelection(string selection)
        {
            int.TryParse(selection, out int sel);
            switch (sel)
            {
                case (int)Vehicletype.Bike:
                    return new LevelOneParking();
                default:
                    return new LevelTwoParking();
            }
        }
    }
}
