using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.XML
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Marks { get; set; }

        public static Student[] GetAllStudents()
        {
            Student[] students = new Student[4];
            students[0] = new Student
            {
                Id = 1,
                Name = "Bill",
                Gender = "Male",
                Marks = 12
            };
            students[1] = new Student
            {
                Id = 2,
                Name = "Stefani",
                Gender = "Female",
                Marks = 11
            };
            students[2] = new Student
            {
                Id = 3,
                Name = "Stiven",
                Gender = "Male",
                Marks = 9
            };
            students[3] = new Student
            {
                Id = 4,
                Name = "Eva",
                Gender = "Female",
                Marks = 10
            }; 

            return students;
        }
    }
}
