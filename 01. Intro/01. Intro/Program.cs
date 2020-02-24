using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Intro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world!");


            //string name = "Bill";
            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();
            Console.WriteLine(name);
            int age = 45;
            char chr = 'a';
            float fl = 3.14f;
            bool isDirector = true;
            var magic = "It's some kind of magic";

            //Console.WriteLine("What is var? " + magic);
            Console.WriteLine("What is var? {0} ", magic);
            Console.WriteLine("-----------------------------------");
            int x = 10;
            //byte y = x;  // Error
            byte y = (byte)x;
            Console.WriteLine(y);

            string str = "22";
            int number = Convert.ToInt32(str);
            Console.WriteLine(number);
            int number1 = int.Parse(str);
            Console.WriteLine(number1);
            //Console.WriteLine("############################");
            //int a = 5;
            //int b = 3;

            //int c = a + b;
            //int d = a * b;
            //double e = (double)a / b;
            //double f = 5 % 2;

            //Console.WriteLine("{0},{1},{2},{3}", c, d, e, f);
            //a++;
            //b--;
            //int q = 1;
            //int z = ++q; 

            //Console.WriteLine("{0}, {1}, {2}", a, b, z);

            //Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
            //int a = 5;
            //int b = 7;
            //string res = null;
            //bool x = false;


            //if (a == b)
            //    res = "Equal";

            //if (a != b)
            //    res = "Not equal";

            //if (a > b)
            //    res = "A > B";

            //if (a < b)
            //    res = "A < B";

            //if (a >= b)
            //    res = "A >= B";

            //if (a <= b)
            //    res = "A <= B";


            //Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
