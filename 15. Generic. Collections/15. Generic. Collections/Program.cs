using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Generic.Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //Wallet<string, int> ltc1 = new Wallet<string, int>("0094TR2W", 100, "LTC");
            //Wallet<string, int> ltc2 = new Wallet<string, int>("54ER43Q6", 50, "LTC");
            ////ltc1.ShowBalance();
            ////ltc1.Pay(90);
            ////ltc1.ShowBalance();

            //var btc1 = new Wallet<int, double>(45675444, 1.1222, "BTC");
            //var btc2 = new Wallet<int, double>(65464566, 5.6456, "BTC");
            ////btc1.ShowBalance();
            ////btc1.Pay(0.21);
            ////btc1.ShowBalance();
            ////1.123456789

            //var pServiceLTC = new PaymentService<Wallet<string, int>, string, string, int>();
            //pServiceLTC.FromWallet = ltc1;
            //pServiceLTC.ToWallet = ltc2;
            //pServiceLTC.Transaction = "34REN95P";
            //pServiceLTC.Sum = 20;
            //pServiceLTC.MakePayment();

            //Console.WriteLine("=============================================>");

            //var pServiceBTC = new PaymentService<Wallet<int, double>, string, int, double>();
            //pServiceBTC.FromWallet = btc1;
            //pServiceBTC.ToWallet = btc2;
            //pServiceBTC.Transaction = "34REN95P";
            //pServiceBTC.Sum = 1;
            //pServiceBTC.MakePayment();

            // Collections

            // 1. ArrayList 
            //ArrayList arr = new ArrayList();
            //arr.Add("First");
            //arr.Add(4);
            //arr.AddRange(new string[] { "AddRange", "55" });
            //arr.Add(4.546);
            //arr.RemoveAt(0);
            //arr.Reverse();

            //foreach(var item in arr)
            //{
            //    Console.WriteLine("Elem => {0}", item);
            //}

            // 2 List
            //List<int> arr = new List<int>();
            //arr.Add(72);
            //arr.Add(11);
            //arr.Add(8);
            //arr.Add(43);
            //arr.Add(16);
            //arr.AddRange(new int[] { 3, 90, 54 });
            //Console.WriteLine("AVG {0}",arr.Average());
            //arr.Insert(1, 100500);


            //foreach (var item in arr)
            //{
            //    Console.WriteLine("Elem => {0}", item);
            //}

            // 3. LinkedList

            //LinkedList<int> arr = new LinkedList<int>();
            //arr.AddLast(33);
            //arr.AddFirst(42);
            //arr.AddBefore(arr.Last, 99);
            ////Console.WriteLine("Find 99 => {0}", arr.Find(99));

            //arr.RemoveFirst();


            //foreach (var item in arr)
            //{
            //    Console.WriteLine("Elem => {0}", item);
            //}

            // 4 Queue

            //Queue<int> arr = new Queue<int>();
            //arr.Enqueue(6);
            //arr.Enqueue(82);

            //foreach (var item in arr)
            //{
            //    Console.WriteLine("Elem => {0}", item);
            //}

            // 5 Stack

            //Stack<int> arr = new Stack<int>();
            //arr.Push(89);
            //arr.Push(92);
            //arr.Push(7);
            //arr.Pop();
            //Console.WriteLine("First elem => {0}",arr.Peek());

            //foreach (var item in arr)
            //{
            //    Console.WriteLine("Elem => {0}", item);
            //}

            // 6. Dictionary

            //Dictionary<int, string> arr = new Dictionary<int, string>();

            //arr.Add(1, "Richerd");
            //arr.Add(2, "Bobolton");
            //arr.Add(3, "Adam");

            //foreach(KeyValuePair<int, string> item in arr){
            //    Console.WriteLine("Key => {0} <---> value {1}", item.Key, item.Value);
            //}
            
        }
    }
}
