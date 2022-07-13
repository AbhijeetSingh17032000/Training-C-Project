[1., 2., 3.] - (Same questions solved in Linq HandsOn 1st(12th July 2022))

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

1. Most frequent character
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

            Console.WriteLine("Enter the word ");
            string inp = Console.ReadLine();

            var result = (from a in inp
                          group a by a into a
                          orderby a.Count() descending
                          select a).Take(1);

            foreach (var n in result)
            {
                Console.WriteLine("Most frequent character in string is : " + n.Key);
            }

            Console.Read();
        }
    }
}

2. Find out Unique values
//Main Function
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

            Console.Write("How many string's you want to enter? ");
            Console.WriteLine();
            int a = Convert.ToInt32(Console.ReadLine());

            String[] b = new String[a];

            for (int i = 0; i < a; i++)
            {
                Console.WriteLine("Enter " + (i + 1) + " record :");
                b[i] = Console.ReadLine();
            }
            Console.WriteLine();

            var result = (from studentData in b                         
                          select studentData).Distinct().ToList();
            var result1 = (from studentData in b
                          select studentData).ToList();

            Console.WriteLine("Unique (non-duplicate) strings :");
            foreach (var c in result)
            {
                var QSCount = (from emp in result1
                               where emp == c
                               select emp).Count();
                if(QSCount == 1)
                Console.WriteLine(c);
            }

            Console.Read();
        }
    }
}

3. Top 5 numbers
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

            Console.Write("How many records you want to enter? ");
            Console.WriteLine();
            int a = Convert.ToInt32(Console.ReadLine());

            int[] b = new int[a];

            for (int i = 0; i < a; i++)
            {
                Console.WriteLine("Enter " + (i + 1) + " record :");
                b[i] = Convert.ToInt32(Console.ReadLine());
            }

            var result = (from studentData in b

                          orderby studentData descending
                          select studentData
                          ).Take(5);
            Console.WriteLine("The top 5"+" numbers from the list are :");
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            Console.Read();
        }
    }
}

[4., 5.] - (Same questions solved in Linq HandsOn 1st(12th July 2022))
    
6. Output how many numbers are in this list?
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

            List<int> numbers = new List<int>()
            {
                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };

            var result = (from TableName in numbers select TableName).Count();
            Console.WriteLine(result+ " numbers are in the given list.");
            
            Console.Read();
        }
    }
}

7. How much money have we made?
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

            List<double> purchases = new List<double>()
            {
                2340.29, 745.31, 21.76, 34.03, 4786.45, 879.45, 9442.85, 2454.63, 45.65
            };
            var result = (from TableName in  purchases
                         select TableName).Sum();
            Console.WriteLine(result);

            Console.Read();
        }
    }
}

8. What is our most expensive product?
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

            List<double> prices = new List<double>()
            {
                879.45, 9442.85, 2454.63, 45.65, 2340.29, 34.03, 4786.45, 745.31, 21.76
            };

            var result = (from TableName in prices 
                          orderby TableName descending
                          select TableName).Take(1).ToList();

            foreach (var item in result)
            {
                Console.WriteLine("Most Expensive Product: " + item);
            }

            Console.Read();
        }
    }
}
