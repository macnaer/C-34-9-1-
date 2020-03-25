using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.IEnumerable_GC
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] languages = { "C++", "C#", "JavaScript", "Python", "Java" };
            //Languages programming = new Languages(languages);

            //foreach(var item in programming)
            //{
            //    Console.WriteLine(item);
            //}

            // ================================
            int a = 10;
            string[] languages = { "C++", "C#", "JavaScript", "Python", "Java" };
            using (Languages programming = new Languages(languages))
            {
                foreach (var item in programming)
                 {
                     Console.WriteLine(item);
                 }
            }
        }


    }
}
