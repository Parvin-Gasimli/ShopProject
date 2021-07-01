using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market_layihesi.Models
{
    class Product
    {  
        public string Name { get; set; }
        public double Price { get; set; }
        public static int Count { get; set; } = 1000;
        public string Code { get; set; }
        public Catagory Catagories { get; set; }
        public Product(string name,double price,Catagory catagory,string code)
        {
            Count++;
            
            Name = name;
            Catagories = catagory;
            Price = price;
            code = Name.Substring(0, 2).ToUpper() + Count;
        }
        public override string ToString()
        {
            return $" Name:{Name}/  Catagory:{Catagories}/    Price: {Price}/   Code:{Code}/";
        }

    }
  
     
}
