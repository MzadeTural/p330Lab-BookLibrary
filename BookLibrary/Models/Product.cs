using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.Models
{
    internal class Product
    {
       
        public int No;
        public string Name;
        public double Price;
        public int Count;
        public Product(int no, string name, double price)
        {
            No = no;
            Name = name;
            Price = price;
        }
    
}
}
