using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session3OOP.Override
{//Override
    internal class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("The Dog Barks");
        }
    }
}
