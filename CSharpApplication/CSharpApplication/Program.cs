using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* 
            int a, b, c;
            Console.Write("Enter value A: ");
            a = Convert.ToInt32 (Console.ReadLine());
            Console.Write("Enter value B: ");
            b = Convert.ToInt32 (Console.ReadLine());
            c = a + b;
            Console.WriteLine("The Sum is: "+c);           // How to print/display output?
            Console.Read();                                // how yo read keyboard input?
            */

            //for (int j = 0; j < 5; j++)
            //{
            //    Console.WriteLine(j);
            //}

            // eventObj is instance, given by the user. (new) keyword hlps for memory allocation.
            //Event eventObj = new Event();                  // how to create object?
            //eventObj.CreateEvent();                        // Object.MethodName
            //eventObj.SelectEvents();                       // Object.MethodName
            //Console.Read();

            //Movie movieObj = new Movie();
            //movieObj.SelectMovies();

            //SerializationDemo demo = new SerializationDemo();
            //demo.JsonSerialize();

            SerializationDemo1 serializationDemo1 = new SerializationDemo1();
            serializationDemo1.JsonSerialize();

            //SerializationDemo1 serializationDemo1 = new SerializationDemo1();
            //serializationDemo1.XmlSerialize();
            //serializationDemo1.XmlDeSerialize();




            // genericsDemo.ShowReport<int>(10);

            //genericsDemo.ShowSalaryReport(400.20);
            //genericsDemo.ShowGenderReport("Other");
            //genericsDemo.ShowAgeReport(22);

            Console.Read();
        }
    }
}
