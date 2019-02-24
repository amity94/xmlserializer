using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("amity","nissimov", 1.83, "maginim 6 street", 44, 5);
            Console.WriteLine(p1);

            XmlSerializer myXmlSerializer = new XmlSerializer(typeof(Person));

            using (Stream file = new FileStream(@"C:\temp\xmlfile.xml", FileMode.Create))
            {
                myXmlSerializer.Serialize(file, p1);
            }

            using (Stream file = new FileStream(@"C:\temp\xmlfile.xml", FileMode.Open))
            {
                p1 = myXmlSerializer.Deserialize(file) as Person;
            }

            Console.WriteLine(p1);
        }
    }
}
