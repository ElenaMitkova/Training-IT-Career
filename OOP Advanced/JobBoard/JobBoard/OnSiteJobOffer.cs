using System;
using System.Collections.Generic;
using System.Text;
public class OnSiteJobOffer : JobOffer
{
    public string City { get; }
    public OnSiteJobOffer(string jobTitle, string company, double salary, string city) : base(jobTitle, company, salary)
    {
        if (city.Length < 3 || city.Length > 30)
        {
            throw new ArgumentException("City should be between 3 and 30 characters!");
        }
        City = city;
    }
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine(base.ToString());
        sb.Append($"City: {City}");
        return sb.ToString();
    }
}