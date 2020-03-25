using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.FS
{
    class Program
    {
        static void Main(string[] args)
        {
            //string path = "D:\\";
            //if (Directory.Exists(path))
            //{
            //    Console.WriteLine("Folders:");
            //    string[] directory = Directory.GetDirectories(path);
            //    foreach (var item  in directory)
            //    {
            //        Console.WriteLine(item);
            //    }
            //}
            //string[] files = Directory.GetFiles(path);
            //foreach (var item in files)
            //{
            //    Console.WriteLine(item);
            //}

            //string path = @"D:\Folder\Users";

            //string photo = @"photo";
            //DirectoryInfo dir = new DirectoryInfo(path);
            //if (!dir.Exists)
            //{
            //    dir.Create();
            //    Console.WriteLine("Done!");
            //}
            //dir.CreateSubdirectory(photo);

            //string path = @"D:\Folder\Users";

            //try
            //{
            //    DirectoryInfo dir = new DirectoryInfo(path);
            //    dir.Delete();
            //    Console.WriteLine("Deleted!");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //string path = @"D:\Folder\Users";
            //string newPath = @"D:\Users2";

            //DirectoryInfo dir = new DirectoryInfo(path);
            //if (dir.Exists && Directory.Exists(newPath) == false)
            //{
            //    dir.MoveTo(newPath);
            //    Console.WriteLine("Moved!");
            //}

            //string path = @"D:\Index_Mobile.psd";
            //FileInfo file = new FileInfo(path);
            //if (file.Exists)
            //{
            //    Console.WriteLine("File name: {0}", file.Name);
            //    Console.WriteLine("File size: {0}", file.Length);
            //    Console.WriteLine("File LastWriteTime: {0}", file.LastWriteTime);
            //    Console.WriteLine("File CreationTime: {0}", file.CreationTime);
            //    Console.WriteLine("File LastAccessTime: {0}", file.LastAccessTime);

            //}

            //string path = @"D:\Folder\Index_Mobile.psd";
            //FileInfo file = new FileInfo(path);
            //if (file.Exists)
            //{
            //    file.Delete();
            //    Console.WriteLine($"{file.Name} deleted");
            //}
            //else{
            //    Console.WriteLine($"{file.Name} does not exists.");
            //}

            //string path = @"D:\Folder\Users.txt";
            //string newPath = @"D:\Users2.txt";

            //FileInfo file = new FileInfo(path);
            //if (file.Exists && Directory.Exists(newPath) == false)
            //{
            //    file.MoveTo(newPath);
            //    Console.WriteLine("Moved!");
            //}

            //string path = @"D:\Folder\Users.txt";
            //string newPath = @"D:\Folder\Users2.txt";

            //FileInfo file = new FileInfo(path);
            //if (file.Exists && Directory.Exists(newPath) == false)
            //{
            //    file.CopyTo(newPath);
            //    Console.WriteLine("Done!");
            //}

            //Console.WriteLine("Enter text ...");
            //string message = Console.ReadLine();

            //string path = @"D:\Folder\db.txt";
            //using(FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            //{
            //    Byte[] arr = System.Text.Encoding.Default.GetBytes(message);
            //    fs.Write(arr, 0, arr.Length);
            //    Console.WriteLine("Done!");
            //}
            //using(FileStream fs = File.OpenRead(path))
            //{
            //    Byte[] arr = new Byte[fs.Length];
            //    fs.Read(arr, 0, arr.Length);
            //    string myText = System.Text.Encoding.Default.GetString(arr);
            //    Console.WriteLine("My Text {0}", myText);
            //}

            //string path = @"D:\Folder\db.txt";

            //Console.WriteLine("Enter text ...");
            //object message = Console.ReadLine();
            //try
            //{
            //    using (StreamWriter sw = new StreamWriter(path, true, System.Text.Encoding.Default))
            //    {
            //        sw.WriteLine(message);
            //        Console.WriteLine("Done!");
            //    }
            //}
            //catch(Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
        }
    }
}
