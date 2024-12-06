using System;

public class River : IGeographicObject
{
    public int X { get; set; }
    public int Y { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal CurrentSpeed { get; set; } // Швидкість течії (см/с)
    public double Length { get; set; } // Загальна довжина

    public void GetInfo()
    {
        Console.WriteLine($"Name: {Name}, Description: {Description}, Coordinates: ({X}, {Y}), Current Speed: {CurrentSpeed} cm/s, Length: {Length} km");
    }
}
