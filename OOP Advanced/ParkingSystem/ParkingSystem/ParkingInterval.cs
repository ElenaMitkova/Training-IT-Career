using System;
using System.Collections.Generic;
using System.Text;
public class ParkingInterval
{
    public ParkingSpot ParkingSpot { get; }
    public string RegistrationPlate { get; }
    public int HoursParked { get; }
    public double Revenue { get; }
    public ParkingInterval(ParkingSpot parkingSpot, string registrationPlate, int hoursParked)
    {
        if (string.IsNullOrEmpty(registrationPlate))
        {
            throw new ArgumentNullException("Registration plate can’t be null or empty!");
        }
        if (hoursParked <= 0)
        {
            throw new ArgumentException("Hours parked can’t be zero or negative!");
        }
        if (parkingSpot.Type == "subscription")
        {
            Revenue = 0;
        }
        else
        {
            this.Revenue = ParkingSpot.Price * HoursParked;
        }
        this.ParkingSpot = parkingSpot;
        this.RegistrationPlate = registrationPlate;
        this.HoursParked = hoursParked;
    }
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"> Parking Spot #{ParkingSpot.Id}");
        sb.AppendLine($"> RegistrationPlate: {RegistrationPlate}");
        sb.AppendLine($"> HoursParked: {HoursParked}");
        sb.AppendLine($"> Revenue: {Revenue:F2} BGN");
        return sb.ToString();
   }
} 