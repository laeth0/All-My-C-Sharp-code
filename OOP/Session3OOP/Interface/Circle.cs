using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session3OOP.Interface
{
    internal class Circle : IShape//Implementation 
    {
        public double Radius { get; set; }
        public int Test { get; set; }//Automatic Prop

        public Circle(double raduis)
        {

            Radius = raduis;
        }
        public double CalculateArea()
        {
           return Math.PI * Radius * Radius;    //3.14
        }

        public double CalculatePerimeter()
        {
            return 2 *Math.PI*Radius;
        }
       
    }
}
