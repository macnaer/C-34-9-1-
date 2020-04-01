using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Schema;

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

            //StringBuilder sb = new StringBuilder();
            //string delimiter = ",";

            //XDocument.Load(path).Descendants("Student")
            //    .ToList().ForEach(x => sb.Append(
            //        x.Attribute("Id").Value + delimiter + "\t" + 
            //        x.Element("Name").Value + delimiter +
            //        x.Element("Gender").Value + delimiter +
            //        x.Element("Marks").Value + "\n"
            //        ));
            //StreamWriter sw = new StreamWriter(@"D:\Folder\Result.csv");
            //sw.WriteLine(sb.ToString());
            //sw.Close();

            //XDocument xmlDocument =  XDocument.Load(path);

            //XDocument result = new XDocument(new XElement("table", new XAttribute("border", 2),
            //    new XElement("thead",
            //        new XElement("tr",
            //            new XElement("th", "Id"),
            //            new XElement("th", "Name"),
            //            new XElement("th", "Gender"),
            //            new XElement("th", "Marks"))),
            //    new XElement("tbody",
            //        from student in xmlDocument.Descendants("Student")
            //        select new XElement("tr",
            //            new XElement("td", student.Attribute("Id").Value),
            //            new XElement("td", student.Element("Name").Value),
            //            new XElement("td", student.Element("Gender").Value),
            //            new XElement("td", student.Element("Marks").Value)))
            //    ));
            //result.Save(@"D:\Folder\index.html");

            XmlSchemaSet schema = new XmlSchemaSet();
            string schemaPath = @"C:\Users\macnaer\Desktop\C#\18. XML\18. XML\Student.xsd";
            schema.Add("", schemaPath);
            XDocument xmlDocument = XDocument.Load(path);

            bool valid = false;

            xmlDocument.Validate(schema, (s, e) =>
            {
                Console.WriteLine(e.Message);
                valid = true;
            });

            if (!valid)
            {
                Console.WriteLine("Validation success!");
            }
            else
            {
                Console.WriteLine("Validation failed!");
            }

            // Lambda
            //Func<int, int> square = x => x * x;
            //Console.WriteLine(square(5));
            //System.Linq.Expressions.Expression<Func<int, int>> e = x => x * x;
            //Console.WriteLine(e);

            //int[] numbers = { 2, 3, 4, 5 };
            //var squaredNumbers = numbers.Select(x => x * x);
            //Console.WriteLine(string.Join(" ", squaredNumbers));

            // Specify the data source.
            //int[] scores = new int[] { 97, 92, 81, 60 };

            //// Define the query expression.
            //IEnumerable<int> scoreQuery =
            //    from score in scores
            //    where score > 80
            //    select score;

            //// Execute the query.
            //foreach (int i in scoreQuery)
            //{
            //    Console.WriteLine(i + " ");
            //}
        } 
    }
}
