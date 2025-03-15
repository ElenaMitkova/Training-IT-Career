using System;
using System.Collections.Generic;
using System.Text;
namespace RegularExam
{
    internal class Perfume
    {
        private string brand;
        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }
        private double price;
        public double Price
        {
            get { return price; }
            set
            {
                if (value>100)
                {
                    throw new ArgumentException("Invalid perfume price!");
                }
                price = value;
            }
        }
        public Perfume(string brand, double price)
        {
            Brand = brand;
            Price = price;
        }
        public override string ToString()
        {
            return $"Perfume {Brand} costs {Price:f2}";
        }
    }
}