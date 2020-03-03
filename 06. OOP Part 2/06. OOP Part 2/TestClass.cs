using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.OOP_Part_2
{
    class TestClass
    {
        private double mark;
        public string Name { get; set; }
        public string Surname { get; set; }

        public void SetMark(ref double m)
        {
            this.mark = m;
        }


        public void GetAll(out double mark, out string name, out string surname)
        {
            mark = this.mark;
            name = this.Name;
            surname = this.Surname;
        }
    }
}
