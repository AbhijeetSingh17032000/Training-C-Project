1.
static void Main(string[] args)
        {
            int[] Values = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };
            var result = from TableName in Values
                         where TableName > 0
                         orderby TableName
                         select TableName;
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            Console.Read();
	}

2.
static void Main(string[] args)
        {
            int[] Values = { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };
            var result1 = Values.Distinct();
            var result = from TableName in Values
                         select TableName;
            var result2 = from TableName in result1
                         select TableName;
            Console.WriteLine("The numbers in the array are :");
            foreach (var item in result)
            {
                Console.Write(item+", ");
            }
            Console.WriteLine();
            Console.WriteLine("The number and the Frequency are:");
            foreach (var item in result2)
            {
                var QSCount = (from emp in Values
                               where emp == item
                           select emp).Count();
                Console.WriteLine("Number "+item+" appears " + QSCount+" times");
            }
            

            Console.Read();
	}

3.
        static void Main(string[] args)
        {
            Console.Write("Input the string: ");
            Console.WriteLine();

            string str = Console.ReadLine(); 
            char[] ch = new char[str.Length];
            for (int i = 0; i < str.Length; i++)
            {
                ch[i] = str[i];
            }
            var result = ch.Distinct();
            foreach (char c in result)
            {
                var QSCount = (from emp in ch
                               where emp == c
                               select emp).Count();
                Console.WriteLine("Character " + c + " appears " + QSCount + " times");
            }

            Console.Read();
        }

4.
 	static void Main(string[] args)
        {
            
            Console.Write("How many city's record you want to enter? ");
            Console.WriteLine();
            int a = Convert.ToInt32(Console.ReadLine());

            String[] b = new String[a];

            for (int i = 0; i < a; i++)
            {
                Console.WriteLine("Enter "+(i+1)+" city record :");
                b[i] = Console.ReadLine();
            }

            Console.Write("Input starting character for the string :");
            Console.WriteLine();
            string disp1 = Console.ReadLine();
            Console.Write("Input ending character for the string :");
            Console.WriteLine();
            string disp2 = Console.ReadLine();

            var result = (from studentData in b
                         where studentData.StartsWith(disp1) && studentData.EndsWith(disp2)
                         select studentData).ToList();

            foreach (var item in result)
            {
                Console.WriteLine("The city starting with " + disp1 + " and ending with " + disp2 + " is : " + item);
            }

            Console.Read();
        }


5.
        static void Main(string[] args)
        {
            
            Console.Write("How many records you want to enter? ");
            Console.WriteLine();
            int a = Convert.ToInt32(Console.ReadLine());

            int[] b = new int[a];

            for (int i = 0; i < a; i++)
            {
                Console.WriteLine("Enter "+(i+1)+" record :");
                b[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("How many records you want to display? ");
            Console.WriteLine();
            int display = Convert.ToInt32(Console.ReadLine());

            var result = (from studentData in b

                          orderby studentData descending
                          select studentData
                          ).Take(display);
            Console.WriteLine("The top "+display+" records from the list are :");
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            Console.Read();
        }

6.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_HandsOn
{
    public class Students
    {
        public int StuId { get; set; }
        public string StuName { get; set; }
        public int GrPoint { get; set; }
        public static void ShowStudentDetails()
        {
            List<Students> stulist = new List<Students>();
            stulist.Add(new Students { StuId = 1, StuName = " Joseph ", GrPoint = 800 });
            stulist.Add(new Students { StuId = 2, StuName = "Alex", GrPoint = 458 });
            stulist.Add(new Students { StuId = 3, StuName = "Harris", GrPoint = 900 });
            stulist.Add(new Students { StuId = 4, StuName = "Taylor", GrPoint = 900 });
            stulist.Add(new Students { StuId = 5, StuName = "Smith", GrPoint = 458 });
            stulist.Add(new Students { StuId = 6, StuName = "Natasa", GrPoint = 700 });
            stulist.Add(new Students { StuId = 7, StuName = "David", GrPoint = 750 });
            stulist.Add(new Students { StuId = 8, StuName = "Harry", GrPoint = 700 });
            stulist.Add(new Students { StuId = 9, StuName = "Nicolash", GrPoint = 597 });
            stulist.Add(new Students { StuId = 10, StuName = "Jenny", GrPoint = 750 });

            Console.WriteLine("Which maximum grade point(1st, 2nd, 3rd, ...) you want to find  :");
            int a = Convert.ToInt32(Console.ReadLine());

            var result = (from TableName in stulist
                         orderby TableName.GrPoint descending 
                         select new Students()
                         {
                            GrPoint = TableName.GrPoint,
                         }).Distinct().ToList();
            
            var b = result[a];
            
            var result2 = from TableName in stulist
                          where TableName.GrPoint == Convert.ToInt32(b.GrPoint)
                         select TableName;


            foreach (var item in result2)
            {
                Console.WriteLine("StuId : "+item.StuId);
                Console.WriteLine("StuName : " + item.StuName);
                Console.WriteLine("StuGrPoint : " + item.GrPoint);
                Console.WriteLine();
            }

        }
    }

    internal class Linq
    {

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

            Students.ShowStudentDetails();

            Console.Read();
        }
    }
}

7.
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
        public static void HandsOn7()
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
                         where TableName.Lastname.StartsWith("D")
                         select TableName;

            foreach (var item in result)
            {
                Console.WriteLine(item.Firstname);
                Console.WriteLine(item.Lastname);
                Console.WriteLine(item.Age);
                Console.WriteLine();
            }
        }

        internal class Linq
            {

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

            Person.HandsOn7();

            Console.Read();
        }
    }
}

8.
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
        public static void HandsOn8()
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

            var result = (from TableName in people
                         where TableName.Lastname.StartsWith("D")
                         select TableName).Count();

            Console.WriteLine(result);
        }

        internal class Linq
            {

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

            Person.HandsOn8();

            Console.Read();
        }
    }
}

9.
