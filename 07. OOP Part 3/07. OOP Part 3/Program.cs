using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.OOP_Part_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Swordman Unit1 = new Swordman("Ork");
            //Console.WriteLine(Unit1.Race);
            SuperSwordman elf = new SuperSwordman("Elf");
            elf.Hit(10);
            Console.WriteLine(elf.Health);
        }
    }
}
