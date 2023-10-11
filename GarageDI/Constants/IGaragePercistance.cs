namespace GarageDI.Constants
{
    internal interface IGaragePercistance
    {
        IGarage<IVehicle> LoadFromFile();
        void SaveToFile(IGarage<IVehicle> garage);
    }
}