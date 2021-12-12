using System;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var car = new CarModel("Civic");
            Console.WriteLine($"Starting Car!");
            car.OnStart += Car_OnStart;
            car.AttemptStart();

        }

        private static void Car_OnStart(object sender, string message)
        {
            var car = (CarModel)sender;
            Console.WriteLine($"Car: {car.Name} {message}");
        }
    }
}
