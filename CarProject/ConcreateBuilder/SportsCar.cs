namespace CarProject
{
    public class SportsCar : ICarBuilder
    {
        
        public SportsCar()
        {
            car = new CarProduct("Sports Car");
        }

        public override void airbags()
        {
            car["AirBags"] = "2";
        }

        public override void door()
        {
            car["Doors"] = "2";
        }

        public override void engine()
        {
            car["Engine"] = "V6";
        }

        public override void frame()
        {
            car["Frametype"] = "low";
        }

        public override void seats()
        {
            car["Seat"] = "2";
        }

        public override void suspention()
        {
            car["Suspension"] = "low heigh setting";
        }
    }
}
