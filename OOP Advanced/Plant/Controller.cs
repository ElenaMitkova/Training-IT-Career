using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
public class Controller
{
    private Dictionary<int, Plant> plants = new Dictionary<int, Plant>();
    public string AddCareItem(List<string> args)
    {
        int plantId = int.Parse(args[0]);
        string name = args[1];
        bool status = bool.Parse(args[2]);
        if (plants.ContainsKey(plantId))
        {
            CareItem item = new CareItem(name, status);
            plants[plantId].AddCareItem(item);
            return $"Created Care {name} for {plantId}!";
        }
        return "Plant not found!";
    }
    public string AddPlant(List<string> args)
    {
        int id = int.Parse(args[0]);
        if (plants.ContainsKey(id))
        {
            return $"Plant with ID {id} already exists!";
        }
        string name = args[1];
        double humidityLevel = double.Parse(args[2]);
        double fertilityLevel = double.Parse(args[3]);
        string type = args[4];
        Plant plant = null;
        if (type == "flower")
        {
            string color = args[5];
            plant = new FloweringPlant(id, name, humidityLevel, fertilityLevel, color);
        }
        else if (type == "tree")
        {
            int height = int.Parse(args[5]);
            plant = new TreePlant(id, name, humidityLevel, fertilityLevel, height);
        }
        if (plant != null)
        {
            plants[id] = plant;
            return $"Created Plant {name} with ID {id}!";
        }
        return $"Plant with ID {id} already exists!";
    }
    public string GetTotalCaresByPlantId(List<string> args)
    {
        int id = int.Parse(args[0]);
        if (!plants.ContainsKey(id))
        {
            return $"Plant not found!";
        }
        return $"Total cares for plant {id}: {plants[id].TotalCaresDone()}";
    }
    public string WaterPlantById(List<string> args)
    {
        int id = int.Parse(args[0]);
        double percent = double.Parse(args[1]);
        if (!plants.ContainsKey(id))
        {
            return $"Plant not found!";
        }
        if (plants[id].Water(percent))
        {
            return $"Plant {id} was watered successfully!";
        }
        return $"Plant {id} could not be watered!";
    }
    public string FertilizePlantById(List<string> args)
    {
        int id = int.Parse(args[0]);
        if (!plants.ContainsKey(id))
        {
            return $"Plant not found!";
        }
        double percent = double.Parse(args[1]);
        if (plants[id].Fertilize(percent))
        {
            return $"Plant {id} was fertilized successfully!";
        }
        return $"Plant {id} could not be fertilized!";
    }
    public string GetTallestTree(List<string> args)
    {
        var tallest = plants.Values.OfType<TreePlant>().OrderByDescending(x => x.Height).FirstOrDefault();
        if (tallest == null)
        {
            return "No trees found!";
        }
        return tallest.ToString();
    }
}