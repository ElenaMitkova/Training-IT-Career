using System;
using System.Collections.Generic;
using System.Text;

namespace RegularExam
{
    internal class Hat
    {
        private string type;
        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        private string color;
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        private double price;
        public double Price
        {
            get { return price; }
            set 
            {
                if (price >100)
                {
                    throw new ArgumentException("Invalid hat price!");
                }
                price = value;
            }
        }
        public Hat(string type, string color, double price)
        {
            Type = type;
            Color = color;
            Price = price;
        }
        public override string ToString()
        {
            return $"Hat {Type} with color {Color} costs {Price}";
        }
    }
}
