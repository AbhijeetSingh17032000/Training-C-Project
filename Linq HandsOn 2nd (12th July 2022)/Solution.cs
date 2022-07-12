[1., 2., 3.] - (Same questions solved in Linq HandsOn 2nd(12th July 2022))

4.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_HandsOn
{
    public class Person
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int Age { get; set; }
        public Person(string Firstname, string Lastname, int Age)
        {
            this.Firstname = Firstname;
            this.Lastname = Lastname;
            this.Age = Age;
        }
        public static void HandsOn2_4()
        {
            var people = new List<Person>()
        {
            new Person("Bill",  "Smith", 41),
            new Person("Sarah", "Jones", 22),
            new Person("Stacy","Baker", 21),
            new Person("Vivianne","Dexter", 19 ),
            new Person("Bob","Smith", 49 ),
            new Person("Brett","Baker", 51 ),
            new Person("Mark","Parker", 19),
            new Person("Alice","Thompson", 18),
            new Person("Evelyn","Thompson", 58 ),
            new Person("Mort","Martin", 58),
            new Person("Eugene","DeLauter", 84 ),
            new Person("Gail","Dawson", 19 ),
            };

            var result = from TableName in people
                         select TableName;

            Console.WriteLine("Full Names: ");
            foreach (var item in result)
            {
                Console.WriteLine(String.Concat(item.Firstname) +" "+ String.Concat(item.Lastname));
            }
        }
    }
}

// Main Function
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_HandsOn
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Person.HandsOn2_4();

            Console.Read();
        }
    }
}

5.

