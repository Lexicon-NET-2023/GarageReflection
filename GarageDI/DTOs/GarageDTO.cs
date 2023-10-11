#nullable disable

namespace GarageDI.DTOs;

internal class GarageDTO<T> where T : IVehicle
{
    public string Name { get; set; }

    public int Capacity { get; set; }

    public T[] Vehicles { get; set; }
}


