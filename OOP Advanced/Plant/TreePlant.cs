using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
public class TreePlant : Plant
{
    public int Height { get; set; }
    public TreePlant(int id, string name, double humidityLevel, double fertilityLevel, int height)
        : base(id, name, "tree", humidityLevel, fertilityLevel)
    {
        if (height < 0)
        {
            throw new ArgumentException("Height should be positive!");
        }
        this.Height = height;
    }
    public override string ToString()
    {
        StringBuilder stringBuilder = new StringBuilder();
        stringBuilder.AppendLine(base.ToString());
        stringBuilder.Append($"Height: {Height}");
        return stringBuilder.ToString();
    }
}