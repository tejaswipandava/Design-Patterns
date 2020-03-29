namespace CarProject
{
    public abstract class ICarBuilder
    {
        public CarProduct car { get; set; }
        public abstract void frame();
        public abstract void door();
        public abstract void engine();
        public abstract void suspention();
        public abstract void seats();
        public abstract void airbags();
    }
}