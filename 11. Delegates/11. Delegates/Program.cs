using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Delegates
{
    class Program
    {
        static Car car;
        static void Main(string[] args)
        {
            car = new Car();
            car.Start();
            car.RegisterOnTooFast(HandleOnToFast);
            car.Accelerate();
            car.Accelerate();
            car.Accelerate();
            car.Accelerate();
        }
        private static void HandleOnToFast()
        {
            Console.WriteLine("TooFast Handle works...");
            car.Stop();
        }
    }
}
