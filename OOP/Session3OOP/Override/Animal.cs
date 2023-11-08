using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session3OOP.Override
{
    internal class Animal
    {
        public string Name { get; set; }
        public virtual void MakeSound()
        {
            Console.WriteLine("The Animal Makes a Generic Sound");
        } 
    }
}
