using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Structure
{
    class Client
    {
        string name;
        ushort age;
        public Book myBooks { get; private set; }

        public Client(string name, ushort age, Book myBooks)
        {
            this.name = name;
            this.age = age;
            this.myBooks = myBooks;
        }
    }
}
