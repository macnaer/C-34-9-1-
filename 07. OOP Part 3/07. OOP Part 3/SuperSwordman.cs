using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.OOP_Part_3
{
    class SuperSwordman : Swordman
    {
        public SuperSwordman(string race) : base(race)
        {

        }
        public override void Hit(int damage)
        {
            base.Hit(damage);
        }
    }
}
