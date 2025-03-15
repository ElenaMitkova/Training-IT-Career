using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
internal class ParkingController
{
    private readonly List<ParkingSpot> parkingSpots = new List<ParkingSpot>();
    public string CreateParkingSpot(List<string> args)
    {
        int id = int.Parse(args[0]);
        if (parkingSpots.Any(x => x.Id == id))
        {
            return $"Parking spot {id} is already registered!";
        }

        bool occupied = bool.Parse(args[1]);
        string type = args[2];
        double price = double.Parse(args[3]);
        ParkingSpot parking = null;

        if (type == "subscription")
        {
            string registrationPlate = args[4];
            parking = new SubscriptionParkingSpot(id, occupied, price, registrationPlate);
        }
        else if (type == "car")
        {
            parking = new CarParkingSpot(id, occupied, price);
        }
        else if (type == "bus")
        {
            parking = new BusParkingSpot(id, occupied, price);
        }

        if (parking == null)
        {
            return "Unable to create parking spot!";
        }

        parkingSpots.Add(parking);
        return $"Parking spot {parking.Id} was successfully registered in the system!";
    }
    public string ParkVehicle(List<string> args)
    {
        int parkingSpotId = int.Parse(args[0]);
        ParkingSpot parking = parkingSpots.FirstOrDefault(x => x.Id == parkingSpotId);

        if (parking == null)
        {
            return $"Parking spot {parkingSpotId} not found!";
        }

        string registrationPlate = args[1];
        int hoursParked = int.Parse(args[2]);
        string type = args[3];

        bool couldPark = parking.ParkVehicle(registrationPlate, hoursParked, type);

        if (!couldPark)
        {
            return $"Vehicle {registrationPlate} can't park at {parkingSpotId}.";
        }

        parking.Occupied = true;
        return $"Vehicle {registrationPlate} parked at {parkingSpotId} for {hoursParked} hours.";
    }
    public string FreeParkingSpot(List<string> args)
    {
        int parkingSpotId = int.Parse(args[0]);
        ParkingSpot parking = parkingSpots.FirstOrDefault(x => x.Id == parkingSpotId);
        if (parking == null)
        {
            return $"Parking spot {parkingSpotId} not found!";
        }
        if (parking.Occupied)
        {
            return $"Parking spot {parkingSpotId} is not occupied.";
        }
        return $"Parking spot {parkingSpotId} is now free!";
    }
    public string GetParkingSpotById(List<string> args)
    {
        int parkingSpotId = int.Parse(args[0]);
        ParkingSpot parking = parkingSpots.FirstOrDefault(x => x.Id == parkingSpotId);
        if (parking == null)
        {
            return $"Parking spot {parkingSpotId} not found!";
        }
        return parking.ToString();
    }
    public string GetParkingIntervalsByParkingSpotIdAndRegistrationPlate(List<string> args)
    {
        int parkingSpotId = int.Parse(args[0]);
        string registrationPlate = args[1];
        ParkingSpot parking = parkingSpots.FirstOrDefault(x => x.Id == parkingSpotId);
        if (parking == null)
        {
            return $"Parking spot {parkingSpotId} not found!";
        }
        return "";
    }
    public string CalculateTotal(List<string> args)
    {
        //TODO: Implement me
        throw new NotImplementedException();
    }
}