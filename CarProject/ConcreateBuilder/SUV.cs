namespace CarProject
{
    public class SUV : ICarBuilder
    {
        public SUV()
        {
            car = new CarProduct("Sports Car");
        }

        public override void airbags()
        {
            car["AirBags"] = "8";
        }

        public override void door()
        {
            car["Doors"] = "5";
        }

        public override void engine()
        {
            car["Engine"] = "V12";
        }

        public override void frame()
        {
            car["Frametype"] = "High";
        }

        public override void seats()
        {
            car["Seat"] = "8";
        }

        public override void suspention()
        {
            car["Suspension"] = "High heigh setting";
        }
    }
}
