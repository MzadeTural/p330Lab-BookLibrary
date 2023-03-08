using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.Models
{
    internal class Book:Product
    {
        public Book(int no, string name, double price, string genre) : base(no, name, price)
        {
            Genre = genre;
        }
        public string Genre;
        public string GetInfo()
        {
            return $"===============================\nNo: {this.No} -- Name: {this.Name}\n -- Genre: {this.Genre}  Price: {this.Price} Azn -- Count: {this.Count}\n===============================\n";
        }
    }
}
