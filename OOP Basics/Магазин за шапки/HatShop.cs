using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
namespace RegularExam
{
    internal class HatShop
    {
        List<Hat> hats;
        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                if (value.Length<6)
                {
                    throw new ArgumentException("Invalid hat shop name!");
                }
                name = value;
            }
        }
        public HatShop(string name)
        {
            Name = name;
            hats = new List<Hat>();
        }
        public void AddHat(Hat hat)
        {
            hats.Add(hat);
        }
        public bool SellHat(Hat hat)
        {
            foreach (var item in hats)
            {
                if (item.Type == hat.Type && item.Color == hat.Color)
                {
                    hats.Remove(hat);
                    return true;
                }
            }
            return false;
        }
        public double CalculateTotalPrice()
        {
            return hats.Sum(hat => hat.Price);
        }
        public void RenameHatShop(string name)
        {
            if (name.Length < 6)
            {
                throw new ArgumentException("Invalid hat shop name!");
            }
            Name = name;
        }
        public void SellAllHats()
        {
            hats.Clear();
        }
        public Hat GetHatWithHighestPrice()
        {
            return hats.OrderByDescending(hat => hat.Price).FirstOrDefault();
        }
        public Hat GetHatWithLowestPrice()
        {
            return hats.OrderBy(hat => hat.Price).FirstOrDefault();
        }
        public override string ToString()
        {
            if (hats.Count > 0)
            {
                return $"Hat Shop {Name} has {hats.Count} hat/s:\n" +
                    $"{string.Join("\n", hats)}";
            }
            else
            {
                return $"Hat Shop {Name} has no available hats.";
            }
        }
    }
}