using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Program
{
    public class Farm
    {
        private string name;
        private List<Animal> animals;
        public Farm(string name)
        {
            Name = name;
            Animals = new List<Animal>();
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
            }
        public List<Animal> Animals
        {
            get
            {
                return animals;
            }
            set
            {
                animals = value;
            }
        }
        public void AddAnimal(string type, int weight)
        {
            Animal animal = new Animal(type, weight);
            Animals.Add(animal);
        }
        public double AverageWeight()
        {
            if (animals.Count == 0) return 0;
            return animals.Average(a => a.Weight);
        }
        public List<string> FilterAnimalsByWeight(int weight)
        {
            return animals.Where(a => a.Weight < weight).Select(a => a.Type).ToList();
        }
        public List<Animal> SortAscendingByType()
        {
            Animals.Sort((x, y) => x.Type.CompareTo(y.Type));
            return Animals;
        }
        public List<Animal> SortDescendingByWeight()
        {
            Animals.Sort((x, y) => y.Weight.CompareTo(x.Weight));
            return Animals;
        }
        public bool CheckAnimalIsInFarm(string type)
        {
            if (animals.Any(a => a.Type == type)) return true;
            return false;
        }
        public string[] ProvideInformationAboutAllAnimals()
        {
            string[] strings = new string[animals.Count];
            int i = 0;
            foreach (var item in animals)
            {
                string text = item.ToString();
                strings[i] = text;
                i++;
            }
            return strings;
        }
    }
}