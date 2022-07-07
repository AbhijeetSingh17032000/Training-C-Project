using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpApplication
{
    public class Event
    {
        public int EventId;
        public void CreateEvent()
        {
            Console.WriteLine("Event Created!");
        }
        public void SelectEvents()
        {
            Console.WriteLine("Events Selected!");
        }
    }
}
