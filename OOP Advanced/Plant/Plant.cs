using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Xml.Linq;
public abstract class Plant
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Type { get; set; }
    private List<CareItem> careItems;
    public double HumidityLevel { get; set; }
    public double FertilityLevel { get; set; }
    public Plant(int id, string name, string type, double humidityLevel, double fertilityLevel)
    {
        if (name.Length < 3 || name.Length > 30)
        {
            throw new ArgumentException("Name should be between 3 and 30 characters!");
        }
        if (type.Length < 3 || type.Length > 30)
        {
            throw new ArgumentException("Type should be between 3 and 30 characters!");
        }
        if (humidityLevel < 0 || humidityLevel > 1)
        {
            throw new ArgumentException("Humidity Level should be between 0 and 1!");
        }
        if (fertilityLevel < 0 || fertilityLevel > 1)
        {
            throw new ArgumentException("Fertility Level should be between 0 and 1!");
        }
        this.Id = id;
        this.Name = name;
        this.Type = type;
        this.HumidityLevel = humidityLevel;
        this.FertilityLevel = fertilityLevel;
        this.careItems = new List<CareItem>();
    }
    public void AddCareItem(CareItem careItem)
    {
        careItems.Add(careItem);
    }
    public int TotalCaresDone()
    {
        return careItems.Where(x => x.Status == true).Count();
    }
    public bool Water(double percent)
    {
        if (HumidityLevel + percent <= 1)
        {
            HumidityLevel += percent;
            return true;
        }
        return false;
    }
    public bool Fertilize(double percent)
    {
        if (FertilityLevel + percent <= 1)
        {
            FertilityLevel += percent;
            return true;
        }
        return false;
    }
    public override string ToString()
    {
        StringBuilder stringBuilder = new StringBuilder();
        stringBuilder.AppendLine($"Id: {Id}");
        stringBuilder.AppendLine($"Name: {Name}");
        stringBuilder.AppendLine($"Type: {Type}");
        stringBuilder.AppendLine($"Humidity Level: {HumidityLevel:F2} %");
        stringBuilder.Append($"Fertility Level: {FertilityLevel:F2} %");
        return stringBuilder.ToString();
    }
}