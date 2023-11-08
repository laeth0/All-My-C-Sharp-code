using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session3OOP.Abstraction
{
    internal abstract class Product
    {//Abstract Class=> Class not Fully Implemented
        //Abstract Class =>Can not Create Object from it 
        public  string Name { get; set; }    
        public decimal Price { get; set; }

        public Product(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public abstract string DisplayInfo();//Virtual
       
    }
}
