using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.OOP_Part_2
{
    class Out
    {
        private double mark;
        public string Name { get; set; }
        public string Surname { get; set; }

        public void SetMark(double mark)
        {
            this.mark = mark;
        }

        public void Sum(int x, int y, out int a)
        {
            a = x + y;
        }


        public void GetAll(out double mark, out string name, out string surname)
        {
            mark = this.mark;
            name = this.Name;
            surname = this.Surname;
        }
    }
}
