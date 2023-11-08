using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session3OOP.Override.OverrideWithExample2
{
    internal class BMW:Car
    {
        public new void StartEngine()
        {
            Console.WriteLine("BMW Engine is Started");
        }
        public override void DisplayInfo()
        {
            Console.WriteLine("THIS is BMW Car ");
        }
    }
}
