using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session3OOP.Abstraction
{
    internal class Laptop:Electronics
    {
        public string Brand { get;set; }
         
        public Laptop(string name, decimal price, string brand):base(name,price)
        {
            Brand = brand;
        }

        public override string DisplayInfo()
        {
            return  $"Product: {Name}\nBrand: {Brand}\nPrice: ${Price}\n";
        }
    }
}
