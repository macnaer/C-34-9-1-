using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Exeptions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter number: ");
            //string result = Console.ReadLine();

            //int number = 0;

            //try
            //{
            //    number = int.Parse(result);
            //    Console.WriteLine("Parse result = {0}", number);
            //}
            //catch (FormatException ex)
            //{
            //    Console.WriteLine("Format exeptions: fix it please");
            //    //Console.WriteLine(ex.ToString());
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Exp => {0}", ex);
            //}

            //FileStream file = null;
            //try
            //{
            //    file = File.Open("test.txt", FileMode.Open);
            //}
            //catch (IOException ex)
            //{
            //    Console.WriteLine(ex);
            //}
            //finally{
            //    if (file != null)
            //    {
            //        file.Dispose();
            //    }
            //}


            int age = 0;
            
            if (age == 0)
            {
                throw new ArgumentNullException("Age can't be null ");
            }
            if (age < 0)
            {
                throw new ArgumentException("Age can't be less then 0");
            }


        }
    }
}
