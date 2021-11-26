using DesignPatterns.FactoryMethod.Models;
using System;

namespace DesignPatterns.FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var carFactory = new CarFactory();
            var motorcycleFactory = new MotorcycleFactory();

            Console.WriteLine(carFactory.SomeOperation());
            Console.WriteLine(motorcycleFactory.SomeOperation());
        }
    }
}
