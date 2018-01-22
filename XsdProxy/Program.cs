using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.IO;
using System.Xml.Serialization;

namespace XmlDeSerializer
{
    class Program
    {
        static void Main(string[] args)
        {
            using (FileStream xmlStream = new FileStream(@"Students.xml", FileMode.Open))
            {
                using (XmlReader xmlReader = XmlReader.Create(xmlStream))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(Students));
                    Students deserializedStudents = serializer.Deserialize(xmlReader) as Students;
                    foreach (var student in deserializedStudents.Student)
                    {
                        Console.WriteLine("Roll No : {0}", student.RollNo);
                        Console.WriteLine("Name : {0}", student.Name);
                        Console.WriteLine("Address : {0}", student.Address);
                        Console.WriteLine("");
                    }
                }
            }
            Console.ReadLine();
            Students st = new Students();
            
        }
    }
}
