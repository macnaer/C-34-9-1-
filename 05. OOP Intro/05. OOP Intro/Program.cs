using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// public 
// private 
// protected
// internal

namespace _05.OOP_Intro
{
    class Program
    {
        static void Main(string[] args)
        {
            Swordman kozak = new Swordman();
            kozak.Hit(10);
            Console.WriteLine(kozak.Health);
            kozak.Hit(10, 30);
            Console.WriteLine(kozak.Health);
            //kozak.Karma = 11;
            //Console.WriteLine(kozak.Karma);


            //Console.WriteLine("<<<========================================>>>");
            int avg = kozak.AvgDamage(new int[] { 30, 22, 32, 12,70 });
            Console.WriteLine("Avg damage = {0}", avg);
            //Console.WriteLine("<<<---------------------------------------->>>");

            //int newAvg = kozak.NewAvgDamage(24, 20, 52);
            int newAvg = kozak.NewAvgDamage(24, 20, 52, 10 , 100);
            Console.WriteLine("New damage = {0}", newAvg);

        }
    }
}
