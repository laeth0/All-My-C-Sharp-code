using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session3OOP.Abstraction
{
    internal  class Book:Product
    {
        public string Auther { get;set; }
        public Book(string name,decimal price,string auther):base(name,price)
        {
            Auther = auther;
        }
        public override string DisplayInfo()
        {
            return $"Product: {Name}\n Auther: {Auther} \n Price: {Price}";
        }
    }
}
