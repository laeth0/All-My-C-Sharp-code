using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session3OOP.Override.OverrideWithExample2
{
    internal class Vehicle
    {
        public virtual void StartEngine()
        {
            Console.WriteLine("Generic Vehicle engine Started.");
        }

         public virtual void DisplayInfo()
        {
            Console.WriteLine("This is a Generic Vehicle.");
        }
    }
}
