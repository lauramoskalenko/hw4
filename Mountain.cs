using System;

public class Mountain : IGeographicObject
{
    public int X { get; set; }
    public int Y { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public double HighestPoint { get; set; } // Найвища точка

    public void GetInfo()
    {
        Console.WriteLine($"Name: {Name}, Description: {Description}, Coordinates: ({X}, {Y}), Highest Point: {HighestPoint} meters above sea level");
    }
}
