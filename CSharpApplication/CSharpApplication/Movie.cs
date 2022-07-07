using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CSharpApplication
{
    internal class Movie
    {
        public void CreateMovie()
        {
            // Step 1 How to create file?
            FileStream fileStreamObj = new FileStream("C:\\Users\\abhijeetsingh9\\Downloads\\DotNet Project\\Training\\movie.txt",FileMode.Create,FileAccess.Write);
            // Step 2 Hpw tp write file?
            StreamWriter streamWriter = new StreamWriter(fileStreamObj);
            int a;
            Console.Write("Enter value Movie Id: ");
            a = Convert.ToInt32(Console.ReadLine());
            String b;
            Console.Write("Enter value Movie Name: ");
            b = Console.ReadLine();
            String c;
            Console.Write("Enter value Movie Description: ");
            c = Console.ReadLine();
            String d;
            Console.Write("Enter value Movie language: ");
            d = Console.ReadLine();
            streamWriter.WriteLine("MovieId:"+a);
            streamWriter.WriteLine("MovieName:"+b);
            streamWriter.WriteLine("MovieDesc:"+c);
            streamWriter.WriteLine("Movielanguage:"+d);
            streamWriter.Close();   // Close Writing Operation
            fileStreamObj.Close();  // Close File Opearation
            Console.WriteLine("File Operation Completed.");
        }
        public void SelectMovies()
        {
            FileStream fileStream = new FileStream("C:\\Users\\abhijeetsingh9\\Downloads\\DotNet Project\\Training\\movie.txt", FileMode.Open, FileAccess.Read);
            StreamReader streamReaderObj = new StreamReader(fileStream);
            // Console.WriteLine(streamReaderObj.ReadLine());
            // Console.WriteLine(streamReaderObj.ReadLine());
            // Console.WriteLine(streamReaderObj.ReadLine());
            // Console.WriteLine(streamReaderObj.ReadLine());

            // Console.WriteLine(streamReaderObj.ReadToEnd()); Can also be used but prefer peek for reading specific lines.

            // Declaration of Array
            // string [] myvalues = new string[5]; (Fixed Array - specifying how many values to store)
            // myvalue[0] = "A";
            // myvalue[1] = "b";
            // myvalue[2] = "c";
            // myvalue[3] = "d";
            // myvalue[4] = "e";

            while (streamReaderObj.Peek()>0)
            {
               string line = streamReaderObj.ReadLine();

                string[] myStrs = line.Split(':');         // Dynamic Array - No need to specify how many values to store.
                Console.WriteLine(myStrs[1]);
            }
            fileStream.Close();
            Console.WriteLine("File Operation Completed.");
        }
    }
}
// File Handling
