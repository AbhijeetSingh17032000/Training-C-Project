using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using System.Text.Json;

namespace CSharpApplication
{
        public class Person
        {
            public string Name { get; set; } // Data Type
            public int Age { get; set; } // Data Type
            public string City { get; set; } // Data Type
        }

        internal class SerializationDemo1
        {
            public void JsonSerialize()
            {
                var person = new Person
                {
                    Name = Console.ReadLine(),
                    Age = Convert.ToInt32 (Console.ReadLine()),
                    City = Console.ReadLine()
                };
                // How to serialize from object to Json
                string jsonString = JsonSerializer.Serialize(person);
                Console.WriteLine();
                Console.WriteLine(jsonString);
                Console.WriteLine();
                // How to Deserialize from Json to object
                var obj = JsonSerializer.Deserialize<Person>(jsonString);
                Console.Write("Name:");
                Console.WriteLine(obj.Name);
                Console.Write("Age:");
                Console.WriteLine(obj.Age);
                Console.Write("City:");
                Console.WriteLine(obj.City);
            }
        public void XmlSerialize()
        {
            var person = new Person
            {
                Name = Console.ReadLine(),
                Age = Convert.ToInt32(Console.ReadLine()),
                City = Console.ReadLine()
            };

            XmlSerializer xs = new XmlSerializer(typeof(Person));
            TextWriter txtWriter = new StreamWriter(@"C:\Users\abhijeetsingh9\Downloads\DotNet Project\Testprojects\CSharpApplication\Serialization1.xml");
            xs.Serialize(txtWriter, person);
            txtWriter.Close();
        }
        public void XmlDeSerialize()
        {
            Person person = new Person();

            XmlSerializer xs = new XmlSerializer(typeof(Person));
            StreamReader reader = new StreamReader(@"C:\Users\abhijeetsingh9\Downloads\DotNet Project\Testprojects\CSharpApplication\Serialization1.xml");
            person = (Person)xs.Deserialize(reader);
            Console.WriteLine("Person Details");
            Console.WriteLine();
            Console.WriteLine("Name:" + person.Name);
            Console.WriteLine("Age:" + person.Age);
            Console.WriteLine("City:" + person.City);

        }
    }
}

