﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.OOP_Part_2
{
    static class Calc
    {
        public static void Plus(int a, int b, out int sum)
        {
            sum = a + b;
        }

        public static int Minus(int a, int b)
        {
            return a - b;
        }
    }
}
