using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session3OOP.Override.OverrideWithExample2
{
    internal class MotorCycle:Vehicle
    {
        public override void StartEngine()
        {
            Console.WriteLine(" MotorCycle Engine started");
        }

        public override void DisplayInfo()
        {
            Console.WriteLine("This is a MotorCycle");
        }
    }
}
