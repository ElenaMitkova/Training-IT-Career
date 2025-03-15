using System;
using System.Collections.Generic;
using System.Text;
namespace Bar
{
    internal class Cocktail
    {
        private string name;
        private double price;
        public Cocktail(string name, double price)
        {
            Name = name;
            Price = price;
        }
        public string Name { get; set; }
        public double Price { get; set; }
        public override string ToString()
        {
            return $"Cocktail {Name} costs {Price:f2} lv.";
        }
    }
}