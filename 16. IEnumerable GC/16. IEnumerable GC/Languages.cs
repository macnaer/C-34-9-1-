using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.IEnumerable_GC
{
    class Languages : IEnumerable, IDisposable
    {
        string [] languages;
        string[] arr = { "a", "b", "c", "d"};

        public Languages(string [] languages)
        {
            this.languages = languages;
        }

        public IEnumerator GetEnumerator()
        {
            return languages.GetEnumerator();
        }

        public void Dispose()
        {

            GC.SuppressFinalize(this);
        }

        ~Languages()
        {
            Console.Beep();
            this.Dispose();
            Console.WriteLine("Destructor");
        }

    }
}