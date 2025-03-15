using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Coffee_Shop
{
    public class CoffeeShop
    {
        private string name;
        private List<Coffee> coffees;

        public CoffeeShop() 
        { 
            
        }
        public CoffeeShop(string name)
        {
            Name = name;coffees = new List<Coffee>();
        }
        public string Name 
        {
            get
            {

            return name; }

            set
            {
                name = value;
            }
        }
        public List<Coffee> Coffees {  get; set; }
        public void AddCoffee(string type, double price)
        {
            Coffee coffee = new Coffee(type, price);
            coffees.Add(coffee);
        }
        public double AveragePriceInRange(double start, double end)
        {
            var result = coffees.Where(coffee => coffee.Price >= start && coffee.Price <= end);
            return result.Average(p  => p.Price);
        }
        public List<string> FilterCoffeesByPrice(double price)
        {
            return coffees.Where(c => c.Price < price).Select(c => c.Type).ToList();
        }
        public List<Coffee> SortAscendingByType()
        {
            return coffees.OrderBy(p=>p.Type).ToList();
        }
        public List<Coffee> SortDescendingByPrice()
        {
            return coffees.OrderByDescending(p=>p.Price).ToList();
        }
        public bool CheckCoffeeIsInCoffeeShop(string type)
        {
            if (coffees.Any(p=> p.Type==type)) return true;
            return false;
        }
        public string[] ProvideInformationAboutAllCoffees()
        {
            string[] strings = new string[coffees.Count];
            int i = 0;
            foreach (var item in coffees)
            {
                string text = item.ToString();
                strings[i] = text;
                i++;
            }
            return strings;
        }
    }
}