using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace RegularExam
{
    internal class FlowerStore
    {
        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                if (value.Length<6)
                {
                    throw new ArgumentException("Invalid flower store name!");
                }
                
                    name = value;
                
            }
        }
        List<Flower> lflower;
        public FlowerStore(string name)
        {
            Name = name;
            lflower = new List<Flower>();
        }
        public void AddFlower(Flower flower)
        {
            lflower.Add(flower);
        }
        public bool SellFlower(Flower flower)
        {
            foreach (var item in lflower)
            {
                if (item.Type==flower.Type&&item.Color==flower.Color)
                {
                    lflower.Remove(item);
                    return true;
                    
                }
                
            }
            return
                false;
        }
        public double CalculateTotalPrice()
        {
            return lflower.Sum(item => item.Price);
        }
        public void RenameFlowerStore(string newName)
        {
            if (newName.Length < 6)
            {
                throw new ArgumentException("Invalid flower store name!");
            }
            else
            {
                Name = newName;
            }
        }
        public void SellAllFlowers()
        {
            lflower.Clear();
        }
        public Flower GetFlowerWithHighestPrice()
        {
            return lflower.OrderByDescending(x => x.Price).FirstOrDefault();
        }
        public double GetFlowerWithLowestPrice()
        {
            lflower.OrderByDescending(x => x.Price).FirstOrDefault();
            return lflower[lflower.Count-1].Price;
        }
        public override string ToString()
        {
            if (lflower.Count > 0)
            {
                return $"Flower store {Name} has {lflower.Count} flower/s: \n" +
                    $"{string.Join("\n", lflower)}";
            }
            else
            {
                return $"Flower store {Name} has no available flowers.";
            }
        }
    }
}