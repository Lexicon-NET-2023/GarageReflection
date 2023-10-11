namespace GarageDI.Persistence;

internal class GaragePercistance : IGaragePercistance
{
    private string filePath = Path.Combine(Environment.CurrentDirectory, Percistance.FileName);

    public void SaveToFile(IGarage<IVehicle> garage)
    {
        string json = ToJson(garage);
        File.WriteAllText(filePath, json);
    }

    public IGarage<IVehicle> LoadFromFile()
    {
        string json = File.ReadAllText(filePath);
        return FromJson(json);
    }

    private string ToJson(IGarage<IVehicle> garage)
    {
        var container = new GarageDTO<IVehicle>
        {
            Name = garage.Name,
            Capacity = garage.Capacity,
            Vehicles = garage.ToArray()
        };

        return JsonConvert.SerializeObject(container, Formatting.Indented);
    }

    private InMemoryGarage<IVehicle> FromJson(string json)
    {
        var container = JsonConvert.DeserializeObject<GarageDTO<Vehicle>>(json);

        if (container == null) ArgumentNullException.ThrowIfNull(nameof(container));

        var settings = new Settings { Name = container!.Name, Size = container.Capacity };

        var garage = new InMemoryGarage<IVehicle>(settings);

        foreach (var v in container.Vehicles)
        {
            garage.Park(v);
        }

        return garage;
    }

}
