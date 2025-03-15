using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
public class FloweringPlant : Plant
{
    public string Color { get; set; }
    public FloweringPlant(int id, string name, double humidityLevel, double fertilityLevel, string color) : base(id, name, "flower", humidityLevel, fertilityLevel)
    {
        if (color.Length < 3 || color.Length > 30)
        {
            throw new ArgumentException("Color should be between 3 and 30 characters!");
        }
        this.Color = color;
    }
    public override string ToString()
    {
        StringBuilder stringBuilder = new StringBuilder();
        stringBuilder.AppendLine(base.ToString());
        stringBuilder.Append($"Color: {Color}");
        return stringBuilder.ToString();
    }
}