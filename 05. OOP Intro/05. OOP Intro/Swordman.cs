using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.OOP_Intro
{
    public class Swordman
    {
        public int Health { get; private set; } = 100;// Get set

        private readonly string skill = "Fight";

        int karma;

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


        internal void Hit(int damage)
        {
            if (damage > Health)
            {
                damage = Health;
            }
            Health -= damage;

        }

        public void Hit(int damage, int fatality)
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

            foreach(int item in damage)
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
