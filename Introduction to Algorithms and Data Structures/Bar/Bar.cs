using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Bar
{
    internal class Bar
    {
        //private string name;
        //private List<Cocktail> cocktails;
        //public Bar(string name)
        //{
        //    Name = name;
        //    cocktails = new List<Cocktail>();
        //}
        //public string Name { get; set; }
        //public List<Cocktail> Cocktails { get; set; }
        //public void AddCocktail(string name, double price)
        //{
        //    Cocktail cocktail = new Cocktail(name, price);
        //    cocktails.Add(cocktail);
        //}
        //public double AveragePriceInRange(double start, double end)
        //{
        //    var result = cocktails.Where(p => p.Price >= start && p.Price <= end).ToList();
        //    return result.Average(p => p.Price);
        //}
        //public List<string> FilterCocktailsByPrice(double price)
        //{
        //    return cocktails.Where(p => p.Price < price).Select(p => p.Name).ToList();
        //}
        //public List<Cocktail> SortAscendingByName()
        //{

        //    var result =  cocktails.OrderBy(p => p.Name).ToList();
        //    cocktails = result;
        //    return cocktails;
        //}
        //public List<Cocktail> SortDescendingByPrice()
        //{
        //    var result = cocktails.OrderByDescending(p => p.Price).ToList();
        //    cocktails = result;
        //    return cocktails;
        //}
        //public bool CheckCocktailIsInBar(string name)
        //{
        //    if (cocktails.Any(p => p.Name == name)) return true;
        //    return false;
        //}
        //public string[] ProvideInformationAboutAllCocktails()
        //{
        //    string[] strings = new string[cocktails.Count];
        //    int i = 0;
        //    foreach (var item in cocktails)
        //    {
        //        string text = item.ToString();
        //        strings[i] = text;
        //        i++;
        //    }
        //    return strings;
        //}
        private string name;
        private List<Cocktail> cocktails;

        public Bar(string name)
        {
            this.Name = name;
            this.cocktails = new List<Cocktail>();
        }

        public string Name { get; set; }
        public List<Cocktail> Cocktails
        {
            get { return this.cocktails; }
            set { this.cocktails = value; }
        }

        public void AddCocktail(string name, double price)
        {
            Cocktail cocktail = new Cocktail(name, price);
            this.cocktails.Add(cocktail);
        }

        public double AveragePriceInRange(double start, double end)
        {
            var result = this.cocktails.Where(p => p.Price >= start && p.Price <= end).ToList();
            return result.Any() ? result.Average(p => p.Price) : 0;
        }

        public List<string> FilterCocktailsByPrice(double price)
        {
            return this.cocktails.Where(p => p.Price < price).Select(p => p.Name).ToList();
        }

        public List<Cocktail> SortAscendingByName()
        {
            Cocktails.Sort((x,y)=>string.Compare(x.Name,y.Name));
            return Cocktails;
        }

        public List<Cocktail> SortDescendingByPrice()
        {
            return this.cocktails.OrderByDescending(p => p.Price).ToList();
        }

        public bool CheckCocktailIsInBar(string name)
        {
            return this.cocktails.Any(p => p.Name == name);
        }

        public string[] ProvideInformationAboutAllCocktails()
        {
            return this.cocktails.Select(c => c.ToString()).ToArray();
        }
    }
}