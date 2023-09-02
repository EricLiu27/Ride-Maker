public class Vehicle
{
    public string Name;
    public int NumPassengers;
    public string Color;
    public bool HasEngine;
    public int TopSpeed;
    private int DistanceTravelled = 0;

    public Vehicle(string name, int numPassengers, string color, bool hasEngine, int topSpeed)
    {
        Name = name;
        NumPassengers = numPassengers;
        Color = color;
        HasEngine = hasEngine;
        TopSpeed = topSpeed;
    }

    public Vehicle(string name, string color)
    {
        Name = name;
        NumPassengers = 5;
        Color = color;
        HasEngine = true;
        TopSpeed = 120;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Name:{Name}");
        Console.WriteLine($"Number of Passengers:{NumPassengers}");
        Console.WriteLine($"Color:{Color}");
        Console.WriteLine($"Has an Engine:{HasEngine}");
        Console.WriteLine($"Top Speed:{TopSpeed}");
        Console.WriteLine($"Distance Travelled:{DistanceTravelled}");

    }
    public void Travel(int amount)
    {
        DistanceTravelled += amount;
        Console.WriteLine($"{Name} has Traveled {amount} miles. Total distance travelled: {DistanceTravelled}");

    }
}