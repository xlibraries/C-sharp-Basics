﻿#define Debug

using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Collections;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;

namespace Delegates
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Type type = typeof(string);
            Console.WriteLine("Name: " + type.Name);
            Console.WriteLine("Full Name: " + type.FullName);
            Console.WriteLine("Namespace: " + type.Namespace);
            Console.WriteLine("Base Type: " + type.BaseType);
            Console.WriteLine("Check: " + type.GUID);
            Console.WriteLine("Serilizable: " + type.IsSerializable);
            Console.Read();
        }
    }
}





//public static async Task CallMethod()
//{
//    Task<int> ob = Method1();
//    Method2();
//    int count = await ob;
//    Method3(count);
//}
//public static async Task<int> Method1()
//{
//    int count = 1;
//    await Task.Run(() =>
//    {
//        for (int i = 0; i < 4; i++)
//        {
//            Console.WriteLine("Method1");
//            Task.Delay(100).Wait();
//            count++;
//        }
//    });
//    return count;
//}

//public static void Method2()
//{
//    for (int i = 0; i < 4; i++)
//    {
//        Console.WriteLine("Method2");
//        Task.Delay(100).Wait();
//    }
//}
//public static void Method3(int count)
//{
//    Console.WriteLine("Total Count: " + count);

//}
//static void Main(string[] args)
//{
//    _ = CallMethod();
//    Console.Read();
//}



//static void Work1()
//{
//    for (int i = 0; i < 10; i++)
//    {
//        Console.WriteLine("Kaccha Papad Pakka Papad");
//        //Thread.Sleep(200);
//    }
//    Console.WriteLine("Humm bhi  khataam");
//}
////static void Work2()
////{
////    for (int i = 0; i < 10; i++)
////    {
////        Console.WriteLine("Pake padh pe paka patita  pintu padke paka papita");
////        Thread.Sleep(200);
////    }
////}
//static void Main(string[] args)
//{
//    Thread thread1 = new Thread(Work1);
//    //Thread thread2 = new Thread(Work2);
//    thread1.Start();
//    thread1.IsBackground = true;
//    //thread2.Start();
//    //thread1.Join();
//    Console.WriteLine("Khatam");

//    //thread2.Join();
//    Console.Read();
//}





//[Serializable]
//public class Student
//{
//    public int Rollno
//    {
//        get;
//        set;
//    }
//    public string Name
//    {
//        get;
//        set;
//    }
//    public string Location
//    {
//        get;
//        set;
//    }
//}

//internal class Program
//{
//    static void Main(string[] args)
//    {
//        List<Student> list = new List<Student>();
//        list.Add(new Student()
//        {
//            Rollno = 101,
//            Name = "Xlib",
//            Location = "Katangi"
//        });
//        string result = JsonConvert.SerializeObject(list);
//        //string answer = JsonConvert.DeserializeObject();
//        Console.WriteLine(result);
//        List<Student> res2 = JsonConvert.DeserializeObject<List<Student>>(result);
//        foreach(var i in res2)
//        {
//            Console.WriteLine(i.Rollno);
//            Console.WriteLine(i.Name);
//            Console.WriteLine(i.Location);
//        }

//        //FileStream fs = new FileStream("P:\\PersistentSystems\\Demo\\Serilization.txt", FileMode.OpenOrCreate);
//        //BinaryFormatter bn = new BinaryFormatter();
//        //XmlSerializer xmlSerializer = new XmlSerializer(typeof(Student));
//        //TextWriter textWriter = new StreamWriter("P:\\PersistentSystems\\Demo\\XmlSerilizer.txt");
//        //TextReader textReader = new StreamReader("P:\\PersistentSystems\\Demo\\XmlSerilizer.txt");
//        //Student student = (Student)xmlSerializer.Deserialize(textReader);
//        //Console.WriteLine(student.name);
//        //Console.WriteLine(student.rollNo);

//        //xmlSerializer.Serialize(textWriter, student);
//        //textWriter.Close();

//        //Student student = (Student)bn.Deserialize(fs);
//        //Console.WriteLine("Roll No.: " + student.rollNo);
//        //Console.WriteLine("Name:" + student.name);
//        //Student s = new Student(101, "Xlib");
//        //bn.Serialize(fs, s);
//        //fs.Close();
//        Console.Read();

//    }
//}





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