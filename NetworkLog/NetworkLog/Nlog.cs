using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace NetworkLog
{
    internal class Nlog
    {
        public void Output()
        {
            FileStream fileStream = new FileStream("C:\\Users\\abhijeetsingh9\\Downloads\\networklog.txt", FileMode.Open, FileAccess.Read);
            StreamReader streamReaderObj = new StreamReader(fileStream);
                int i = 0;
            while (streamReaderObj.Peek() > 0)
            {
                if (i == 7)
                    i = 0;
                    string line = streamReaderObj.ReadLine();
                if (line != "")
                {
                    if (line.StartsWith("Date"))
                    {
                        string[] a = line.Split(' ');
                        string[] b = a[0].Split(':');
                        Console.Write(b[1] + "\t");
                        Console.Write(a[1] + "\t");
                    }
                    else
                    {
                        string[] b = line.Split(':');
                        Console.Write(b[1] + "\t");
                        if (line.StartsWith("Network"))
                        {
                            Console.WriteLine();
                        }
                    }
                }
                    i++;

                
                }
            fileStream.Close();
        }
        }
    }

