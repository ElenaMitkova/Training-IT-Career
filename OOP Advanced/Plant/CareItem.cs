using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
public class CareItem
{
    public string Name { get; set; }
    public bool Status { get; set; }
    public CareItem(string name, bool status)
    {
        if (name.Length < 2 || name.Length > 40)
        {
            throw new ArgumentException("Name should be between 2 and 40 characters!");
        }
        this.Name = name;
        this.Status = status;
    }
    public override string ToString()
    {
        StringBuilder stringBuilder = new StringBuilder();
        stringBuilder.AppendLine($"CareItem {Name}");
        stringBuilder.Append($"Status: {Status}");
        return stringBuilder.ToString();
    }
}