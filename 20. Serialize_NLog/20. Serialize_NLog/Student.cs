using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20.Serialize_NLog
{
    [Serializable]
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Marks { get; set; }

        public Student(int id, string name, string gender, int marks)
        {
            this.Id = id;
            this.Name = name;
            this.Gender = gender;
            this.Marks = marks;
        }

    }
}
