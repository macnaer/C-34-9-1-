using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Structure
{
    class Librarian : Client
    {
        string credentials;

        public Librarian(string name, ushort age, Book myBooks, string credentials) : base(name, age, myBooks)
        {
            this.credentials = credentials;
        }

        public void ShowCredentials()
        {
            Console.WriteLine($"Credentials: {this.credentials}");
        }
    }
}
