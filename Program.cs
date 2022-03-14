using System;
using System.IO;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Delegates
{
    [Serializable]
    public class Student
    {
        public int Rollno
        {
            get;
            set;
        }
        public string Name
        {
            get;
            set;
        }
        public string Location
        {
            get;
            set;
        }
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> list = new List<Student>();
            list.Add(new Student()
            {
                Rollno = 101,
                Name = "Xlib",
                Location = "Katangi"
            });
            string result = JsonConvert.SerializeObject(list);
            Console.WriteLine(result);



            //FileStream fs = new FileStream("P:\\PersistentSystems\\Demo\\Serilization.txt", FileMode.OpenOrCreate);
            //BinaryFormatter bn = new BinaryFormatter();
            //XmlSerializer xmlSerializer = new XmlSerializer(typeof(Student));
            //TextWriter textWriter = new StreamWriter("P:\\PersistentSystems\\Demo\\XmlSerilizer.txt");
            //TextReader textReader = new StreamReader("P:\\PersistentSystems\\Demo\\XmlSerilizer.txt");
            //Student student = (Student)xmlSerializer.Deserialize(textReader);
            //Console.WriteLine(student.name);
            //Console.WriteLine(student.rollNo);

            //xmlSerializer.Serialize(textWriter, student);
            //textWriter.Close();

            //Student student = (Student)bn.Deserialize(fs);
            //Console.WriteLine("Roll No.: " + student.rollNo);
            //Console.WriteLine("Name:" + student.name);
            //Student s = new Student(101, "Xlib");
            //bn.Serialize(fs, s);
            //fs.Close();
            Console.Read();

        }
    }
}





















//class Program
//{


//public static void Main(string[] args)
//{
//    DirectoryInfo dir = new DirectoryInfo("P:\\PersistentSystems\\Demo\\Directory");
//    try
//    {
//        if (dir.Exists)
//        {
//            Console.WriteLine("Bani to hai");
//        }
//        dir.Create();
//        Console.WriteLine("Bana liye");
//        dir.Delete();
//        Console.WriteLine("Mita diya xD");
//    }

//    catch(Exception ex)
//    {
//        Console.WriteLine("Nahi mili yaar" + ex.ToString());
//    }

//    Console.Read();
//}

//public static void Main(string[] args)
//{
//WriteText();
//ReadText();
//string text = "Hello kon bol raha hai" + "Hum bol rahe hai" + "Hum Kon" + " phone pakdhao unko";
//StringBuilder sb = new();
//StringWriter sw = new(sb);
//sw.WriteLine(text);
//sw.Close();

//StringReader sr = new(sb.ToString());
//while(sr.Peek () > -1)
//{
//    Console.WriteLine(sr.ReadLine());
//}

//Console.Read();
//}

//public static void WriteText()
//{
//    using (BinaryWriter bw = new BinaryWriter(File.Open("P:\\PersistentSystems\\Demo\\BinaryWriter.txt", FileMode.CreateNew)))
//    {
//        bw.Write(12.5);
//        bw.Write("This is the string");
//        bw.Write(true);
//    }
//    Console.WriteLine("Can't write more xD");
//}

//public static void ReadText()
//{
//    Console.WriteLine();
//    Console.WriteLine("Now Let's Read what was written");
//    using (BinaryReader br = new BinaryReader(File.Open("P:\\PersistentSystems\\Demo\\BinaryWriter.txt", FileMode.Open)))
//    {
//        Console.WriteLine(br.ReadDouble());
//        Console.WriteLine(br.ReadString());
//        Console.WriteLine(br.ReadBoolean());
//    }
//    Console.WriteLine("That's All I can Read");
//}

//}










//using System;
//using System.IO;

//namespace Program
//{
//    public class Test
//    {
//        public static void Main(string[] args)
//        {
//            string path = "P:\\PersistentSystems\\Demo\\file1.txt";
//            FileStream fs = new FileStream(path, FileMode.OpenOrCreate);
//            {
//                //int i;
//                for (int i = 65; i < 91; i++)
//                {
//                    fs.WriteByte((byte)i);
//                }
//                Console.WriteLine("File is created Succefully");
//                fs.Seek(0, SeekOrigin.Begin);
//                int j = 0;
//                while ((j = fs.ReadByte()) != -1)
//                {
//                    Console.Write((char)j);
//                }
//                fs.Close();
//            }
//            Console.Read();
//        }
//    }
//}









////string path = "P:\\PersistentSystems\\Demo\\file1.txt";
////FileStream fs = new FileStream(path, FileMode.OpenOrCreate);
////{
////    for (int i = 65; i < 91; i++)
////    {
////        fs.WriteByte((byte)i);
////    }
////    //fs.Close();
////    Console.WriteLine("File is created Succefully");
////    //Console.Read();
////    int j;
////    while ((j = fs.ReadByte()) != -1)
////    {
////        Console.Write((char)j);
////    }
////    fs.Close();
////}
////Console.Read();