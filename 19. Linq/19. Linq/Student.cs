using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.Linq
{
    class Student
    {
        public int ID { get; set; }  
        public string Name { get; set; }  
        public string Gender { get; set; }  
        public int Marks { get; set; }

        public static List<Student> GetStudents()
        {
            List<Student> studentList = new List<Student>();
            Student student1 = new Student()
            {
                ID = 1,
                Name = "Bill",
                Gender = "Male",
                Marks = 9
            };
            Student student2 = new Student()
            {
                ID = 2,
                Name = "Sarra",
                Gender = "Female",
                Marks = 10
            };
            Student student3 = new Student()
            {
                ID = 3,
                Name = "Sidney",
                Gender = "Female",
                Marks = 8
            };
            studentList.Add(student1);
            studentList.Add(student2);
            studentList.Add(student3);
            return studentList;
        }

    }
}
