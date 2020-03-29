using System;

namespace CarProject
{
    public class Director
    {
        public Director()
        {
            Console.WriteLine("Welcome to Car designer. Please select the car type you would want us to build for you");
        }

        public ICarBuilder carSelection()
        {
            Console.WriteLine("Press 1 for sports and 2 for SUV");
            string s = Console.ReadLine();
            if(s =="1")
            {
                return new SportsCar();
            }
            else
            {
                return new SUV();
            }
        }

        public void BuildCar(ICarBuilder car)
        {
            car.airbags();
            car.seats();
            car.frame();
            car.door();
            car.suspention();
            car.engine();
        }
    }
}
