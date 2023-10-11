namespace GarageDI.Extensions;

internal static class Generic
{
    public static PropertyInfo[] GetPropertiesWithIncludedAttribute<T>(this T type) where T : IVehicle
    {
        return type.GetType()
                   .GetProperties()
                   .Where(p => p.IsDefined(typeof(Include), true))
                   .OrderBy(p => ((Include)p.GetCustomAttribute(typeof(Include))!).Order)
                   .ToArray();
    }
}
