using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
public abstract class ParkingSpot
{
    protected List<ParkingInterval> parkingIntervals;
    public int Id { get; }
    public bool Occupied { get; set; }
    public string Type { get; }
    public double Price { get; } 
    public ParkingSpot(int id, bool occupied, string type, double price)
    {
        if (price <= 0)
        {
            throw new ArgumentException("Parking price cannot be less or equal to 0!");
        }
        this.Id = id;
        this.Occupied = occupied;
        this.Type = type;
        this.Price = price;
    }
    public virtual bool ParkVehicle(string registrationPlate, int hoursParked, string type)
    {
        if (Occupied && Type == type)
        {
            parkingIntervals.Add(new ParkingInterval(this, registrationPlate, hoursParked));
            Occupied = true;
            return true;
        }
        return false;
    }
    public List<ParkingInterval> GetAllParkingIntervalsByRegistrationPlate(string registrationPlate)
    {
        return parkingIntervals.Where(x => x.RegistrationPlate == registrationPlate).ToList();
    }
    public virtual double CalculateTotal()
    {
        return parkingIntervals.Sum(x => x.Revenue);
    }
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"> Parking Spot #{Id}");
        sb.AppendLine($"> Occupied: {Occupied}");
        sb.AppendLine($"> Type: {Type}");
        sb.Append($"> Price per hour: {Price:F2} BGN");
        return sb.ToString();
    }
}