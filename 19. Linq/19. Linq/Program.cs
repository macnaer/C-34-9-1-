using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 3, 4, 5, 7, 8, 9, 2 };
            int min = arr.Min();
            //Console.WriteLine(min);
            int minE = arr.Where(n => n % 2 == 0).Min();
            //Console.WriteLine(minE);
            int maxE = arr.Where(n => n % 2 == 0).Max();
            //Console.WriteLine(maxE);
            int sum = arr.Where(n => n % 2 == 0).Sum();
            //Console.WriteLine(sum);
            int count = arr.Where(n => n % 2 == 0).Count();
            //Console.WriteLine(count);
            double avg = arr.Where(n => n % 2 == 0).Average();
            //Console.WriteLine(avg);

            //string[] names = { "Bill", "Abraham", "Jason", "Jenkins", "Abrahim", "Zalugnuy" };
            //var smaX = names.Max();
            //Console.WriteLine("Max => {0}",smaX);

            //string order = names.OrderByDescending(names);

            //var smiN = names.Min();
            //Console.WriteLine("Min => {0}", smiN);

            //foreach (string item in names)
            //{
            //    Console.WriteLine(item);
            //}

            string[] cars = { "Alfa Romeo", "Aston Martin", "Audi", "Nissan", "Chevrolet",  "Chrysler", "Dodge", "BMW",
                            "Ferrari",  "Bentley", "Ford", "Lexus", "Mercedes", "Toyota", "Volvo", "Subaru", "Жигули :)"};
            //IEnumerable<string> auto = cars.OrderBy(s => s.Length);
            //IEnumerable<string> auto = cars.OrderByDescending(c => c);
            //IEnumerable<string> auto = cars.OrderBy(c => c);

            //foreach (string str in auto)
            //{
            //    Console.WriteLine(str);
            //}

            Student student4 = new Student
            {
                ID = 4,
                Name = "Stive",
                Gender = "Male",
                Marks = 10
            };
          
            IEnumerable<Student> students = from student in Student.GetStudents()
                                            where student.Marks >= 9 || student.Name == "Sidney"
                                            select student;

 
            foreach (var item in students)
            {
                Console.WriteLine($"ID = {item.ID}\nName = {item.Name}\nGender = {item.Gender}\nMarks = {item.Marks}");
            }

        }
    }
}
