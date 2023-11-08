using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session3OOP.Interface
{
    internal interface IShape
    {
        //1)Signatures for Prop
        //2)Signatures for methods 
        //3) Defualt Implemented Method 
        //Default Access Modifier inside Interface => Public

        int Test { get;set; }//without Attribute
        double CalculateArea();
        double CalculatePerimeter();

        void Test()
        {
            Console.WriteLine("Hello World");
        }
    }
}
