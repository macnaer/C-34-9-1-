using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _18.XML
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\Folder\Data.xml";

            // Create XML file from class Student
            //XDocument xmlDocument = new XDocument(
            //    new XDeclaration("1.0", "utf-8", "yes"),
            //    new XComment("This is a test comment"),
            //    new XElement("Students", from student in Student.GetAllStudents()
            //                             select new XElement("Student", new XAttribute("Id", student.Id),
            //                             new XElement("Name", student.Name),
            //                             new XElement("Gender", student.Gender),
            //                             new XElement("Marks", student.Marks))

            //    ));
            //xmlDocument.Save(path);

            // Retrive data from XML

            //IEnumerable<string> names = from student in XDocument.Load(path).Element("Students").Elements("Student")
            //                            where (int)student.Element("Marks") > 9
            //                            orderby (int)student.Element("Marks") ascending
            //                            select student.Element("Name").Value;
            //foreach (string name in names)
            //{
            //    Console.WriteLine(name);
            //}

            //XDocument xmlDocument = XDocument.Load(path);

            //xmlDocument.Element("Students").Add(
            //    new XElement("Student", new XAttribute("Id", 5),
            //    new XElement("Name", "Adam"),
            //    new XElement("Gender", "Male"),
            //    new XElement("Marks", "10")
            //    ));
            //xmlDocument.Save(path);

            //XDocument xmlDocument = XDocument.Load(path);
            //xmlDocument.Element("Students").Elements("Student")
            //    .Where(x => x.Attribute("Id").Value == "3").FirstOrDefault()
            //    .SetElementValue("Marks", 10);
            //xmlDocument.Save(path);

            // C.R.U.D.

            //XDocument xmlDocument = XDocument.Load(path);
            //xmlDocument.Root.Elements().Where(x => x.Attribute("Id").Value == "2").Remove();
            //xmlDocument.Save(path);

            StringBuilder sb = new StringBuilder();
            string delimiter = ",";

            XDocument.Load(path).Descendants("Student")
                .ToList().ForEach(x => sb.Append(
                    x.Attribute("Id").Value + delimiter + "\t" + 
                    x.Element("Name").Value + delimiter +
                    x.Element("Gender").Value + delimiter +
                    x.Element("Marks").Value + "\n"
                    ));
            StreamWriter sw = new StreamWriter(@"D:\Folder\Result.csv");
            sw.WriteLine(sb.ToString());
            sw.Close();
        } 
    }
}
