namespace GarageDI.UI;

public class ConsoleUI : IUI
{
    public void Clear()
    {
        Console.Clear();
    }

    public string GetString()
    {
        var input = Console.ReadLine();

        if (input is null) ArgumentNullException.ThrowIfNull(input, nameof(input));

        return input;

    }

    public string GetKey()
    {
        return Console.ReadKey(intercept: true).KeyChar.ToString();
    }

    public void Meny(bool isFull, string options, string menyheading)
    {
        Console.WriteLine(isFull ? "No spots left" : menyheading + "\n" + options);
    }

    public void Print(string message)
    {
        Console.WriteLine(message);
    }

    public void ShowMeny()
    {
        Print("Welcome to the Garage");
        Print("1, Park");
        Print("2, List Parked");
        Print("3, List By Type");
        Print("4, UnPark");
        Print("5, Search");
        Print("6, Seed Vehicles");
        Print("0, Quit");
    }
}
