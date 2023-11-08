using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session3OOP.Override
{
    internal class Cat:Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("The cat meows");
        }
    }
}
