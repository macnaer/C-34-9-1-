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
            ///*Array arr = Array.CreateInstance(typeof(int), 5);*/  // не зручно
            ////arr[0] = 10; // Error
            ////arr.SetValue(22, 0);
            ////arr.SetValue(18, 1);

            ////Console.WriteLine(arr.GetValue(0));
            ////Console.WriteLine(arr.GetValue(1));


            //int[] numbers = { 1,2,3,4,5,6,7,8,9,10};
            ////int index = Array.BinarySearch(numbers, 8);    // Перше входження у відсортованому масиві
            ////Console.WriteLine("Index of 8 = {0}", index);

            //int[] numbers2 = new int[10];
            //Array.Copy(numbers, numbers2, numbers.Length);

            ////foreach (int value in numbers2)
            ////{
            ////    Console.WriteLine(value);
            ////}
            ////Console.WriteLine("========================================>");

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


            //#region
            //var list = new List<int>();
            //list.Add(11);
            //list.Add(14);
            //list.Add(56);
            //list.Add(1);
            //list.Add(56);
            //list.Sort();
            //list.Insert(2, 100500);
            //list.RemoveAt(0);
            ////list.Clear();
            //list.Remove(56);

            //foreach (var value in list)
            //{
            //    Console.WriteLine(value);
            //}
            //Console.WriteLine("========================================>");
            ////Console.WriteLine(list[2]);
            //Console.WriteLine(list.Sum());
            ////Console.WriteLine(list.Average());
            //#endregion

            //#region
            //var list = new List<Person>();
            //list.Add(new Person { name = "Bill", surname = "Gates", age = 57 });
            //list.Add(new Person { name = "Stive", surname = "Balmor", age = 59 });
            //list.Add(new Person { name = "Ronald", surname = "MacDonald", age = 61 });

            //foreach(var item in list)
            //{
            //    Console.WriteLine("Name: {0}\nSurname: {1}\nAge: {2}", item.name, item.surname, item.age);
            //    Console.WriteLine("==============================================>>>>");
            //}
            //#endregion
        }
    }
    class Person
    {
        public string name { get; set; }
        public string surname { get; set; }
        public byte age { get; set; }
    }
}
