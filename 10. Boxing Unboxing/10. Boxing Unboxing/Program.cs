using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Boxing_Unboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            object obj = a;
            int b = (int)obj;
            Console.WriteLine(b);
        }
    }
}
