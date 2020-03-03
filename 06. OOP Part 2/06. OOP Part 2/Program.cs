using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.OOP_Part_2


{
    class Program
    {
        enum Operation
        {
            Add = 1,
            Subtract,
            Multiply,
            Divide
        }
        static void Main(string[] args)
        {
            //Operation op;
            //op = Operation.Divide;
            //Console.WriteLine(op); 
            #region
            // Reference
            //int a = 5;
            //Console.WriteLine($"Variable a starts with  = {a}");
            //Increment(ref a);
            //Console.WriteLine($"variable a after Increment method = {a}");

            ////Console.ReadKey();
            //void Increment(ref int x)
            //{
            //    x++;
            //    Console.WriteLine($"Inside Increment: {x}");
            //}

            #endregion

            #region
            //Console.WriteLine("Enter number: ");
            //string num = Console.ReadLine();

            //bool isParsed = int.TryParse(num, out int number);
            //if (isParsed)
            //{
            //    Console.WriteLine(number);
            //}
            //else
            //{
            //    Console.WriteLine("Faled to parse");
            //}

            //Console.WriteLine("Special for Sergiy: " + number);

            //Out Bill = new Out();
            //Bill.Name = "Bill";
            //Bill.Surname = "Gates";
            //Bill.SetMark(10.3);
            //Bill.GetAll(out double mark, out string name, out string surname);

            //Console.WriteLine("Name: " + name + " - Mark: " + mark);
            //Console.WriteLine(Bill.Name + " - " + Bill.Surname);


            //var student = new Out()
            //{
            //    //Name = "Stive",
            //    Surname = "Balmor"
            //};
            //student.SetMark(7.9);
            //student.GetAll(out double mark, out string name, out string surname);
            //Console.WriteLine("Name: " + name + " - Mark: " + mark);
            //Console.WriteLine(student.Name + " - " + student.Surname);

            #endregion

            #region
            // out
            Console.WriteLine("Enter first number: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            int b = int.Parse(Console.ReadLine());
            Calc.Plus(a, b, out int sum);
            Console.WriteLine($"Sum = {sum}");
            #endregion

        }
    }
}
