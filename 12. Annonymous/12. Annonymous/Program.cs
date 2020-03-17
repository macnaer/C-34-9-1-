using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Annonymous
{
    delegate void SomeHandler(string msg);
    class Program
    {
        
        static void Main(string[] args)
        {
            //SomeHandler handler = delegate (string msg)
            //{
            //    Console.WriteLine($"Delegate massage {msg}");
            //};
            //handler("Hello dalagate");

            ShowInfo("Test massage", delegate (string msg)
            {
                Console.WriteLine(msg);
            });
        }
        static void ShowInfo(string msg, SomeHandler handler)
        {
            handler(msg);
        }
    }
}
