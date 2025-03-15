using System;
using System.Collections.Generic;
using System.Text;
namespace Coffee_Shop
{
    public class Coffee
    {
        private string type;
        private double price;
        public Coffee() 
        { 

        }
        public Coffee(string type, double price)
        {
            Type = type;
            Price = price;
        }
        public string Type { get; set; }
        public double Price { get; set; }
        public override string ToString()
        {
            return $"Coffee {Type} costs {Price:f2} lv.";
        }
    }
}