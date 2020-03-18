using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Structure
{
    class Program
    {
        static void Main(string[] args)
        {
            Book clr = new Book("C# Deep dive", "Andrew Troelson", 999, "Best book for true programmers", 2019);
            Book cpp = new Book("C++ OOP", "Bjorn Straustrup", 1299, "Best book for geeks", 2015);
            Book js = new Book("JavaScript Ninja", "Nikolas Zakos", 850, "For true javascriptisers", 2018);
            //clr.ShowBook();
            Client bill = new Client("Bill", 48, clr);
            //bill.myBooks.ShowBook();
            Client adam = new Librarian("Adam", 56, js, "administrator");
            List<Client> clients = new List<Client>();
            clients.Add(bill);
            clients.Add(adam);

            List<Librarian> librarian = new List<Librarian>();

            foreach (Client item in clients)
            {
                //item.myBooks.ShowBook();
                //if (item is Librarian)
                //{
                //    Console.WriteLine("Data type Librarian");
                //    item.myBooks.ShowBook();
                //}
                //else if (item is Client)
                //{
                //    Console.WriteLine("Data type Client");
                //    item.myBooks.ShowBook();
                //}

                Librarian newLibrarian = item as Librarian;
                if (newLibrarian is Librarian)
                {
                    librarian.Add(newLibrarian);
                    newLibrarian.myBooks.ShowBook();
                    newLibrarian.ShowCredentials();
                }
            }

            //foreach(Librarian item in librarian)
            //{
            //    item.myBooks.ShowBook();
            //    item.ShowCredentials();
            //}

        }
    }
}
