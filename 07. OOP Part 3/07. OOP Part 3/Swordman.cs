using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.OOP_Part_3
{
    class Swordman
    {
        public int Health { get; private set; } = 100;// Get set

        protected readonly string skill = "Fight";

        int karma;
        public string Race { private set; get; }
        public int Armor { get; set; }


        public Swordman(string race)
        {
            this.Race = race;
        }

        public Swordman(string race, int armor)
        {
            this.Race = race;
            this.Armor = armor;
        }


        public int Karma
        {
            get
            {
                return karma;
            }
            set
            {
                if (value == 10)
                {
                    karma = value;
                }
                else
                {
                    Console.WriteLine("Bad karma!");
                }

            }
        }


        public virtual void Hit(int damage)
        {
            Console.WriteLine("Class Swordman: ");
            if (damage > Health)
            {
                damage = Health;
            }
            Health -= damage;

        }

        public virtual void Hit(int damage, int fatality)
        {
            if (damage > Health)
            {
                damage = Health;
            }
            Health -= damage;

            if (fatality > Health)
            {
                fatality = Health;
            }
            Health -= fatality;
        }

        public int AvgDamage(int[] damage)
        {
            int sum = 0;

            foreach (int item in damage)
            {
                sum += item;
            }

            return sum / damage.Length;
        }

        public int NewAvgDamage(params int[] damage)
        {
            int sum = 0;

            foreach (int item in damage)
            {
                sum += item;
            }

            return sum / damage.Length;
        }
    }
}
