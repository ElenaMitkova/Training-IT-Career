using System;
using System.Collections.Generic;
using System.Text;
internal class SubscriptionParkingSpot : ParkingSpot
{
    public string RegistrationPlate { get; }
    public SubscriptionParkingSpot(int id, bool occupied, double price, string registrationPlate) : base(id, occupied, "subscription", price)
    {
        if (string.IsNullOrEmpty(registrationPlate))
        {
            throw new ArgumentException("Registration plate can’t be null or empty!");
        }
        this.RegistrationPlate = registrationPlate;
    }
    public override bool ParkVehicle(string registrationPlate, int hoursParked, string type)
    {
        if(base.ParkVehicle(registrationPlate, hoursParked, type))
        {
            return true;
        }
        return false;
    }

    public override double CalculateTotal()
    {
        return 0;
    }
}

