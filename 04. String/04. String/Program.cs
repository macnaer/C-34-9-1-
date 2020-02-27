using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.String
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "somegoodword";
            bool cW = name.Contains("w");
            Console.WriteLine(cW);

            string word = string.Concat("w", "o", "r", "d");
            Console.WriteLine(word);

            int num = 100;
            string snum = num.ToString();
            Console.WriteLine(snum);
        }
    }
}
