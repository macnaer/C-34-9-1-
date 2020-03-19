using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Indexes
{
    class Employee
    {

        Worker[] data;
        ushort size;

        public List<Worker> workerList = new List<Worker>();

        public Employee(ushort size)
        {
            this.size = size;
            this.data = new Worker[this.size];
        }

        public void ShowWorkers()
        {
            foreach(Worker item in workerList)
            {
                Console.WriteLine($"Worker => {item.Name}");
            }
        }

        public Worker this[int index]   // Index for array
        {
            get
            {
                return this.data[index];
            }
            set
            {
                this.data[index] = value;
            }
        }

        public void ShowWorkerInfo()
        {
            foreach (Worker item in this.data)
            {
                Console.WriteLine($"Name => {item.Name}");
            }
        }


    }
}
