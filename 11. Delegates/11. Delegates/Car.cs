using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Delegates
{
    class Car
    {
        int speed = 0;

        public delegate void TooFast();

        private TooFast tooFast;

        public void RegisterOnTooFast(TooFast toofast)
        {
            this.tooFast = toofast;
        }

        public void Start()
        {
            speed = 10;
        }

        public void Accelerate()
        {
            this.speed += 10;
            Console.WriteLine($"Current speed {this.speed}");
            if (speed > 40)
            {
                tooFast();
            }
        }

        public void Stop()
        {
            this.speed = 0;
        }
    }
}
