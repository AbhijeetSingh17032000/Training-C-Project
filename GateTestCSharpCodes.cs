// Maximum Vowels

using System;
using System.Collections.Generic;
using System.Linq;

namespace GateTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "";
            s = Console.ReadLine();
            List<string> tokens = new List<string>();
            tokens = s.Split(',').ToList();

            string v = "";
            int k, max;
            k = 0;
            max = 0;

            foreach (string token in tokens)
            {
                for (int i = 0; i < token.Length; i++)
                {
                    if (token.ElementAt(i).Equals('a') || token.ElementAt(i).Equals('e') || token.ElementAt(i).Equals('i') || token.ElementAt(i).Equals('o') || token.ElementAt(i).Equals('u'))
                    {
                        k = k + 1;
                    }

                }
                if (k > max)
                {
                    max = k;
                    v = token;
                }
                k = 0;
            }
            Console.WriteLine(v);
            Console.ReadLine();
        }
    }
}

// Maximum Vowels
using System;
using System.Collections.Generic;
using System.Linq;

namespace GateTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
string s = "";
            s = Console.ReadLine();
            s = s.Replace("[", "").Replace("]", "");
            s = s.ToLower();
            string v = "";
            int k, max;
            k = 0;
            max = 0;
            List<string> tokens = new List<string>();
            tokens = s.Split(',').ToList();
            foreach (string token in tokens)
            {
                for (int i = 0; i < token.Length; i++)
                {
                    if (token.ElementAt(i).Equals('a') || token.ElementAt(i).Equals('e') || token.ElementAt(i).Equals('i') || token.ElementAt(i).Equals('o') || token.ElementAt(i).Equals('u'))
                    {
                        k = k + 1;
                    }
                }
                if (k > max)
                {
                    max = k;
                    v = token;
                }
                else if (k == max)
                {
                    if (token.Length < v.Length)
                    {
                        v = token;
                    }
                }
                k = 0;
            }
            Console.WriteLine(v.Substring(1, v.Length - 2));
            Console.ReadLine();


        }
    }
}

// Prime Number Between 2 numbers
using System;

namespace GateTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] b = Console.ReadLine().Split(',');
            string c = "";
            int flag = 1;
            for (int i = Convert.ToInt32(b[0]) + 1; i < Convert.ToInt32(b[1]); i++)
            {
                for (int k = 2; k <= i / 2; k++)
                {
                    if (i % k == 0)
                    {
                        flag = 0;
                        break;
                    }
                }
                if (flag == 1 && i != 1)
                {
                    c = c + i + ",";

                }
                flag = 1;
            }
            Console.WriteLine(c.Substring(0,c.Length-1));
            Console.ReadLine();
        }
    }
}

// Character is Vowel or Not
using System;

namespace GateTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String b = Console.ReadLine();
            if (b == "a" || b == "e" || b == "i" || b == "o" || b == "u")
                Console.WriteLine("true");
            else
                Console.WriteLine("false");
            Console.ReadLine();
        }
    }
}

// HCF
using System;

namespace GateTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(',');
            int a = Convert.ToInt32(s[0]);
            int b = Convert.ToInt32(s[1]);

            if (a == 0 || b == 0)
            {
                Console.WriteLine(Math.Max(a, b));
            }
            else
            {
                for (int i = Math.Min(a, b); i > 0; i--)
                {
                    if (a % i == 0 && b % i == 0)
                    {
                        Console.WriteLine(i);
                        break;
                    }
                }
                Console.ReadLine();
            }

        }
    }
}

// Int to Binary
using System;

namespace GateTest
{
    internal class Program
    {
        static void Main(string[] args)
        {            
                int a = Convert.ToInt32(Console.ReadLine());
                string b = "";
                int rem;
                while (a > 0)
                {
                    rem = a % 2;
                    a /= 2;
                    b = rem.ToString() + b;
                }
                Console.WriteLine(b);
                Console.ReadLine();
        }        
    }
   
}


