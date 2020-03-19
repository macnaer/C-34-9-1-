using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Indexes
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee(2);
            
            emp[0] = new Worker { Name = "Bill" };
            emp[1] = new Worker { Name = "Tom" };

            emp.ShowWorkerInfo();
            Console.WriteLine("=================================================>");

            Worker work1 = new Worker();
            work1.Name = "Bob";

            emp.workerList.Add(work1);
            emp.workerList.Add(emp[0]);
            emp.workerList.Add(emp[1]);

            emp.ShowWorkers();

            //Manager boss = new Manager();

            //boss["name"] = "Big boss";
            //boss["email"] = "boss@site.com";
            //boss["phone"] = "(066)-234-45-54";

            //Console.WriteLine(boss["name"]);
            //Console.WriteLine(boss["email"]);
            //Console.WriteLine(boss["phone"]);
        }
    }
}
