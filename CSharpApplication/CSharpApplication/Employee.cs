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
    public class WeatherForecast
    {
        public DateTimeOffset Date { get; set; } // Data Type
        public int TemperatureCelsius { get; set; } // Data Type
        public string Summary { get; set; } // Data Type
    }
    public class Employee
    {
        public int Id = 1;
        public string name = "John Smith";
        public string subject = "Physics";
    }
    internal class SerializationDemo
    {
        public void JsonSerialize()
        {
            var weatherForecast = new WeatherForecast
            {
                Date = DateTime.Parse("2019-08-01 09:30:00"),
                TemperatureCelsius = 25,
                Summary = "Hot"
            };
            // How to serialize from object to Json
            string jsonString = JsonSerializer.Serialize(weatherForecast);
            // How to Deserialize from Json to object
            var obj = JsonSerializer.Deserialize<WeatherForecast>(jsonString);
            Console.WriteLine(obj.Date);
            Console.WriteLine(obj.TemperatureCelsius);
            Console.WriteLine(obj.Summary);
        }
        public void XmlSerialize()
        {
            Employee bs = new Employee();
            XmlSerializer xs = new XmlSerializer(typeof(Employee));
            TextWriter txtWriter = new StreamWriter(@"C:\Users\abhijeetsingh9\Downloads\DotNet Project\Testprojects\CSharpApplication\Serialization.xml");
            xs.Serialize(txtWriter, bs);
            txtWriter.Close();
        }
        public void XmlDeSerialize()
        {
            Employee bs = new Employee();
            XmlSerializer xs = new XmlSerializer(typeof(Employee));
            StreamReader reader = new StreamReader(@"C:\Users\abhijeetsingh9\Downloads\DotNet Project\Testprojects\CSharpApplication\Serialization.xml");
            bs = (Employee)xs.Deserialize(reader);
            Console.WriteLine("Employee Details");
            Console.WriteLine("Id:" + bs.Id);
            Console.WriteLine("Name:" + bs.name);
            Console.WriteLine("Subject:" + bs.subject);

        }
    }
}
