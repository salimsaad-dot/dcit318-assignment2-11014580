using System;

namespace DCIT318_Assignment2
{
    // Interface definition
    interface IMovable
    {
        void Move();
    }

    class Car : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Car is moving");
        }
    }

    class Bicycle : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Bicycle is moving");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Interfaces ===");

            IMovable car = new Car();
            IMovable bicycle = new Bicycle();

            car.Move();        // Output: Car is moving
            bicycle.Move();    // Output: Bicycle is moving
        }
    }
}
