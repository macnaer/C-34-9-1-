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

        //public event Callback ToFastEvent;
        public event Action<int> ToFastEvent;
        //public delegate void Callback();

        //private Callback tooFast;

        //public void RegisterOnTooFast(Callback tooFast)
        //{
        //    this.tooFast = tooFast;
        //}

        public void Start()
        {
            Console.WriteLine("Started...");
            this.speed = 10;
        }

        public void Accelerate()
        {
            Console.WriteLine($"Current speed = {this.speed}");
            this.speed += 10;
            if (this.speed > 60)
            {
                Console.WriteLine("Too fast inside if");
                ToFastEvent(speed);
            }
        }

        public void Stop(int speed)
        {
            this.speed = speed;
            Console.WriteLine($"After full stop {this.speed}");
        }

        public void Break(int speed)
        {
            this.speed -= speed;
            Console.WriteLine($"After break stop {this.speed}");
        }
    }
}
