using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace RegularExam
{
    internal class Perfumery
    {
        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                if (value.Length<6)
                {
                    throw new ArgumentException("Invalid perfumery name!");
                }
                name = value;
            }
        }
        List<Perfume> perfumes;
        public Perfumery(string name)
        {
            Name = name;
            perfumes = new List<Perfume>();
        }
        public void AddPerfume(Perfume perfume)
        {
            perfumes.Add(perfume);
        }
        public bool SellPerfume(Perfume perfume)
        {
            foreach (var item in perfumes)
            {
                if (item.Brand == perfume.Brand && item.Price == perfume.Price)
                {
                    perfumes.Remove(item);
                    return true;
                }
            }
            return false;
        }
        public double CalculateTotalPrice()
        {
            return perfumes.Sum(p => p.Price);
        }
        public void RenamePerfumery(string newName)
        {
            if (newName.Length < 6)
            {
                throw new ArgumentException("Invalid perfumery name!");
            }
            name = newName;
        }
        public void SellAllPerfumes()
        {
            perfumes.Clear();
        }
        public Perfume GetPerfumeWithHighestPrice()
        {
            return perfumes.OrderByDescending(p => p.Price).FirstOrDefault();
        }
        public Perfume GetPerfumeWithLowestPrice()
        {
            return perfumes.OrderBy(p => p.Price).FirstOrDefault();
        }
        public override string ToString()
        {
            if (perfumes.Count > 0)
            {
                return $"Perfumery {Name} has {perfumes.Count} perfume/s:\n" +
                    $"{string.Join("\n", perfumes)}";
            }
            return $"Perfumery {Name} has no available perfumes.";
        }
    }
}