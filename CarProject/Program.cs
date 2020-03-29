using System;

namespace CarProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Director director = new Director();
            ICarBuilder carbuilder =  director.carSelection();
            director.BuildCar(carbuilder);
            carbuilder.car.showCar();

        }
    }
}
