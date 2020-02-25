using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //#region
            ////string[] names = { "Bill", "John", "Jasica", "Tina" };

            ////foreach (var name in names)
            ////{
            ////    Console.WriteLine(name);
            ////}

            ////Array arr = new int[5];
            //Array arr = Array.CreateInstance(typeof(int), 5);  // не зручно
            ////arr[0] = 10; // Error
            //arr.SetValue(22, 0);
            //Console.WriteLine(arr.GetValue(0));

            //int[] numbers = { 1,2,3,4,5,6,7,8,9,10};
            //int index = Array.BinarySearch(numbers, 8);    // Перше входження у відсортованому масиві
            //Console.WriteLine("Index of 8 = {0}", index);

            //int[] numbers2 = new int[10];
            //Array.Copy(numbers, numbers2, numbers.Length);

            //foreach(int value in numbers2)
            //{
            //    Console.WriteLine(value);
            //}
            //Console.WriteLine("========================================>");

            //int[] numbers3 = new int[10];
            //numbers2.CopyTo(numbers3, 0);
            //foreach (int value in numbers3)
            //{
            //    Console.WriteLine(value);
            //}
            //Console.WriteLine("========================================>");
            //Array.Reverse(numbers3);
            //foreach (int value in numbers3)
            //{
            //    Console.WriteLine(value);
            //}
            //Console.WriteLine("========================================>");
            //Array.Sort(numbers3);
            //foreach (int value in numbers3)
            //{
            //    Console.WriteLine(value);
            //}
            //Console.WriteLine("#########################################>");
            //#endregion
            #region
            var list = new List<int>() { 34, 435, 346, 67, 68 };
            list.Add(11);

            foreach(var value in list)
            {
                Console.WriteLine(value);
            }
            Console.WriteLine("========================================>");
            list.Insert(2, 100500);
            Console.WriteLine(list[2]);
            #endregion
        }
    }
}
