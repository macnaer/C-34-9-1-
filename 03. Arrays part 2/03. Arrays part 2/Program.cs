using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Arrays_part_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //#region
            ////1
            //int[,] array = new int[3, 3];

            //array[0, 0] = 1;
            //array[0, 1] = 2;
            //array[0, 2] = 3;

            //array[1, 0] = 4;
            //array[1, 1] = 5;
            //array[1, 2] = 6;

            //array[2, 0] = 7;
            //array[2, 1] = 8;
            //array[2, 2] = 9;

            //Console.Write(array[0, 0]);
            //Console.Write(array[0, 1]);
            //Console.Write(array[0, 2]);
            //Console.Write("\n");
            //Console.Write(array[1, 0]);
            //Console.Write(array[1, 1]);
            //Console.Write(array[1, 2]);
            //Console.Write("\n");
            //Console.Write(array[2, 0]);
            //Console.Write(array[2, 1]);
            //Console.Write(array[2, 2]);

            ////2            
            //int[,] array2 = new int[3, 3];


            //for (int i = 0; i < array2.GetUpperBound(0) + 1; i++)
            //{
            //    for (int j = 0; j < array2.GetUpperBound(1) + 1; j++)
            //    {
            //        array2[i, j] = i * j + 1;
            //    }
            //}

            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write("{0} ", array2[i, j]);
            //        //Console.Write($"{array2[i, j]}"); // інтерполяція
            //    }
            //    Console.Write("\n");
            //    //Console.WriteLine();
            //}

            ////3
            //int[,] array3 =
            //               {
            //                 { 1, 2, 3 },
            //                 { 4, 5, 6 },
            //                 { 7, 8, 9 }
            //               };

            //Console.WriteLine(array3.Length);

            //Console.WriteLine(array3);
            //Console.WriteLine();

            //int a = 3, b = 3; // c = 3;
            //for (int i = 0; i < a; i++)
            //{
            //    for (int j = 0; j < b; j++)
            //    {
            //        Console.Write($"{array3[i, j]}");

            //    }
            //    Console.Write("\n");
            //}

            //Console.WriteLine("===================================================>>>");
            //#endregion
            //#region
            ////1
            //int[,,] array = new int[3, 3, 3];

            //array[0, 0, 0] = 1;
            //array[0, 0, 1] = 2;
            //array[0, 0, 2] = 3;
            //array[0, 1, 0] = 4;
            //array[0, 1, 1] = 5;
            //array[0, 1, 2] = 6;
            //array[0, 2, 0] = 7;
            //array[0, 2, 1] = 8;
            //array[0, 2, 2] = 9;

            //array[1, 0, 0] = 1;
            //array[1, 0, 1] = 2;
            //array[1, 0, 2] = 3;
            //array[1, 1, 0] = 4;
            //array[1, 1, 1] = 5;
            //array[1, 1, 2] = 6;
            //array[1, 2, 0] = 7;
            //array[1, 2, 1] = 8;
            //array[1, 2, 2] = 9;

            //array[2, 0, 0] = 1;
            //array[2, 0, 1] = 2;
            //array[2, 0, 2] = 3;
            //array[2, 1, 0] = 4;
            //array[2, 1, 1] = 5;
            //array[2, 1, 2] = 6;
            //array[2, 2, 0] = 7;
            //array[2, 2, 1] = 8;
            //array[2, 2, 2] = 9;


            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        for (int k = 0; k < 3; k++)
            //        {
            //            Console.Write("{0} ", array[i, j, k]);
            //        }
            //        Console.Write("\n");
            //    }
            //    Console.Write("\n");
            //}


            ////2
            //int[,,] array2 =
            //{
            //    {
            //        { 1, 2, 3 },
            //        { 4, 5, 6 },
            //        { 7, 8, 9 }
            //    },
            //   { { 1, 2, 3 }, { 4, 5, 6 }, {7, 8, 9} },
            //   { { 1, 2, 3 }, { 4, 5, 6 }, {7, 8, 9} }
            //};


            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        for (int k = 0; k < 3; k++)
            //        {
            //            Console.Write("{0} ", array2[i, j, k]);
            //        }
            //        Console.Write("\n");
            //    }
            //    Console.Write("\n");
            //}
            //#endregion
            //#region
            //int[,,,] array2 =
            //{
            //  {
            //    { { 0x0, 0x1 }, {0x2, 0x3 } },
            //    { { 0x4, 0x5 }, {0x6, 0x7 } }
            //  },
            //  {
            //    { { 0x8, 0x9 }, {0xA, 0xB } },
            //    { { 0xC, 0xD }, {0xE, 0xF } }
            //  }
            //};


            //for (int i = 0; i < 2; i++)
            //{
            //    for (int j = 0; j < 2; j++)
            //    {
            //        for (int k = 0; k < 2; k++)
            //        {
            //            for (int l = 0; l < 2; l++)
            //            {
            //                Console.Write("{0:X} ", array2[i, j, k, l]);
            //            }
            //            Console.Write("\n");
            //        }
            //        Console.Write("\n");
            //    }
            //    Console.Write("\n");
            //}
            //#endregion
            //#region
            //// зубчастий масив
            //int[][] jagged = new int[3][];

            //jagged[0] = new int[] { 1, 2 };
            //jagged[1] = new int[] { 1, 2, 3, 4, 5 };
            //jagged[2] = new int[] { 1, 2, 3 };

            //Console.WriteLine(jagged.Length);


            //for (int i = 0; i < jagged.Length; ++i)
            //{
            //    for (int j = 0; j < jagged[i].Length; ++j)
            //    {
            //        Console.Write($"{{{i};{j}}}={     jagged[i][j]     }");
            //    }
            //    Console.Write("\n");
            //}

            //Console.WriteLine();

            //foreach (int[] item in jagged)
            //{
            //    foreach (int i in item)
            //    {
            //        Console.Write(i + " - ");
            //    }
            //}
            //#endregion
            #region
            var person = new Dictionary<int, string>()
            {
                { 1, "Alice"},
                { 2, "Bob"},
                { 3, "Eva"}
            };

            person.Add(4, "Bill");
            foreach (var item in person)
            {
                Console.WriteLine(item);
                Console.WriteLine($"Name:{item.Value}");
            }
            #endregion
        }
    }
}
