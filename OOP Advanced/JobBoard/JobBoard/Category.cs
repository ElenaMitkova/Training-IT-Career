using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
public class Category
{
    private readonly List<JobOffer> jobOffers = new List<JobOffer>();
    public string Name { get; }
    public Category(string name)
    {
        if (name == null || name.Length < 2 || name.Length > 40)
        {
            throw new ArgumentException("Name should be between 2 and 40 characters!");
        }
        Name = name;
    }
    public void AddJobOffer(JobOffer offer)
    {
        jobOffers.Add(offer);
    }
    public double AverageSalary()
    {
        if (jobOffers.Count == 0)
        {
            return 0;
        }
        return jobOffers.Average(offer => offer.Salary);
    }
    public List<JobOffer> GetOffersAboveSalary(double salary)
    {
        return jobOffers.Where(x => x.Salary >= salary).OrderByDescending(x => x.Salary).ToList();
    }
    public List<JobOffer> GetOffersWithoutSalary()
    {
        return jobOffers.Where(x => x.Salary == 0.0).OrderBy(x => x.Company).ToList();
    }
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"Category {Name}");
        sb.Append($"Total Offers: {jobOffers.Count}");
        return sb.ToString();
    }
}