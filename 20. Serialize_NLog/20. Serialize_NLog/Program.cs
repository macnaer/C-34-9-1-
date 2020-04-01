using NLog;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace _20.Serialize_NLog
{
    class Program
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();

        static void Main(string[] args)
        {
            //logger.Debug("Debug message");
            //logger.Info("Info message");
            //logger.Warn("Huston! We are have a problem!");
            //logger.Error("Error message");
            //logger.Fatal("Fatal message");

            string path = @"D:\Folder\Serial.dat";
            Student s1 = new Student(1, "Jim", "Male", 11);
            Student s2 = new Student(2, "Rich", "Male", 9);

            //try
            //{
            //    FileStream stream = new FileStream(path, FileMode.OpenOrCreate);
            //    BinaryFormatter formatter = new BinaryFormatter();
            //    formatter.Serialize(stream, s1);
            //    stream.Close();
            //    logger.Info($"File {path} : Data {s1}");
            //    Console.ForegroundColor = System.ConsoleColor.DarkGreen;
            //    Console.WriteLine("File saved!");
            //}
            //catch(Exception ex)
            //{
            //    logger.Error(ex.Message);
            //    Console.WriteLine(ex.Message);
            //}

            try
            {
                FileStream stream = new FileStream(path, FileMode.OpenOrCreate);
                BinaryFormatter formatter = new BinaryFormatter();

                Student student1 = (Student)formatter.Deserialize(stream);
                stream.Close();

                logger.Info($"Retrived data from {path}");
            
                Console.ForegroundColor = System.ConsoleColor.Magenta;

                Console.WriteLine($"Id {student1.Id}\nName {student1.Name}\nGender {student1.Gender}\nMarks {student1.Marks}");
            }
            catch (Exception ex)
            {
                logger.Debug(ex.Message);
                Console.WriteLine(ex.Message);
            }



        }
    }
}
