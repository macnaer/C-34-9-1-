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
            //car.RegisterOnTooFast(Brake);
            car.ToFastEvent += Brake;
            car.ToFastEvent += FullStop;
            //car.ToFastEvent -= Brake;
            car.Accelerate();
            car.Accelerate();
            car.Accelerate();
            car.Accelerate();
            car.Accelerate();
            car.Accelerate();

            //while (true)
            //{
            //    car.Accelerate();
            //}
            
        }
        private static void FullStop(int stop)
        {
            Console.WriteLine("FullStop working ...");
            car.Stop(20);
        }
        private static void Brake(int brake)
        {
            Console.WriteLine("Brake working ...");
            car.Break(40);
        }
    }
}
